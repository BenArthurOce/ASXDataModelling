using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models
{
    public class PortfolioModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }


        public string DropDownBoxDisplay
        {
            get
            {
                return $"{Name}";
            }
        }
    }


}
