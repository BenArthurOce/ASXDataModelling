using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models2
{
    public class FullPortfolioModel
    {
        public Guid Id { get; set; }

        public int PortfolioNumber { get; set; }

        public string Name { get; set; }

        public bool isDeleted { get; set; }

        public List<NewIndividualModel> Individuals { get; set; }

        public List<FullShareTransactionModel> Transactions { get; set; }
    }
}
