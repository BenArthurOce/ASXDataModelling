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

        private Color activeColor = Color.Red;
        private Color hoverColor = Color.Green;
        private Color inactiveColor = Color.Pink;

        private bool isHovered;

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
            this.ForeColor = Color.White;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
           // MessageBox.Show(this.text);
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
                //MessageBox.Show("ishovered_toFill");
            }

            else
            {
                Color c1 = Color.FromArgb(color1Transparent, inactiveColor);
                Color c2 = Color.FromArgb(color2Transparent, inactiveColor);
                //Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
                //SolidBrush frcolor = new SolidBrush(this.ForeColor);
                //pe.Graphics.FillRectangle(b, ClientRectangle);
            }




            
            
            /*
            {
                Color c1 = Color.FromArgb(color1Transparent, hoverColor);
                Color c2 = Color.FromArgb(color2Transparent, hoverColor);
                Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
                SolidBrush frcolor = new SolidBrush(this.ForeColor);
                e.Graphics.FillRectangle(b, ClientRectangle);
                //e.Graphics.DrawString(text, this.Font, frcolor, new Point(textX, textY));
                //Rectangle rc = new Rectangle(boxlocatx, boxlocaty, boxsize, boxsize);
                //ControlPaint.DrawRadioButtonTab(e.Graphics, rc, this.Checked ? ButtonState.Checked : ButtonState.Normal);
                b.Dispose();
            }
            */


        }
        /*
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Checked)
            {
                MessageBox.Show("Checked");
                MessageBox.Show(text);
            }

            base.OnPaint(e);
            this.AutoSize = false;
            text = this.Text;
            Color c1 = Color.FromArgb(color1Transparent, color1);
            Color c2 = Color.FromArgb(color2Transparent, color2);
            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
            SolidBrush frcolor = new SolidBrush(this.ForeColor);
            e.Graphics.FillRectangle(b, ClientRectangle);
            e.Graphics.DrawString(text, this.Font, frcolor, new Point(textX, textY));
            Rectangle rc = new Rectangle(boxlocatx, boxlocaty, boxsize, boxsize);
            ControlPaint.DrawRadioButtonTab(e.Graphics, rc, this.Checked ? ButtonState.Checked : ButtonState.Normal);
            b.Dispose();
        }
        */
    }
}
