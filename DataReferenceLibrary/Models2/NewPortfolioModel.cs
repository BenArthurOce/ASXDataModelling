using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models2
{
    public class NewPortfolioModel
    {
        public Guid Id { get; set; }

        public int PortfolioNumber { get; set; }

        public string Name { get; set; }

        public bool isDeleted { get; set; }

  //   public ICollection<NewShareTransactionModel> ShareTransactions { get; set; }

        public List <NewShareTransactionModel> ShareTransactions { get; set; }

        public List <NewIndividualModel> Individuals { get; set; }
    }
}
