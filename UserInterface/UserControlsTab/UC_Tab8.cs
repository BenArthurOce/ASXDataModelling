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
using System.Windows.Documents;

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
        private List<TradingTransactionTypeModel> transactionTypes = GlobalConfig.Connection.spGETLIST_TransactionTypes();
        private List<TradingSectorModel> tradingSectors = GlobalConfig.Connection.spGETLIST_TradingSectors();

        public UC_Tab8()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            cBoxPortfolio.DataSource = availablePortfolios;
            cBoxPortfolio.DisplayMember = "DropDownBoxDisplay";

            cboxType.DataSource = transactionTypes;
            cboxType.DisplayMember = "DropDownBoxDisplay";

            cboxSector.DataSource = tradingSectors;
            cboxSector.DisplayMember = "DropDownBoxDisplay";
        }

        //TODO - find what 3 letter codes are missing an industry

        //TODO - Line up header panel correctly - padding doesnt work when window is resized


        //TODO - Sector is now missing from the Transaction Panel. I changed "SectorName" to "Name" in the model. It has to do with that.

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            //TODO - VALIDATE FILTER ITEMS

            // Clear previous entries
            flowLayoutPanel1.Controls.Clear();

            IEnumerable<zFullPortfolioModel> output2;
            output2 = GlobalConfig.Connection.spQUERY_PortfoliosIndividualsTransactions();

            //TODO - ADD CATCH IF THE TEXTBOX IS NULL
            zFullPortfolioModel selected_portfolio = output2.FirstOrDefault(item => item.Name == cBoxPortfolio.Text);


            //List<TradingTransactionModel> filtered_transactions = selected_portfolio.Transactions.FirstOrDefault(p => p.TradingTransactionTypeId.Name == cboxType.Text);

            //List<TradingTransactionModel> filtered_transactions = (List<TradingTransactionModel>)selected_portfolio.Transactions.Where(p => p.TradingTransactionTypeId.Name == cboxType.Text);

            //var items = selected_portfolio.Transactions.Where(item => item.TradingTransactionTypeId.Name == "BUY");

            var items = selected_portfolio.Transactions.Where(item => item.TradingEntityId.ASXCode == tBoxASXCode.Text);
            int a = 1;

            foreach (var trans in items)
            {
                TransactionPanel newCustomPanel = new TransactionPanel(trans);
                newCustomPanel.Width = flowLayoutPanel1.Width;
                newCustomPanel.Dock = DockStyle.Top;

                flowLayoutPanel1.Controls.Add(newCustomPanel);
            }

            /*
            foreach (TradingTransactionModel transaction in selected_portfolio.Transactions)
            {
                TransactionPanel newCustomPanel = new TransactionPanel(transaction);
                newCustomPanel.Width = flowLayoutPanel1.Width;
                newCustomPanel.Dock = DockStyle.Top;

                flowLayoutPanel1.Controls.Add(newCustomPanel);
            }
            */
        }





        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpDateFrom.Text = null;
            dtpDateTo.Text = null;
            cboxType.Text = null;
            cboxSector.Text = null;
            tBoxASXCode.Text = null;
            nTboxMinAmount.Text = null;
            nTboxMaxAmount.Text = null;
        }
    }
}
