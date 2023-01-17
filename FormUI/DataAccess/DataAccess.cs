using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class DataAccess
    {



        public List<ASXPriceModel> GetASXPriceData(string LookupId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BENASXDATABASE")))
            {
                var output = connection.Query<ASXPriceModel>("dbo.spQueryASXSharePricesBetweenDates @ASXCode, @StartDate, @EndDate", new { ASXCode = LookupId, StartDate = 20220101, EndDate = 20220630}).ToList();
                return output;
            }
        }
    }



}
