using DataReferenceLibrary.Models;
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
        List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceOpen(string ASXCode, int InputYear);
        List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceClose(string ASXCode, int InputYear);
        List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceHigh(string ASXCode, int InputYear);
        List<spQueryASXSharePricesForOneYear> spQueryASXSharePricesForOneYear_PriceLow(string ASXCode, int InputYear);

        List<ASXPriceModel> spINSERT_NotepadFile(DataTable dt);

        DocumentUploadHistoryModel CreateNewDocumentUploadRecord(DocumentUploadHistoryModel model);

        ShareTransactionTypeModel CreateTransactionType(ShareTransactionTypeModel model);
    }
}




