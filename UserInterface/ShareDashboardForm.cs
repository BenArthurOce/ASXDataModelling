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

        private void gBtn_tab1_Click(object sender, EventArgs e)
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

        private void gBtn_tab2_Click(object sender, EventArgs e)
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

        private void gBtn_tab3_Click(object sender, EventArgs e)
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

        private void gBtn_tab4_Click(object sender, EventArgs e)
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
    }
}
