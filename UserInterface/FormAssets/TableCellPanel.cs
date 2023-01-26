using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.FormAssets
{
    class TableCellPanel : System.Windows.Forms.Panel
    {
        Color clr1, clr2;
        private Color color1 = Color.SteelBlue;
        private Color color2 = Color.DarkBlue;
        private Color m_hovercolor1 = Color.Yellow;
        private Color m_hovercolor2 = Color.DarkOrange;
        private int color1Transparent = 150;
        private int color2Transparent = 150;
        private int boxsize = 18;
        private int boxlocatx = 0;
        private int boxlocaty = 0;
        private int angle = 90;
        private int textX = 4;
        private int textY = 5;
        private String text = "";

        private int lbl1PositionX = 10;
        private int lbl1PositionY = 10;
        private String lbl1Text = "I am Label One";

        private int lbl2PositionX = 10;
        private int lbl2PositionY = 50;
        private String lbl2Text = "I am Label Two";

        private int lbl3PositionX = 60;
        private int lbl3PositionY = 100;
        private String lbl3Text = "I am Label Three";

        private Color activeColor = Color.Red;
        private Color hoverColor = Color.Green;
        private Color inactiveColor = Color.Pink;

        private bool isHovered;


        private Label lblHeaderTransactionNum;
        private Label lblHeaderTransactionType;
        private Label lblHeaderASXCode;
        private Label lblHeaderTransactionTotal;

        private Label _lblFooterTransactionNum;
        private Label _lblFooterTransactionType;
        private Label _lblFooterASXCode;
        private Label _lblFooterTransactionTotal;


        public Label lblFooterTransactionNum
        {
            get { return _lblFooterTransactionNum; }
            set { _lblFooterTransactionNum = value; Invalidate(); }
        }

        public Label lblFooterTransactionType
        {
            get { return _lblFooterTransactionType; }
            set { _lblFooterTransactionType = value; Invalidate(); }
        }

        public Label lblFooterASXCode
        {
            get { return _lblFooterASXCode; }
            set { _lblFooterASXCode = value; Invalidate(); }
        }

        public Label lblFooterTransactionTotal
        {
            get { return _lblFooterTransactionTotal; }
            set { _lblFooterTransactionTotal = value; Invalidate(); }
        }


       
        public String DisplayText
        {
            get { return text; }
            set { text = value; Invalidate(); }
        }
        public Color StartColor
        {
            get { return color1; }
            set { color1 = value; Invalidate(); }
        }
        public Color EndColor
        {
            get { return color2; }
            set { color2 = value; Invalidate(); }
        }
        public Color MouseHoverColor1
        {
            get { return m_hovercolor1; }
            set { m_hovercolor1 = value; Invalidate(); }
        }
        public Color MouseHoverColor2
        {
            get { return m_hovercolor2; }
            set { m_hovercolor2 = value; Invalidate(); }
        }
        public int Transparent1
        {
            get { return color1Transparent; }
            set
            {
                color1Transparent = value;
                if (color1Transparent > 255)
                {
                    color1Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }

        public int Transparent2
        {
            get { return color2Transparent; }
            set
            {
                color2Transparent = value;
                if (color2Transparent > 255)
                {
                    color2Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }

        public int GradientAngle
        {
            get { return angle; }
            set { angle = value; Invalidate(); }
        }

        public int TextLocation_X
        {
            get { return textX; }
            set { textX = value; Invalidate(); }
        }
        public int TextLocation_Y
        {
            get { return textY; }
            set { textY = value; Invalidate(); }
        }
        public int BoxSize
        {
            get { return boxsize; }
            set { boxsize = value; Invalidate(); }
        }
        public int BoxLocation_X
        {
            get { return boxlocatx; }
            set { boxlocatx = value; Invalidate(); }
        }
        public int BoxLocation_Y
        {
            get { return boxlocaty; }
            set { boxlocaty = value; Invalidate(); }
        }
        public TableCellPanel()
        {

            this.lblHeaderTransactionNum = new Label();
            this.lblHeaderTransactionType = new Label();
            this.lblHeaderASXCode = new Label();
            this.lblHeaderTransactionTotal = new Label();

            this.lblHeaderTransactionNum.Text = "Number:";
            this.lblHeaderTransactionNum.Location = new System.Drawing.Point(50, 10);
            this.lblHeaderTransactionNum.Size = new System.Drawing.Size(100, 20);

            this.lblHeaderTransactionType.Text = "Type:";
            this.lblHeaderTransactionType.Location = new System.Drawing.Point(200, 10);
            this.lblHeaderTransactionType.Size = new System.Drawing.Size(100, 20);

            this.lblHeaderASXCode.Text = "ASX Code:";
            this.lblHeaderASXCode.Location = new System.Drawing.Point(350, 10);
            this.lblHeaderASXCode.Size = new System.Drawing.Size(100, 20);

            this.lblHeaderTransactionTotal.Text = "Total:";
            this.lblHeaderTransactionTotal.Location = new System.Drawing.Point(500, 10);
            this.lblHeaderTransactionTotal.Size = new System.Drawing.Size(100, 20);

            this.Controls.Add(this.lblHeaderTransactionNum);
            this.Controls.Add(this.lblHeaderTransactionType);
            this.Controls.Add(this.lblHeaderASXCode);
            this.Controls.Add(this.lblHeaderTransactionTotal);


            this.lblFooterTransactionNum = new Label();
            this.lblFooterTransactionType = new Label();
            this.lblFooterASXCode = new Label();
            this.lblFooterTransactionTotal = new Label();

            this.lblFooterTransactionNum.Text = "Number:";
            this.lblFooterTransactionNum.Location = new System.Drawing.Point(50, 50);
            this.lblFooterTransactionNum.Size = new System.Drawing.Size(100, 20);

            this.lblFooterTransactionType.Text = "Type:";
            this.lblFooterTransactionType.Location = new System.Drawing.Point(200, 50);
            this.lblFooterTransactionType.Size = new System.Drawing.Size(100, 20);

            this.lblFooterASXCode.Text = "ASX Code:";
            this.lblFooterASXCode.Location = new System.Drawing.Point(350, 50);
            this.lblFooterASXCode.Size = new System.Drawing.Size(100, 20);

            this.lblFooterTransactionTotal.Text = "Total:";
            this.lblFooterTransactionTotal.Location = new System.Drawing.Point(500, 50);
            this.lblFooterTransactionTotal.Size = new System.Drawing.Size(100, 20);

            this.Controls.Add(this.lblFooterTransactionNum);
            this.Controls.Add(this.lblFooterTransactionType);
            this.Controls.Add(this.lblFooterASXCode);
            this.Controls.Add(this.lblFooterTransactionTotal);


        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            //MessageBox.Show(this.CustomLabel3.ToString());
            isHovered = true;
            clr1 = color1;
            clr2 = color2;
            color1 = m_hovercolor1;
            color2 = m_hovercolor2;
            this.BackColor = Color.White;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            color1 = clr1;
            color2 = clr2;
            this.BackColor = Color.Purple;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            text = this.Text;

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
    }
}
