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
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

            List<ASXEODPriceModel> sql_query = GlobalConfig.Connection.spQUERY_SharePricesSixMonths();

            List<KeyValuePair<int, decimal>> data = new List<KeyValuePair<int, decimal>>();
            int n = 0;
            foreach (ASXEODPriceModel priceModel in sql_query)
            {
                n += 1;
                data.Add(new KeyValuePair<int, decimal>(n, priceModel.PriceClose));
            }
            chart1.Series.Add(new Series());
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Points.DataBind(data, "Key", "Value", "");
            //chart1

        }
    }
}