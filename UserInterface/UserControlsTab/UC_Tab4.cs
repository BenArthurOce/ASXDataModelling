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
using System.Web.Util;
using System.Xml.Linq;
using System.Reflection;
using System.Windows.Markup;

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


        private void btnGenerate_Click(object sender, EventArgs e)
        {

            //TODO - If a TrendLine is not used, it needs to be invisible or something
            //TODO - Radiobuttons to give different scope of date
            //TODO - Numbers for Y Axis on Portfolio Value


            // ==============================================
            // RUN SQL QUERY
            // ==============================================

            // Get last date on record, and 5 days prior to that (required to fill SQL parameters)
            int finalDatePossible = GlobalConfig.Connection.spGETLIST_MostRecentPriceData();
            DateTime date = DateTime.ParseExact(finalDatePossible.ToString(), "yyyyMMdd", null);
            DateTime newDate = date.AddDays(-300);
            int outputDateInt = int.Parse(newDate.ToString("yyyyMMdd"));


            // Run Query to get standings
            IEnumerable<ShareHolding> sql_results;
            sql_results = GlobalConfig.Connection.spQUERY_dwPortfolioStandings(cBoxPortfolio.Text, outputDateInt, finalDatePossible);

            //TODO - Fix var
            var sumsByDate = sql_results.GroupBy(t => t.Date)
                                         .Select(g => new {
                                             Date = g.Key
                                             ,
                                             CostBaseSum = g.Sum(t => t.CostBase)
                                             ,
                                             MarketValueSum = g.Sum(t => t.MarketValue)
                                         })
                                         .OrderBy(x => x.Date)
                                         .ToList();



            // ==============================================
            // UPDATE PORTFOLIO GRAPH
            // ==============================================
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            updateGraphTwoLine();

            // Step 0 - Put Query Results into KeyPairValue
            List<KeyValuePair<int, decimal>> data_costBase = new List<KeyValuePair<int, decimal>>();
            List<KeyValuePair<int, decimal>> data_marketValue = new List<KeyValuePair<int, decimal>>();


            // Step 1 - Set up KeyValuePair for X and Y points
            int n = 0;
            foreach (var standing in sumsByDate)
            {
                n += 1;
                data_costBase.Add(new KeyValuePair<int, decimal>(n, standing.CostBaseSum));
                data_marketValue.Add(new KeyValuePair<int, decimal>(n, standing.MarketValueSum));
            }


            // Step 2 - create Series
            var series_costBase = new Series("Cost Base");
            series_costBase.ChartType = SeriesChartType.Line;

            var series_marketValue = new Series("Market Value");
            series_marketValue.ChartType = SeriesChartType.Line;


            // Step 3 - Find the lowest value to set a minimum Y Axis
            decimal minYValue_costBase = data_costBase.Min(d => d.Value);
            decimal minYValue_marketValue = data_marketValue.Min(d => d.Value);
            chart1.ChartAreas[0].AxisY.Minimum = (double)minYValue_costBase * .98;

            // Step 5 - Populate the graph
            series_costBase.Points.DataBind(data_costBase, "Key", "Value", "");
            series_marketValue.Points.DataBind(data_marketValue, "Key", "Value", "");
            chart1.Series.Add(series_costBase);
            chart1.Series.Add(series_marketValue);


            // ==============================================
            // UPDATE TRENDLINES
            // ==============================================
            // Step 1 - Get the List of trend line panels
            List<TrendLinePanel> trendLinePanels = tlPnlTrendLines.Controls
                .OfType<Control>()
                .SelectMany(c => c.Controls.OfType<TrendLinePanel>())
                .ToList();


            // Step 2 - Get the List of ASX codes that are currently Active
            List<string> asxCodesList = sql_results
                                        .Select(t => t.TradingEntityModel.ASXCode)      // Extract the code from each transaction
                                        .Distinct()                                     // Get distinct codes
                                        .ToList();                                      // Convert the result to a list


            // Step 3 - Using that list of ASX codes, get relevant price data
            IEnumerable<zFullEODPriceModel> sql_query;
            sql_query = GlobalConfig.Connection.spQUERY_SharePriceHistoryMultiple(asxCodesList);

            // Get the date value that is 30 days prior to the final record date
            DateTime date2 = DateTime.ParseExact(finalDatePossible.ToString(), "yyyyMMdd", null);
            DateTime newDate2 = date2.AddDays(-30);
            int outputDateInt2 = int.Parse(newDate2.ToString("yyyyMMdd"));

            // Step 4 - Loop
            for (int i = 0; i < asxCodesList.Count; i++)
            {
                IEnumerable<zFullEODPriceModel> filtered_prices = sql_query.Where(p => p.TradingEntityModel.ASXCode == asxCodesList[i] && p.DatesModel.DateKey >= outputDateInt2 && p.DatesModel.DateKey <= finalDatePossible);

                // Step 4b - If there are less than 5 prices in the results, skip it
                if (filtered_prices.Count() <= 5)
                {
                    continue;
                }
                else
                {
                    TrendLineUpdateData(trendLinePanels[i], filtered_prices, asxCodesList[i]);
                }

            }

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



        // TAKEN FROM THE TRENDLINE PANEL CONTROL
        public void updateGraphTwoLine()
        {
            var series1 = new Series("First")
            {
                ChartType = SeriesChartType.Spline, //line chart
                ChartArea = "chartArea",
                Color = Color.White
            };

            var series2 = new Series("Second")
            {
                ChartType = SeriesChartType.Spline, //line chart
                ChartArea = "chartArea",
                Color = Color.White
            };

            //creating display area
            var chartArea = new ChartArea("chartArea")
            {
                //hiding grid lines
                AxisX =
                                    {
                                         LineWidth = 0
                                        ,IntervalType = DateTimeIntervalType.NotSet
                                        ,LabelStyle = {Enabled = false}
                                        ,MajorGrid = {LineWidth = 0}
                                        ,MajorTickMark = {LineWidth = 0}
                                    },
                AxisY =
                                    {
                                         LineWidth = 0
                                        ,LabelStyle = {Enabled = false}
                                        ,MajorGrid = {LineWidth = 0}
                                        ,MajorTickMark = {LineWidth = 0}
                                        ,Title = "Price"
                                    },
                BackColor = Color.Black
            };


            chart1.ChartAreas.Add(chartArea);
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);

        }


    }
}