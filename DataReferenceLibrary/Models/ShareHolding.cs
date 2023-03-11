using DataReferenceLibrary.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models
{
    public class ShareHolding
    {

        public int Id { get; set; }

        public int Date { get; set; }

        public int SharesOwned { get; set; }
        public decimal CostBase { get; set; }
        public decimal CostPerShare { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal MarketValue { get; set; }
        public decimal ProfitLoss { get; set; }
        public decimal ProfitLossPct { get; set; }
        public decimal WeightPct { get; set; }

        public PortfolioModel PortfolioModel { get; set; }
    
        public TradingEntityModel TradingEntityModel { get; set; }




    }
}
