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
        IEnumerable<FullPortfolioModel> PopulatePortfolioModel();
        IEnumerable<FullShareTransactionModel> spQueryDummyAllInformation2();
        IEnumerable<NewShareTransactionModel> spQueryDummyAllInformation();

        IEnumerable<NewShareTransactionModel> spQueryDummyTransactions();

        ///////////////////////////////
        /////// DROP DOWN BOXES ///////
        ///////////////////////////////
        List<PortfolioModel> spQueryPortfolios();

        List<ShareTransactionTypeModel> spQueryTransactionTypes();

        ///////////////////////////////
        ///////TAB - PRICE QUERY///////
        ///////////////////////////////
        List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceOpen(string ASXCode, int InputYear);
        List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceClose(string ASXCode, int InputYear);
        List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceHigh(string ASXCode, int InputYear);
        List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceLow(string ASXCode, int InputYear);


        /////////////////////////////////////
        ///////TAB - PORTFILIO ON DAY///////
        ////////////////////////////////////
        List<spQueryPortfolioItemsForCertainDate> spQueryPortfolioItemsForCertainDate(string InputPortfolioName, int InputStartDate, int InputEndDate);


        ///////////////////////////////////////
        ///////TAB - SHARE TRANSACTIONS///////
        //////////////////////////////////////
        List<spQueryShareTransactionsForPortfolio> spQueryAllShareTransactions(string InputPortfolioName);

        ShareTransactionModel spInsertNewShareTransaction(string PortfolioName, ShareTransactionModel model);

        ///////////////////////////////////////
        ///////TAB - PORTFOLIO MOVEMENTS///////
        //////////////////////////////////////


        //////////////////////////////////
        ///////TAB - NOTEPAD UPLOAD///////
        //////////////////////////////////
        List<ASXPriceModel> spINSERT_NotepadFile(DataTable dt);
        DocumentUploadHistoryModel CreateNewDocumentUploadRecord(DocumentUploadHistoryModel model);




        ShareTransactionTypeModel CreateTransactionType(ShareTransactionTypeModel model);
    }
}




