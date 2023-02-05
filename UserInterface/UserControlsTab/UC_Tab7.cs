using DataReferenceLibrary.DataAccess;
using DataReferenceLibrary.Models;
using DataReferenceLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataReferenceLibrary.StoredProcs;
using System.Globalization;
using UserInterface.FormAssets;

namespace UserInterface.UserControlsTab
{
    public partial class UC_Tab7 : UserControl
    {
        private static UC_Tab7 _instance;

        public static UC_Tab7 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Tab7();
                return _instance;
            }
        }



        public UC_Tab7()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string InputPortfolioName = "Ben Portfolio Account 1";
            List<spQueryShareTransactionsForPortfolio> output;
            output = GlobalConfig.Connection.spQueryAllShareTransactions(InputPortfolioName);
            PrepareTableLayoutPanel(output);
        }

        private void PrepareTableLayoutPanel(List<spQueryShareTransactionsForPortfolio> output)
        {

            foreach (spQueryShareTransactionsForPortfolio TransLine in output)
            {

                

                // Adjust Date
                int input = TransLine.Date; ;
                string inputString = input.ToString();
                DateTime date = DateTime.ParseExact(inputString, "yyyyMMdd", CultureInfo.InvariantCulture);
                string DateAdjust = date.ToString("dd/MM/yyyy");

                // Adjust Trade Value
                decimal TradeValueInput = TransLine.TradeValue;
                string TradeValueOutput = string.Format("{0:C}", TradeValueInput);

                // Adjust Currency
                decimal TotalValueInput = TransLine.TotalValue;
                string TotalValueOutput = string.Format("{0:C}", TotalValueInput);


                TransactionPanel newCustomPanel = new TransactionPanel
                (
                    // _TransPortfolio
                    "",
                    //_TransContractNote
                    TransLine.ContractNote.ToString(),
                    //_TransDate
                    DateAdjust,
                    //_TransType, 
                    TransLine.Type.ToString(),
                    //_TransShareCode
                    TransLine.ASXCode.ToString(),
                    //_TransShareName
                    TransLine.CompanyName,
                    //_TransShareSector
                    TransLine.CompanySector,
                    //_TransQuantity
                    TransLine.Quantity.ToString(),
                    //_TransUnitPrice, 
                    TransLine.UnitPrice.ToString(),
                    //_TransTradeValue,
                    TradeValueOutput,
                    //_TransBrokerage
                    TransLine.Brokerage.ToString(),
                    //_TransCostTotal
                    TotalValueOutput
                );


                flowLayoutPanel1.Controls.Add(newCustomPanel);


            }
        }
    }
}