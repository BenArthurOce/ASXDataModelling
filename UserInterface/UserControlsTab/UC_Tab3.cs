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
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    TableCellPanel tile = new TableCellPanel();
                    tile.BackColor = Color.Blue;
                    tile.Dock = DockStyle.Fill;

                    Label title = new Label();
                    title.Text = "Tile Title";
                    title.Dock = DockStyle.Top;
                    tile.Controls.Add(title);

                    Label description = new Label();
                    description.Text = "Tile Description";
                    description.Dock = DockStyle.Bottom;
                    tile.Controls.Add(description);

                    tableLayoutPanel1.Controls.Add(tile, i, j);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                // Create a new instance of the custom control
                TableCellPanel myControl = new TableCellPanel();

                // Set properties of the control
                myControl.Text = "Control " + (i + 1);

                // Add the control to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(myControl);
            }
        }
    }
}