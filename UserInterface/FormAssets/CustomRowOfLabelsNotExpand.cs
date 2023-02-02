using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.FormAssets
{
    class CustomRowOfLabelsNotExpand : Panel
    {
        private Label lblCol1;
        private Label lblCol2;
        private Label lblCol3;
        private Label lblCol4;
        private Label lblCol5;
        private Label lblCol6;
        private Label lblCol7;

        private int _distanceBetween;
        private int _distanceIndent;

        public CustomRowOfLabelsNotExpand()
        {
            lblCol1 = new Label();
            lblCol2 = new Label();
            lblCol3 = new Label();
            lblCol4 = new Label();
            lblCol5 = new Label();
            lblCol6 = new Label();
            lblCol7 = new Label();

            this.Controls.Add(lblCol1);
            this.Controls.Add(lblCol2);
            this.Controls.Add(lblCol3);
            this.Controls.Add(lblCol4);
            this.Controls.Add(lblCol5);
            this.Controls.Add(lblCol6);
            this.Controls.Add(lblCol7);

            this.Height = 20;
            this.Padding = new Padding(5);
            this.Margin = new Padding(DistanceIndent);
            this.Font = new Font("Arial", 11);

        }

        public string Column1Text
        {
            get { return lblCol1.Text; }
            set { lblCol1.Text = value; }
        }

        public string Column2Text
        {
            get { return lblCol2.Text; }
            set { lblCol2.Text = value; }
        }

        public string Column3Text
        {
            get { return lblCol3.Text; }
            set { lblCol3.Text = value; }
        }

        public string Column4Text
        {
            get { return lblCol4.Text; }
            set { lblCol4.Text = value; }
        }

        public string Column5Text
        {
            get { return lblCol5.Text; }
            set { lblCol5.Text = value; }
        }

        public string Column6Text
        {
            get { return lblCol6.Text; }
            set { lblCol6.Text = value; }
        }

        public string Column7Text
        {
            get { return lblCol7.Text; }
            set { lblCol7.Text = value; }
        }

        public int DistanceBetweenLabels
        {
            get { return _distanceBetween; }
            set { _distanceBetween = value; }
        }

        public int DistanceIndent
        {
            get { return _distanceIndent; }
            set { _distanceIndent = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            int label1Width = (int)(this.Width * 0.5);
            lblCol1.Size = new System.Drawing.Size(this.DistanceBetweenLabels, 20);
            lblCol2.Size = new System.Drawing.Size(this.DistanceBetweenLabels, 20);
            lblCol3.Size = new System.Drawing.Size(this.DistanceBetweenLabels, 20);
            lblCol4.Size = new System.Drawing.Size(this.DistanceBetweenLabels, 20);
            lblCol5.Size = new System.Drawing.Size(this.DistanceBetweenLabels, 20);
            lblCol6.Size = new System.Drawing.Size(this.DistanceBetweenLabels, 20);
            lblCol7.Size = new System.Drawing.Size(this.DistanceBetweenLabels, 20);

            lblCol1.Location = new System.Drawing.Point(0, 0);
            lblCol2.Location = new System.Drawing.Point(this.DistanceBetweenLabels * 1, 0);
            lblCol3.Location = new System.Drawing.Point(this.DistanceBetweenLabels * 2, 0);
            lblCol4.Location = new System.Drawing.Point(this.DistanceBetweenLabels * 3, 0);
            lblCol5.Location = new System.Drawing.Point(this.DistanceBetweenLabels * 4, 0);
            lblCol6.Location = new System.Drawing.Point(this.DistanceBetweenLabels * 5, 0);
            lblCol7.Location = new System.Drawing.Point(this.DistanceBetweenLabels * 6, 0);
        }
    }
}