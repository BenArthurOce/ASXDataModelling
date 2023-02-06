using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Forms;

namespace UserInterface.FormAssets
{
    class NumericTextBox : TextBox
    {
        private bool _allowsDecimals;

        public bool AllowsDecimals
        {
            get { return _allowsDecimals; }
            set { _allowsDecimals = value; Invalidate(); }
        }

        public NumericTextBox()
        {
            this.AllowsDecimals = _allowsDecimals;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (AllowsDecimals == true)
            {
                //Check for Number or decimal value
                if (!isNumber(e.KeyChar, this.Text)) { e.Handled = true; }
                base.OnKeyPress(e);
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

        }

        private bool isNumber(char ch, string text)
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

    }
}
