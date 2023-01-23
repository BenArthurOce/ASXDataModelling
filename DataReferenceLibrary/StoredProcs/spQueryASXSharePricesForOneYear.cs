using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.StoredProcs
{
    public class spQueryASXSharePricesForOneYear
    {
        public long DateKey { get; set; }

        public long DayInt { get; set; }

        public long MonthInt { get; set; }

        public long YearCalendar { get; set; }

        public double? Price { get; set; }
    }
}
