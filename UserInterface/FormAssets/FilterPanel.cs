using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Forms;

namespace UserInterface.FormAssets
{
    class FilterPanel : TableLayoutPanel
    {
        private string _FilterIsString;
        private string _FilterContentsString;

        public string FilterIsString
        {
            get { return _FilterIsString; }
            set { _FilterIsString = value; Invalidate(); }
        }
        public string FilterContentsString
        {
            get { return _FilterContentsString; }
            set { _FilterContentsString = value; Invalidate(); }
        }

        public FilterPanel(string _FilterIsString, string _FilterContentsString) 
        {
            this.FilterIsString = _FilterIsString;
            this.FilterContentsString = _FilterContentsString;

            Width = 292;
            Height = 40;

            this.BackColor = Color.Pink;

            // Define the number of columns and rows
            int columns = 3;
            int rows = 1;

            this.ColumnCount = columns;
            this.RowCount = rows;

            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));        // Empty. Just making space for scrollbar
            //
            // lblFilterIsString
            //
            Label lblFilterIsString = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = this.FilterIsString
            };
            //
            // FilterContentsString
            //
            Label FilterContentsString = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = this.FilterContentsString
            };
            //
            // btnClose
            //
            Button btnClose = new Button
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "x"
            };
            this.Controls.Add(lblFilterIsString, 0, 0);
            this.Controls.Add(FilterContentsString, 1, 0);
            this.Controls.Add(btnClose, 2, 0);
        }
    }
}
