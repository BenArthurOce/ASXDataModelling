﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataReferenceLibrary.Models
{
    public class ShareTransactionTypeModel
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

        public ShareTransactionTypeModel()
        {

        }

        
        public ShareTransactionTypeModel(string id, string type, string isDeleted)
        {

        }



    }
}
