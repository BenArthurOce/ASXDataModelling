using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataReferenceLibrary.Models2
{
    public class TradingSectorModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string DropDownBoxDisplay
        {
            get
            {
                return $"{Name}";
            }
        }


    }
}
