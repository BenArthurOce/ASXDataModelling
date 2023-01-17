using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models
{
    public class ShareTransactionTypeModel
    {
        public Guid Id { get; set; }

        public string Type { get; set; }

        public bool IsDeleted { get; set; }


        public ShareTransactionTypeModel()
        {

        }

        
        public ShareTransactionTypeModel(string id, string type, string isDeleted)
        {

        }



    }
}
