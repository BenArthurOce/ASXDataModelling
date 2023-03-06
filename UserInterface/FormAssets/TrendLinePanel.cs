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
using System.Windows.Forms.DataVisualization.Charting;
using UserInterface.Forms;

namespace UserInterface.FormAssets
{
    class TrendLinePanel : Panel
    {
        private string _labelText;
        private Label lblASXcode;

        [Category("Custom Properties")]
        [Description("The text to display in the label.")]
        public string LabelText
        {
            get { return _labelText; }
            set
            {
                _labelText = value;
                lblASXcode.Text = value;
            }
        }














        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlTrendLineRow2Col1;
        //private Label lblASXcode;
        private Panel pnlTrendLineRow1Col2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTrendLineRow2Col1 = new System.Windows.Forms.Panel();
            this.lblASXcode = new System.Windows.Forms.Label();
            this.pnlTrendLineRow1Col2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlTrendLineRow2Col1.SuspendLayout();
            this.pnlTrendLineRow1Col2.SuspendLayout();
            this.SuspendLayout();


            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pnlTrendLineRow2Col1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlTrendLineRow1Col2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlTrendLineRow2Col1
            // 
            this.pnlTrendLineRow2Col1.Controls.Add(this.lblASXcode);
            this.pnlTrendLineRow2Col1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrendLineRow2Col1.Location = new System.Drawing.Point(3, 36);
            this.pnlTrendLineRow2Col1.Name = "pnlTrendLineRow2Col1";
            this.pnlTrendLineRow2Col1.Size = new System.Drawing.Size(44, 27);
            this.pnlTrendLineRow2Col1.TabIndex = 0;
            // 
            // pnlTrendLineRow1Col2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pnlTrendLineRow1Col2, 3);
            this.pnlTrendLineRow1Col2.Controls.Add(this.chart1);
            this.pnlTrendLineRow1Col2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrendLineRow1Col2.Location = new System.Drawing.Point(53, 3);
            this.pnlTrendLineRow1Col2.Name = "pnlTrendLineRow1Col2";
            this.tableLayoutPanel1.SetRowSpan(this.pnlTrendLineRow1Col2, 3);
            this.pnlTrendLineRow1Col2.Size = new System.Drawing.Size(144, 94);
            this.pnlTrendLineRow1Col2.TabIndex = 1;
            // 
            // lblASXcode
            // 
            this.lblASXcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblASXcode.Location = new System.Drawing.Point(0, 0);
            this.lblASXcode.Name = "lblASXcode";
            this.lblASXcode.Size = new System.Drawing.Size(44, 27);
            this.lblASXcode.TabIndex = 0;
            this.lblASXcode.Text = LabelText;
            this.lblASXcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            //this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(144, 94);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";

            this.Controls.Add(tableLayoutPanel1);

        }

        public TrendLinePanel()
        {
            InitializeComponent();
            updateGraph();
        }

        public void updateGraph()
        {
            var series = new Series("First")
            {
                ChartType = SeriesChartType.Spline, //line chart
                ChartArea = "chartArea",
                Color = Color.White
            };


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

        }
    }
}
