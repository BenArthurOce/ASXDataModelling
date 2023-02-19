using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models2
{
    public class TradingTransactionTypeModel
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public bool isIncrease { get; set; }

        public bool isDecrease { get; set; }

        public string DropDownBoxDisplay
        {
            get
            {
                return $"{Name}";
            }
        }
    }
}
