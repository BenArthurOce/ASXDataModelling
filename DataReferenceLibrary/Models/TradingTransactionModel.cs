using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models2
{
    public class TradingTransactionModel 
    {
        public Guid Id { get; set; }

        public int SequenceNumber { get; set; }

        public string ContractNote { get; set; }

        public PortfolioModel PortfolioId { get; set; }

        public TradingEntityModel TradingEntityId { get; set; }

        public int Date { get; set; }

        public TradingTransactionTypeModel TradingTransactionTypeId { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public double TradeValue { get; set; }

        public double Brokerage { get; set; }

        public double TotalValue { get; set; }

        public bool IsDeleted { get; set; }


        public TradingTransactionModel()
        { }


        public TradingTransactionModel(string _ContractNote, string _ASXCode, string _Date, string _Type, string _Quantity, string _UnitPrice, string _TradeValue, string _Brokerage, string _TotalValue, string _IsIncrease)
        {
            //int ContractNoteValue = 0;
            //int.TryParse(_ContractNote, out ContractNoteValue);
            //ContractNote = ContractNoteValue;

            //ASXCode = _ASXCode;

            int DateValue = 0;
            int.TryParse(_Date, out DateValue);
            Date = DateValue;

            //Type = _Type;

            int QuantityValue = 0;
            int.TryParse(_Quantity, out QuantityValue);
            Quantity = QuantityValue;

            //decimal UnitPriceValue = 0;
            //decimal.TryParse(_UnitPrice, out UnitPriceValue);
            //UnitPrice = UnitPriceValue;

            decimal TradeValueValue = 0;
            decimal.TryParse(_TradeValue, out TradeValueValue);
            //TradeValue = TradeValueValue;

            decimal BrokerageValue = 0;
            decimal.TryParse(_Brokerage, out BrokerageValue);
            // Brokerage = BrokerageValue;


            decimal TotalValueValue = 0;
            decimal.TryParse(_TotalValue, out TotalValueValue);
            //TotalValue = TotalValueValue;

        }
    }
}