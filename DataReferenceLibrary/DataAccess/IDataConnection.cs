using DataReferenceLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.DataAccess
{
    public interface IDataConnection
    {
       ShareTransactionTypeModel CreateTransactionType(ShareTransactionTypeModel model);
    }
}
