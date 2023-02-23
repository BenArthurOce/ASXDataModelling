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
using DataReferenceLibrary.Models2;
using System.Globalization;
using UserInterface.FormAssets;
using DataReferenceLibrary.Models;
using UserInterface.Forms;

namespace UserInterface.UserControlsTab
{
    public partial class UC_Tab8 : UserControl
    {
        private static UC_Tab8 _instance;

        public static UC_Tab8 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Tab8();
                return _instance;
            }
        }

        private List<PortfolioModel> availablePortfolios = GlobalConfig.Connection.spGETLIST_Portfolios();

        public UC_Tab8()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            cBoxPortfolio.DataSource = availablePortfolios;
            cBoxPortfolio.DisplayMember = "DropDownBoxDisplay";
        }
        //TODO - Drop down display of portfolios

        //TODO - find what 3 letter codes are missing an industry

        //TODO - Line up header panel correctly - padding doesnt work when window is resized
        private void btnDisplay_Click(object sender, EventArgs e)
        {

            // Clear previous entries
            flowLayoutPanel1.Controls.Clear();



            IEnumerable<zFullPortfolioModel> output2;
            output2 = GlobalConfig.Connection.spQUERY_PortfoliosIndividualsTransactions();

            foreach (zFullPortfolioModel portfolio in output2)
            {
                if (portfolio.Name == cBoxPortfolio.Text)
                {

                    foreach (var transaction in portfolio.Transactions)
                    {

                        TransactionPanel newCustomPanel = new TransactionPanel(transaction);
                        //MessageBox.Show(flowLayoutPanel1.Width.ToString());
                        //newCustomPanel.PanelWidth = flowLayoutPanel1.Width;
                        newCustomPanel.Width = flowLayoutPanel1.Width;
                        newCustomPanel.Dock = DockStyle.Top;
                        //newCustomPanel.BackColor = Color.Red;
                        //newCustomPanel.Dock = DockStyle.Fill;


                        flowLayoutPanel1.Controls.Add(newCustomPanel);
                    }

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Call the CreateNewTransactionForm
            //CreateNewTransactionForm form = new CreateNewTransactionForm(this);
            //form.Show();

           


        }
    }
}
