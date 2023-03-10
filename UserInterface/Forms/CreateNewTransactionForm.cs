using DataReferenceLibrary;
using DataReferenceLibrary.DataAccess;
using DataReferenceLibrary.Models;
using DataReferenceLibrary.Models2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Forms
{
    public partial class CreateNewTransactionForm : Form
    {
        public bool IsNewTransaction { get; set; }

        private List<PortfolioModel> availablePortfolios = GlobalConfig.Connection.spGETLIST_Portfolios();
        private List<TradingTransactionTypeModel> availableTransactionTypes = GlobalConfig.Connection.spGETLIST_TransactionTypes();

        private TradingTransactionModel transactionModel;

        public CreateNewTransactionForm(bool isNewTransaction)
        {
            InitializeComponent();
            IsNewTransaction = isNewTransaction;
            WireUpLists();
            if (IsNewTransaction)
            {
                transactionModel = new TradingTransactionModel(); // Initialize with default values
                tBoxTradeValue.Enabled = false;
                tBoxTotalValue.Enabled = false;

                //Change Form Header
                lblFormTitle.Text = "Create New Transaction";
            }
        }

        public CreateNewTransactionForm(bool isNewTransaction, TradingTransactionModel transaction)
        {
            InitializeComponent();
            IsNewTransaction = isNewTransaction;
            WireUpLists();
            if (!IsNewTransaction == true && transaction != null)
            {
                string dateString = transaction.Date.ToString("####/##/##"); // Convert yyyymmdd to a string in the format "yyyy/MM/dd"
                DateTime date = DateTime.ParseExact(dateString, "yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture);


                this.transactionModel = transaction; // Use the passed transaction to initialize fields
                                                     // set form fields to the values in the transaction object
                tBoxContractNote.Text = transaction.ContractNote;
                tBoxASXCode.Text = transaction.TradingEntityId.ASXCode;
                dtpDate.Value = date;
                cboxType.Text = transaction.TradingTransactionTypeId.Name;
                nTBoxQuantity.Text = transaction.Quantity.ToString();
                nTBoxUnitPrice.Text = transaction.UnitPrice.ToString();
                tBoxTradeValue.Text = transaction.TradeValue.ToString();
                nTBoxBrokerage.Text = transaction.Brokerage.ToString();
                tBoxTotalValue.Text = transaction.TotalValue.ToString();

                //Disable Certain Textboxes
                cBoxPortfolio.Enabled = false;
                tBoxContractNote.Enabled = false;
                tBoxTradeValue.Enabled = false;
                tBoxTotalValue.Enabled = false;

                //Change Form Header
                lblFormTitle.Text = "Edit Transaction";
            }
        }

        private void WireUpLists()
        {
            cBoxPortfolio.DataSource = availablePortfolios;
            cBoxPortfolio.DisplayMember = "DropDownBoxDisplay";

            cboxType.DataSource = availableTransactionTypes;
            cboxType.DisplayMember = "DropDownBoxDisplay";
        }

        //TODO - Need a checkbox for contract note


        private bool ValidateForm()
        {
            if (cBoxPortfolio.Text == null) { return false; }
            //if (tBoxContractNote.Text == null) { return false; }
            if (tBoxASXCode.Text == null) { return false; }
            if (dtpDate.Text == null) { return false; }
            if (cboxType.Text == null) { return false; }
            if (nTBoxQuantity.Text == null) { return false; }
            if (nTBoxUnitPrice.Text == null) { return false; }
            if (tBoxTradeValue.Text == null) { return false; }
            //if (nTBoxBrokerage.Text == null) { return false; }
            if (tBoxTotalValue.Text == null) { return false; }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                int dateInt = Int32.Parse(dtpDate.Value.ToString("yyyyMMdd"));

                TradingTransactionModel newTransModel = new TradingTransactionModel(
                     cBoxPortfolio.Text      //PortfolioId
                    ,tBoxContractNote.Text   //ContractNote
                    ,tBoxASXCode.Text        //TradingEntityId
                    ,dateInt.ToString()      //Date
                    ,cboxType.Text           //TradingTransactionTypeId
                    ,nTBoxQuantity.Text      //Quantity
                    ,nTBoxUnitPrice.Text     //UnitPrice
                    ,tBoxTradeValue.Text     //TradeValue
                    ,nTBoxBrokerage.Text     //Brokerage
                    ,tBoxTotalValue.Text     //TotalValue
                    );

                
                if (IsNewTransaction == true)
                {
                    GlobalConfig.Connection.spINSERTDATA_TradingTransaction(newTransModel);
                    MessageBox.Show("This Transaction was imported Successfully. Recommended that you regenerate transactions to display edited transaction");

                }
                else if (IsNewTransaction == false)
                {
                    // Create a transaction model from the details of the original transaction prior to edit
                    TradingTransactionModel oldTransModel = new TradingTransactionModel(
                      cBoxPortfolio.Text                            //PortfolioId
                    , this.transactionModel.ContractNote             //ContractNote
                    , this.transactionModel.TradingEntityId.ASXCode  //TradingEntityId
                    , this.transactionModel.Date.ToString()                  //Date
                    , this.transactionModel.TradingTransactionTypeId.Name   //TradingTransactionTypeId
                    , this.transactionModel.Quantity.ToString()       //Quantity
                    , this.transactionModel.UnitPrice.ToString()      //UnitPrice
                    , this.transactionModel.TradeValue.ToString()      //TradeValue
                    , this.transactionModel.Brokerage.ToString()       //Brokerage
                    , this.transactionModel.TotalValue.ToString()      //TotalValue
                    );
                    GlobalConfig.Connection.spEDITDATA_TradingTransaction(oldTransModel, newTransModel);
                    MessageBox.Show("This Transaction was edited Successfully. Recommended that you regenerate transactions to display edited transaction");

                }


                
                this.Close();

            }
            else
            {
                MessageBox.Show("Error Missing, data not inputted");
            }
        }


        private void nTBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (nTBoxQuantity.Text.EndsWith(".")) { return; } else { CheckFormBlanksAndApplyMath(); }
        }

        private void nTBoxUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (nTBoxUnitPrice.Text.EndsWith(".")) { return; } else { CheckFormBlanksAndApplyMath(); }
        }

        private void nTBoxBrokerage_TextChanged(object sender, EventArgs e)
        {
            if (nTBoxBrokerage.Text.EndsWith(".")) { return; } else { CheckFormBlanksAndApplyMath(); }
        }

        private void tBoxTradeValue_TextChanged(object sender, EventArgs e)
        {
            if (tBoxTradeValue.Text.EndsWith(".")) { return; } else { CheckFormBlanksAndApplyMath(); }
        }


        private void CheckFormBlanksAndApplyMath()
        {
            float TradeValue = 0;
            float TotalValue = 0;

            // If "UnitPrice or Quantity are blank or null, this code is to be skipped
            if (string.IsNullOrWhiteSpace(nTBoxQuantity.Text) == true || string.IsNullOrWhiteSpace(nTBoxUnitPrice.Text) == true)
            {
                tBoxTradeValue.Text = null;
                tBoxTotalValue.Text = null;
                return;     // Leave the method
            }
            else
            {   // Calculate the Trade value and apply it to textbox
                TradeValue = float.Parse(nTBoxQuantity.Text) * float.Parse(nTBoxUnitPrice.Text);
                tBoxTradeValue.Text = TradeValue.ToString();
            }

            // If Brokerage is empty
            if (string.IsNullOrWhiteSpace(nTBoxBrokerage.Text) == true)
            {
                // Then calculate Total Value without brokerage
                TotalValue = float.Parse(tBoxTradeValue.Text);
                tBoxTotalValue.Text = TotalValue.ToString();
            }

            // If Brokerage is not empty
            else
            {
                // Then calculate Total Value with brokerage
                TotalValue = float.Parse(tBoxTradeValue.Text) + float.Parse(nTBoxBrokerage.Text);
                tBoxTotalValue.Text = TotalValue.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //cBoxPortfolio.Text = "Dummy Portfolio 3";
            //tBoxContractNote.Text = "DUM00000M13";
            //tBoxASXCode.Text = "CXO";
            //dtpDate.Text = "14/1/2022";
            //cboxType.Text = "Buy";
            nTBoxQuantity.Text = 5000.ToString();
            nTBoxUnitPrice.Text = 0.91.ToString();
            //tBoxTradeValue.Text = ;
            nTBoxBrokerage.Text = 25.ToString(); ;
            //tBoxTotalValue.Text = ;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //tBoxContractNote.Text = "";
            tBoxASXCode.Text = null;
            cboxType.Text = null;
            nTBoxQuantity.Text = null;
            nTBoxUnitPrice.Text = null;
            tBoxTradeValue.Text = null;
            nTBoxBrokerage.Text = null;
            tBoxTotalValue.Text = null;

        }
    }
}
