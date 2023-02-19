using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models2
{
    public class FullShareTransactionModel
    {
        public Guid Id { get; set; }

        public TradingTransactionTypeModel TypeId { get; set; }

        public TradingEntityModel CompanyId { get; set; }

        public int SequenceNumber { get; set; }

        public string ContractNote { get; set; }

        public int Date { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public double TradeValue { get; set; }

        public double Brokerage { get; set; }

        public double TotalValue { get; set; }

        public bool IsIncrease { get; set; }

        public bool IsDeleted { get; set; }
    }
}
