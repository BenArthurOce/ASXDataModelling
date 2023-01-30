using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace UserInterface.FormAssets
{
    class CustomPanel : Panel
    {

        private bool _isClicked;

        private int _minimumHeight;
        private int _maximumHeight;
        private int _defaultWidth;

        private Label _lblTransNum;
        private Label _lblTransType;
        private Label _lblTransCode;
        private Label _lblTransCostTotal;

        private int x20;
        private int x40;
        private int x60;
        private int x80;

        public bool IsClicked
        {
            get { return _isClicked; }
            set { _isClicked = value; Invalidate(); }
        }


        public int MinimumHeight
        {
            get { return _minimumHeight; }
            set { _minimumHeight = value; Invalidate(); }
        }

        public int MaximumHeight
        {
            get { return _maximumHeight; }
            set { _maximumHeight = value; Invalidate(); }
        }

        public int DefaultWidth
        {
            get { return _defaultWidth; }
            set { _defaultWidth = value; Invalidate(); }
        }

        public Label lblTransNum
        {
            get { return _lblTransNum; }
            set { _lblTransNum = value; Invalidate(); }
        }

        public Label lblTransType
        {
            get { return _lblTransType;  }
            set { _lblTransType = value; Invalidate(); }
        }

        public Label lblTransCode
        {
            get { return _lblTransCode; }
            set { _lblTransCode = value; Invalidate(); }
        }

        public Label lblTransCostTotal
        {
            get { return _lblTransCostTotal; }
            set { _lblTransCostTotal = value; Invalidate(); }
        }

        public CustomPanel()
        {
            this.MinimumHeight = 30;
            this.MaximumHeight = 90;
            this.DefaultWidth = 300;
            this.MinimumSize = new Size(DefaultWidth, MinimumHeight);
            this.MaximumSize = new Size(DefaultWidth, MaximumHeight);
            this.Size = new Size(DefaultWidth, MinimumHeight);
            this.AutoSize = false;

            x20 = this.DefaultWidth / 5 * 1;    // 20% Mark of the Panel
            x40 = this.DefaultWidth / 5 * 2;    // 40% Mark of the Panel
            x60 = this.DefaultWidth / 5 * 3;    // 60% Mark of the Panel
            x80 = this.DefaultWidth / 5 * 4;    // 80% Mark of the Panel


            lblTransNum = new Label
            {
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.x20, 10),
                Size = new System.Drawing.Size(50, 20),
                Text = "TransNum",
            };


            lblTransType = new Label
            {
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.x40, 10),
                Size = new System.Drawing.Size(50, 20),
                Text = "Trans Type",
            };


            lblTransCode = new Label
            {
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.x60, 10),
                Size = new System.Drawing.Size(50, 20),
                Text = "Code",
            };


            lblTransCostTotal = new Label
            {
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.x80, 10),
                Size = new System.Drawing.Size(50, 20),
                Text = "TotalCost"
            };

            this.Controls.Add(lblTransNum);
            this.Controls.Add(lblTransType);
            this.Controls.Add(lblTransCode);
            this.Controls.Add(lblTransCostTotal);


            this.BackColor = Color.Red;
            this.Click += PanelClicked;
        }


        private void PanelClicked(object sender, EventArgs e)
        {
            CustomPanel panel = (CustomPanel)sender;
            if (panel.IsClicked)
            {
                return;
            }

            foreach (Control control in panel.Parent.Controls)
            {
                if (control is CustomPanel)
                {
                    ((CustomPanel)control).IsClicked = false;
                    ((CustomPanel)control).Size = this.MinimumSize;
                }
            }

            panel.IsClicked = true;
            panel.Size = this.MaximumSize;
        }

        /*
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            text = this.Text;

            if (isClicked)
            {
                this.Height = 300;
            }
            else
            {
                this.Height = 200;
            }

            if (isHovered)
            {
                Color c1 = Color.FromArgb(color1Transparent, hoverColor);
                Color c2 = Color.FromArgb(color2Transparent, hoverColor);
                Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
                SolidBrush frcolor = new SolidBrush(this.ForeColor);
                pe.Graphics.FillRectangle(b, ClientRectangle);
                //MessageBox.Show(label1.Text);
            }

            else
            {
                Color c1 = Color.FromArgb(color1Transparent, inactiveColor);
                Color c2 = Color.FromArgb(color2Transparent, inactiveColor);
                //Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
                //SolidBrush frcolor = new SolidBrush(this.ForeColor);
                //pe.Graphics.FillRectangle(b, ClientRectangle);
            }

        }
        */
    }
}
