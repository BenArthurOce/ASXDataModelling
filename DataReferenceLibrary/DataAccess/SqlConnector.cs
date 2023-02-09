using System;
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



        public IEnumerable<FullPortfolioModel> PopulatePortfolioModel()
        {

            var transaction_list = new List<FullShareTransactionModel>();
            var portfolio_list = new List<FullPortfolioModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                /*
                var output_portfolios = connection.Query<FullPortfolioModel, NewConnectorPortfolioIndividualModel, NewIndividualModel, FullPortfolioModel >
                    ("dbo.spQueryDummyPortfolioInformation2",
                    (portfolio, connector, individual) =>
                    {

                        // get from lookup (if any)
                        var port = portfolio_list.FirstOrDefault(s => s.Id == portfolio.Id);

                        // if its not there, add
                        if (port == null)
                        {
                            portfolio_list.Add(portfolio);
                            port = portfolio;
                        }

                        // if there is no list for individuals, instantiate it
                        port.Individuals = port.Individuals ?? new List<NewIndividualModel>();

                        // add the individual from this row
                        port.Individuals.Add(individual);
                        return null;
                    }, splitOn: "Id");
                */


                var output_portfolios = connection.Query<FullPortfolioModel, NewConnectorPortfolioIndividualModel, NewIndividualModel, FullShareTransactionModel, NewShareTransactionTypeModel, NewTradingCompanyModel, NewTradingSectorModel, FullPortfolioModel>
                    ("dbo.spQueryDummyPortfolioInformation",
                    (portfolio, connector, individual, transaction, transtype, company, sector) =>
                    {

                        // Moodel the transaction information into one single "part" of data
                        transaction.TypeId = transtype;
                        transaction.CompanyId = company;
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
                        port.Individuals = port.Individuals ?? new List<NewIndividualModel>();

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
                        port.Transactions = port.Transactions ?? new List<FullShareTransactionModel>();
                        port.Transactions.Add(transaction);

                        return null;
                    }, splitOn: "Id");
                





                // output_portfolios has 18 count, all null
                // portfolio_list has 15 count

                //When all fields are used:
                // output_portfolios has 221 count, all null
                // portfolio_list has 14 count?
                // Each Portfolio has 13 or 26 individuals


                return output_portfolios;
            }
           
        }

        public IEnumerable<FullShareTransactionModel> spQueryDummyAllInformation2()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var output = connection.Query<FullShareTransactionModel, NewShareTransactionTypeModel, NewTradingCompanyModel, NewTradingSectorModel, FullShareTransactionModel>
                    ("dbo.spQueryDummyTransactions2",
                    (trans0, type0, company0, sector0) => {

                        trans0.TypeId = type0;
                        trans0.CompanyId = company0;
                        company0.TradingSectorId = sector0;
                        return trans0;
                    }, splitOn: "Id");


                foreach (var p in output)
                {


                    //string resultString = $"FirstName:{o.IndividualId.FirstName} LastName:{o.IndividualId.LastName}";
                    string resultString = $"Date:{p.Date} UnitPrice:{p.UnitPrice} TotalAmount:{p.TotalValue} Type:{p.TypeId.Name} CompanyName: {p.CompanyId.Name} Sector:{p.CompanyId.TradingSectorId.SectorName}";
                    Console.WriteLine(resultString);


                }
                return output;
            }
        }


        public IEnumerable<NewShareTransactionModel> spQueryDummyAllInformation()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {


                
                var output = connection.Query<NewPortfolioModel, NewConnectorPortfolioIndividualModel, NewIndividualModel, NewShareTransactionModel, NewShareTransactionTypeModel, NewTradingCompanyModel, NewTradingSectorModel, NewShareTransactionModel>
                    ("dbo.spQueryDummyAllInformation",
                    (portfolio1, conn1, indiv1, trans1, type1, company1, sector1) => {

                        conn1.IndividualId = indiv1;
                        //conn1.PortfolioId = portfolio1;
                        //trans1.PortfolioId = portfolio1;
                        trans1.TypeId = type1;
                        trans1.CompanyId = company1;
                        company1.TradingSectorId = sector1;
                        return trans1;
                    }, splitOn: "Id");


                foreach (var c in output)
                {
                    //string resultString = $"FirstName:{c.IndividualId.FirstName} LastName:{c.IndividualId.LastName}";
                    //Console.WriteLine(resultString);
                }
                



                /*
                var output2 = connection.Query<NewPortfolioModel, NewConnectorPortfolioIndividualModel, NewIndividualModel, NewShareTransactionModel, NewShareTransactionTypeModel, NewTradingCompanyModel, NewTradingSectorModel, NewShareTransactionModel>
                    ("dbo.spQueryDummyAllInformation",
                    (portfolio, conn, indiv, trans, type, company, sector) => {

                        conn.IndividualId = indiv;
                        conn.PortfolioId = portfolio;
                        trans.PortfolioId = portfolio;
                        trans.TypeId = type;
                        trans.CompanyId = company;
                        company.TradingSectorId = sector;
                        return trans;
                    }, splitOn: "Id");


                foreach (var o in output2)
                {
                    if(o.PortfolioId.Name == "Bens Stock Portfolio")
                    {
                        //string resultString = $"FirstName:{o.IndividualId.FirstName} LastName:{o.IndividualId.LastName}";

                        string resultString = $"Date:{o.Date} Type:{o.TypeId.Name} Cost:{o.TradeValue}";
                        Console.WriteLine(resultString);
                    }

                }
                */

                /*
                var output3 = connection.Query<NewPortfolioModel, NewConnectorPortfolioIndividualModel, NewIndividualModel, NewShareTransactionModel, NewShareTransactionTypeModel, NewTradingCompanyModel, NewTradingSectorModel, NewPortfolioModel>
                    ("dbo.spQueryDummyAllInformation",
                    (portfolio, conn, indiv, trans, type, company, sector) => {


                        //Match the 1 to 1 Fields
                        trans.TypeId = type;
                        trans.CompanyId = company;
                        company.TradingSectorId = sector;
                        //company.TradingIssuer = issuer

                        conn.IndividualId = indiv;
                        conn.PortfolioId = portfolio;
                        //trans.PortfolioId = portfolio;
                        
                        // Add transaction to portfolio
                        if (portfolio.ShareTransactions == null)
                            portfolio.ShareTransactions = new List<NewShareTransactionModel>();

                        portfolio.ShareTransactions.Add(trans);

                        // Add Portfolio Owner to portfolio
                        if (portfolio.Individuals == null)
                            portfolio.Individuals = new List<NewIndividualModel>();

                        portfolio.Individuals.Add(indiv);

                        return portfolio;

                    }, splitOn: "Id");

                





                //portfolio.ShareTransactions.Add(trans);
                foreach (var o in output3)
                {
                    //if (o.PortfolioId.Name == "Bens Stock Portfolio")
                   // {
                        //string resultString = $"FirstName:{o.IndividualId.FirstName} LastName:{o.IndividualId.LastName}";

                        //string resultString = $"Date:{o.Date} Type:{o.TypeId.Name} Cost:{o.TradeValue}";
                        //string resultString = $"{}";
                        //Console.WriteLine(resultString);
                   // }

                }

                */




                var output4 = connection.Query<FullShareTransactionModel, NewShareTransactionTypeModel, NewTradingCompanyModel, NewTradingSectorModel, FullShareTransactionModel>
                    ("dbo.spQueryDummyTransactions2",
                    (trans0, type0, company0, sector0) => {

                        trans0.TypeId = type0;
                        trans0.CompanyId = company0;
                        company0.TradingSectorId = sector0;
                        return trans0;
                    }, splitOn: "Id");


                foreach (var p in output4)
                {


                    //string resultString = $"FirstName:{o.IndividualId.FirstName} LastName:{o.IndividualId.LastName}";
                    string resultString = $"Date:{p.Date} UnitPrice:{p.UnitPrice} TotalAmount:{p.TotalValue} Type:{p.TypeId.Name} CompanyName: {p.CompanyId.Name} Sector:{p.CompanyId.TradingSectorId.SectorName}";
                    Console.WriteLine(resultString);


                }





                return output;
            }
        }




        public IEnumerable<NewShareTransactionModel> spQueryDummyTransactions()
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                // THIS CODE WORKS. DO NOT DELETE
                
                var output2 = connection.Query<NewShareTransactionModel, NewShareTransactionTypeModel, NewPortfolioModel, NewTradingCompanyModel, NewTradingSectorModel, NewShareTransactionModel>
                    ("dbo.spQueryDummyTransactions2", 
                    (trans, type, portfolio, company, sector) => {  trans.TypeId = type; 
                                                                    trans.PortfolioId = portfolio; 
                                                                    trans.CompanyId = company; 
                                                                    company.TradingSectorId = sector;  
                                                                    return trans; }, splitOn: "Id");
                
                foreach (var t2 in output2)
                {
                    string resultString = $"Date:{t2.Date} UnitPrice:{t2.UnitPrice} TotalAmount:{t2.TotalValue} Type:{t2.TypeId.Name} CompanyName: {t2.CompanyId.Name} Sector:{t2.CompanyId.TradingSectorId.SectorName}";
                    Console.WriteLine(resultString);
                }
                
                return output2;
            }
        }


        ///////////////////////////////
        /////// DROP DOWN BOXES ///////
        ///////////////////////////////
        public List<PortfolioModel> spQueryPortfolios()
        {
            List<PortfolioModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PortfolioModel>("dbo.spQueryPortfolios").ToList();
            }
            return output;
        }

        public List<ShareTransactionTypeModel> spQueryTransactionTypes()
        {
            List<ShareTransactionTypeModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ShareTransactionTypeModel>("dbo.spQueryTransactionTypes").ToList();
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

        public List<spQueryPortfolioItemsForCertainDate> spQueryPortfolioItemsForCertainDate(string InputPortfolioName, int InputStartDate, int InputEndDate)
        {
            List<spQueryPortfolioItemsForCertainDate> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<spQueryPortfolioItemsForCertainDate>("dbo.spQueryPortfolioItemsForCertainDate @in_PortfolioName, @in_StartDate, @in_EndDate", new { in_PortfolioName = InputPortfolioName, in_StartDate = InputStartDate, in_EndDate = InputEndDate }).ToList();
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

        public ShareTransactionModel spInsertNewShareTransaction(string PortfolioName, ShareTransactionModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@in_PortfolioOwner", PortfolioName);
                p.Add("@in_ContractNote", model.ContractNote);
                p.Add("@in_ASXCode", model.ASXCode);
                p.Add("@in_Date", model.Date);
                p.Add("@in_Type", model.Type);
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

        public List<ASXPriceModel> spINSERT_NotepadFile(DataTable dt)
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


        public ShareTransactionTypeModel CreateTransactionType(ShareTransactionTypeModel model)
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
