using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models
{
    public class ASXPriceModel
    {


        // https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-7.0
        /// <summary>
        /// The unique identifier for the ASX day summary
        /// </summary>
        public Guid Id { get; set; }
        public long RecordNum { get; set; }
        public string ASXCode { get; set; }
        public long? ASXDate { get; set; }
        public double? PriceOpen { get; set; }
        public double? PriceHigh { get; set; }
        public double? PriceLow { get; set; }
        public double? PriceClose { get; set; }
        public long? VolumeTraded { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{Id}, {RecordNum}, {ASXCode}, {ASXDate}, {PriceOpen} ";
            }
        }


    }
}
