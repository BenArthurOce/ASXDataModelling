using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models
{
    public class TradingCompanyModel
    {
        public Guid Id { get; set; }
        public string ASXCode { get; set; }
        public string Name { get; set; }
        public TradingSectorModel SectorId { get; set; }

    }
}
