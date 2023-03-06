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
using System.Windows.Forms.DataVisualization.Charting;
using UserInterface.FormAssets;
using DataReferenceLibrary.Models2;
using DataReferenceLibrary.StoredProcs;
using System.Web.Util;
using System.Xml.Linq;
using System.Reflection;

namespace UserInterface.UserControlsTab
{
    public partial class UC_Tab4 : UserControl
    {
        private static UC_Tab4 _instance;

        public static UC_Tab4 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Tab4();
                return _instance;
            }
        }

        private List<PortfolioModel> availablePortfolios = GlobalConfig.Connection.spGETLIST_Portfolios();

        public UC_Tab4()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            cBoxPortfolio.DataSource = availablePortfolios;
            cBoxPortfolio.DisplayMember = "DropDownBoxDisplay";
        }


 

        private void button1_Click(object sender, EventArgs e)
        {


            // Step 1 - Get the List of ASX codes that are currently Active
            List<TrendLinePanel> trendLinePanels = tlpTrendLines.Controls
                .OfType<Control>()
                .SelectMany(c => c.Controls.OfType<TrendLinePanel>())
                .ToList();


            // Step 2 - Get the List of ASX codes that are currently Active
            List<string> ASXCodelist = GetShareOwnerCodes();


            // Step 3 - Using that list of ASX codes, get relevant price data
            IEnumerable<zFullEODPriceModel> sql_query;
            sql_query = GlobalConfig.Connection.spQUERY_SharePricesOneMonth(ASXCodelist);


            // Step 4 - Loop
            foreach (var pair in ASXCodelist.Select((name, index) => new { Name = name, Index = index }))
            {

                // Step 4a - Use LinQ to obtain the price data for that ASX code
                IEnumerable<zFullEODPriceModel> filtered_prices = sql_query.Where(item => item.TradingEntityModel.ASXCode == ASXCodelist[pair.Index]);

                // Step 4b - If there are less than 5 prices in the results, skip it
                if (filtered_prices.Count() <= 5)
                {
                    continue;
                }
                else
                {
                    TrendLineUpdateData(trendLinePanels[pair.Index], filtered_prices, pair.Name);
                }
                
            }

        }



        private List<string> GetShareOwnerCodes()
        {
            //TODO - In this query there is a date set staticlly. We need to to be the result of a query for the most recent date of data
            List<spQueryPortfolioItemsForCertainDate> sql_request = GlobalConfig.Connection.spQUERY_PortfolioValue(cBoxPortfolio.Text, 20220810);

            List<string> asxCodesList = sql_request
                                        .Select(t => t.ASXCode)     // Extract the code from each transaction
                                        .Distinct()                 // Get distinct codes
                                        .ToList();                  // Convert the result to a list

            return asxCodesList;
        }



        private void TrendLineUpdateData(TrendLinePanel panel, IEnumerable<zFullEODPriceModel> filtered_prices, string ASXCodeString)
        {

            // Step 1 - Set up KeyValuePair for X and Y points
            List<KeyValuePair<int, decimal>> data = new List<KeyValuePair<int, decimal>>();
            int n = 0;
            foreach (zFullEODPriceModel priceModel in filtered_prices)
            {
                n += 1;
                data.Add(new KeyValuePair<int, decimal>(n, priceModel.PriceClose));
            }


            // Step 2 - Find and remove the old series
            foreach (Series series1 in panel.chart1.Series)
            {
                // Check if the series has the name you want to delete
                if (series1.Name == "Share Prices")
                {
                    // Remove the series from the chart
                    panel.chart1.Series.Remove(series1);
                    break;
                }
            }


            // Step 3 - Set up the chart
            var series = new Series("Share Prices");
            panel.chart1.Series.Add(series);
            panel.chart1.Series["Share Prices"].ChartType = SeriesChartType.Line;


            // Step 4 - Find the lowest value to set a minimum Y Axis
            decimal minYValue = data.Min(d => d.Value);
            panel.chart1.ChartAreas[0].AxisY.Minimum = (double)minYValue * .98;

            // Step 5 - Populate the graph
            panel.chart1.Series[0].Points.DataBind(data, "Key", "Value", "");

            //Step 6 - Name the Label
            panel.LabelText = ASXCodeString;


        }

    }
}