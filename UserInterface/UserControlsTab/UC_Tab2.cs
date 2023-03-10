using DataReferenceLibrary.DataAccess;
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
using DataReferenceLibrary.Models;
using DataReferenceLibrary.Models2;

namespace UserInterface.UserControlsTab
{
    public partial class UC_Tab2 : UserControl
    {
        private static UC_Tab2 _instance;

        public static UC_Tab2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Tab2();
                return _instance;
            }
        }
        //TODO - Format Cells based on profit/loss
        //TODO - Introduce a new tab that can query multiple prices at once

        private List<PortfolioModel> availablePortfolios = GlobalConfig.Connection.spGETLIST_Portfolios();

        public UC_Tab2()
        {
            InitializeComponent();
            WireUpLists();
        }
        private void WireUpLists()
        {
            cBoxPortfolio.DataSource = availablePortfolios;
            cBoxPortfolio.DisplayMember = "DropDownBoxDisplay";
        }

        private void btnPortfolioGenerate_Click(object sender, EventArgs e)
        {
            // Leave Code if Portfolio ComboBox is Empty
            if (string.IsNullOrWhiteSpace(cBoxPortfolio.Text))
            {
                MessageBox.Show("A Portfolio Must be selected before transactions can be generated");
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("ASXCode", typeof(string));
            dt.Columns.Add("SharesOwned", typeof(int));
            dt.Columns.Add("CostBase", typeof(decimal));
            dt.Columns.Add("CostPrice", typeof(decimal));
            dt.Columns.Add("CurrentPrice", typeof(decimal));
            dt.Columns.Add("MarketValue", typeof(decimal));
            dt.Columns.Add("ProfitLoss", typeof(decimal));
            dt.Columns.Add("ProfitLossP", typeof(decimal));
            dt.Columns.Add("WeightP", typeof(decimal));


            string InputPortfolioName = cBoxPortfolio.Text;
            int InputEndDate = Int32.Parse(dtpDate.Value.ToString("yyyyMMdd"));
            int finalDatePossible = GlobalConfig.Connection.spGETLIST_MostRecentPriceData();


            IEnumerable<ShareHolding> sql_results;
            sql_results = GlobalConfig.Connection.spQUERY_dwPortfolioStandings(InputPortfolioName, InputEndDate, finalDatePossible);


            List<ShareHolding> filteredHoldings = sql_results
                                        .Where(t => t.Date == InputEndDate).ToList();


            foreach (ShareHolding shareholding in filteredHoldings)
            {
                dt.Rows.Add(
                    shareholding.TradingEntityModel.ASXCode,
                    shareholding.SharesOwned,
                    shareholding.CostBase,
                    shareholding.CostPerShare,
                    shareholding.CurrentPrice,
                    shareholding.MarketValue,
                    shareholding.ProfitLoss,
                    shareholding.ProfitLossPct,
                    shareholding.WeightPct
                        );
            }
            dgvPortfolioItems.DataSource = dt;
        }

    }
}