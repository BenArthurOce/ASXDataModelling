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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                CustomPanel newCustomPanel = new CustomPanel();
                newCustomPanel.Width = fpnlTesting.Width;
                newCustomPanel.lblTransNum.Text = i.ToString();
                newCustomPanel.lblTransType.Text = "Buy";
                newCustomPanel.lblTransCode.Text = "CBA";
                newCustomPanel.lblTransCostTotal.Text = "$0";
                fpnlTesting.Controls.Add(newCustomPanel);

            }
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {

        }

        private void btnTestExpand_Click(object sender, EventArgs e)
        {
            foreach (CustomPanel panel in fpnlTesting.Controls)
            {
                if (panel.IsClicked == true) { panel.Size = new Size(300, 90); }
                else { panel.Size = new Size(300, 30); }

                //if (panel.IsClicked == true) { panel.Size = this.MaximumSize; }
                //else { panel.Size = this.MinimumSize; }

            }
        }



        private void fpnlTesting_SizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The panel itself was clicked");
        }
    }
}