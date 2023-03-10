using DataReferenceLibrary.Models;
using DataReferenceLibrary.Models2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.DataAccess
{
    public interface IDataConnection
    {
        

        


        ///////////////////////////////
        /////// DROP DOWN BOXES ///////
        ///////////////////////////////
        List<PortfolioModel> spGETLIST_Portfolios();

        List<TradingTransactionTypeModel> spGETLIST_TransactionTypes();

        List<TradingSectorModel> spGETLIST_TradingSectors();

        int spGETLIST_MostRecentPriceData();


        ///////////////////////////////
        ///////TAB - PRICE QUERY///////
        ///////////////////////////////
        IEnumerable<zFullEODPriceModel> spQUERY_PricesOnYears(string ASXCode, int YearRequest);


        /////////////////////////////////////
        ///////TAB - PORTFILIO ON DAY///////
        ////////////////////////////////////

        IEnumerable<xShareHolding> spGetShareHoldingsFromWarehouse(string InputPortfolioName, int StartDate, int EndDate);




        ///////////////////////////////////////
        ///////TAB - SHARE TRANSACTIONS///////
        //////////////////////////////////////

        IEnumerable<zFullPortfolioModel> spQUERY_PortfoliosIndividualsTransactions();


        TradingTransactionModel spINSERTDATA_TradingTransaction(TradingTransactionModel model);


        TradingTransactionModel spEDITDATA_TradingTransaction(TradingTransactionModel oldModel, TradingTransactionModel newModel);

        ///////////////////////////////////////
        ///////TAB - PORTFOLIO MOVEMENTS///////
        //////////////////////////////////////

        List<ASXEODPriceModel> spQUERY_SharePricesSixMonths();

        List<ASXEODPriceModel> spQUERY_SharePricesOneMonth(string ASXCode);

        IEnumerable<zFullEODPriceModel> spQUERY_SharePricesOneMonth(List<string> ASXCodeList);

        //////////////////////////////////
        ///////TAB - NOTEPAD UPLOAD///////
        //////////////////////////////////
        List<ASXEODPriceModel> spINSERTDATA_ASXEODPrice(DataTable dt);
        DocumentUploadHistoryModel spINSERTDATA_DocumentUploadRecord(DocumentUploadHistoryModel model);




        TradingTransactionTypeModel CreateTransactionType(TradingTransactionTypeModel model);
    }
}




