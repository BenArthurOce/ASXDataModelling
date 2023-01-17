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
    public partial class UC_Tab4 : UserControl
    {
        private static UC_Tab4 _instance;

        public static UC_Tab4 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_Tab4();
                return _instance;
            }
        }



        public UC_Tab4()
        {
            InitializeComponent();
        }
    }
}