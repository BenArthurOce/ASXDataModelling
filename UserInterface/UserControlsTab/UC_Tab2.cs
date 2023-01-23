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
            PrepareDataGridView();
        }


        private void PrepareDataGridView()
        {
            // Create columns for the DataGridView
            List<string> months = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            for (int i = 1; i <= 12; i++)
            {
                dgv_tab2_PriceHistory.Columns.Add(i.ToString(), months[i - 1]);
            }

            // Create rows for the DataGridView
            for (int i = 1; i <= 31; i++)
            {
                dgv_tab2_PriceHistory.Rows.Add();
                dgv_tab2_PriceHistory.Rows[i - 1].HeaderCell.Value = i.ToString();
            }

            // Set sizes for the DataGridView

        }


        private void btn_tab2_Display_Click(object sender, EventArgs e)
        {

            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                int YearRequest = Convert.ToInt32(tbox_tab2_Year.Text);
                string ASXCode = tbox_tab2_ASXShare.Text;
                string PriceType = cbox_tab2_PriceType.Text;
                List<spQueryASXSharePricesForOneYear> output;

                switch (PriceType)
                {
                    case "Open":
                        output = db.spQueryASXSharePricesForOneYear_PriceOpen(ASXCode, YearRequest);
                        break;
                    case "Close":
                        output = db.spQueryASXSharePricesForOneYear_PriceClose(ASXCode, YearRequest);
                        break;
                    case "High":
                        output = db.spQueryASXSharePricesForOneYear_PriceHigh(ASXCode, YearRequest);
                        break;
                    case "Low":
                        output = db.spQueryASXSharePricesForOneYear_PriceLow(ASXCode, YearRequest);
                        break;
                    default:
                        output = new List<spQueryASXSharePricesForOneYear>();
                        break;
                }
                PopulateGridViewTab2(output);
            }     
        }

        private void PopulateGridViewTab2(List<spQueryASXSharePricesForOneYear> output)
        {
            {
                // Input the query result into the datagridview
                foreach (spQueryASXSharePricesForOneYear result in output)
                {
                    int x = (int)result.DayInt - 1;
                    int y = (int)result.MonthInt - 1;
                    dgv_tab2_PriceHistory[y, (x)].Value = result.Price.ToString();
                }
            }
        }
    }
}