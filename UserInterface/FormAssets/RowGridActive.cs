

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


        private string _string1;
        private string _string2;
        private string _string3;
        private string _string4;
        private string _string5;
        private string _string6;
        private string _string7;
        private string _string8;
        private string _string9;
        private string _string10;
        private string _string11;
        private string _string12;

        public string String1
        {
            get { return _string1; }
            set { _string1 = value; Invalidate(); }
        }

        public string String2
        {
            get { return _string2; }
            set { _string2 = value; Invalidate(); }
        }

        public string String3
        {
            get { return _string3; }
            set { _string3 = value; Invalidate(); }
        }

        public string String4
        {
            get { return _string4; }
            set { _string4 = value; Invalidate(); }
        }

        public string String5
        {
            get { return _string5; }
            set { _string5 = value; Invalidate(); }
        }

        public string String6
        {
            get { return _string6; }
            set { _string6 = value; Invalidate(); }
        }

        public string String7
        {
            get { return _string7; }
            set { _string7 = value; Invalidate(); }
        }

        public string String8
        {
            get { return _string8; }
            set { _string8 = value; Invalidate(); }
        }

        public string String9
        {
            get { return _string9; }
            set { _string9 = value; Invalidate(); }
        }

        public string String10
        {
            get { return _string10; }
            set { _string10 = value; Invalidate(); }
        }

        public string String11
        {
            get { return _string11; }
            set { _string11 = value; Invalidate(); }
        }

        public string String12
        {
            get { return _string12; }
            set { _string12 = value; Invalidate(); }
        }

        //public RowGridInactive(string _string1, string _string2, string _string3, string _string4, string _string5, string _string6, string _string7, string _string8)
        public RowGridActive(string _string1, string _string2, string _string3, string _string4, string _string5, string _string6, string _string7, string _string8, string _string9, string _string10)
        //public RowGridActive()
        {
            this.String1 = _string1;
            this.String2 = _string2;
            this.String3 = _string3;
            this.String4 = _string4;
            this.String5 = _string5;
            this.String6 = _string6;
            this.String7 = _string7;
            this.String8 = _string8;
            this.String9 = _string9;
            this.String10 = _string10;
            //this.String11 = _string11;
            //this.String12 = _string12;

            // Define the number of columns and rows
            int columns = 8;
            int rows = 6;

            this.ColumnCount = columns;
            this.RowCount = rows;



            //List<string> listStrings = new List<string>() { this.String1, this.String2, this.String3, this.String4, this.String5, this.String6, this.String7, this.String8 };


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
            // lblHeader_TransShareCode
            //
            Label lblHeader_TransShareCode = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "ASX Code:"
            };
            //
            // lblHeader_TransShareName
            //
            Label lblHeader_TransShareName = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "ASX Name:"
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
                Text = String1
            };
            //
            // lblFooter_TransContractNote
            //
            Label lblFooter_TransContractNote = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "b"
            };
            //
            // lblFooter_TransType
            //
            Label lblFooter_TransType = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "c"
            };
            //
            // lblFooter_TransShareCode
            //
            Label lblFooter_TransShareCode = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "d"
            };
            //
            // lblFooter_TransShareName
            //
            Label lblFooter_TransShareName = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "e"
            };
            //
            // lblFooter_TransQuantity
            //
            Label lblFooter_TransQuantity = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "f"
            };
            //
            // lblFooter_TransUnitPrice
            //
            Label lblFooter_TransUnitPrice = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "g"
            };
            //
            // lblFooter_TransTradeValue
            //
            Label lblFooter_TransTradeValue = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "h"
            };
            //
            // lblFooter_TransBrokerage
            //
            Label lblFooter_TransBrokerage = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "i"
            };
            //
            // lblFooter_TransCostTotal
            //
            Label lblFooter_TransCostTotal = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "j"
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
            this.Controls.Add(lblHeader_TransShareCode, 0, 3);
            this.Controls.Add(lblHeader_TransShareName, 0, 4);
            this.Controls.Add(lblHeader_TransQuantity, 3, 0);
            this.Controls.Add(lblHeader_TransUnitPrice, 3, 1);
            this.Controls.Add(lblHeader_TransTradeValue, 3, 2);
            this.Controls.Add(lblHeader_TransBrokerage, 3, 3);
            this.Controls.Add(lblHeader_TransCostTotal, 3, 4);

            this.Controls.Add(lblFooter_TransDate, 1, 0);
            this.Controls.Add(lblFooter_TransContractNote, 1, 1);
            this.Controls.Add(lblFooter_TransType, 1, 2);
            this.Controls.Add(lblFooter_TransShareCode, 1, 3);
            this.Controls.Add(lblFooter_TransShareName, 1, 4);
            this.Controls.Add(lblFooter_TransQuantity, 4, 0);
            this.Controls.Add(lblFooter_TransUnitPrice, 4, 1);
            this.Controls.Add(lblFooter_TransTradeValue, 4, 2);
            this.Controls.Add(lblFooter_TransBrokerage, 4, 3);
            this.Controls.Add(lblFooter_TransCostTotal, 4, 4);

            this.Controls.Add(btnEdit, 6, 1);
            this.SetRowSpan(btnEdit, 2);

            this.Controls.Add(btnDelete, 6, 3);
            this.SetRowSpan(btnDelete, 2);
            /*
            for (int i = 0; i < columns * rows; i++)
            {
                Label label = new Label
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.Green,
                    Text = "aa"
                };
                this.Controls.Add(label, i % columns, i / columns);
            }
            */
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