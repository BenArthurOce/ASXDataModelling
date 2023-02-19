﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataReferenceLibrary.Models;
using DataReferenceLibrary.Models2;
using DataReferenceLibrary.StoredProcs;

namespace DataReferenceLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "AppConfigAccess1";



        public IEnumerable<zFullPortfolioModel> PopulatePortfolioModel()
        {

            var transaction_list = new List<TradingTransactionModel>();
            var portfolio_list = new List<zFullPortfolioModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {


                var output_portfolios = connection.Query<zFullPortfolioModel, ConnectorIndividualsPortfolios, IndividualModel, TradingTransactionModel, TradingTransactionTypeModel, TradingEntityModel, TradingSectorModel, zFullPortfolioModel>
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

                        // Add the transaction for every line (no checks need to be made for duplicates like Portfolios or individuals)
                        //port.Transactions = port.Transactions ?? new List<FullShareTransactionModel>();
                        //port.Transactions.Add(transaction);


                        // if there is no list for individuals, instantiate it
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
                





                // output_portfolios has 18 count, all null
                // portfolio_list has 15 count

                //When all fields are used:
                // output_portfolios has 221 count, all null
                // portfolio_list has 14 count?
                // Each Portfolio has 13 or 26 individuals


                return portfolio_list;
            }
           
        }



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


        ///////////////////////////////
        ///////TAB - PRICE QUERY///////
        ///////////////////////////////
        public List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceOpen(string ASXCode, int YearInput)
        {
            List<spQueryASXSharePricesForOneYear> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<spQueryASXSharePricesForOneYear>("dbo.spQueryASXSharePricesForOneYear_PriceOpen @ASXCode, @Year", new { ASXCode = ASXCode, Year = YearInput }).ToList();
            }
            return output;
        }

        public List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceClose(string ASXCode, int YearInput)
        {
            List<spQueryASXSharePricesForOneYear> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<spQueryASXSharePricesForOneYear>("dbo.spQueryASXSharePricesForOneYear_PriceClose @ASXCode, @Year", new { ASXCode = ASXCode, Year = YearInput }).ToList();
            }
            return output;
        }

        public List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceHigh(string ASXCode, int YearInput)
        {
            List<spQueryASXSharePricesForOneYear> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<spQueryASXSharePricesForOneYear>("dbo.spQueryASXSharePricesForOneYear_PriceHigh @ASXCode, @Year", new { ASXCode = ASXCode, Year = YearInput }).ToList();
            }
            return output;
        }

        public List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceLow(string ASXCode, int YearInput)
        {
            List<spQueryASXSharePricesForOneYear> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<spQueryASXSharePricesForOneYear>("dbo.spQueryASXSharePricesForOneYear_PriceLow @ASXCode, @Year", new { ASXCode = ASXCode, Year = YearInput }).ToList();
            }
            return output;
        }


        /////////////////////////////////////
        ///////TAB - PORTFILIO ON DAY///////
        ////////////////////////////////////

        public List<spQueryPortfolioItemsForCertainDate> spQUERY_PortfolioValue(string InputPortfolioName, int InputEndDate)
        {
            List<spQueryPortfolioItemsForCertainDate> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<spQueryPortfolioItemsForCertainDate>("dbo.spQUERY_PortfolioValue @in_PortfolioName, @in_EndDate", new { in_PortfolioName = InputPortfolioName, in_EndDate = InputEndDate }).ToList();
            }
            return output;
        }


        ///////////////////////////////////////
        ///////TAB - SHARE TRANSACTIONS///////
        //////////////////////////////////////
        public List<spQueryShareTransactionsForPortfolio> spQueryAllShareTransactions(string InputPortfolioName)
        {
            List<spQueryShareTransactionsForPortfolio> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<spQueryShareTransactionsForPortfolio>("dbo.spQueryShareTransactionsForPortfolio @in_PortfolioName", new { in_PortfolioName = InputPortfolioName }).ToList();
            }
            return output;
        }

        public TradingTransactionModel spInsertNewShareTransaction(string PortfolioName, TradingTransactionModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@in_PortfolioOwner", PortfolioName);
                p.Add("@in_ContractNote", model.ContractNote);
               // p.Add("@in_ASXCode", model.ASXCode);
               // p.Add("@in_Date", model.Date);
                //p.Add("@in_Type", model.Type);
                p.Add("@in_Quantity", model.Quantity);
                p.Add("@in_UnitPrice", model.UnitPrice);
                p.Add("@in_TradeValue", model.TradeValue);
                p.Add("@in_Brokerage", model.Brokerage);
                p.Add("@in_TotalValue", model.TotalValue);
                connection.Execute("dbo.spInsertNewShareTransaction", p, commandType: CommandType.StoredProcedure);
            }
            return model;
        }


        ///////////////////////////////////////
        ///////TAB - PORTFOLIO MOVEMENTS///////
        //////////////////////////////////////



        //////////////////////////////////
        ///////TAB - NOTEPAD UPLOAD///////
        //////////////////////////////////

        public List<ASXEODPriceModel> spINSERT_NotepadFile(DataTable dt)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@data", dt, DbType.Object);
                connection.Execute("dbo.spINSERT_NotepadFile", p, commandType: CommandType.StoredProcedure);
            }
            return null;
        }

        public DocumentUploadHistoryModel CreateNewDocumentUploadRecord(DocumentUploadHistoryModel model)
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
                connection.Execute("dbo.spINSERT_DocumentUploadRecord", p, commandType: CommandType.StoredProcedure);
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
