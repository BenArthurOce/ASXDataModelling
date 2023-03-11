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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Data.Common;
using System.Security.Claims;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Windows.Media.Effects;
using DataReferenceLibrary.Models2;
using System.IO;
using System.Windows.Media;
using System.Web.Util;

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



        public UC_Tab1()
        {
            InitializeComponent();
            PrepareRows();

            cBoxYear.Text = "2020";
            tBoxASXCode.Text = "CBA";
            cBoxPosition.Text = "Open";
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {

            // Validate Data
            if (ValidateForm() == false)
            {
                MessageBox.Show("Data Validation Failed");
                return;
            }

            // Obtain Input Information
            int YearRequest = Convert.ToInt32(cBoxYear.Text);
            string ASXCode = tBoxASXCode.Text;
            string PriceType = cBoxPosition.Text;

            // Read SQL Query
            IEnumerable<zFullEODPriceModel> sql_result;
            sql_result = GlobalConfig.Connection.spQUERY_SharePriceHistorySingle(ASXCode);

            // Extract Relevant Years
            IEnumerable<zFullEODPriceModel> filteredPriceModel = sql_result.Where(p => p.DatesModel.YearCalendar >= YearRequest && p.DatesModel.YearCalendar <= YearRequest + 1);


            // Check that the ASX code exists


            //Clear out Current Data
            dgvLeftPrices.DataSource = null; // Set the DataSource to null to clear the data
            dgvLeftPrices.Rows.Clear(); // Clear the rows collection

            //Prepare Column Headers
            PrepareColumnHeaders(filteredPriceModel);

            // Prepare Rows
            PrepareRows();

            // Input the sql results into the datagridview
            InputData(filteredPriceModel);

            // Obtain the Mean and the Standard Deviation of the values
            var tempValues = CalculateMeanAndDeviation();
            double AverageMean = tempValues.Item1;
            double StandardDeviation = tempValues.Item2;

            // Change colours on a sliding scale of red to green
            ColourCells(AverageMean, StandardDeviation);

            //TODO - Fix Error When MNS is typed in 

        }


        private bool ValidateForm()
        {
            if (cBoxYear.Text == null) { return false; }
            if (tBoxASXCode.Text == null) { return false; }
            if (cBoxPosition.Text == null) { return false; }
            return true;
        }


        private void PrepareColumnHeaders(IEnumerable<zFullEODPriceModel> sql_result)
        {
            int Year = Convert.ToInt32(cBoxYear.Text);
            List<string> monthsYear = new List<string>();

            // Add the MonthYear Column Names for the First Year
            for (int i = 1; i <= 12; i++)
            {
                DateTime monthDate = new DateTime(Year, i, 1);
                string monthYearString = string.Format("{0:MMMyy}", monthDate);
                monthsYear.Add(monthYearString);
            }

            // Add the MonthYear Column Names for the Second Year
            for (int i = 1; i <= 12; i++)
            {
                DateTime monthDate = new DateTime(Year + 1, i, 1);
                string monthYearString = string.Format("{0:MMMyy}", monthDate);
                monthsYear.Add(monthYearString);
            }

            //Add a blank string to the 12th position
            monthsYear.Insert(12, "");

            for (int i = 0; i < 25; i++)
            {
                dgvLeftPrices.Columns[i].HeaderText = monthsYear[i];
            }

            dgvLeftPrices.Refresh(); // Refresh the DataGridView
        }

        private void PrepareRows()
        {
            // Create rows for the DataGridView

            dgvLeftPrices.Rows.Add();
            dgvLeftPrices.Rows[0].HeaderCell.Value = "Min";
            dgvLeftPrices.Rows.Add();
            dgvLeftPrices.Rows[1].HeaderCell.Value = "Max";
            dgvLeftPrices.Rows.Add(); //Empty Row

            for (int i = 1; i <= 31; i++)
            {
                dgvLeftPrices.Rows.Add();
                dgvLeftPrices.Rows[i - 1 + 3].HeaderCell.Value = i.ToString();
            }

            dgvLeftPrices.RowHeadersDefaultCellStyle.Padding = new Padding(3);
        }

        private void InputData(IEnumerable<zFullEODPriceModel> sql_result)
        {
            // Populate Grid with Data From SQL query
            foreach (zFullEODPriceModel result in sql_result)
            {
                int x = 0;
                int y = 0;

                x = (int)result.DatesModel.DayInt - 1 + 3;
                y = (int)result.DatesModel.MonthInt - 1;

                if ((int)result.DatesModel.YearCalendar == Convert.ToInt32(cBoxYear.Text) + 1)
                {
                    y += 13;
                }

                switch (cBoxPosition.Text)
                {
                    case "Open":
                        dgvLeftPrices[y, (x)].Value = result.PriceOpen.ToString();
                        break;
                    case "Close":
                        dgvLeftPrices[y, (x)].Value = result.PriceClose.ToString();
                        break;
                    case "High":
                        dgvLeftPrices[y, (x)].Value = result.PriceHigh.ToString();
                        break;
                    case "Low":
                        dgvLeftPrices[y, (x)].Value = result.PriceLow.ToString();
                        break;
                    default:
                        dgvLeftPrices[y, (x)].Value = result.PriceOpen.ToString();
                        break;
                }
            }

            // Populate MinMax Rows
            for (int i = 0; i < dgvLeftPrices.Columns.Count; i++)
            {
                if (i == 12)
                {
                    continue;
                }
                else
                {
                    DataGridViewColumn column = dgvLeftPrices.Columns[i];
                    double max = double.MinValue;
                    double min = double.MaxValue;

                    foreach (DataGridViewRow row in dgvLeftPrices.Rows)
                    {
                        if (row.Cells[i].Value != null && double.TryParse(row.Cells[i].Value.ToString(), out double value))
                        {
                            if (value > max)
                                max = value;
                            if (value < min)
                                min = value;
                        }
                    }
                    dgvLeftPrices[i, (0)].Value = max;
                    dgvLeftPrices[i, (1)].Value = min;
                    Console.WriteLine($"Column {column.HeaderText}: max = {max}");
                }
            }
        }

        private Tuple<double, double> CalculateMeanAndDeviation()
        {
            // Put all Numbers into a List and calculate the Standard Deviation of the number set
            List<double> allValueList = new List<double>();
            foreach (DataGridViewRow row in dgvLeftPrices.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || cell.Value == "")
                    {
                        continue;
                    }
                    else
                    {
                        allValueList.Add(Convert.ToDouble(cell.Value));
                    }
                }
            }
            double AverageMean = allValueList.Average();
            double StandardDeviation = Math.Sqrt(allValueList.Average(v => Math.Pow(v - AverageMean, 2)));
            return Tuple.Create(AverageMean, StandardDeviation);

        }

        private void ColourCells(double AverageMean, double StandardDeviation)
        {
            foreach (DataGridViewRow row in dgvLeftPrices.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // If the cell is null, colour it gray
                    if (cell.Value == null || cell.Value == "")
                    {
                        cell.Style.BackColor = System.Drawing.Color.FromArgb(211, 211, 211);
                        continue;
                    }
                    else
                    {
                        // Get the Value of the cell
                        double cellValue = Convert.ToDouble(cell.Value);

                        // Get the Z Score of the cell
                        double zScore = (cellValue - AverageMean) / StandardDeviation;

                        // Normalize the Z-score between 0 and 1
                        double normalizedZScore = (zScore - (-3)) / (3 - (-3));

                        // Modify RGB values based on the Z score
                        int red = Math.Min(255, (int)(255 * (1 - normalizedZScore)));
                        int green = Math.Min(255, (int)(255 * normalizedZScore));
                        int blue = 0;

                         cell.Style.BackColor = System.Drawing.Color.FromArgb(red, green, blue);


                    }
                }
            }
        }

    }
}
 