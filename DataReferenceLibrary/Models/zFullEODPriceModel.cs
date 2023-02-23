using DataReferenceLibrary.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models
{
    public class zFullEODPriceModel
    {

        //public Guid Id { get; set; }
        public TradingEntityModel TradingEntityModel { get; set; }
        public DatesModel DatesModel { get; set; }
        public decimal PriceOpen { get; set; }
        public decimal PriceHigh { get; set; }
        public decimal PriceLow { get; set; }
        public decimal PriceClose { get; set; }
        public int VolumeTraded { get; set; }


    }
}
