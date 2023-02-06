using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReferenceLibrary.Filters
{
    public class Filter
    {
        public string FieldAffected { get; set; }

        public string MatchType { get; set; }       // Less Than, Greater Than, Equal To, Between

        public string DataType { get; set; }

        public string MatchValue { get; set; }

        public string LowerValueToMatch { get; set; }

        public string HigherValueToMatch { get; set; }

        public Filter() 
        { }

        public Filter(string fieldAffected, string dataType, string matchType, string matchValue)
        {
            FieldAffected = fieldAffected;
            DataType = dataType;
            MatchType = matchType;
            MatchValue = matchValue;
        }

        public Filter(string fieldAffected, string dataType, string matchType, string lowerValueToMatch, string higherValueToMatch)
        {
            FieldAffected = fieldAffected;
            DataType = dataType;
            MatchType = matchType;
            LowerValueToMatch = lowerValueToMatch;
            HigherValueToMatch = higherValueToMatch;
        }
    }
}
