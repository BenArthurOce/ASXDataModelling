using DataReferenceLibrary;
using DataReferenceLibrary.Models2;
using DataReferenceLibrary.StoredProcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Documents;
using System.Windows.Forms;
using UserInterface.FormAssets;
using static System.Net.WebRequestMethods;

namespace UserInterface.Forms
{
    public partial class TransactionFilterForm : Form
    {

        //public List<Filter> FilterList = new List<Filter>();
        //public List<Filter2> filters2List = new List<Filter2>();

        //TODO - Need to have a combination of items into a single filter, like ANZ transactions of any kind over $1,000

        public TransactionFilterForm()
        {
            InitializeComponent();
        }

        
        private void populateFilterPanel()
        {
            /*
            // This populates the grid of Filter panels depending on the instances of the class Filter are kept in "FilterList"
            // For each Filter instance, it will make a new panel containing information about the Filter class.
            // It will also hold a "Delete" button. When deleted, it will remove the panel, and remove the instance from the stored list

            fpnlCurrentFilters.Controls.Clear();
            foreach (Filter FilterClass in FilterList)
            {
                // Create a new Panel
                FilterPanel newFilterPanel = new FilterPanel(FilterClass.FieldAffected, FilterClass.DataType, FilterClass.MatchType, FilterClass.MatchValue, FilterClass.LowerValueToMatch, FilterClass.HigherValueToMatch);

                // Create a new delete button which is programmed to remove its instance from the stored list
                newFilterPanel.DeleteButton = new Button
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "x"
                };
                newFilterPanel.DeleteButton.Click += (sender, e) =>
                {
                    newFilterPanel.Parent.Controls.Remove(newFilterPanel);
                    FilterList.Remove(FilterClass);
                };

                // Add the button to the FilterPanel
                newFilterPanel.Controls.Add(newFilterPanel.DeleteButton, 3, 0);

                // Add the FilterPanel to the form
                fpnlCurrentFilters.Controls.Add(newFilterPanel);
            }
            */
        }


        private void btnFilterAddType_Click(object sender, EventArgs e)
        {
            /*
            //TODO - Check against existing filters
            //TODO - Populate ComboBox

            if (string.IsNullOrWhiteSpace(cboxFilterType.Text))
            {
                return;
            }
            else 
            {
                Filter newFilter = new Filter("Type", "String", "Equals", cboxFilterType.Text);
                FilterList.Add(newFilter);
                cboxFilterType.Text = null;
                populateFilterPanel();

                TradingTransactionTypeModel newTypeModel = new TradingTransactionTypeModel();
                newTypeModel.Name = cboxFilterType.Text;

                Filter2 newFilterToAdd = new Filter2(newTypeModel);
                filters2List.Add(newFilterToAdd);

            }
            */
        }

        private void btnFilterAddCode_Click(object sender, EventArgs e)
        {
            /*
            //TODO - Validation check that the ASX code actually exists?
            if (string.IsNullOrWhiteSpace(tboxFilterCode.Text))
            {
                return;
            }
            else
            {
                Filter newFilter = new Filter("Code", "String", "Equals", tboxFilterCode.Text);
                FilterList.Add(newFilter);
                tboxFilterCode.Text = null;
                populateFilterPanel();
            }
            */
        }

        private void btnFilterAddSector_Click(object sender, EventArgs e)
        {
            /*
            //TODO - Populate ComboBox
            if (string.IsNullOrWhiteSpace(cboxFilterSector.Text))
            {
                return;
            }
            else
            {
                Filter newFilter = new Filter("Sector", "String", "Equals", cboxFilterSector.Text);
                FilterList.Add(newFilter);
                cboxFilterSector.Text = null;
                populateFilterPanel();
            }
            */
        }

        private void btnFilterAddDate_Click(object sender, EventArgs e)
        {
            /*
            //TODO - Validate Input Box 1
            //TODO - Validate Input Box 2



            DateTime firstDate = DateTime.TryParse(dtpFilterDateStart.Text, out DateTime parsedDate1) ? parsedDate1 : DateTime.MinValue;
            DateTime secondDate = DateTime.TryParse(dtpFilterDateEnd.Text, out DateTime parsedDate2) ? parsedDate2 : DateTime.MinValue;

            //If FirstNumber and SecondNumber are both zero - Error and no update
            if (firstDate == DateTime.MinValue && secondDate == DateTime.MinValue)
            {
                MessageBox.Show("Input required. Zero or higher must be input in both boxes to generate a filter");
                return;
            }

            //If firstDate and secondDate are the same number, return a "is equal" class
            if (firstDate == secondDate)
            {
                Filter newFilter = new Filter("Date", "DateTime", "Equals", $"{firstDate:dd/MMM/yyyy}");
                FilterList.Add(newFilter);
                ntboxFilterAmountStart.Text = null;
                ntboxFilterAmountEnd.Text = null;
                populateFilterPanel();
                return;
            }


            //If firstDate is 0, return a "is less than"
            if (firstDate == DateTime.MinValue)
            {
                Filter newFilter = new Filter("Date", "DateTime", "Less Than", $"{secondDate:dd/MMM/yyyy}");
                FilterList.Add(newFilter);
                ntboxFilterAmountStart.Text = null;
                ntboxFilterAmountEnd.Text = null;
                populateFilterPanel();
                return;
            }

            //If secondDate is 0, return a "is greater than"
            if (secondDate == DateTime.MinValue)
            {
                Filter newFilter = new Filter("Date", "DateTime", "Greater Than", $"{firstDate:dd/MMM/yyyy}");
                FilterList.Add(newFilter);
                ntboxFilterAmountStart.Text = null;
                ntboxFilterAmountEnd.Text = null;
                populateFilterPanel();
                return;
            }

            //If firstDate and secondDate have non 0 values, and firstDate is larger - Error and no update
            if (firstDate != DateTime.MinValue && secondDate != DateTime.MinValue && firstDate > secondDate)
            {
                MessageBox.Show("Starting date cannot be larger than Ending date");
                return;
            }

            // If firstDate is less than secondDate, return a "Between"
            if (firstDate < secondDate)
            {
                Filter newFilter = new Filter("Date", "DateTime", "Between", $"{firstDate:dd/MMM/yyyy}", $"{secondDate:dd/MMM/yyyy}");
                FilterList.Add(newFilter);
                ntboxFilterAmountStart.Text = null;
                ntboxFilterAmountEnd.Text = null;
                populateFilterPanel();
                return;
            }

            // If you made it this far, error check
            //TODO - Ensure this is deleted
            MessageBox.Show("You shouldn't have reached this far - How'd you do that.");
            */
        }

