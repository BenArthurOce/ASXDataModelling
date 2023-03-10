
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
using System.Web.Util;
using System.Linq.Expressions;

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
            dtpDateFrom.Value = DateTime.Now;
            dtpDateTo.Value = DateTime.Now;
            cboxType.SelectedItem = null;
            cboxSector.SelectedItem = null;
            InputDummyDates();
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

        private void InputDummyDates()
        {
            dtpDateFrom.Checked = true;
            dtpDateTo.Checked = true;
            dtpDateFrom.Value = DateTime.Today.AddDays(-600);
            dtpDateTo.Value = DateTime.Today.AddDays(-400);
        }

        //TODO - find what 3 letter codes are missing an industry

        //TODO - Line up header panel correctly - padding doesnt work when window is resized


        //TODO - Sector is now missing from the Transaction Panel. I changed "SectorName" to "Name" in the model. It has to do with that.


        private IEnumerable<zFullPortfolioModel> QueryPortfolioTransactions()
        {
            IEnumerable<zFullPortfolioModel> sql_results;
            sql_results = GlobalConfig.Connection.spQUERY_PortfoliosIndividualsTransactions();
            return sql_results;
        }


        private IEnumerable<TradingTransactionModel> FilterTheTransactions(IEnumerable<TradingTransactionModel> filtered_transactions)
        {
            //FILTER - DATES
            //======================================
            //Activate the Code if one of the date time pickers has been filled with data
            if (!string.IsNullOrWhiteSpace(dtpDateFrom.Text) || !string.IsNullOrWhiteSpace(dtpDateTo.Text))
            {
                try
                {
                    // MinBox YES, MaxBox NO (Search Transactions after the MinDate)
                    if (!string.IsNullOrWhiteSpace(dtpDateFrom.Text) && string.IsNullOrWhiteSpace(dtpDateTo.Text))
                    {
                        int minDate = Int32.Parse(dtpDateFrom.Value.ToString("yyyyMMdd"));
                        filtered_transactions = filtered_transactions.Where(t => t.Date >= minDate);
                    }


                    // MinBox NO, MaxBox YES (Search Transactions before the MaxDate)
                    if (string.IsNullOrWhiteSpace(dtpDateFrom.Text) && !string.IsNullOrWhiteSpace(dtpDateTo.Text))
                    {
                        int maxDate = Int32.Parse(dtpDateTo.Value.ToString("yyyyMMdd"));
                        filtered_transactions = filtered_transactions.Where(t => t.Date <= maxDate);
                    }


                    // MinBox YES, MaxBox YES (Search Transactions between the two dates)
                    if (!string.IsNullOrWhiteSpace(dtpDateFrom.Text) && !string.IsNullOrWhiteSpace(dtpDateTo.Text))
                    {
                        int minDate = Int32.Parse(dtpDateFrom.Value.ToString("yyyyMMdd"));
                        int maxDate = Int32.Parse(dtpDateTo.Value.ToString("yyyyMMdd"));

                        // If Min is higher than max, give error exit code
                        if (minDate > maxDate)
                        {
                            throw new Exception("Minimum Date Filter is larger than Maximum Date Filter. Please adjust");
                        }
                        else
                        {
                            filtered_transactions = filtered_transactions.Where(t => t.Date >= minDate && t.Date <= maxDate);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



            //FILTER - TRANSACTION TYPES
            //======================================
            if (!string.IsNullOrWhiteSpace(cboxType.Text))
            {
                filtered_transactions = filtered_transactions.Where(item => item.TradingTransactionTypeId.Name == cboxType.Text);
            }


            //FILTER - ASX CODE
            //======================================
            if (!string.IsNullOrWhiteSpace(tBoxASXCode.Text))
            {
                filtered_transactions = filtered_transactions.Where(item => item.TradingEntityId.ASXCode == tBoxASXCode.Text.ToUpper());
            }


            //FILTER - TRANSACTION AMOUNT
            //======================================
            //Activate the Code if one of the numeric textboxes has been filled with data
            if (!string.IsNullOrWhiteSpace(nTboxMinAmount.Text) || !string.IsNullOrWhiteSpace(nTboxMaxAmount.Text))
            {
                try
                {

                    // MinBox YES, MaxBox NO (Search Transactions with a value more than the MinAmount)
                    if (!string.IsNullOrWhiteSpace(nTboxMinAmount.Text) && string.IsNullOrWhiteSpace(nTboxMaxAmount.Text))
                    {
                        int minAmount = Int32.Parse(nTboxMinAmount.Text);
                        filtered_transactions = filtered_transactions.Where(t => t.TotalValue >= minAmount);
                    }


                    // MinBox NO, MaxBox YES (Search Transactions with a value less than the MaxAmount)
                    if (string.IsNullOrWhiteSpace(nTboxMinAmount.Text) && !string.IsNullOrWhiteSpace(nTboxMaxAmount.Text))
                    {
                        int maxAmount = Int32.Parse(nTboxMaxAmount.Text);
                        filtered_transactions = filtered_transactions.Where(t => t.TotalValue <= maxAmount);
                    }


                    // MinBox YES, MaxBox YES (Search Transactions with values between the two dates)
                    if (!string.IsNullOrWhiteSpace(nTboxMinAmount.Text) && !string.IsNullOrWhiteSpace(nTboxMaxAmount.Text))
                    {
                        int minAmount = Int32.Parse(nTboxMinAmount.Text);
                        int maxAmount = Int32.Parse(nTboxMaxAmount.Text);

                        // If Min is higher than max, give error exit code
                        if (minAmount > maxAmount)
                        {
                            throw new Exception("Minimum Value Filter is larger than Maximum Value Filter. Please adjust");
                        }
                        else
                        {
                            filtered_transactions = filtered_transactions.Where(t => t.TotalValue >= minAmount && t.TotalValue <= maxAmount);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return filtered_transactions;
        }


        private void Populate_flPanelTransactions(IEnumerable<TradingTransactionModel> filtered_transactions)
        {

        }




        private void btnGenerate_Click(object sender, EventArgs e)
        {
        }
    }
}
