using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;
using UserInterface.FormAssets;

namespace UserInterface.UserControlsTab
{
    public partial class UC_Tab6 : UserControl
    {
        private static UC_Tab6 _instance;

        public static UC_Tab6 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Tab6();
                return _instance;
            }
        }



        public UC_Tab6()
        {
            InitializeComponent();
            //panel1.Controls.Add(new CustomRowOfLabelsExpanded());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //GridRow newRow = new GridRow();
            //newRow.String2 = "bb";
            //newRow.Width = 1000;
            //flowLayoutPanel1.Controls.Add(newRow);

            RowGridInactive newPanel = new RowGridInactive("a", "b", "c", "d", "e", "f", "g", "h");
            //TransactionPanel newPanel = new TransactionPanel("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k");
            newPanel.Width = 1000;
            flowLayoutPanel1.Controls.Add(newPanel);

            //tpnlTesting.RowCount = tpnlTesting.RowCount + 1;

            //CustomRowOfLabels newRow = new CustomRowOfLabels();
            //newRow.MinimumSize = new Size(1045, 50);
            //newRow.BackColor = Color.Pink;
            //newRow.DistanceBetweenLabels = 130;
            //tpnlTesting.Controls.Add(newRow, 1, 0);



            //CustomRowOfLabelsExpanded test2 = new CustomRowOfLabelsExpanded { GridCols= 7, GridRows = 4 };
            //panel1.Controls.Add(new CustomRowOfLabelsExpanded());

            //CustomRowOfLabelsExpanded test2 = new CustomRowOfLabelsExpanded { _gridCols = 7, _gridRows = 4 };
            //panel1.Controls.Add(test2);

            //CustomRowOfLabelsExpanded test3 = new CustomRowOfLabelsExpanded(7,4);


            //CustomRowOfLabelsExpanded myControl = new CustomRowOfLabelsExpanded(7, 5);
            //myControl.GridCols = 7;
            //myControl.GridRows = 5;
            //myControl.lblx0x0.Text = "hi";
            //panel1.Controls.Add(myControl);

            //CustomExpandableRow customRow = new CustomExpandableRow();
            //customRow.InnerPanel.Controls.Add(new Label { Text = "Additional Data" });

            //customRow.InnerPanel.Controls.Add(new CustomRowOfLabels { DistanceBetweenLabels = 130 });
            //customRow.MinimumSize = new Size(1045, 50);
            //tpnlTesting.Controls.Add(customRow, 1, 0);


            // TableLayoutPanel panel = new TableLayoutPanel();
            // panel.RowCount = 2;
            // panel.ColumnCount = 2;




        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {

        }

        private void btnTestExpand_Click(object sender, EventArgs e)
        {
         //   foreach (CustomPanel panel in fpnlTesting.Controls)
        //    {
        //        if (panel.IsClicked == true) { panel.Size = new Size(300, 90); }
        //        else { panel.Size = new Size(300, 30); }

                //if (panel.IsClicked == true) { panel.Size = this.MaximumSize; }
                //else { panel.Size = this.MinimumSize; }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomTableLayoutPanel newPanel = new CustomTableLayoutPanel();
            newPanel.Width = 1000;
            flowLayoutPanel1.Controls.Add(newPanel);
        }

        private void transactionPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }



      //  private void fpnlTesting_SizeChanged(object sender, EventArgs e)
      //  {
      //      MessageBox.Show("The panel itself was clicked");
      //  }
    }

