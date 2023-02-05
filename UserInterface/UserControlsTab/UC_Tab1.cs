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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Data.Common;

namespace UserInterface.UserControlsTab
{
    public partial class UC_Tab1 : UserControl
    {
        private static UC_Tab1 _instance;

        public static UC_Tab1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Tab1();
                return _instance;
            }
        }

        //TODO - Add data validation
        //TODO - Include some 52 week high, low data etc
        //TODO - Colour Cells based on percentile

        public UC_Tab1()
        {
            InitializeComponent();
            PrepareDataGridView();
            tboxYear.Text = "2021";
            tboxASXShare.Text = "CBA";
            cboxPriceType.Text = "Open";
        }

        private void PrepareDataGridView()
        {
            // Create rows for the DataGridView
            for (int i = 1; i <= 31; i++)
            {
                dgvAllSharePrices.Rows.Add();
                dgvAllSharePrices.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
        }
    


        private void btn_tab2_Display_Click(object sender, EventArgs e)
        {

            int YearRequest = Convert.ToInt32(tboxYear.Text);
            string ASXCode = tboxASXShare.Text;
            string PriceType = cboxPriceType.Text;
            List<spQueryASXSharePricesForOneYear> output;

            switch (PriceType)
            {
                case "Open":
                    output = GlobalConfig.Connection.spQueryASXSharePricesForOneYear_PriceOpen(ASXCode, YearRequest);
                    break;
                case "Close":
                    output = GlobalConfig.Connection.spQueryASXSharePricesForOneYear_PriceClose(ASXCode, YearRequest);
                    break;
                case "High":
                    output = GlobalConfig.Connection.spQueryASXSharePricesForOneYear_PriceHigh(ASXCode, YearRequest);
                    break;
                case "Low":
                    output = GlobalConfig.Connection.spQueryASXSharePricesForOneYear_PriceLow(ASXCode, YearRequest);
                    break;
                default:
                    output = new List<spQueryASXSharePricesForOneYear>();
                    break;
            }
            PopulateGrid(output);
            //ColorCells(dgvAllSharePrices);

            double? average = 0;
            double average2 = 0;
            int count = 0;
            foreach (spQueryASXSharePricesForOneYear singleResult in output)
            {
                if (singleResult.Price != null)
                {
                    count += 1;
                    average += singleResult.Price;
                }
            }
            average /= count;
            average2 = Convert.ToDouble(average);
            ColorCells(average2);
        }

        private void PopulateGrid(List<spQueryASXSharePricesForOneYear> output)
        {
            {
                // Input the query result into the datagridview
                foreach (spQueryASXSharePricesForOneYear result in output)
                {
                    int x = (int)result.DayInt - 1;
                    int y = (int)result.MonthInt - 1;
                    dgvAllSharePrices[y, (x)].Value = result.Price.ToString();
                }
            }
        }


        private void ColorCells(double averagePrice)
        {
            int columnIndex = 1;

            // Loop through each cell
            foreach (DataGridViewRow row in dgvAllSharePrices.Rows)
            {
                DataGridViewCell cell = row.Cells[columnIndex];
                if (cell.Value != null)
                {
                    // Calculate deviation from the average
                    double deviation = Math.Abs(Convert.ToDouble(cell.Value) - averagePrice);
                    int red = (int)(255 * deviation / averagePrice);
                    int green = 255 - red;
                    red = Math.Min(red, 255);
                    green = Math.Min(green, 255);
                    cell.Style.BackColor = Color.FromArgb(red, green, 0);
                }
            }
        }





    }
}