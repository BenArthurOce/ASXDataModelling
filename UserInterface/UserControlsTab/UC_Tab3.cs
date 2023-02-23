using DataReferenceLibrary.DataAccess;
using DataReferenceLibrary.Models;
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
using DataReferenceLibrary.StoredProcs;
using System.Globalization;
using UserInterface.FormAssets;
using DataReferenceLibrary.Models2;
using UserInterface.Forms;

namespace UserInterface.UserControlsTab
{
    public partial class UC_Tab3 : UserControl, ICreateTransactionRequester
    {
        private List<PortfolioModel> availablePortfolios = GlobalConfig.Connection.spGETLIST_Portfolios();

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
            WireUpLists();

        }

        private void WireUpLists()
        {
            cBoxPortfolio.DataSource = availablePortfolios;
            cBoxPortfolio.DisplayMember = "DropDownBoxDisplay";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PrepareTableLayoutPanel(List<spQueryShareTransactionsForPortfolio> output)
        {
            IEnumerable<zFullPortfolioModel> output2;
            output2 = GlobalConfig.Connection.spQUERY_PortfoliosIndividualsTransactions();

            foreach (zFullPortfolioModel portfolio in output2)
            {
                if (portfolio.Name == cBoxPortfolio.Text)
                {

                    foreach (var transaction in portfolio.Transactions)
                    {

                        TransactionPanel newCustomPanel = new TransactionPanel(transaction);


                        flowLayoutPanel1.Controls.Add(newCustomPanel);
                    }

                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Call the CreateNewTransactionForm
            CreateNewTransactionForm form = new CreateNewTransactionForm(this);
            form.Show();
        }

        public void CreateTransactionComplete(TradingTransactionModel model)
        {
            throw new NotImplementedException();
        }
    }
}