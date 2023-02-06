using DataReferenceLibrary.StoredProcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Filters
{
    public class TransactionFilter
    {
        public List<spQueryShareTransactionsForPortfolio> FilterTransactions(List<spQueryShareTransactionsForPortfolio> transactions, Func<spQueryShareTransactionsForPortfolio, bool> filterCriteria)
        {
            return transactions.Where(filterCriteria).ToList();
        }
    }
}
