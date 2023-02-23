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
using System.Security.Claims;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Windows.Media.Effects;
using DataReferenceLibrary.Models2;

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
            cBoxYear.Text = "2020";
            tBoxASXCode.Text = "CBA";
            cBoxPosition.Text = "Open";
        }

        private void PrepareDataGridView()
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


  


        private void btnGenerate_Click(object sender, EventArgs e)
        {

            int YearRequest = Convert.ToInt32(cBoxYear.Text);
            string ASXCode = tBoxASXCode.Text;
            string PriceType = cBoxPosition.Text;

            IEnumerable<zFullEODPriceModel> output;
            output = GlobalConfig.Connection.spQUERY_PricesOnYears(ASXCode, YearRequest);


            // Populate Grid
            foreach (zFullEODPriceModel result in output)
            {
                int x = 0;
                int y = 0;

                x = (int)result.DatesModel.DayInt - 1 + 3;
                y = (int)result.DatesModel.MonthInt - 1;

                if ((int)result.DatesModel.YearCalendar == YearRequest + 1)
                {
                    y += 13;
                }

                switch (PriceType)
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

            //TODO - Add Year Number to columns
            //TODO - Add Min and Max

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

            //Populate the Highest and Lowest Prices from the datagridview
            //lblFooterLowestPrice.Text = "$ " + allValueList.Min().ToString();
            //lblFooterHighestPrice.Text = "$ " + allValueList.Max().ToString();

            // Colour Cells in the datagridview based on their relation to the average of all numbers
            ColourCells(AverageMean, StandardDeviation);

            
        }



        private void ColourCells(double AverageMean, double StandardDeviation)
        {
            foreach (DataGridViewRow row in dgvLeftPrices.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || cell.Value == "")
                    {
                        cell.Style.BackColor = Color.FromArgb(255, 255, 255);
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

                        cell.Style.BackColor = Color.FromArgb(red, green, blue);


                    }
                }
            }
        }




    }
}
 