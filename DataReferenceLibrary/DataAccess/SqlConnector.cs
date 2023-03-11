using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataReferenceLibrary.Models;
using DataReferenceLibrary.Models2;
using static System.Collections.Specialized.BitVector32;

namespace DataReferenceLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "AppConfigAccess1";










        ///////////////////////////////
        /////// DROP DOWN BOXES ///////
        ///////////////////////////////
        public List<PortfolioModel> spGETLIST_Portfolios()
        {
            List<PortfolioModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PortfolioModel>("dbo.spGETLIST_Portfolios").ToList();
            }
            return output;
        }

        public List<TradingTransactionTypeModel> spGETLIST_TransactionTypes()
        {
            List<TradingTransactionTypeModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TradingTransactionTypeModel>("dbo.spGETLIST_TransactionTypes").ToList();
            }
            return output;
        }

        public List<TradingSectorModel> spGETLIST_TradingSectors()
        {
            List<TradingSectorModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TradingSectorModel>("dbo.spGETLIST_TradingSectors").ToList();
            }
            return output;
        }

        public int spGETLIST_MostRecentPriceData()
        {
            int myvalue;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                myvalue = connection.Query<int>("spGETLIST_MostRecentPriceData",
                       CommandType.StoredProcedure).First();
            }
            return myvalue;
        }


        ///////////////////////////////
        ///////TAB - PRICE QUERY///////
        ///////////////////////////////
        public IEnumerable<zFullEODPriceModel> spQUERY_SharePriceHistorySingle(string inputASXCode)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var output_priceData = connection.Query<zFullEODPriceModel, TradingEntityModel, TradingSectorModel, DatesModel, zFullEODPriceModel>
                    ("dbo.spQUERY_SharePriceHistorySingle @in_ASXCode",
                    (prices, tradingEntity, tradingSector, dates) =>
                    {
                        prices.TradingEntityModel = tradingEntity;
                        prices.DatesModel = dates;
                        tradingEntity.TradingSectorId = tradingSector;
                        return prices;
                    },
                    new { in_ASXCode = inputASXCode },
                    splitOn: "Id"
                    );
                return output_priceData;
            }
        }



        /////////////////////////////////////
        ///////TAB - PORTFILIO ON DAY///////
        ////////////////////////////////////


        public IEnumerable<ShareHolding> spQUERY_dwPortfolioStandings(string inputPortfolioName, int inputStartDate, int inputEndDate)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var output_portfolioStandings = connection.Query<ShareHolding, PortfolioModel, ConnectorIndividualsPortfolios, IndividualModel, TradingEntityModel, TradingSectorModel, ShareHolding>
                    ("dbo.spQUERY_dwPortfolioStandings @in_PortfolioName, @in_StartDate, @in_EndDate",
                    (holding, portfolio, connector, individual, entity, sector) =>
                    {
                        holding.PortfolioModel = portfolio;
                        holding.TradingEntityModel = entity;
                        entity.TradingSectorId = sector;

                        return holding;
                    },
                    new { in_PortfolioName = inputPortfolioName, in_StartDate = inputStartDate, in_EndDate = inputEndDate },
                    splitOn: "Id"
                    );
                return output_portfolioStandings;
            }
        }



        ///////////////////////////////////////
        ///////TAB - SHARE TRANSACTIONS///////
        //////////////////////////////////////
      
        public IEnumerable<PortfolioModel> spQUERY_PortfoliosIndividualsTransactions()
        {

            var portfolio_list = new List<PortfolioModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                var output_portfolios = connection.Query<PortfolioModel, ConnectorIndividualsPortfolios, IndividualModel, TradingTransactionModel, TradingTransactionTypeModel, TradingEntityModel, TradingSectorModel, PortfolioModel>
                    ("dbo.spQUERY_PortfoliosIndividualsTransactions",
                    (portfolio, connector, individual, transaction, transtype, company, sector) =>
                    {

                        // Moodel the transaction information into one single "part" of data
                        transaction.TradingTransactionTypeId = transtype;
                        transaction.TradingEntityId = company;
                        company.TradingSectorId = sector;

                        //====================================
                        // get from lookup (if any)
                        var port = portfolio_list.FirstOrDefault(s => s.Id == portfolio.Id);

                        // if its not there, add
                        if (port == null)
                        {
                            portfolio_list.Add(portfolio);
                            port = portfolio;
                        }

                        // if there is no list for individuals, instantiate it
                        port.Individuals = port.Individuals ?? new List<IndividualModel>();

                        //====================================
                        // get from lookup (if any)
                        var indiv = port.Individuals.FirstOrDefault(s => s.Id == individual.Id);

                        // if its not there, add
                        if (indiv == null)
                        {
                            port.Individuals.Add(individual);
                            indiv = individual;
                        }

                        // if there is no list for transactions, instantiate it
                        port.Transactions = port.Transactions ?? new List<TradingTransactionModel>();

                        //====================================
                        // get from lookup (if any)
                        var trans = port.Transactions.FirstOrDefault(s => s.Id == transaction.Id);
                        if (trans == null)
                        {
                            port.Transactions.Add(transaction);
                            trans = transaction;
                        }

                        return null;
                    }, splitOn: "Id");


                return portfolio_list;
            }

        }

        public TradingTransactionModel spINSERTDATA_TradingTransaction(TradingTransactionModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@in_ContactNote", model.ContractNote);
                p.Add("@in_PortfolioName", model.PortfolioId.Name);
                p.Add("@in_TradingEntityASXCode", model.TradingEntityId.ASXCode);
                p.Add("@in_Date", model.Date);
                p.Add("@in_Type", model.TradingTransactionTypeId.Name);
                p.Add("@in_Quantity", model.Quantity);
                p.Add("@in_UnitPrice", model.UnitPrice);
                p.Add("@in_Brokerage", model.Brokerage);
                connection.Execute("dbo.spINSERTDATA_TradingTransaction", p, commandType: CommandType.StoredProcedure);
            }
            return model;
        }

        public TradingTransactionModel spEDITDATA_TradingTransaction(TradingTransactionModel oldModel, TradingTransactionModel newModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@orig_ContactNote", oldModel.ContractNote);
                p.Add("@orig_PortfolioName", oldModel.PortfolioId.Name);
                p.Add("@orig_TradingEntityASXCode", oldModel.TradingEntityId.ASXCode);
                p.Add("@orig_Date", oldModel.Date);
                p.Add("@orig_Type", oldModel.TradingTransactionTypeId.Name);
                p.Add("@orig_Quantity", oldModel.Quantity);
                p.Add("@orig_UnitPrice", oldModel.UnitPrice);
                p.Add("@orig_TradeValue", oldModel.TradeValue);
                p.Add("@orig_Brokerage", oldModel.Brokerage);
                p.Add("@orig_TotalValue", oldModel.TotalValue);

                p.Add("@update_ContactNote", newModel.ContractNote);
                p.Add("@update_PortfolioName", newModel.PortfolioId.Name);
                p.Add("@update_TradingEntityASXCode", newModel.TradingEntityId.ASXCode);
                p.Add("@update_Date", newModel.Date);
                p.Add("@update_Type", newModel.TradingTransactionTypeId.Name);
                p.Add("@update_Quantity", newModel.Quantity);
                p.Add("@update_UnitPrice", newModel.UnitPrice);
                p.Add("@update_TradeValue", newModel.TradeValue);
                p.Add("@update_Brokerage", newModel.Brokerage);
                p.Add("@update_TotalValue", newModel.TotalValue);

                connection.Execute("dbo.spEDITDATA_TradingTransaction", p, commandType: CommandType.StoredProcedure);
            }
            return newModel;
        }


        ///////////////////////////////////////
        ///////TAB - PORTFOLIO MOVEMENTS///////
        //////////////////////////////////////


        public IEnumerable<zFullEODPriceModel> spQUERY_SharePriceHistoryMultiple(List<string> inputASXCodeList)
        {

            var table = new DataTable();
            table.Columns.Add("Code", typeof(string));
            foreach (var code in inputASXCodeList)
            {
                table.Rows.Add(code);
            }

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var output_priceData = connection.Query<zFullEODPriceModel, TradingEntityModel, TradingSectorModel, DatesModel, zFullEODPriceModel>
                    ("dbo.spQUERY_SharePriceHistoryMultiple @in_ASXCodeList",
                    (prices, tradingEntity, tradingSector, dates) =>
                    {
                        prices.TradingEntityModel = tradingEntity;
                        prices.DatesModel = dates;
                        tradingEntity.TradingSectorId = tradingSector;
                        return prices;
                    },
                    new { in_ASXCodeList = table.AsTableValuedParameter("StockCodeList") },
                    splitOn: "Id"
                    );
                return output_priceData;
            }
        }




        //////////////////////////////////
        ///////TAB - NOTEPAD UPLOAD///////
        //////////////////////////////////

        public List<ASXEODPriceModel> spINSERTDATA_ASXEODPrice(DataTable dt)
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
                {
                    var p = new DynamicParameters();
                    p.Add("@data", dt, DbType.Object);
                    connection.Execute("dbo.spINSERTDATA_ASXEODPrice", p, commandType: CommandType.StoredProcedure);
                }
                return null;
            }

        public DocumentUploadHistoryModel spINSERTDATA_DocumentUploadRecord(DocumentUploadHistoryModel model)
        {
            model.Id = Guid.NewGuid();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@in_FilePath", model.FilePath);
                p.Add("@in_FileName", model.FileName);
                p.Add("@in_DateTimeUpload", model.DateTimeUploaded);
                p.Add("@in_FileSizeBytes", model.FileSizeBytes);
                p.Add("@in_RowsInFile", model.RowsInFile);
                connection.Execute("dbo.spINSERTDATA_DocumentUploadRecord", p, commandType: CommandType.StoredProcedure);
            }
            return model;
        }


        public TradingTransactionTypeModel CreateTransactionType(TradingTransactionTypeModel model)
        {
            model.Id = Guid.NewGuid();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@in_TransType", model.Name);
                connection.Execute("dbo.spINSERT_ShareTransactionType", p, commandType: CommandType.StoredProcedure);
            }
            return model;
        }

    }
}
