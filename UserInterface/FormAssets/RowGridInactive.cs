

using DataReferenceLibrary.Models2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.FormAssets
{
    class RowGridInactive : TableLayoutPanel
    {
        private TradingTransactionModel TransactionModel;

        public RowGridInactive(TradingTransactionModel _transactionModel)
        {
            this.TransactionModel = _transactionModel;

            // Define the number of columns and rows
            int columns = 8;
            int rows = 1;


            this.ColumnCount = columns;
            this.RowCount = rows;
            this.Margin = new Padding(0);


            List<string> listStrings = new List<string>() 
            { 
                DateTime.ParseExact(TransactionModel.Date.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy"),
                this.TransactionModel.TradingTransactionTypeId.Name, 
                this.TransactionModel.TradingEntityId.ASXCode, 
                this.TransactionModel.Quantity.ToString(),
                string.Format("{0:C}", this.TransactionModel.UnitPrice),
                string.Format("{0:C}", this.TransactionModel.Brokerage),
                string.Format("{0:C}", this.TransactionModel.TotalValue),
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
