using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.FormAssets
{
    class RadioButtonTab : System.Windows.Forms.RadioButton
    {


        private String text = "";
        private Color _textForeColour = Color.Black;
        private Color _activeColor = Color.SteelBlue;
        private Color _hoverColor = Color.LightGray;
        private Color _inactiveColor = Color.LightBlue;
        private bool isHovered;

        private int _defaultMinWidth = 90;
        private int _defaultMinHeight = 70;

        private Color _defaultBoarderColor = Color.Red;
        private int _defaultBoarderWidth = 90;

        public Color DefaultBoarderColor
        {
            get { return _defaultBoarderColor; }
            set { _defaultBoarderColor = value; Invalidate(); }
        }

        public int DefaultBoarderWidth
        {
            get { return _defaultBoarderWidth; }
            set { _defaultBoarderWidth = value; Invalidate(); }
        }

        public Color TextForeColor
        {
            get { return _textForeColour; }
            set { _textForeColour = value; Invalidate(); }
        }

        public Color ColorMouseHovorOn
        {
            get { return _hoverColor; }
            set { _hoverColor = value; Invalidate(); }
        }

        public Color ColorMouseHovorOff
        {
            get { return _inactiveColor; }
            set { _inactiveColor = value; Invalidate(); }
        }

        public Color ColourMouseClick
        {
            get { return _activeColor; }
            set { _activeColor = value; Invalidate(); }
        }

        public String DisplayText
        {
            get { return text; }
            set { text = value; Invalidate(); }
        }

        public int DefaultMinWidth
        {
            get { return _defaultMinWidth; }
            set { _defaultMinWidth = value; Invalidate(); }
        }
        public int DefaultMinHeight
        {
            get { return _defaultMinHeight; }
            set { _defaultMinHeight = value; Invalidate(); }
        }


        public RadioButtonTab()
        {

            this.TextForeColor = TextForeColor;
            this.Appearance = Appearance.Button;
            this.AutoSize = false;
            this.MinimumSize = new Size(DefaultMinWidth, DefaultMinHeight);
            this.Text = DisplayText;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.FlatAppearance.BorderColor = DefaultBoarderColor;
            this.FlatAppearance.BorderSize = DefaultBoarderWidth;
            this.FlatAppearance.MouseOverBackColor = Color.Red;
            this.FlatAppearance.MouseDownBackColor = Color.Green;
            
            int x = this.Size.Width / 2;
            int y = this.Size.Height / 2;


        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Call the OnPaint method of the base class.
            base.OnPaint(pe);

            //If the RadioButtonTab is checked
            if (Checked)
            {   //Create Brush and Fill the Radiobutton Area Colour
                SolidBrush bsh = new SolidBrush(ColourMouseClick);
                pe.Graphics.FillRectangle(bsh, ClientRectangle);

                //Find the middle of the radiobutton text area and set Black text to the middle
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                pe.Graphics.DrawString(DisplayText, this.Font, new SolidBrush(TextForeColor), ClientRectangle, sf);
                bsh.Dispose();
            }
            else if (isHovered)
            {   //Create Brush and Fill the Radiobutton Area Colour
                SolidBrush bsh = new SolidBrush(ColorMouseHovorOn);
                pe.Graphics.FillRectangle(bsh, ClientRectangle);

                //Find the middle of the radiobutton text area and set Black text to the middle
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                pe.Graphics.DrawString(DisplayText, this.Font, new SolidBrush(TextForeColor), ClientRectangle, sf);
                bsh.Dispose();
            }
            else
            {   //Create Brush and Fill the Radiobutton Area Colour
                SolidBrush bsh = new SolidBrush(ColorMouseHovorOff);
                pe.Graphics.FillRectangle(bsh, ClientRectangle);

                //Find the middle of the radiobutton text area and set Black text to the middle
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                pe.Graphics.DrawString(DisplayText, this.Font, new SolidBrush(TextForeColor), ClientRectangle, sf);
                bsh.Dispose();
            }
        }
    }
}