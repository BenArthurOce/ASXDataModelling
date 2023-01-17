using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataReferenceLibrary;

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
            DataReferenceLibrary.GlobalConfig.InitializeConnections(true, false);

            Application.Run(new ShareDashboardForm());
        }
    }
}
