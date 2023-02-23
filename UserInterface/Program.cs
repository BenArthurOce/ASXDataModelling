using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataReferenceLibrary;
using UserInterface.Forms;

namespace UserInterface
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            


            // Start the Reference Library
            DataReferenceLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);

            //TODO - Create SQL lists for forms (Transaction Types, Portfolio Names)

            Application.Run(new ShareDashboardForm());
            //Application.Run(new CreateNewTransactionForm());
            //Application.Run(new TransactionFilterForm());


        }
    }
}
