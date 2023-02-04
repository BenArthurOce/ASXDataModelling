using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.FormAssets
{

    

    class TransactionPanel : Panel
    {
        private RowGridActive _ActiveGridRow;
        private RowGridInactive _InactiveGridRow;
        private bool _isClicked;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]

        private string _TransPortfolio;
        private string _TransContractNote;
        private string _TransDate;
        private string _TransType;
        private string _TransShareCode;
        private string _TransShareName;
        private string _TransShareSector;
        private string _TransQuantity;
        private string _TransUnitPrice;
        private string _TransTradeValue;
        private string _TransBrokerage;
        private string _TransCostTotal;


        public string TransPortfolio
        {
            get { return _TransPortfolio; }
            set { _TransPortfolio = value; Invalidate(); }
        }


        public string TransContractNote
        {
            get { return _TransContractNote; }
            set { _TransContractNote = value; Invalidate(); }
        }

        public string TransDate
        {
            get { return _TransDate; }
            set { _TransDate = value; Invalidate(); }
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

        public RowGridActive ActiveGridRow
        {
            get { return _ActiveGridRow; }
        }
        public RowGridInactive InactiveGridRow
        {
            get { return _InactiveGridRow; }
        }

        public bool IsClicked
        {
            get { return _isClicked; }
            set { _isClicked = value; Invalidate(); }
        }

        public TransactionPanel(string _TransPortfolio, string _TransContractNote, string _TransDate, string _TransType, string _TransShareCode, string _TransShareName, string _TransShareSector, string _TransQuantity, string _TransUnitPrice, string _TransTradeValue, string _TransBrokerage, string _TransCostTotal)
        {
            Width = 867;
            Height = 40;

            this.TransPortfolio = _TransPortfolio;
            this.TransContractNote = _TransContractNote;
            this.TransDate = _TransDate.ToString();
            this.TransType = _TransType;
            this.TransShareCode = _TransShareCode;
            this.TransShareName = _TransShareName;
            this.TransShareSector = _TransShareSector;
            this.TransQuantity = _TransQuantity;
            this.TransUnitPrice = _TransUnitPrice;
            this.TransTradeValue = _TransTradeValue;
            this.TransBrokerage = _TransBrokerage;
            this.TransCostTotal = _TransCostTotal;

            // This Panel needs two States. Active and Inactive.
            // When Active - Show the Control "ActiveGridRow" Which has details of the transactions and edit buttons
            // When Inactive - Shows the Control "GridRow" which has the Transactions but in a standard format
            // The purpose of this control is to switch between the two, depending on active state

            this._ActiveGridRow = new RowGridActive(TransDate, TransContractNote, TransType, TransShareCode, TransShareName, TransShareSector, TransQuantity, TransUnitPrice, TransBrokerage, TransCostTotal);
            _ActiveGridRow.Width = 867;
            _ActiveGridRow.Height = 150;
            _ActiveGridRow.Visible = false;
            _ActiveGridRow.Location = new System.Drawing.Point(0, 0);
            _ActiveGridRow.Margin = new Padding(0);
            _ActiveGridRow.BackColor = Color.SteelBlue;
            _ActiveGridRow.ForeColor = Color.Black;


            this._InactiveGridRow = new RowGridInactive(TransDate, TransType, TransShareCode, TransQuantity, TransUnitPrice, TransBrokerage, TransCostTotal, "");
            _InactiveGridRow.Width = 867;
            _InactiveGridRow.Height = 40;
            _InactiveGridRow.Visible = false;
            _InactiveGridRow.Location = new System.Drawing.Point(0, 0);
            _InactiveGridRow.Margin = new Padding(0);
            _InactiveGridRow.BackColor = Color.LightGray;
            _InactiveGridRow.ForeColor = Color.Black;
            _InactiveGridRow.String1 = TransDate;
            _InactiveGridRow.String2 = TransType;
            _InactiveGridRow.String3 = TransShareCode;
            _InactiveGridRow.String4 = TransQuantity;
            _InactiveGridRow.String5 = TransUnitPrice;
            _InactiveGridRow.String6 = TransBrokerage;
            _InactiveGridRow.String7 = TransCostTotal;
            _InactiveGridRow.String8 = "";


            this.Controls.Add(_ActiveGridRow);
            this.Controls.Add(_InactiveGridRow);


            foreach (Control control in this.Controls)
            {
                
                if (control is RowGridInactive || control is RowGridActive)
                {
                    control.Click += APanelWasClicked;
                }

                foreach (Control lblcontrol in control.Controls)
                {
                    if (lblcontrol is Label)
                    {
                        lblcontrol.Click += APanelWasClicked;
                    }
                }

            }

            // Set all the labels in each custom panel to expand the panel

            _InactiveGridRow.Visible = true;
            _ActiveGridRow.Visible = false;
             //this.BackColor = Color.Purple;
            this.Click += TransactionPanel_Clicked;

        }

        private void APanelWasClicked(object sender, EventArgs e)
        {
            TransactionPanel_Clicked(this, e);
        }




        private void TransactionPanel_Clicked(object sender, EventArgs e)
        {
            TransactionPanel ThisPanel = (TransactionPanel)sender;
            ThisPanel.IsClicked = true;


            foreach (Control control in ThisPanel.Parent.Controls)
            {
                if (control is TransactionPanel)
                {
                    if (control != sender)
                    {
                        ((TransactionPanel)control).IsClicked = false;
                        ((TransactionPanel)control).InactiveGridRow.Visible = true;
                        ((TransactionPanel)control).ActiveGridRow.Visible = false;
                        ((TransactionPanel)control).Height = _InactiveGridRow.Height;


                    }
                    else
                    {
                        ((TransactionPanel)control).IsClicked = true;
                        ((TransactionPanel)control).InactiveGridRow.Visible = false;
                        ((TransactionPanel)control).ActiveGridRow.Visible = true;
                        ((TransactionPanel)control).Height = _ActiveGridRow.Height;
                    }
                }
            }
        }
    }
}
