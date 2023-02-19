using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Models2
{
    public class DatesModel
    {
        public Guid Id { get; set; }
        public int DateKey { get; set; }
        public DateTime DateId { get; set; }
        public long DayInt { get; set; }
        public decimal DayInt00 { get; set; }
        public string DayOrdinal { get; set; }
        public long WeekDayInt { get; set; }
        public string WeekdayFull { get; set; }
        public string WeekdayAbv { get; set; }
        public bool IsWeekday { get; set; }
        public bool IsWeekEnd { get; set; }
        public long MonthInt { get; set; }
        public decimal MonthInt00 { get; set; }
        public string MonthStringFull { get; set; }
        public string MonthStringAbv { get; set; }
        public long YearCalendar { get; set; }
        public long YearFinancial { get; set; }
        public long IsLeapYear { get; set; }
        public long QuarterCalendarInt { get; set; }
        public long QuarterFinancialInt { get; set; }
        public long DaysInMonth { get; set; }
        public long DayOfYear { get; set; }
        public long DaysLeftInYear { get; set; }
        public long YearMonthInt { get; set; }
        public string MonthYearStringFull { get; set; }
        public string MonthYearStringAbv { get; set; }
        public string YearMonthStringFull { get; set; }
        public string YearMonthStringAbv { get; set; }
        public string FullDateStringLong { get; set; }
        
    }
}
