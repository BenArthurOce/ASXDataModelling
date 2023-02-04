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
using DataReferenceLibrary;

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


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

    }
}

