using DataReferenceLibrary;
using DataReferenceLibrary.DataAccess;
using DataReferenceLibrary.Models;
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
        private List<PortfolioModel> availablePortfolios = GlobalConfig.Connection.spQueryPortfolios();
        private List<ShareTransactionTypeModel> availableTransactionTypes = GlobalConfig.Connection.spQueryTransactionTypes();

        ICreateTransactionRequester callingForm;

        public CreateNewTransactionForm(ICreateTransactionRequester caller)
        {
            InitializeComponent();
            WireUpLists();
            callingForm = caller;
        }

        private void WireUpLists()
        {
            cBoxPortfolio.DataSource = availablePortfolios;
            cBoxPortfolio.DisplayMember = "DropDownBoxDisplay";

            cboxType.DataSource = availableTransactionTypes;
            cboxType.DisplayMember = "DropDownBoxDisplay";
        }

        //TODO - Introduce "Clear" button to remove all data from fields
        //TODO - Find way to make date bar more presentable
        //TODO - Need a checkbox for contract note


        private bool ValidateForm()
        {
            if (cBoxPortfolio.Text == null) { return false; }
            if (tBoxContractNote.Text == null) { return false; }
            if (tBoxASXCode.Text == null) { return false; }
            if (dtpDate.Text == null) { return false; }
            if (cboxType.Text == null) { return false; }
            if (tBoxQuantity.Text == null) { return false; }
            if (tBoxUnitPrice.Text == null) { return false; }
            if (tBoxTradeValue.Text == null) { return false; }
            if (tBoxBrokerage.Text == null) { return false; }
            if (tBoxTotalValue.Text == null) { return false; }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                //callingForm.CreateTransactionComplete(model);
                string portfolioName = cBoxPortfolio.Text;
                ShareTransactionModel newTrans = new ShareTransactionModel(
                    tBoxContractNote.Text,
                    tBoxASXCode.Text,
                    "20201010",
                    cboxType.Text,
                    tBoxQuantity.Text,
                    tBoxUnitPrice.Text,
                    tBoxTradeValue.Text,
                    tBoxBrokerage.Text,
                    tBoxTotalValue.Text,
                    "false");




                GlobalConfig.Connection.spInsertNewShareTransaction(portfolioName, newTrans);

                //callingform.CreateTransactionComplete();

                this.Close();

                //TODO - Reset textboxes and notify user that success
            }
            else
            {
                MessageBox.Show("Error Missing, data not inputted");
            }
        }

        private void tBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (tBoxQuantity.Text.EndsWith(".")) { return; } else { CheckFormBlanksAndApplyMath(); }
        }

        private void tBoxUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (tBoxUnitPrice.Text.EndsWith(".")) { return; } else { CheckFormBlanksAndApplyMath(); }
        }

        private void tBoxTradeValue_TextChanged(object sender, EventArgs e)
        {
            if (tBoxTradeValue.Text.EndsWith(".")) { return; } else { CheckFormBlanksAndApplyMath(); }
        }

        private void tBoxBrokerage_TextChanged(object sender, EventArgs e)
        {
            if (tBoxBrokerage.Text.EndsWith(".")) { return; } else { CheckFormBlanksAndApplyMath(); }
        }


        private void CheckFormBlanksAndApplyMath()
        {
            float TradeValue = 0;
            float TotalValue = 0;

            // If "UnitPrice or Quantity are blank or null, this code is to be skipped
            if (string.IsNullOrWhiteSpace(tBoxQuantity.Text) == true || string.IsNullOrWhiteSpace(tBoxUnitPrice.Text) == true)
            {
                tBoxTradeValue.Text = null;
                tBoxTotalValue.Text = null;
                return;     // Leave the method
            }
            else
            {   // Calculate the Trade value and apply it to textbox
                TradeValue = float.Parse(tBoxQuantity.Text) * float.Parse(tBoxUnitPrice.Text);
                tBoxTradeValue.Text = TradeValue.ToString();
            }

            // If Brokerage is empty
            if (string.IsNullOrWhiteSpace(tBoxBrokerage.Text) == true)
            {
                // Then calculate Total Value without brokerage
                TotalValue = float.Parse(tBoxTradeValue.Text);
                tBoxTotalValue.Text = TotalValue.ToString();
            }

            // If Brokerage is not empty
            else
            {
                // Then calculate Total Value with brokerage
                TotalValue = float.Parse(tBoxTradeValue.Text) + float.Parse(tBoxBrokerage.Text);
                tBoxTotalValue.Text = TotalValue.ToString();
            }
        }

        private void tBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tBoxUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isNumber(e.KeyChar, tBoxUnitPrice.Text))
                e.Handled = true;
        }

        private void tBoxTradeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isNumber(e.KeyChar, tBoxTradeValue.Text))
                e.Handled = true;
        }

        private void tBoxBrokerage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isNumber(e.KeyChar, tBoxBrokerage.Text))
                e.Handled = true;
        }


        public bool isNumber(char ch, string text)
        {
            bool res = true;
            char decimalChar = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            //check if it´s a decimal separator and if doesn´t already have one in the text string
            if (ch == decimalChar && text.IndexOf(decimalChar) != -1)
            {
                res = false;
                return res;
            }

            //check if it´s a digit, decimal separator and backspace
            if (!Char.IsDigit(ch) && ch != decimalChar && ch != (char)Keys.Back)
                res = false;

            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cBoxPortfolio.Text = "Dummy Portfolio 3";
            tBoxContractNote.Text = 00000001.ToString();
            tBoxASXCode.Text = "CBA";
            //dtpDate.Text = ;
            cboxType.Text = "Buy";
            tBoxQuantity.Text = 50.ToString();
            tBoxUnitPrice.Text = 99.99.ToString();
            //tBoxTradeValue.Text = ;
            //tBoxBrokerage.Text = ;
            //tBoxTotalValue.Text = ;
        }
    }
}
