using DataReferenceLibrary.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Filters
{
    public class Filter2 : IFilter<TradingTransactionModel>
    {

        private TradingTransactionTypeModel _transactionType;
        private readonly TradingEntityModel _tradingCompany;
        private readonly TradingSectorModel _tradingSector;
        private readonly DateTime _minDate;
        private readonly DateTime _maxDate;
        private readonly double _minTradeValue;
        private readonly double _maxTradeValue;


        public Filter2(TradingTransactionTypeModel transactionType)
        {
            _transactionType = transactionType;
        }

        public Filter2(TradingEntityModel tradingCompany)
        {
            _tradingCompany = tradingCompany;
        }

        public Filter2(TradingSectorModel tradingSector)
        {
            _tradingSector = tradingSector;
        }

        public Filter2(DateTime minDate, DateTime maxDate)
        {
            _minDate = minDate;
            _maxDate = maxDate;
        }

        public Filter2 (double minTradeValue, double maxTradeValue)
        {
            _minTradeValue = minTradeValue;
            _maxTradeValue = maxTradeValue;
        }

        public bool Filtering(TradingTransactionModel model) 
        {
            return model.TotalValue >= _minTradeValue && model.TotalValue <= _maxTradeValue;
        }
    }
}
