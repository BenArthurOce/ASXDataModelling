

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UserInterface.FormAssets
{

    class RowGridActive : TableLayoutPanel
    {


        private string _string1 = "a";
        private string _string2 = "";
        private string _string3 = "";
        private string _string4 = "";
        private string _string5 = "";
        private string _string6 = "";
        private string _string7 = "";
        private string _string8 = "";

        public string String1
        {
            get { return _string1; }
            set { _string1 = value; Invalidate(); }
        }

        public string String2
        {
            get { return _string2; }
            set { _string2 = value; Invalidate(); }
        }

        public string String3
        {
            get { return _string3; }
            set { _string3 = value; Invalidate(); }
        }

        public string String4
        {
            get { return _string4; }
            set { _string4 = value; Invalidate(); }
        }

        public string String5
        {
            get { return _string5; }
            set { _string5 = value; Invalidate(); }
        }

        public string String6
        {
            get { return _string6; }
            set { _string6 = value; Invalidate(); }
        }

        public string String7
        {
            get { return _string7; }
            set { _string7 = value; Invalidate(); }
        }

        public string String8
        {
            get { return _string8; }
            set { _string8 = value; Invalidate(); }
        }

        public RowGridActive()
        {

            // Define the number of columns and rows
            int columns = 8;
            int rows = 1;

            this.ColumnCount = columns;
            this.RowCount = rows;



            List<string> listStrings = new List<string>() { this.String1, this.String2, this.String3, this.String4, this.String5, this.String6, this.String7, this.String8 };


            //Add Columns to the Control
            for (int i = 0; i < 8; i++)
            {
                this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            }

            for (int i = 0; i < rows; i++)
            {
                this.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));
            }

            for (int i = 0; i < columns * rows; i++)
            {
                Label label = new Label
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.Green,
                };
                this.Controls.Add(label, i % columns, i / columns);
            }

        }

    }
}