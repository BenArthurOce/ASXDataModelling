using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models
{
    public class ASXEODPriceModel
    {


        // https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-7.0
        /// <summary>
        /// The unique identifier for the ASX day summary
        /// </summary>
        public Guid Id { get; set; }
        public string ASXCode { get; set; }
        public int Date { get; set; }
        public decimal PriceOpen { get; set; }
        public decimal PriceHigh { get; set; }
        public decimal PriceLow { get; set; }
        public decimal PriceClose { get; set; }
        public int VolumeTraded { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{Id}, {ASXCode}, {Date}, {PriceOpen} ";
            }
        }

        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

    }
}
