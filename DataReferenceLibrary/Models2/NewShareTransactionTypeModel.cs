using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models2
{
    public class NewShareTransactionTypeModel
    {

        //public NewShareTransactionTypeModel Id { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

    }
}
