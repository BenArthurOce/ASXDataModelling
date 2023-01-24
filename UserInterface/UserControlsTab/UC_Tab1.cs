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



        public UC_Tab1()
        {
            InitializeComponent();
            PrepareDataGridView();
        }


        private void PrepareDataGridView()
        {
            // Create columns for the DataGridView
            List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            for (int i = 1; i <= 12; i++)
            {
                dgvPriceHistory1.Columns.Add(i.ToString(), months[i - 1]);
                dgvPriceHistory2.Columns.Add(i.ToString(), months[i - 1]);
            }

            // Create rows for the DataGridView
            for (int i = 1; i <= 31; i++)
            {
                dgvPriceHistory1.Rows.Add();
                dgvPriceHistory1.Rows[i - 1].HeaderCell.Value = i.ToString();
                dgvPriceHistory2.Rows.Add();
                dgvPriceHistory2.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
        }


        private void btn_tab2_Display_Click(object sender, EventArgs e)
        {

            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                int YearRequest = Convert.ToInt32(tbox_tab1_Year.Text);
                string ASXCode = tbox_tab1_ASXShare.Text;
                string PriceType = cbox_tab1_PriceType.Text;
                List<spQueryASXSharePricesForOneYear> output1;
                List<spQueryASXSharePricesForOneYear> output2;

                switch (PriceType)
                {
                    case "Open":
                        output1 = db.spQueryASXSharePricesForOneYear_PriceOpen(ASXCode, YearRequest);
                        output2 = db.spQueryASXSharePricesForOneYear_PriceOpen(ASXCode, YearRequest+1);
                        break;
                    case "Close":
                        output1 = db.spQueryASXSharePricesForOneYear_PriceClose(ASXCode, YearRequest);
                        output2 = db.spQueryASXSharePricesForOneYear_PriceOpen(ASXCode, YearRequest + 1);
                        break;
                    case "High":
                        output1 = db.spQueryASXSharePricesForOneYear_PriceHigh(ASXCode, YearRequest);
                        output2 = db.spQueryASXSharePricesForOneYear_PriceOpen(ASXCode, YearRequest + 1);
                        break;
                    case "Low":
                        output1 = db.spQueryASXSharePricesForOneYear_PriceLow(ASXCode, YearRequest);
                        output2 = db.spQueryASXSharePricesForOneYear_PriceOpen(ASXCode, YearRequest + 1);
                        break;
                    default:
                        output1 = new List<spQueryASXSharePricesForOneYear>();
                        output2 = new List<spQueryASXSharePricesForOneYear>();
                        break;
                }
                PopulateFirstPriceGrid(output1);
                PopulateSecondPriceGrid(output2);
            }     
        }

        private void PopulateFirstPriceGrid(List<spQueryASXSharePricesForOneYear> output)
        {
            {
                // Input the query result into the datagridview
                foreach (spQueryASXSharePricesForOneYear result in output)
                {
                    int x = (int)result.DayInt - 1;
                    int y = (int)result.MonthInt - 1;
                    dgvPriceHistory1[y, (x)].Value = result.Price.ToString();
                }
            }
        }

        private void PopulateSecondPriceGrid(List<spQueryASXSharePricesForOneYear> output)
        {
            {
                // Input the query result into the datagridview
                foreach (spQueryASXSharePricesForOneYear result in output)
                {
                    int x = (int)result.DayInt - 1;
                    int y = (int)result.MonthInt - 1;
                    dgvPriceHistory2[y, (x)].Value = result.Price.ToString();
                }
            }
        }

    }
}