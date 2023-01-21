using DataReferenceLibrary.Models;
using DataReferenceLibrary.StoredProcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.DataAccess
{
    public interface IDataConnection
    {

        List<spQueryASXSharePricesForOneYear> QueryPriceForOneYear(string ASXCode, int InputYear);
        //public List<ASXPriceModel> QueryPriceBetweenTwoYears()

        ShareTransactionTypeModel CreateTransactionType(ShareTransactionTypeModel model);
        //public ShareTransactionTypeModel CreateTransactionType(ShareTransactionTypeModel model)
    }
}
