using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models2
{
    public class TradingEntityModel
    {

        public Guid Id { get; set; }

        public string ASXCode { get; set; }

        public string Name { get; set; }

        public TradingSectorModel TradingSectorId { get; set; }

        public bool isLICS { get; set; }

        public bool isAREIT { get; set; }

        public bool isETP { get; set; }

        public bool isIndices { get; set; }

        public bool isABFund { get; set; }

        public bool isDerivative { get; set; }

        public string Notes { get; set; }
    }
}
