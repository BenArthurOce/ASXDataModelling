using DataReferenceLibrary.Models2;
using DataReferenceLibrary.StoredProcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Filters
{
    public class Filtering
    {
        private TradingTransactionTypeModel _transactionType;
        private readonly TradingEntityModel _tradingCompany;
        private readonly TradingSectorModel _tradingSector;
        private readonly DateTime _minDate;
        private readonly DateTime _maxDate;
        private readonly double _minTradeValue;
        private readonly double _maxTradeValue;

        public Filtering(TradingTransactionTypeModel transactionType)
        {
            _transactionType = transactionType;
        }

        public Filtering(TradingEntityModel tradingCompany)
        {
            _tradingCompany = tradingCompany;
        }

        public Filtering(TradingSectorModel tradingSector)
        {
            _tradingSector = tradingSector;
        }

        public Filtering(DateTime minDate, DateTime maxDate)
        {
            _minDate = minDate;
            _maxDate = maxDate;
        }

        public Filtering(double minTradeValue, double maxTradeValue)
        {
            _minTradeValue = minTradeValue;
            _maxTradeValue = maxTradeValue;
        }

        public List<TradingTransactionModel> FilterTransactions(List<TradingTransactionModel> transactions, Func<TradingTransactionModel, bool> filterCriteria)
        {
            return transactions.Where(filterCriteria).ToList();
        }


    }
}
