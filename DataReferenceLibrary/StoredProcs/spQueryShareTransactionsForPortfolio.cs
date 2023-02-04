using DataReferenceLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.StoredProcs
{
    public class spQueryShareTransactionsForPortfolio
    {
        public Guid Id { get; set; }

        public int ContractNote { get; set; }

        public string ASXCode { get; set; }

        public string CompanyName { get; set; }

        public string CompanySector { get; set; }

        public int Date { get; set; }

        public string Type { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TradeValue { get; set; }

        public decimal Brokerage { get; set; }

        public decimal TotalValue { get; set; }

        public bool IsIncrease { get; set; }



        public spQueryShareTransactionsForPortfolio()
        { }


        public spQueryShareTransactionsForPortfolio(string _ContractNote, string _ASXCode, string _CompanyName, string _CompanySector, string _Date, string _Type, string _Quantity, string _UnitPrice, string _TradeValue, string _Brokerage, string _TotalValue, string _IsIncrease)
        {
            int ContractNoteValue = 0;
            int.TryParse(_ContractNote, out ContractNoteValue);
            ContractNote = ContractNoteValue;

            ASXCode = _ASXCode;
            CompanyName = _CompanyName;
            CompanySector = _CompanySector;

            int DateValue = 0;
            int.TryParse(_Date, out DateValue);
            Date = DateValue;

            Type = _Type;

            int QuantityValue = 0;
            int.TryParse(_Quantity, out QuantityValue);
            Quantity = QuantityValue;

            decimal UnitPriceValue = 0;
            decimal.TryParse(_UnitPrice, out UnitPriceValue);
            UnitPrice = UnitPriceValue;

            decimal TradeValueValue = 0;
            decimal.TryParse(_TradeValue, out TradeValueValue);
            TradeValue = TradeValueValue;

            decimal BrokerageValue = 0;
            decimal.TryParse(_Brokerage, out BrokerageValue);
            Brokerage = BrokerageValue;


            decimal TotalValueValue = 0;
            decimal.TryParse(_TotalValue, out TotalValueValue);
            TotalValue = TotalValueValue;

            if (_Type == "Buy" || _Type == "DRP") { IsIncrease = true; } else { IsIncrease = false; }

        }


    }


}
