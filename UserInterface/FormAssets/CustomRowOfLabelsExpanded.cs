using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.FormAssets
{
    class CustomRowOfLabelsExpanded : Panel
    {
        private int _rowDistance;
        private int _columnDistance;

        private int _cellx;
        private int _celly;

        private int _gridRows;
        private int _gridCols;

        public int RowDistance
        {
            get { return _rowDistance; }
            set { _rowDistance = value; }
        }

        public int ColumnDistance
        {
            get { return _columnDistance; }
            set { _columnDistance = value; }
        }

        public int CellHeight
        {
            get { return _cellx; }
            set { _cellx = value; }
        }

        public int CellLength
        {
            get { return _celly; }
            set { _celly = value; }
        }

        public int GridRows
        {
            get { return _gridRows; }
            set { _gridRows = value; }
        }

        public int GridCols
        {
            get { return _gridCols; }
            set { _gridCols = value; }
        }

        public CustomRowOfLabelsExpanded(int xx, int yy)
        {
            for (int x = 0; x < xx; x++)
            {
                for (int y = 0; y < yy; y++)
                {
                    SetLabelAttributes(x, y);
                }
            }
            /*
            for (int x = 0; x < this.GridRows; x++)
            {
                for (int y = 0; y < this.GridCols; y++)
                {
                    SetLabelAttributes(x, y);
                }
            }
            */

        }



        private void SetLabelAttributes(int x, int y)
        {
            Label label = new Label();

            label.AutoEllipsis = true;
            label.Font = new Font("Arial", 10);
            label.Location = new System.Drawing.Point(x*85, y*30);
            label.Name = "lblx" + x.ToString() + "y" + y.ToString();
            label.Size = new System.Drawing.Size(70, 20);
            label.Text = "lblx" + x.ToString() + "y" + y.ToString();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.UseMnemonic = false;

            this.Controls.Add(label);
        }

    }
}
