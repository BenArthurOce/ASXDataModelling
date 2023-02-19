using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models2
{
    public class PortfolioModel
    {
        public Guid Id { get; set; }

        public int PortfolioCustomerNumber { get; set; }

        public string Name { get; set; }

        public bool isDeleted { get; set; }

        public List <TradingTransactionModel> ShareTransactions { get; set; }

        public List <IndividualModel> Individuals { get; set; }

        public string DropDownBoxDisplay
        {
            get
            {
                return $"{Name}";
            }
        }
    }
}
