

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
using UserInterface.Forms;

namespace UserInterface.FormAssets
{

    class RowGridActive : TableLayoutPanel
    {

        private TradingTransactionModel TransactionModel;


        public RowGridActive(TradingTransactionModel _transactionModel)
        {
            this.TransactionModel = _transactionModel;

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
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Date"
            };
            //
            // lblHeader_TransContractNote
            //
            Label lblHeader_TransContractNote = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Contract Note:"
            };
            //
            // lblHeader_TransType
            //
            Label lblHeader_TransType = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Type:"
            };
            //
            // lblHeader_TransASXCodeAndName
            //
            Label lblHeader_TransASXCodeAndName = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Company:"
            };
            //
            // lblHeader_TransSector
            //
            Label lblHeader_TransSector = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Sector:"
            };
            //
            // lblHeader_TransQuantity
            //
            Label lblHeader_TransQuantity = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Quantity"
            };
            //
            // lblHeader_TransUnitPrice
            //
            Label lblHeader_TransUnitPrice = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Unit Price"
            };
            //
            // lblHeader_TransTradeValue
            //
            Label lblHeader_TransTradeValue = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Trade Value:"
            };
            //
            // lblHeader_TransBrokerage
            //
            Label lblHeader_TransBrokerage = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Brokerage:"
            };
            //
            // lblHeader_TransCostTotal
            //
            Label lblHeader_TransCostTotal = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Total Cost:"
            };
            //
            // lblFooter_TransDate
            //
            Label lblFooter_TransDate = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = DateTime.ParseExact(TransactionModel.Date.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy")
            };
            //
            // lblFooter_TransContractNote
            //
            Label lblFooter_TransContractNote = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransactionModel.ContractNote.ToString()
            };
            //
            // lblFooter_TransType
            //
            Label lblFooter_TransType = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransactionModel.TradingTransactionTypeId.Name.ToString()
            };
            //
            // lblFooter_TransASXCodeAndName
            //
            Label lblFooter_TransASXCodeAndName = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "(" + TransactionModel.TradingEntityId.ASXCode + ")" + " " + TransactionModel.TradingEntityId.Name
            };
            //
            // lblFooter_TransSector
            //
            Label lblFooter_TransSector = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransactionModel.TradingEntityId.TradingSectorId.SectorName
            };
            //
            // lblFooter_TransQuantity
            //
            Label lblFooter_TransQuantity = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = TransactionModel.Quantity.ToString()
            };
            //
            // lblFooter_TransUnitPrice
            //
            Label lblFooter_TransUnitPrice = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = string.Format("{0:C}", TransactionModel.UnitPrice)
        };
            //
            // lblFooter_TransTradeValue
            //
            Label lblFooter_TransTradeValue = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = string.Format("{0:C}", TransactionModel.TradeValue)
            };
            //
            // lblFooter_TransBrokerage
            //
            Label lblFooter_TransBrokerage = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = string.Format("{0:C}", TransactionModel.Brokerage)
            };
            //
            // lblFooter_TransCostTotal
            //
            Label lblFooter_TransCostTotal = new Label
            {
                AutoEllipsis = true,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = string.Format("{0:C}", TransactionModel.TotalValue)
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
            this.Controls.Add(lblHeader_TransASXCodeAndName, 0, 2); this.SetRowSpan(lblHeader_TransASXCodeAndName, 2);
            this.Controls.Add(lblHeader_TransSector, 0, 4); this.SetRowSpan(lblHeader_TransSector, 2);

            this.Controls.Add(lblHeader_TransType, 3, 0);
            this.Controls.Add(lblHeader_TransQuantity, 3, 1);
            this.Controls.Add(lblHeader_TransUnitPrice, 3, 2);
            this.Controls.Add(lblHeader_TransTradeValue, 3, 3);
            this.Controls.Add(lblHeader_TransBrokerage, 3, 4);
            this.Controls.Add(lblHeader_TransCostTotal, 3, 5);

            this.Controls.Add(lblFooter_TransDate, 1, 0);
            this.Controls.Add(lblFooter_TransContractNote, 1, 1);         
            this.Controls.Add(lblFooter_TransASXCodeAndName, 1, 2); this.SetRowSpan(lblFooter_TransASXCodeAndName, 2);
            this.Controls.Add(lblFooter_TransSector, 1, 4); this.SetRowSpan(lblFooter_TransSector, 2);

            this.Controls.Add(lblFooter_TransType, 4, 0);
            this.Controls.Add(lblFooter_TransQuantity, 4, 1);
            this.Controls.Add(lblFooter_TransUnitPrice, 4, 2);
            this.Controls.Add(lblFooter_TransTradeValue, 4, 3);
            this.Controls.Add(lblFooter_TransBrokerage, 4, 4);
            this.Controls.Add(lblFooter_TransCostTotal, 4, 5);



            this.Controls.Add(btnEdit, 6, 1);
            this.SetRowSpan(btnEdit, 2);

            this.Controls.Add(btnDelete, 6, 3);
            this.SetRowSpan(btnDelete, 2);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Call the CreateNewTransactionForm
            //CreateNewTransactionForm form = new CreateNewTransactionForm(this);
            //form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete button clicked");
        }

        public void CreateTransactionComplete(TradingTransactionModel model)
        {
            MessageBox.Show("TransactionEditedFromButton");
        }
    }
}