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
        public Label lblTransNum;
        public Label lblTransType;
        public Label lblTransCode;
        public Label lblTransCostTotal;

        private Color _baseColor = Color.Red;

        private bool _isClicked;

        private int _minimumHeight = 30;
        private int _maximumHeight = 90;
        private int _defaultWidth;

        private string _TransNumber;
        private string _TransType;
        private string _TransCode;
        private string _TransCostTotal;

        private int x20;
        private int x40;
        private int x60;
        private int x80;

        public int _TestWideInt;

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

        public string TransNumber
        {
            get { return _TransNumber; }
            set { _TransNumber = value; Invalidate(); }
        }

        public string TransType
        {
            get { return _TransType; }
            set { _TransType = value; Invalidate(); }
        }

        public string TransCode
        {
            get { return _TransCode; }
            set { _TransCode = value; Invalidate(); }
        }

        public string TransCostTotal
        {
            get { return _TransCostTotal; }
            set { _TransCostTotal = value; Invalidate(); }
        }

        public int TestWideInt
        {
            get { return _TestWideInt; }
            set { _TestWideInt = value; Invalidate(); }
        }

        public CustomPanel()
        {
            //this.DefaultWidth = DefaultWidth;
            //MessageBox.Show(DefaultWidth.ToString();
            this.DefaultWidth = 1248;        // CHANGE THIS DEPENDING ON TAB FOR NOW

            //MessageBox.Show(TestWideInt.ToString());

            this.TransNumber = _TransNumber;
            this.TransType = _TransType;
            this.TransCode = _TransCode;
            this.TransCostTotal = _TransCostTotal;


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
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.x20, 10),
                Size = new System.Drawing.Size(50, 20),
                Text = this.TransNumber,
                UseMnemonic = false,
            };


            lblTransType = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.x40, 10),
                Size = new System.Drawing.Size(50, 20),
                Text = this.TransType,
                UseMnemonic = false,
            };


            lblTransCode = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.x60, 10),
                Size = new System.Drawing.Size(50, 20),
                Text = this.TransCode,
                UseMnemonic = false,
            };


            lblTransCostTotal = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.x80, 10),
                Size = new System.Drawing.Size(50, 20),
                Text = this.TransCostTotal,
                UseMnemonic = false,
            };


            this.Controls.Add(lblTransNum);
            this.Controls.Add(lblTransType);
            this.Controls.Add(lblTransCode);
            this.Controls.Add(lblTransCostTotal);


            // Set all the labels in each custom panel to expand the panel
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.Click += Label_Click;
                }
            }


            this.BackColor = _baseColor;
            this.Click += PanelClicked;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            PanelClicked(this, e);
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
