using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models2
{
    public class NewShareTransactionModel 
    {
        public Guid Id { get; set; }


        public int SequenceNumber { get; set; }

        public int ContractNote { get; set; }

        public NewPortfolioModel PortfolioId { get; set; }

        //public Guid PortfolioId { get; set; }

        /// <summary>
        /// public NewTradingCompanyModel Company { get; set; }
        /// </summary>

        public NewTradingCompanyModel CompanyId { get; set; }

        //public Guid CompanyId { get; set; }

        public int Date { get; set; }

        public NewShareTransactionTypeModel TypeId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public double? TradeValue { get; set; }

        public double? Brokerage { get; set; }

        public double? TotalValue { get; set; }

        public bool IsIncrease { get; set; }

        public bool IsDeleted { get; set; }
    }
}
