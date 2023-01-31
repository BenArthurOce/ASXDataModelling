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

        public UC_Tab2()
        {
            InitializeComponent();
            tBoxPortfolioName.Text = "Dummy Portfolio 3";
            tBoxPortfolioStartDate.Text = "20200101";
            tBoxPortfolioEndDate.Text = "20230101";
        }

        private void btnPortfolioGenerate_Click(object sender, EventArgs e)
        {
            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                string InputPortfolioName = tBoxPortfolioName.Text;
                int InputStartDate = Convert.ToInt32(tBoxPortfolioStartDate.Text);
                int InputEndDate = Convert.ToInt32(tBoxPortfolioEndDate.Text);
                List<spQueryPortfolioItemsForCertainDate> output;
                output = db.spQueryPortfolioItemsForCertainDate(InputPortfolioName, InputStartDate, InputEndDate);

                PopulatePortfolioGrid(output);
            }
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