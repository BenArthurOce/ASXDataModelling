using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UserInterface.FormAssets
{
    class CustomExpandableRow : Control
    {



        private Panel innerPanel;
        private Panel outerPanel;
        private bool isExpanded = false;
        private bool isClicked = false;

        private CustomRowOfLabelsNotExpand _rowdata;

        private int expandedHeight = 100;


        public Panel InnerPanel
        {
            get { return innerPanel; }
        }
        public Panel OuterPanel
        {
            get { return outerPanel; }
        }

        public int ExpandedHeight
        {
            get { return expandedHeight; }
            set { expandedHeight = value; }
        }

        public Control RowData
        {
            get { return _rowdata; }
            set { _rowdata = (CustomRowOfLabelsNotExpand)value; }
        }


        public CustomExpandableRow()
        {

            CustomRowOfLabelsNotExpand newRow = new CustomRowOfLabelsNotExpand();
            newRow.MinimumSize = new Size(1045, 50);
            newRow.BackColor = Color.Pink;
            newRow.DistanceBetweenLabels = 130;


            this.outerPanel = new Panel();
            //outerPanel.MinimumSize = new Size(1045, 50);
            this.Controls.Add(outerPanel);
            this.OuterPanel.Controls.Add(newRow);

            //this.innerpanel.Add(newRow);

            //this.Controls.Add(newRow);


            //this.RowData = new CustomRowOfLabels();
            //this.RowData.Column1Text = "hello";
            //this.RowData.DistanceBetweenLabels = 130;

            //customRow.InnerPanel.Controls.Add(new Label { Text = "Additional Data" });


            //this.RowData.Location = new System.Drawing.Point(1, 1);

            
            //this.Controls.Add(RowData);
            //this.OuterPanel.Controls.Add( new CustomRowOfLabels());
            //MessageBox.Show()

            //this.Controls.Add(RowData);

            this.Click += CustomExpandableRow_Click;
            this.innerPanel = new Panel();
            this.innerPanel.Visible = false;
            this.Controls.Add(innerPanel);
            
            this.BackColor = System.Drawing.Color.Red;


            // Set all the labels in each custom panel to expand the panel
            foreach (Control control in this.Controls)
            {
                if (control is CustomRowOfLabelsNotExpand)
                {
                    control.Click += CustomExpandableRow_Click;
                }
            }


        }

        private void CustomExpandableRow_Click(object sender, EventArgs e)
        {
            //isClicked = !isClicked;
            //innerPanel.Visible = isClicked;
            PanelClicked(this, e);
            innerPanel.Visible = isClicked;
            /*
            isClicked = !isClicked;
            isExpanded = !isExpanded;
            innerPanel.Visible = isExpanded;
            if (isExpanded)
            {
                this.Height = expandedHeight;
                PanelClicked(this, e);
            }
            else
            {
                this.Height = this.MinimumSize.Height;
                PanelClicked(this, e);
            }
            */
        }


        private void PanelClicked(object sender, EventArgs e)
        {

            //To loop through all the current panels and set everything to false
            CustomExpandableRow panel = (CustomExpandableRow)sender;

            // If the panel is already clicked/expanded. Do nothing to this panel.
            if (panel.isClicked)
            {
                this.BackColor = System.Drawing.Color.Blue;
                return;
            }

            foreach (Control control in panel.Parent.Controls)
            {
                if (control is CustomExpandableRow)
                {
                    ((CustomExpandableRow)control).isClicked = false;
                    ((CustomExpandableRow)control).Height = this.MinimumSize.Height;
                    this.BackColor = System.Drawing.Color.Red;
                }
            }

         
            panel.isClicked = true;
            this.Height = expandedHeight;


        }

        
    }
}
