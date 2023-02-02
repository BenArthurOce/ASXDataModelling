using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models
{
    public class ShareTransactionModel
    {
        public Guid Id { get; set; }

        public int SequenceNumber { get; set; }

        public int? ContractNote { get; set; }

        public string ASXCode { get; set; }

        public int Date { get; set; }

        // public Guid TypeId { get; set; }
        // public ICollection<ShareTransactionTypeModel> ShareTransactionTypeId { get; set; }
        //public ShareTransactionTypeModel Type { get; set; }

        public string Type { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TradeValue { get; set; }

        public decimal Brokerage { get; set; }

        public decimal TotalValue { get; set; }

        public bool IsIncrease { get; set; }

    }
}
