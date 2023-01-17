using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}