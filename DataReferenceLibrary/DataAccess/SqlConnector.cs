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
using DataReferenceLibrary.StoredProcs;

namespace DataReferenceLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>


        ///////////////////////////////
        ///////TAB - PRICE QUERY///////
        ///////////////////////////////
        public List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceOpen(string ASXCode, int YearInput)
        {
            List<spQueryASXSharePricesForOneYear> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("AppConfigAccess1")))
            {
                output = connection.Query<spQueryASXSharePricesForOneYear>("dbo.spQueryASXSharePricesForOneYear_PriceOpen @ASXCode, @Year", new { ASXCode = ASXCode, Year = YearInput }).ToList();
            }
            return output;
        }

        public List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceClose(string ASXCode, int YearInput)
        {
            List<spQueryASXSharePricesForOneYear> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("AppConfigAccess1")))
            {
                output = connection.Query<spQueryASXSharePricesForOneYear>("dbo.spQueryASXSharePricesForOneYear_PriceClose @ASXCode, @Year", new { ASXCode = ASXCode, Year = YearInput }).ToList();
            }
            return output;
        }

        public List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceHigh(string ASXCode, int YearInput)
        {
            List<spQueryASXSharePricesForOneYear> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("AppConfigAccess1")))
            {
                output = connection.Query<spQueryASXSharePricesForOneYear>("dbo.spQueryASXSharePricesForOneYear_PriceHigh @ASXCode, @Year", new { ASXCode = ASXCode, Year = YearInput }).ToList();
            }
            return output;
        }

        public List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceLow(string ASXCode, int YearInput)
        {
            List<spQueryASXSharePricesForOneYear> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("AppConfigAccess1")))
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("AppConfigAccess1")))
            {
                output = connection.Query<spQueryPortfolioItemsForCertainDate>("dbo.spQueryPortfolioItemsForCertainDate @in_PortfolioName, @in_StartDate, @in_EndDate", new { in_PortfolioName = InputPortfolioName, in_StartDate = InputStartDate, in_EndDate = InputEndDate }).ToList();
            }
            return output;
        }


        ///////////////////////////////////////
        ///////TAB - SHARE TRANSACTIONS///////
        //////////////////////////////////////
        public List<spQueryAllShareTransactions> spQueryAllShareTransactions()
        {
            List<spQueryAllShareTransactions> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("AppConfigAccess1")))
            {
                output = connection.Query<spQueryAllShareTransactions>("dbo.spQueryAllShareTransactions").ToList();
            }
            return output;
        }

        public ShareTransactionModel spInsertNewShareTransaction(string PortfolioName, ShareTransactionModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("AppConfigAccess1")))
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("AppConfigAccess1")))
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

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("AppConfigAccess1")))
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

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("AppConfigAccess1")))
            {
                var p = new DynamicParameters();
                p.Add("@in_TransType", model.Type);
                connection.Execute("dbo.spINSERT_ShareTransactionType", p, commandType: CommandType.StoredProcedure);
            }
            return model;
        }

    }
}
