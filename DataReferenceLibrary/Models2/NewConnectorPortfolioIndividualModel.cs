using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models2
{
    public class NewConnectorPortfolioIndividualModel
    {
        //public Guid Id { get; set; }

        public NewIndividualModel IndividualId { get; set; }

        public FullPortfolioModel PortfolioId { get; set; }
    }
}
