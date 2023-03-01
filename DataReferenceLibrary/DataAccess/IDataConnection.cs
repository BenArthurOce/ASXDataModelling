using DataReferenceLibrary.Models;
using DataReferenceLibrary.Models2;
using DataReferenceLibrary.StoredProcs;
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


        ///////////////////////////////
        ///////TAB - PRICE QUERY///////
        ///////////////////////////////
        IEnumerable<zFullEODPriceModel> spQUERY_PricesOnYears(string ASXCode, int YearRequest);


        /////////////////////////////////////
        ///////TAB - PORTFILIO ON DAY///////
        ////////////////////////////////////
        List<spQueryPortfolioItemsForCertainDate> spQUERY_PortfolioValue(string InputPortfolioName, int InputEndDate);


        ///////////////////////////////////////
        ///////TAB - SHARE TRANSACTIONS///////
        //////////////////////////////////////

        IEnumerable<zFullPortfolioModel> spQUERY_PortfoliosIndividualsTransactions();


        TradingTransactionModel spINSERTDATA_TradingTransaction(TradingTransactionModel model);


        TradingTransactionModel spEDITDATA_TradingTransaction(TradingTransactionModel oldModel, TradingTransactionModel newModel);

        ///////////////////////////////////////
        ///////TAB - PORTFOLIO MOVEMENTS///////
        //////////////////////////////////////


        //////////////////////////////////
        ///////TAB - NOTEPAD UPLOAD///////
        //////////////////////////////////
        List<ASXEODPriceModel> spINSERTDATA_ASXEODPrice(DataTable dt);
        DocumentUploadHistoryModel spINSERTDATA_DocumentUploadRecord(DocumentUploadHistoryModel model);




        TradingTransactionTypeModel CreateTransactionType(TradingTransactionTypeModel model);
    }
}




