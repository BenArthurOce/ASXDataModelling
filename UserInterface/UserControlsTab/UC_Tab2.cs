using DataReferenceLibrary.DataAccess;
using DataReferenceLibrary;
using DataReferenceLibrary.StoredProcs;
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
        //TODO - Introduce a date time picker and create code to convert to YYYYMMDD int
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
            string InputPortfolioName = cBoxPortfolio.Text;
            int InputEndDate = Convert.ToInt32(tBoxPortfolioEndDate.Text);
            List<spQueryPortfolioItemsForCertainDate> output;
            output = GlobalConfig.Connection.spQUERY_PortfolioValue(InputPortfolioName, InputEndDate);
            PopulatePortfolioGrid(output);   
            
            //TODO - FORM DATA VALIDATION
        }

        private void PopulatePortfolioGrid(List<spQueryPortfolioItemsForCertainDate> output)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ASXCode",       typeof(string));
            dt.Columns.Add("SharesOwned",   typeof(int));
            dt.Columns.Add("CostBase",      typeof(decimal));
            dt.Columns.Add("CostPrice",     typeof(decimal));
            dt.Columns.Add("CurrentPrice",  typeof(decimal));
            dt.Columns.Add("MarketValue",   typeof(decimal));
            dt.Columns.Add("ProfitLoss",    typeof(decimal));
            dt.Columns.Add("ProfitLossP",   typeof(decimal));
            dt.Columns.Add("WeightP",       typeof(decimal));

            foreach (spQueryPortfolioItemsForCertainDate result in output)
            {
                dt.Rows.Add(
                    result.ASXCode,
                    result.SharesOwned,
                    result.CostBase,
                    result.CostPrice,
                    result.CurrentPrice,
                    result.MarketValue,
                    result.ProfitLoss,
                    result.ProfitLossP,
                    result.WeightP
                        );
            }
            dgvPortfolioItems.DataSource = dt;
           
        }
    }
}