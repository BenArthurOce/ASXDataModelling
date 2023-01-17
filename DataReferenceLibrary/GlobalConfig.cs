using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataReferenceLibrary.DataAccess;

namespace DataReferenceLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Create SQL Connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create Text Connection
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
