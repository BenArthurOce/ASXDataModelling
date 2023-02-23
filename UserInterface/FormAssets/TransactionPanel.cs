using DataReferenceLibrary.Models2;
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
        private int _PanelWidth;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]

        private TradingTransactionModel TransactionModel;

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

        public int PanelWidth
        {
            get { return _PanelWidth; }
            set { _PanelWidth = value; Invalidate(); }
        }

        public TransactionPanel(TradingTransactionModel _transactionModel)
        {
            this.Width = PanelWidth;
            //MessageBox.Show(this.Parent.Width.ToString());

            //Width = 867;
           // Width = 1200;
            Height = 40;
 

            // This panel doesnt have a parent because it hasnt been created yet.
            // A value will need to pass into it, to determine its width

            this.BackColor = Color.Pink;

            this.TransactionModel = _transactionModel;

            // This Panel needs two States. Active and Inactive.
            // When Active - Show the Control "ActiveGridRow" Which has details of the transactions and edit buttons
            // When Inactive - Shows the Control "GridRow" which has the Transactions but in a standard format
            // The purpose of this control is to switch between the two, depending on active state

            this._ActiveGridRow = new RowGridActive(this.TransactionModel);
            //_ActiveGridRow.Width = this.Width;
            _ActiveGridRow.Height = 150;
            _ActiveGridRow.Visible = false;
            _ActiveGridRow.Location = new System.Drawing.Point(0, 0);
            _ActiveGridRow.Margin = new Padding(0);
            _ActiveGridRow.BackColor = Color.SteelBlue;
            _ActiveGridRow.ForeColor = Color.Black;
            _ActiveGridRow.Dock = DockStyle.Top;
            _ActiveGridRow.AutoSize = false;


            this._InactiveGridRow = new RowGridInactive(this.TransactionModel);
            //_InactiveGridRow.Width = this.Width;
            _InactiveGridRow.Height = 40;
            _InactiveGridRow.Visible = false;
            _InactiveGridRow.Location = new System.Drawing.Point(0, 0);
            _InactiveGridRow.Margin = new Padding(0);
            _InactiveGridRow.BackColor = Color.LightGray;
            _InactiveGridRow.ForeColor = Color.Black;
            _InactiveGridRow.Dock = DockStyle.Top;
            _InactiveGridRow.AutoSize = false;



            this.Controls.Add(_ActiveGridRow);
            this.Controls.Add(_InactiveGridRow);


            // Set an event whenever a panel is clicked
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

            _InactiveGridRow.Visible = true;
            _ActiveGridRow.Visible = false;
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
