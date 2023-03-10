using DataReferenceLibrary;
using DataReferenceLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas.Clear();

            /*
            var series = new Series("First")
            {
                ChartType = SeriesChartType.Spline, //line chart
                ChartArea = "chartArea",
                Color = Color.White
            };
            */

            /*

            List<KeyValuePair<double, double>> data = new List<KeyValuePair<double, double>>();
            data.Add(new KeyValuePair<double, double>(1, 1));
            data.Add(new KeyValuePair<double, double>(2, 5));
            data.Add(new KeyValuePair<double, double>(3, 2));
            data.Add(new KeyValuePair<double, double>(4, 6));
            data.Add(new KeyValuePair<double, double>(5, 3));
            data.Add(new KeyValuePair<double, double>(6, 5));
            data.Add(new KeyValuePair<double, double>(7, 2));
            data.Add(new KeyValuePair<double, double>(8, 3));
            data.Add(new KeyValuePair<double, double>(9, 9));

            foreach (KeyValuePair<double, double> keypair in data)
            {
                series.Points.AddXY(keypair.Key, keypair.Value);
            }


            //creating display area
            var chartArea = new ChartArea("chartArea")
            {
                //hiding grid lines
                AxisX =
                                    {
                                        LineWidth = 0,
                                        IntervalType = DateTimeIntervalType.NotSet,
                                        LabelStyle = {Enabled = false},
                                        MajorGrid = {LineWidth = 0},
                                        MajorTickMark = {LineWidth = 0}
                                    },
                AxisY =
                                    {
                                        LineWidth = 0,
                                        LabelStyle = {Enabled = false},
                                        MajorGrid = {LineWidth = 0},
                                        MajorTickMark = {LineWidth = 0}
                                    },
                BackColor = Color.Black
            };

            //creating chart control
            //var chart = new Chart { Dock = DockStyle.Fill, BackColor = Color.Black };
            //chart.ChartAreas.Add(chartArea);
            //chart.Series.Add(series);

            chart1.ChartAreas.Add(chartArea);
            chart1.Series.Add(series);


            */

            /*
            IEnumerable <zPortfolioValue> sql_results;
            sql_results = GlobalConfig.Connection.spQUERY_PortfolioMovements2("Jimmys Renewerables", 20210808, finalDatePossible);
            */
 





        }

        private void button2_Click(object sender, EventArgs e)
        {
            int finalDatePossible = GlobalConfig.Connection.spGETLIST_MostRecentPriceData();
            IEnumerable<xShareHolding> sql_results;
            sql_results = GlobalConfig.Connection.spGetShareHoldingsFromWarehouse("Jimmys Renewerables", 20200101, finalDatePossible);

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



            int b = 1;


            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            updateGraph();

            // create a new chart area
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);


            // create a new series
            Series series = new Series();
            series.Name = "Series Name";
            series.ChartType = SeriesChartType.Line;

            /*
            // add data points to the series
            series.Points.AddXY(1, 10);
            series.Points.AddXY(2, 20);
            series.Points.AddXY(3, 15);
            series.Points.AddXY(4, 30);
            */
            int n = 0;
            foreach (var standing in sumsByDate)
            {
                n += 1;
                series.Points.AddXY(n, standing.CostBaseSum);
            }


            // add the series to the chart control
            chart1.Series.Add(series);


        }

        private void button3_Click(object sender, EventArgs e)
        {

            int finalDatePossible = GlobalConfig.Connection.spGETLIST_MostRecentPriceData();
            IEnumerable<xShareHolding> sql_results;
            sql_results = GlobalConfig.Connection.spGetShareHoldingsFromWarehouse("Jimmys Renewerables", 20200101, finalDatePossible);

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







            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            updateGraph();

            // Step 1 - Set up KeyValuePair for X and Y points
            List<KeyValuePair<int, decimal>> data = new List<KeyValuePair<int, decimal>>();
            int n = 0;
            foreach (var standing in sumsByDate)
            {
                n += 1;
                data.Add(new KeyValuePair<int, decimal>(n, standing.CostBaseSum));
            }


            List<KeyValuePair<int, decimal>> data2 = data.Take(20).ToList();


            // Step 2 - Find and remove the old series
            foreach (Series series1 in chart1.Series)
            {
                // Check if the series has the name you want to delete
                if (series1.Name == "Share Prices")
                {
                    // Remove the series from the chart
                    chart1.Series.Remove(series1);
                    break;
                }
            }


            // Step 3 - Set up the chart
            var series = new Series("Share Prices");
            series.ChartType = SeriesChartType.Line;
            //chart1.Series.Add(series);
            //chart1.Series["Share Prices"].ChartType = SeriesChartType.Line;


            // Step 4 - Find the lowest value to set a minimum Y Axis
            decimal minYValue = data.Min(d => d.Value);
            //chart1.ChartAreas[0].AxisY.Minimum = (double)minYValue * .98;

            // Step 5 - Populate the graph
            series.Points.DataBind(data, "Key", "Value", "");

            chart1.Series.Add(series);
            //chart1.Series[0].Points.DataBind(data2, "Key", "Value", "");



            //Step 6 - Name the Label
            //LabelText = ASXCodeString;

        }


        private void button4_Click(object sender, EventArgs e)
        {

            int finalDatePossible = GlobalConfig.Connection.spGETLIST_MostRecentPriceData();
            IEnumerable<xShareHolding> sql_results;
            sql_results = GlobalConfig.Connection.spGetShareHoldingsFromWarehouse("A Peterson Portfolio", 20200101, finalDatePossible);

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



            chart1.ChartAreas.Clear();
            chart1.Series.Clear();
            updateGraph2();



            // Step 1 - Set up KeyValuePair for X and Y points
            List<KeyValuePair<int, decimal>> data1 = new List<KeyValuePair<int, decimal>>();
            int n = 0;
            foreach (var standing in sumsByDate)
            {
                n += 1;
                data1.Add(new KeyValuePair<int, decimal>(n, standing.CostBaseSum));
            }


            // Step 1 - Set up KeyValuePair for X and Y points
            List<KeyValuePair<int, decimal>> data2 = new List<KeyValuePair<int, decimal>>();
            int j = 0;
            foreach (var standing in sumsByDate)
            {
                j += 1;
                data2.Add(new KeyValuePair<int, decimal>(j, standing.MarketValueSum));
            }


            // Step 2 - Find and remove the old series
            foreach (Series eachSeries in chart1.Series)
            {
                // Check if the series has the name you want to delete
                if (eachSeries.Name == "Cost Base" || eachSeries.Name == "Market Value")
                {
                    // Remove the series from the chart
                    chart1.Series.Remove(eachSeries);
                    break;
                }
            }


            // Step 3 - Set up the chart
            var series1 = new Series("Cost Base");
            series1.ChartType = SeriesChartType.Line;

            var series2 = new Series("Market Value");
            series2.ChartType = SeriesChartType.Line;
            //chart1.Series.Add(series);
            //chart1.Series["Share Prices"].ChartType = SeriesChartType.Line;


            // Step 4 - Find the lowest value to set a minimum Y Axis
            decimal minYValue = data1.Min(d => d.Value);
            //chart1.ChartAreas[0].AxisY.Minimum = (double)minYValue * .98;

            // Step 5 - Populate the graph
            series1.Points.DataBind(data1, "Key", "Value", "");
            series2.Points.DataBind(data2, "Key", "Value", "");

            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            //chart1.Series[0].Points.DataBind(data2, "Key", "Value", "");
        }


        // TAKEN FROM THE TRENDLINE PANEL GR
        public void updateGraph()
        {
            var series = new Series("First")
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
            chart1.Series.Add(series);

        }

        // TAKEN FROM THE TRENDLINE PANEL GR
        public void updateGraph2()
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