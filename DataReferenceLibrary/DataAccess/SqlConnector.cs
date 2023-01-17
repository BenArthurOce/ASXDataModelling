using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataReferenceLibrary.Models;

namespace DataReferenceLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        public ShareTransactionTypeModel CreateTransactionType(ShareTransactionTypeModel model)
        {
            model.Id = Guid.NewGuid();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("AppConfigAccess1")))
            {

                string LookupId = "CBA";
                var output = connection.Query<ASXPriceModel>("dbo.spQueryASXSharePricesBetweenDates @ASXCode, @StartDate, @EndDate", new { ASXCode = LookupId, StartDate = 20220101, EndDate = 20220630 }).ToList();



                var p = new DynamicParameters();
                p.Add("@in_TransType", model.Type);

                connection.Execute("dbo.spINSERT_ShareTransactionType", p, commandType: CommandType.StoredProcedure);



                //var output = connection.Query<ShareTransactionTypeModel>("dbo.spQueryASXSharePricesBetweenDates @ASXCode, @StartDate, @EndDate", new { ASXCode = LookupId, StartDate = 20220101, EndDate = 20220630 }).ToList();
                //return output;
            }



                return model;
        }
    }
}
