using DataReferenceLibrary.Models2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.FormAssets
{
    class TransactionPanelHeader : TableLayoutPanel
    {
        private int _ColumnCount = 8;
        private int _RowCount = 1;


        public int ColumnCount
        {
            get { return _ColumnCount; }
            set { _ColumnCount = value; Invalidate(); }
        }

        public int 
            
            
            RowCount
        {
            get { return _RowCount; }
            set { _RowCount = value; Invalidate(); }
        }

        public TransactionPanelHeader()
        {
            this.ColumnCount = _ColumnCount;
            this.RowCount = _RowCount;

            // Define the number of columns and rows
            int columns = _ColumnCount;
            int rows = _RowCount;


            this.ColumnCount = columns;
            this.RowCount = rows;
            this.Margin = new Padding(0);

            List<string> listStrings = new List<string>()
            {
                "Date",
                "Type",
                "Code",
                "Quantity",
                "Unit Price",
                "Brokerage",
                "Total Value",
                "" };

            //Add Columns to the Control
            for (int i = 0; i < 8; i++)
            {
                this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            }

            for (int i = 0; i < rows; i++)
            {
                this.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));
            }

            for (int i = 0; i < columns * rows; i++)
            {
                Label label = new Label
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = listStrings[i],
                };
                this.Controls.Add(label, i % columns, i / columns);
            }

        }

    }
}
