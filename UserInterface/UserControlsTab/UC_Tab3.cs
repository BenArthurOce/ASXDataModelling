using DataReferenceLibrary.DataAccess;
using DataReferenceLibrary.StoredProcs;
using DataReferenceLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.FormAssets;
using DataReferenceLibrary.Models;
using UserInterface.Forms;
using System.Globalization;
using DataReferenceLibrary.Models2;

namespace UserInterface.UserControlsTab
{
    public partial class UC_Tab3 : UserControl, ICreateTransactionRequester
    {
        private static UC_Tab3 _instance;

        public static UC_Tab3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Tab3();
                return _instance;
            }
        }



        public UC_Tab3()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<spQueryShareTransactionsForPortfolio> output;
          //  output = GlobalConfig.Connection.spQueryAllShareTransactions();
          //  PrepareTableLayoutPanel(output);
        }

        private void PrepareTableLayoutPanel(List<spQueryShareTransactionsForPortfolio> output)
        {

            foreach (spQueryShareTransactionsForPortfolio TransLine in output)
            {
    
            }
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            // Call the CreateNewTransactionForm
            CreateNewTransactionForm form = new CreateNewTransactionForm(this);
            form.Show();
        }

        public void CreateTransactionComplete(TradingTransactionModel model)
        {
            throw new NotImplementedException();
        }
    }
}