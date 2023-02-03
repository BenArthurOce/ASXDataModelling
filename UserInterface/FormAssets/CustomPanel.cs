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
        public Label lblTransNumber;
        public Label lblTransDate;
        public Label lblTransType;
        public Label lblTransShareCode;
        public Label lblTransShareName;
        public Label lblTransQuantity;
        public Label lblTransUnitPrice;
        public Label lblTransTradeValue;
        public Label lblTransBrokerage;
        public Label lblTransCostTotal;

        private Label lblHeaderTransNumber;
        private Label lblHeaderTransDate;
        private Label lblHeaderTransType;
        private Label lblHeaderTransShareCode;
        private Label lblHeaderTransShareName;
        private Label lblHeaderTransQuantity;
        private Label lblHeaderTransUnitPrice;
        private Label lblHeaderTransTradeValue;
        private Label lblHeaderTransBrokerage;
        private Label lblHeaderTransCostTotal;

        private Button btnEdit;

        private Color _DefaultColor = Color.LightGray;
        private Color _ActiveColor = Color.SteelBlue;

        //private Color _baseColor = Color.Red;

        private bool _isClicked;

        private int _minimumHeight = 30;
        private int _maximumHeight = 160;
        private int _defaultWidth;

        private string _TransNumber;
        private string _TransDate;
        private string _TransType;
        private string _TransShareCode;
        private string _TransShareName;
        private string _TransQuantity;
        private string _TransUnitPrice;
        private string _TransTradeValue;
        private string _TransBrokerage;
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

        public string TransDate
        {
            get { return _TransDate; ; }
            set { _TransDate = value; Invalidate(); }
        }

        public string TransType
        {
            get { return _TransType; }
            set { _TransType = value; Invalidate(); }
        }

        public string TransShareCode
        {
            get { return _TransShareCode; }
            set { _TransShareCode = value; Invalidate(); }
        }

        public string TransShareName
        {
            get { return _TransShareName; }
            set { _TransShareName = value; Invalidate(); }
        }

        public string TransQuantity
        {
            get { return _TransQuantity; }
            set { _TransQuantity = value; Invalidate(); }
        }

        public string TransUnitPrice
        {
            get { return _TransUnitPrice; }
            set { _TransUnitPrice = value; Invalidate(); }
        }

        public string TransTradeValue
        {
            get { return _TransTradeValue; }
            set { _TransTradeValue = value; Invalidate(); }
        }

        public string TransBrokerage
        {
            get { return _TransBrokerage; }
            set { _TransBrokerage = value; Invalidate(); }
        }

        public string TransCostTotal
        {
            get { return _TransCostTotal; }
            set { _TransCostTotal = value; Invalidate(); }
        }

        public Color DefaultColor
        {
            get { return _DefaultColor; }
            set { _DefaultColor = value; Invalidate(); }
        }

        public Color ActiveColor
        {
            get { return _ActiveColor; }
            set { _ActiveColor = value; Invalidate(); }
        }

        public CustomPanel()
        {
            //this.DefaultWidth = DefaultWidth;
            //MessageBox.Show(DefaultWidth.ToString();
            this.DefaultWidth = 1248;        // CHANGE THIS DEPENDING ON TAB FOR NOW

            //MessageBox.Show(TestWideInt.ToString());

            this.btnEdit = new Button();
            btnEdit.Text = "Edit";
            btnEdit.Location = new System.Drawing.Point(500, 50);
            btnEdit.Visible = false;
            this.Controls.Add(btnEdit);

            this.TransNumber = _TransNumber;
            this.TransDate = _TransDate;
            this.TransType = _TransType;
            this.TransShareCode = _TransShareCode;
            this.TransShareName = _TransShareName;
            this.TransQuantity = _TransQuantity;
            this.TransUnitPrice = _TransUnitPrice;
            this.TransTradeValue = _TransTradeValue;
            this.TransBrokerage = _TransBrokerage;
            this.TransCostTotal = _TransCostTotal;


            this.MinimumSize = new Size(DefaultWidth, MinimumHeight);
            this.MaximumSize = new Size(DefaultWidth, MaximumHeight);
            this.Size = new Size(DefaultWidth, MinimumHeight);
            this.AutoSize = false;


            x20 = this.DefaultWidth / 5 * 1;    // 20% Mark of the Panel
            x40 = this.DefaultWidth / 5 * 2;    // 40% Mark of the Panel
            x60 = this.DefaultWidth / 5 * 3;    // 60% Mark of the Panel
            x80 = this.DefaultWidth / 5 * 4;    // 80% Mark of the Panel

            lblTransNumber = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Font = new Font("Arial", 12),
                Location = new System.Drawing.Point(this.Width / 100 * 00, this.MinimumHeight / 10 * 0 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = this.TransNumber,
                TextAlign = ContentAlignment.MiddleCenter,
                UseMnemonic = false,
            };

            lblTransDate = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Font = new Font("Arial", 12),
                Location = new System.Drawing.Point(this.Width / 100 * 05, this.MinimumHeight / 10 * 5 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = this.TransDate,
                TextAlign = ContentAlignment.MiddleCenter,
                UseMnemonic = false,
            };

            lblTransType = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Font = new Font("Arial", 12),
                Location = new System.Drawing.Point(this.Width / 100 * 23, this.MinimumHeight / 10 * 5 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = this.TransType,
                TextAlign = ContentAlignment.MiddleCenter,
                UseMnemonic = false,
            };

            lblTransShareCode = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Font = new Font("Arial", 12),
                Location = new System.Drawing.Point(this.Width / 100 * 41, this.MinimumHeight / 10 * 5 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = this.TransShareCode,
                TextAlign = ContentAlignment.MiddleCenter,
                UseMnemonic = false,
            };

            lblTransShareName = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Font = new Font("Arial", 12),
                Location = new System.Drawing.Point(this.Width / 100 * 00, this.MinimumHeight / 10 * 0 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = this.TransShareName,
                TextAlign = ContentAlignment.MiddleCenter,
                UseMnemonic = false,
            };

            lblTransQuantity = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Font = new Font("Arial", 12),
                Location = new System.Drawing.Point(this.Width / 100 * 59, this.MinimumHeight / 10 * 5 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = this.TransQuantity,
                TextAlign = ContentAlignment.MiddleCenter,
                UseMnemonic = false,
            };

            lblTransUnitPrice = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Font = new Font("Arial", 12),
                Location = new System.Drawing.Point(this.Width / 100 * 77, this.MinimumHeight / 10 * 5 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = this.TransUnitPrice,
                TextAlign = ContentAlignment.MiddleCenter,
                UseMnemonic = false,
            };

            lblTransTradeValue = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Font = new Font("Arial", 12),
                Location = new System.Drawing.Point(this.Width / 100 * 00, this.MinimumHeight / 10 * 0 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = this.TransTradeValue,
                TextAlign = ContentAlignment.MiddleCenter,
                UseMnemonic = false,
            };

            lblTransBrokerage = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Font = new Font("Arial", 12),
                Location = new System.Drawing.Point(this.Width / 100 * 00, this.MinimumHeight / 10 * 0 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = this.TransBrokerage,
                TextAlign = ContentAlignment.MiddleCenter,
                UseMnemonic = false,
            };

            lblTransCostTotal = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Font = new Font("Arial", 12),
                Location = new System.Drawing.Point(this.Width / 100 * 95, this.MinimumHeight / 10 * 5 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = this.TransCostTotal,
                TextAlign = ContentAlignment.MiddleCenter,
                UseMnemonic = false,
            };


            ///////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////


            lblHeaderTransNumber = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.Width / 100 * 05, this.MaximumHeight / 10 * 1 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = "Number:",
                TextAlign = ContentAlignment.MiddleRight,
                UseMnemonic = false,
            };

            lblHeaderTransDate = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.Width / 100 * 05, this.MaximumHeight / 10 * 3 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = "Date:",
                TextAlign = ContentAlignment.MiddleRight,
                UseMnemonic = false,
            };

            lblHeaderTransType = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.Width / 100 * 05, this.MaximumHeight / 10 * 5 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = "Type:",
                TextAlign = ContentAlignment.MiddleRight,
                UseMnemonic = false,
            };

            lblHeaderTransShareCode = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.Width / 100 * 05, this.MaximumHeight / 10 * 7 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = "Share Code:",
                TextAlign = ContentAlignment.MiddleRight,
                UseMnemonic = false,
            };

            lblHeaderTransShareName = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.Width / 100 * 05, this.MaximumHeight / 10 * 9 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = "Share Name:",
                TextAlign = ContentAlignment.MiddleRight,
                UseMnemonic = false,
            };

            lblHeaderTransQuantity = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.Width / 100 * 40, this.MaximumHeight / 10 * 1 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = "Quantity:",
                TextAlign = ContentAlignment.MiddleRight,
                UseMnemonic = false,
            };

            lblHeaderTransUnitPrice = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.Width / 100 * 40, this.MaximumHeight / 10 * 3 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = "Unit Price:",
                TextAlign = ContentAlignment.MiddleRight,
                UseMnemonic = false,
            };

            lblHeaderTransTradeValue = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.Width / 100 * 40, this.MaximumHeight / 10 * 5 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = "Trade Value:",
                TextAlign = ContentAlignment.MiddleRight,
                UseMnemonic = false,
            };

            lblHeaderTransBrokerage = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.Width / 100 * 40, this.MaximumHeight / 10 * 7 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = "Brokerage:",
                TextAlign = ContentAlignment.MiddleRight,
                UseMnemonic = false,
            };

            lblHeaderTransCostTotal = new Label
            {
                AutoEllipsis = true,
                BackColor = Color.Yellow,
                Location = new System.Drawing.Point(this.Width / 100 * 40, this.MaximumHeight / 10 * 9 - 10),
                Size = new System.Drawing.Size(90, 20),
                Text = "Total Value:",
                TextAlign = ContentAlignment.MiddleRight,
                UseMnemonic = false,
            };


            //this.Controls.Add(lblTransNumber);
            this.Controls.Add(lblTransDate);
            this.Controls.Add(lblTransType);
            this.Controls.Add(lblTransShareCode);
            //this.Controls.Add(lblTransShareName);
            this.Controls.Add(lblTransQuantity);
            this.Controls.Add(lblTransUnitPrice);
            //this.Controls.Add(lblTransTradeValue);
            //this.Controls.Add(lblTransBrokerage);
            this.Controls.Add(lblTransCostTotal);


            // Set all the labels in each custom panel to expand the panel
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.Click += Label_Click;
                }
            }


            this.BackColor = DefaultColor;
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
    


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);


            if (this.IsClicked)
            {   
                //Create Brush and Fill the Radiobutton Area Colour
                SolidBrush bsh = new SolidBrush(ActiveColor);
                pe.Graphics.FillRectangle(bsh, ClientRectangle);
                bsh.Dispose();

                // Remove Unexpanded Labels
                this.Controls.Remove(lblTransDate);
                this.Controls.Remove(lblTransType);
                this.Controls.Remove(lblTransShareCode);
                this.Controls.Remove(lblTransQuantity);
                this.Controls.Remove(lblTransUnitPrice);
                this.Controls.Remove(lblTransCostTotal);

                // Introduce Expanded Labels
                this.Controls.Add(lblHeaderTransNumber);
                this.Controls.Add(lblHeaderTransDate);
                this.Controls.Add(lblHeaderTransType);
                this.Controls.Add(lblHeaderTransShareCode);
                this.Controls.Add(lblHeaderTransShareName);
                this.Controls.Add(lblHeaderTransQuantity);
                this.Controls.Add(lblHeaderTransUnitPrice);
                this.Controls.Add(lblHeaderTransTradeValue);
                this.Controls.Add(lblHeaderTransBrokerage);
                this.Controls.Add(lblHeaderTransCostTotal);

                btnEdit.Visible = true;
            }
            else
            {
                //Create Brush and Fill the Radiobutton Area Colour
                SolidBrush bsh = new SolidBrush(DefaultColor);
                pe.Graphics.FillRectangle(bsh, ClientRectangle);
                bsh.Dispose();

                // Remove Expanded Labels
                this.Controls.Remove(lblHeaderTransNumber);
                this.Controls.Remove(lblHeaderTransDate);
                this.Controls.Remove(lblHeaderTransType);
                this.Controls.Remove(lblHeaderTransShareCode);
                this.Controls.Remove(lblHeaderTransShareName);
                this.Controls.Remove(lblHeaderTransQuantity);
                this.Controls.Remove(lblHeaderTransUnitPrice);
                this.Controls.Remove(lblHeaderTransTradeValue);
                this.Controls.Remove(lblHeaderTransBrokerage);
                this.Controls.Remove(lblHeaderTransCostTotal);

                // Introduce Unexpanded Labels
                this.Controls.Add(lblTransDate);
                this.Controls.Add(lblTransType);
                this.Controls.Add(lblTransShareCode);
                this.Controls.Add(lblTransQuantity);
                this.Controls.Add(lblTransUnitPrice);
                this.Controls.Add(lblTransCostTotal);

                btnEdit.Visible = false;
            }

        }

    }
}
