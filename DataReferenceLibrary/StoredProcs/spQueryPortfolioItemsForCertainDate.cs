using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.StoredProcs
{
    public class spQueryPortfolioItemsForCertainDate
    {

        public string ASXCode { get; set; }

        public int SharesOwned { get; set; }

        public decimal CostBase { get; set; }

        public decimal CostPrice { get; set; }

        public decimal CurrentPrice { get; set; }

        public decimal MarketValue { get; set; }

        public decimal ProfitLoss { get; set; }

        public decimal ProfitLossP { get; set; }

        public decimal WeightP { get; set; }
    }
}
