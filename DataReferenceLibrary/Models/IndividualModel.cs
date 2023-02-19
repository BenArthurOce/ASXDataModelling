using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models2
{
    public class IndividualModel
    {
        public Guid Id { get; set; }

        public int CustomerNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SearchName { get; set; }

        public int HIN { get; set; }

        public int Postcode { get; set; }

        public bool isDeleted { get; set; }
    } 
}