        private void btnFilterAddAmount_Click(object sender, EventArgs e)
        {
            /*
            double firstNumber = double.TryParse(ntboxFilterAmountStart.Text, out double parsedValue1) ? parsedValue1 : 0;
            double secondNumber = double.TryParse(ntboxFilterAmountEnd.Text, out double parsedValue2) ? parsedValue2 : 0;

            //If FirstNumber and SecondNumber are both zero - Error and no update
            if (firstNumber == 0 && secondNumber == 0)
            {
                MessageBox.Show("Input required. Zero or higher must be input in both boxes to generate a filter");
                return;
            }

            //If FirstNumber and SecondNumber are the same number, return a "is equal" class
            if (firstNumber == secondNumber)
            {
                Filter newFilter = new Filter("Amount", "Double", "Equals", $"${firstNumber:0.00}");
                FilterList.Add(newFilter);
                ntboxFilterAmountStart.Text = null;
                ntboxFilterAmountEnd.Text = null;
                populateFilterPanel();
                return;
            }

            //If FirstNumber is 0, return a "is less than"
            if (firstNumber == 0)
            {
                Filter newFilter = new Filter("Amount", "Double", "Less Than", $"${secondNumber:0.00}");
                FilterList.Add(newFilter);
                ntboxFilterAmountStart.Text = null;
                ntboxFilterAmountEnd.Text = null;
                populateFilterPanel();
                return;
            }

            //If SecondNumber is 0, return a "is greater than"
            if (secondNumber == 0)
            {
                Filter newFilter = new Filter("Amount", "Double", "Greater Than", $"${firstNumber:0.00}");
                FilterList.Add(newFilter);
                ntboxFilterAmountStart.Text = null;
                ntboxFilterAmountEnd.Text = null;
                populateFilterPanel();
                return;
            }

            //If FirstNumber and SecondNumber have non 0 values, and FirstNumber is larger - Error and no update
            if (firstNumber !=0 && secondNumber != 0 && firstNumber > secondNumber)
            {
                MessageBox.Show("Starting number cannot be larger than Ending number");
                return;
            }

            // If FirstNumber is less than SecondNumber, return a "Between"
            if (firstNumber < secondNumber)
            {
                Filter newFilter = new Filter("Amount", "Double", "Between", $"${firstNumber:0.00}", $"${secondNumber:0.00}");
                FilterList.Add(newFilter);
                ntboxFilterAmountStart.Text = null;
                ntboxFilterAmountEnd.Text = null;
                populateFilterPanel();
                return;
            }

            // If you made it this far, error check
            //TODO - Ensure this is deleted
            MessageBox.Show("You shouldn't have reached this far - How'd you do that.");
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //TransactionFilter myFilter = new Filter2();

            // first, get a list of data to try on
            string InputPortfolioName = "Bens Stock Portfolio";
            IEnumerable<zFullPortfolioModel> allPortfolios;
            allPortfolios = GlobalConfig.Connection.spQUERY_PortfoliosIndividualsTransactions();
            zFullPortfolioModel myPortfolio = allPortfolios.FirstOrDefault(p => p.Name == InputPortfolioName);

            //Transaction List
            List<TradingTransactionModel> myTransactions;
            myTransactions = myPortfolio.Transactions;

            string lookupNote = "DUM00000B5";
            TradingTransactionModel theTransaction = myTransactions.FirstOrDefault(t => t.ContractNote == lookupNote);

            List<TradingTransactionModel> FilteredTransactions;
            FilteredTransactions = myTransactions.Where(t => t.TradingTransactionTypeId.Name == "Buy").ToList();


            string lookupASXCode = "WPR";
            List<TradingTransactionModel> FilteredTransactions2;
            FilteredTransactions2 = myTransactions.Where(t => t.TradingEntityId.ASXCode == lookupASXCode).ToList();



            int a = 1;



            int b = 1;
            

        }
    }
}
