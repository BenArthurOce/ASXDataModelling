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
    public partial class UC_Tab3 : UserControl
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

        private List<PortfolioModel> availablePortfolios = GlobalConfig.Connection.spGETLIST_Portfolios();
        private List<TradingTransactionTypeModel> transactionTypes = GlobalConfig.Connection.spGETLIST_TransactionTypes();
        private List<TradingSectorModel> tradingSectors = GlobalConfig.Connection.spGETLIST_TradingSectors();

        public UC_Tab3()
        {
            InitializeComponent();
            WireUpLists();
            dtpDateFrom.Value = DateTime.Now;
            dtpDateTo.Value = DateTime.Now;
            cboxType.SelectedItem = null;
            cboxSector.SelectedItem = null;
            //InputDummyDates();
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



        private void btnGenerate_Click(object sender, EventArgs e)
        {

            // Clear previous entries
            flPanelTransactions.Controls.Clear();


            // Leave Code if Portfolio ComboBox is Empty
            if (string.IsNullOrWhiteSpace(cBoxPortfolio.Text))
            {
                MessageBox.Show("A Portfolio Must be selected before transactions can be generated");
                return;
            }


            // Leave code if the SQL query returns an error and returns null
            IEnumerable<zFullPortfolioModel> sql_results = QueryPortfolioTransactions();
            if (sql_results == null)
            {
                MessageBox.Show("The SQL Query returned null before filters. Please check that your query / standardprocedure is correct");
                return;
            }


            // Current sql_results are all the portfolios with all the transactions. Only obtain the one portfolio
            zFullPortfolioModel selected_portfolio = sql_results.FirstOrDefault(portfolio => portfolio.Name == cBoxPortfolio.Text);


            // Filter the transactions based on the controls on the transaction tab
            IEnumerable<TradingTransactionModel> filtered_transactions = FilterTheTransactions(selected_portfolio.Transactions);


            // Use the filtered transactions to populate the flow layout panel
            Populate_flPanelTransactions(filtered_transactions);
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


        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            //Call the CreateNewTransactionForm
            CreateNewTransactionForm transactionForm = new CreateNewTransactionForm(true);
            transactionForm.Show();
        }




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
            foreach (var single_transaction in filtered_transactions)
            {
                TransactionPanel newCustomPanel = new TransactionPanel(single_transaction);
                newCustomPanel.Width = flPanelTransactions.Width;
                newCustomPanel.Dock = DockStyle.Top;

                flPanelTransactions.Controls.Add(newCustomPanel);
            }
        }



        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (((DateTimePicker)sender).ShowCheckBox == true)
            {
                if (((DateTimePicker)sender).Checked == false)
                {
                    ((DateTimePicker)sender).CustomFormat = " ";
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
                }
            }
            else
            {
                ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
            }
        }

        private void dtpDateTo_ValueChanged(object sender, EventArgs e)
        {
            if (((DateTimePicker)sender).ShowCheckBox == true)
            {
                if (((DateTimePicker)sender).Checked == false)
                {
                    ((DateTimePicker)sender).CustomFormat = " ";
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
                }
            }
            else
            {
                ((DateTimePicker)sender).Format = DateTimePickerFormat.Short;
            }
        }


    }
}
