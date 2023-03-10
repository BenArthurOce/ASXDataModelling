using UserInterface.UserControlsTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class ShareDashboardForm : Form
    {
        public ShareDashboardForm()
        {
            InitializeComponent();
            UC_Tab1 uc = new UC_Tab1();
            addUserControl(uc);
        }



        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }




        private void radioButtonTab1_CheckedChanged(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UC_Tab1.Instance))
            {
                panelContainer.Controls.Add(UC_Tab1.Instance);
                UC_Tab1.Instance.Dock = DockStyle.Fill;
                UC_Tab1.Instance.BringToFront();
            }
            else
                UC_Tab1.Instance.BringToFront();
        }

        private void radioButtonTab2_CheckedChanged(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UC_Tab2.Instance))
            {
                panelContainer.Controls.Add(UC_Tab2.Instance);
                UC_Tab2.Instance.Dock = DockStyle.Fill;
                UC_Tab2.Instance.BringToFront();
            }
            else
                UC_Tab2.Instance.BringToFront();
        }

        private void radioButtonTab3_CheckedChanged(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UC_Tab3.Instance))
            {
                panelContainer.Controls.Add(UC_Tab3.Instance);
                UC_Tab3.Instance.Dock = DockStyle.Fill;
                UC_Tab3.Instance.BringToFront();
            }
            else
                UC_Tab3.Instance.BringToFront();
        }

        private void radioButtonTab4_CheckedChanged(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UC_Tab4.Instance))
            {
                panelContainer.Controls.Add(UC_Tab4.Instance);
                UC_Tab4.Instance.Dock = DockStyle.Fill;
                UC_Tab4.Instance.BringToFront();
            }
            else
                UC_Tab4.Instance.BringToFront();
        }

        private void radioButtonTab5_CheckedChanged(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UC_Tab5.Instance))
            {
                panelContainer.Controls.Add(UC_Tab5.Instance);
                UC_Tab5.Instance.Dock = DockStyle.Fill;
                UC_Tab5.Instance.BringToFront();
            }
            else
                UC_Tab5.Instance.BringToFront();
        }

        private void radioButtonTab6_CheckedChanged(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UC_Tab7.Instance))
            {
                panelContainer.Controls.Add(UC_Tab7.Instance);
                UC_Tab7.Instance.Dock = DockStyle.Fill;
                UC_Tab7.Instance.BringToFront();
            }
            else
                UC_Tab7.Instance.BringToFront();
        }

        private void radioButtonTab7_CheckedChanged(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(UC_Tab8.Instance))
            {
                panelContainer.Controls.Add(UC_Tab8.Instance);
                UC_Tab8.Instance.Dock = DockStyle.Fill;
                UC_Tab8.Instance.BringToFront();
            }
            else
                UC_Tab8.Instance.BringToFront();
        }
    }
}
