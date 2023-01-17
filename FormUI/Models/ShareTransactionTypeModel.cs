using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class ShareTransactionTypeModel
    {
        public Guid ShareTransactionTypeId { get; set; }

        public string Type { get; set; }

        public bool IsDeleted { get; set; }

    }
}
