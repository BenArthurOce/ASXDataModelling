

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.FormAssets
{
    class RowGridInactive : TableLayoutPanel
    {
        private string _TransDate;
        private string _TransContractNote;
        private string _TransType;
        private string _TransShareCode;
        private string _TransShareName;
        private string _TransShareSector;
        private string _TransQuantity;
        private string _TransUnitPrice;
        private string _TransTradeValue;
        private string _TransBrokerage;
        private string _TransCostTotal;

        public string TransDate
        {
            get { return _TransDate; }
            set { _TransDate = value; Invalidate(); }
        }

        public string TransContractNote
        {
            get { return _TransContractNote; }
            set { _TransContractNote = value; Invalidate(); }
        }

        public string TransType
        {
            get { return _TransType; }
            set { _TransType = value; Invalidate(); }
        }

        public string TransShareCode
        {
            get { return _TransShareCode; }
            set { _TransShareCode = value; Invalidate(); }
        }

        public string TransShareName
        {
            get { return _TransShareName; }
            set { _TransShareName = value; Invalidate(); }
        }
        public string TransShareSector
        {
            get { return _TransShareSector; }
            set { _TransShareSector = value; Invalidate(); }
        }

        public string TransQuantity
        {
            get { return _TransQuantity; }
            set { _TransQuantity = value; Invalidate(); }
        }

        public string TransUnitPrice
        {
            get { return _TransUnitPrice; }
            set { _TransUnitPrice = value; Invalidate(); }
        }

        public string TransTradeValue
        {
            get { return _TransTradeValue; }
            set { _TransTradeValue = value; Invalidate(); }
        }

        public string TransBrokerage
        {
            get { return _TransBrokerage; }
            set { _TransBrokerage = value; Invalidate(); }
        }

        public string TransCostTotal
        {
            get { return _TransCostTotal; }
            set { _TransCostTotal = value; Invalidate(); }
        }

        public RowGridInactive(string _TransDate, string _TransContractNote, string _TransType, string _TransShareCode, string _TransShareName, string _TransShareSector, string _TransQuantity, string _TransUnitPrice, string _TransTradeValue, string _TransBrokerage, string _TransCostTotal)
        {
            this.TransDate = _TransDate;
            this.TransContractNote = _TransContractNote; ;
            this.TransType = _TransType;
            this.TransShareCode = _TransShareCode;
            this.TransShareName = _TransShareName;
            this.TransShareSector = _TransShareSector;
            this.TransQuantity = _TransQuantity;
            this.TransUnitPrice = _TransUnitPrice;
            this.TransTradeValue = _TransTradeValue;
            this.TransBrokerage = _TransBrokerage;
            this.TransCostTotal = _TransCostTotal;

            // Define the number of columns and rows
            int columns = 8;
            int rows = 1;


            this.ColumnCount = columns;
            this.RowCount = rows;
            this.Margin = new Padding(0);


            List<string> listStrings = new List<string>() { this.TransDate, this.TransType, this.TransShareCode, this.TransQuantity, this.TransUnitPrice, this.TransBrokerage, this.TransCostTotal, "" };


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
