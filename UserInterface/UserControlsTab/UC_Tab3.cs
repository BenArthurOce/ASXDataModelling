using DataReferenceLibrary.DataAccess;
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
using UserInterface.FormAssets;
using DataReferenceLibrary.StoredProcs;

namespace UserInterface.UserControlsTab
{



    public partial class UC_Tab3 : UserControl
    {
        private static UC_Tab3 _instance;

        public static UC_Tab3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Tab3();
                return _instance;
            }
        }





        public UC_Tab3()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //PrepareTableLayoutPanel();

            // Generate a List of Data Transactions
            

            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                List<spQueryAllShareTransactions> output;
                output = db.spQueryAllShareTransactions();

                PrepareTableLayoutPanel(output);
            }
        }



        private void PrepareTableLayoutPanel(List<spQueryAllShareTransactions> output)
        {

            foreach (spQueryAllShareTransactions TransLine in output)
            {
                TableCellPanel myControl = new TableCellPanel();
                myControl.Width = fpnlShareTransactions.Width;
                //myControl.Text = "Control " + (i + 1);



                myControl.lblFooterTransactionNum.Text = 0.ToString();
                myControl.lblFooterASXCode.Text = TransLine.ASXCode.ToString();
                myControl.lblFooterTransactionType.Text = TransLine.Type.ToString();
                myControl.lblFooterTransactionTotal.Text = TransLine.TotalValue.ToString();


                fpnlShareTransactions.Controls.Add(myControl);
            }

            /*
            for (int i = 0; i < 10; i++)
            {
                // Create a new instance of the custom control
                TableCellPanel myControl = new TableCellPanel();
                myControl.Width = fpnlShareTransactions.Width;
                myControl.Text = "Control " + (i + 1);


                myControl.lblFooterASXCode.Text = "hello";

                fpnlShareTransactions.Controls.Add(myControl);

                //myControl.CustomLabel3= new Label();
                //MessageBox.Show(CustomLabel3.Text);
            }
            */
        }




    }
}