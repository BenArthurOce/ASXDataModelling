

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

    class RowGridActive : TableLayoutPanel
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

        public RowGridActive(string _TransDate, string _TransContractNote, string _TransType, string _TransShareCode, string _TransShareName, string _TransShareSector, string _TransQuantity, string _TransUnitPrice, string _TransTradeValue, string _TransBrokerage, string _TransCostTotal)
        {
            this.TransDate = _TransDate;
            this.TransContractNote = _TransContractNote;;
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
            int rows = 6;

            this.ColumnCount = columns;
            this.RowCount = rows;

            //Add Columns to the Control
            for (int i = 0; i < 8; i++)
            {
                this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            }

            for (int i = 0; i < rows; i++)
            {
                this.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66f / rows));
            }
            //
            // lblHeader_TransDate
            //
            Label lblHeader_TransDate = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Date"
            };
            //
            // lblHeader_TransContractNote
            //
            Label lblHeader_TransContractNote = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Contract Note:"
            };
            //
            // lblHeader_TransType
            //
            Label lblHeader_TransType = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Type:"
            };
            //
            // lblHeader_TransSector
            //
            Label lblHeader_TransSector = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Sector:"
            };
            //
            // lblHeader_TransASXCodeAndName
            //
            Label lblHeader_TransASXCodeAndName = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Company:"
            };
            //
            // lblHeader_TransQuantity
            //
            Label lblHeader_TransQuantity = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Quantity"
            };
            //
            // lblHeader_TransUnitPrice
            //
            Label lblHeader_TransUnitPrice = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Unit Price"
            };
            //
            // lblHeader_TransTradeValue
            //
            Label lblHeader_TransTradeValue = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Trade Value:"
            };
            //
            // lblHeader_TransBrokerage
            //
            Label lblHeader_TransBrokerage = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Brokerage:"
            };
            //
            // lblHeader_TransCostTotal
            //
            Label lblHeader_TransCostTotal = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Total Cost:"
            };
            //
            // lblFooter_TransDate
            //
            Label lblFooter_TransDate = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransDate
            };
            //
            // lblFooter_TransContractNote
            //
            Label lblFooter_TransContractNote = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransContractNote
            };
            //
            // lblFooter_TransType
            //
            Label lblFooter_TransType = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransType
            };
            //
            // lblFooter_TransSector
            //
            Label lblFooter_TransSector = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransShareSector
            };
            //
            // lblFooter_TransASXCodeAndName
            //
            Label lblFooter_TransASXCodeAndName = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text =  "(" + TransShareCode + ")" + " " + TransShareName
            };
            //
            // lblFooter_TransQuantity
            //
            Label lblFooter_TransQuantity = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransQuantity
            };
            //
            // lblFooter_TransUnitPrice
            //
            Label lblFooter_TransUnitPrice = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransUnitPrice
            };
            //
            // lblFooter_TransTradeValue
            //
            Label lblFooter_TransTradeValue = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransTradeValue
            };
            //
            // lblFooter_TransBrokerage
            //
            Label lblFooter_TransBrokerage = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransBrokerage
            };
            //
            // lblFooter_TransCostTotal
            //
            Label lblFooter_TransCostTotal = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransCostTotal
            };
            //
            // btnEdit
            //
            Button btnEdit = new Button
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                AutoSize = false,
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Edit",
            };
            btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            //
            // btnDelete
            //
            Button btnDelete = new Button
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                AutoSize = false,
                BackColor = Color.White,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Delete",
            };
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.Controls.Add(lblHeader_TransDate, 0, 0);
            this.Controls.Add(lblHeader_TransContractNote, 0, 1);
            this.Controls.Add(lblHeader_TransType, 0, 2);
            this.Controls.Add(lblHeader_TransSector, 0, 3);
            this.Controls.Add(lblHeader_TransASXCodeAndName, 0, 4); this.SetRowSpan(lblHeader_TransASXCodeAndName, 2);
            this.Controls.Add(lblHeader_TransQuantity, 3, 0);
            this.Controls.Add(lblHeader_TransUnitPrice, 3, 1);
            this.Controls.Add(lblHeader_TransTradeValue, 3, 2);
            this.Controls.Add(lblHeader_TransBrokerage, 3, 3);
            this.Controls.Add(lblHeader_TransCostTotal, 3, 4);

            this.Controls.Add(lblFooter_TransDate, 1, 0);
            this.Controls.Add(lblFooter_TransContractNote, 1, 1);
            this.Controls.Add(lblFooter_TransType, 1, 2);
            this.Controls.Add(lblFooter_TransSector, 1, 3);
            this.Controls.Add(lblFooter_TransASXCodeAndName, 1, 4); this.SetRowSpan(lblFooter_TransASXCodeAndName, 2);
            this.Controls.Add(lblFooter_TransQuantity, 4, 0);
            this.Controls.Add(lblFooter_TransUnitPrice, 4, 1);
            this.Controls.Add(lblFooter_TransTradeValue, 4, 2);
            this.Controls.Add(lblFooter_TransBrokerage, 4, 3);
            this.Controls.Add(lblFooter_TransCostTotal, 4, 4);



            this.Controls.Add(btnEdit, 6, 1);
            this.SetRowSpan(btnEdit, 2);

            this.Controls.Add(btnDelete, 6, 3);
            this.SetRowSpan(btnDelete, 2);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Call the CreateNewTransactionForm
            //CreateNewTransactionForm form = new CreateNewTransactionForm(this);
            //form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete button clicked");
        }

    }
}