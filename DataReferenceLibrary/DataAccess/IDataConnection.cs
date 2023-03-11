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
        IEnumerable<zFullEODPriceModel> spQUERY_SharePriceHistorySingle(string inputASXCode);



        /////////////////////////////////////
        ///////TAB - PORTFILIO ON DAY///////
        ////////////////////////////////////

        IEnumerable<ShareHolding> spQUERY_dwPortfolioStandings(string InputPortfolioName, int StartDate, int EndDate);




        ///////////////////////////////////////
        ///////TAB - SHARE TRANSACTIONS///////
        //////////////////////////////////////

        IEnumerable<PortfolioModel> spQUERY_PortfoliosIndividualsTransactions();


        TradingTransactionModel spINSERTDATA_TradingTransaction(TradingTransactionModel model);


        TradingTransactionModel spEDITDATA_TradingTransaction(TradingTransactionModel oldModel, TradingTransactionModel newModel);

        ///////////////////////////////////////
        ///////TAB - PORTFOLIO MOVEMENTS///////
        //////////////////////////////////////

        IEnumerable<zFullEODPriceModel> spQUERY_SharePriceHistoryMultiple(List<string> inputASXCodeList);


        //////////////////////////////////
        ///////TAB - NOTEPAD UPLOAD///////
        //////////////////////////////////
        List<ASXEODPriceModel> spINSERTDATA_ASXEODPrice(DataTable dt);
        DocumentUploadHistoryModel spINSERTDATA_DocumentUploadRecord(DocumentUploadHistoryModel model);

        TradingTransactionTypeModel CreateTransactionType(TradingTransactionTypeModel model);
    }
}




