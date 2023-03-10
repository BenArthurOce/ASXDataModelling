using DataReferenceLibrary.Models2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Forms;

namespace UserInterface.FormAssets
{
    class CustomLineGraph : Panel
    {

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TableLayoutPanel tableLayoutPanel;
        private Panel panelRow1Col1;
        private Panel panelRow2Col1;
        private Panel panelRow1Col2;
        private Panel panelRow1Col3;
        private FormAssets.RadioButtonTab radioButtonTab1;
        private Panel panelRow1Col4;
        private FormAssets.RadioButtonTab radioButtonTab2;
        private Panel panelRow1Col5;
        private FormAssets.RadioButtonTab radioButtonTab3;
        private Panel panelRow1Col6;
        private FormAssets.RadioButtonTab radioButtonTab4;
        private Panel panelRow1Col7;
        private Panel panelRow1Col8;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.tableLayoutPanel = new TableLayoutPanel();
            this.panelRow1Col1 = new Panel();
            this.panelRow2Col1 = new Panel();
            this.panelRow1Col2 = new Panel();
            this.panelRow1Col3 = new Panel();
            this.panelRow1Col4 = new Panel();
            this.panelRow1Col5 = new Panel();
            this.panelRow1Col6 = new Panel();
            this.panelRow1Col7 = new Panel();
            this.panelRow1Col8 = new Panel();
            this.radioButtonTab1 = new UserInterface.FormAssets.RadioButtonTab();
            this.radioButtonTab2 = new UserInterface.FormAssets.RadioButtonTab();
            this.radioButtonTab3 = new UserInterface.FormAssets.RadioButtonTab();
            this.radioButtonTab4 = new UserInterface.FormAssets.RadioButtonTab();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel.SuspendLayout();
            this.panelRow1Col3.SuspendLayout();
            this.panelRow1Col4.SuspendLayout();
            this.panelRow1Col5.SuspendLayout();
            this.panelRow1Col6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();



            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 8;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.Controls.Add(this.panelRow1Col1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelRow2Col1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.panelRow1Col2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.panelRow1Col3, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.panelRow1Col4, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.panelRow1Col5, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.panelRow1Col6, 5, 0);
            this.tableLayoutPanel.Controls.Add(this.panelRow1Col7, 6, 0);
            this.tableLayoutPanel.Controls.Add(this.panelRow1Col8, 7, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(465, 235);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // panelRow1Col1
            // 
            this.panelRow1Col1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRow1Col1.Location = new System.Drawing.Point(3, 3);
            this.panelRow1Col1.Name = "panelRow1Col1";
            this.panelRow1Col1.Padding = new System.Windows.Forms.Padding(3);
            this.panelRow1Col1.Size = new System.Drawing.Size(52, 52);
            this.panelRow1Col1.TabIndex = 0;
            // 
            // panelRow2Col1
            // 
            this.tableLayoutPanel.SetColumnSpan(this.panelRow2Col1, 8);
            this.panelRow2Col1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRow2Col1.Location = new System.Drawing.Point(5, 63);
            this.panelRow2Col1.Margin = new System.Windows.Forms.Padding(5);
            this.panelRow2Col1.Name = "panelRow2Col1";
            this.panelRow2Col1.Padding = new System.Windows.Forms.Padding(5);
            this.panelRow2Col1.Size = new System.Drawing.Size(455, 167);
            this.panelRow2Col1.TabIndex = 8;
            // 
            // panelRow1Col2
            // 
            this.panelRow1Col2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRow1Col2.Location = new System.Drawing.Point(61, 3);
            this.panelRow1Col2.Name = "panelRow1Col2";
            this.panelRow1Col2.Padding = new System.Windows.Forms.Padding(3);
            this.panelRow1Col2.Size = new System.Drawing.Size(52, 52);
            this.panelRow1Col2.TabIndex = 9;
            // 
            // panelRow1Col3
            // 
            this.panelRow1Col3.Controls.Add(this.radioButtonTab1);
            this.panelRow1Col3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRow1Col3.Location = new System.Drawing.Point(119, 3);
            this.panelRow1Col3.Name = "panelRow1Col3";
            this.panelRow1Col3.Padding = new System.Windows.Forms.Padding(3);
            this.panelRow1Col3.Size = new System.Drawing.Size(52, 52);
            this.panelRow1Col3.TabIndex = 10;
            // 
            // panelRow1Col4
            // 
            this.panelRow1Col4.Controls.Add(this.radioButtonTab2);
            this.panelRow1Col4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRow1Col4.Location = new System.Drawing.Point(177, 3);
            this.panelRow1Col4.Name = "panelRow1Col4";
            this.panelRow1Col4.Padding = new System.Windows.Forms.Padding(3);
            this.panelRow1Col4.Size = new System.Drawing.Size(52, 52);
            this.panelRow1Col4.TabIndex = 11;
            // 
            // panelRow1Col5
            // 
            this.panelRow1Col5.Controls.Add(this.radioButtonTab3);
            this.panelRow1Col5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRow1Col5.Location = new System.Drawing.Point(235, 3);
            this.panelRow1Col5.Name = "panelRow1Col5";
            this.panelRow1Col5.Padding = new System.Windows.Forms.Padding(3);
            this.panelRow1Col5.Size = new System.Drawing.Size(52, 52);
            this.panelRow1Col5.TabIndex = 12;
            // 
            // panelRow1Col6
            // 
            this.panelRow1Col6.Controls.Add(this.radioButtonTab4);
            this.panelRow1Col6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRow1Col6.Location = new System.Drawing.Point(293, 3);
            this.panelRow1Col6.Name = "panelRow1Col6";
            this.panelRow1Col6.Padding = new System.Windows.Forms.Padding(3);
            this.panelRow1Col6.Size = new System.Drawing.Size(52, 52);
            this.panelRow1Col6.TabIndex = 13;
            // 
            // panelRow1Col7
            // 
            this.panelRow1Col7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRow1Col7.Location = new System.Drawing.Point(351, 3);
            this.panelRow1Col7.Name = "panelRow1Col7";
            this.panelRow1Col7.Padding = new System.Windows.Forms.Padding(3);
            this.panelRow1Col7.Size = new System.Drawing.Size(52, 52);
            this.panelRow1Col7.TabIndex = 14;
            // 
            // panelRow1Col8
            // 
            this.panelRow1Col8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRow1Col8.Location = new System.Drawing.Point(409, 3);
            this.panelRow1Col8.Name = "panelRow1Col8";
            this.panelRow1Col8.Padding = new System.Windows.Forms.Padding(3);
            this.panelRow1Col8.Size = new System.Drawing.Size(53, 52);
            this.panelRow1Col8.TabIndex = 15;
            // 
            // radioButtonTab1
            // 
            this.radioButtonTab1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTab1.AutoSize = true;
            this.radioButtonTab1.ColorMouseHovorOff = System.Drawing.Color.LightBlue;
            this.radioButtonTab1.ColorMouseHovorOn = System.Drawing.Color.LightGray;
            this.radioButtonTab1.ColourMouseClick = System.Drawing.Color.SteelBlue;
            this.radioButtonTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonTab1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButtonTab1.FlatAppearance.BorderSize = 90;
            this.radioButtonTab1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.radioButtonTab1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.radioButtonTab1.Location = new System.Drawing.Point(3, 3);
            this.radioButtonTab1.MinimumSize = new System.Drawing.Size(50, 50);
            this.radioButtonTab1.Name = "radioButtonTab1";
            this.radioButtonTab1.Size = new System.Drawing.Size(50, 50);
            this.radioButtonTab1.TabIndex = 0;
            this.radioButtonTab1.TabStop = true;
            this.radioButtonTab1.Text = "1 Month";
            this.radioButtonTab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTab1.TextForeColor = System.Drawing.Color.Black;
            this.radioButtonTab1.UseVisualStyleBackColor = true;
            // 
            // radioButtonTab2
            // 
            this.radioButtonTab2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTab2.AutoSize = true;
            this.radioButtonTab2.ColorMouseHovorOff = System.Drawing.Color.LightBlue;
            this.radioButtonTab2.ColorMouseHovorOn = System.Drawing.Color.LightGray;
            this.radioButtonTab2.ColourMouseClick = System.Drawing.Color.SteelBlue;
            this.radioButtonTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonTab2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButtonTab2.FlatAppearance.BorderSize = 90;
            this.radioButtonTab2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.radioButtonTab2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.radioButtonTab2.Location = new System.Drawing.Point(3, 3);
            this.radioButtonTab2.MinimumSize = new System.Drawing.Size(50, 50);
            this.radioButtonTab2.Name = "radioButtonTab2";
            this.radioButtonTab2.Size = new System.Drawing.Size(50, 50);
            this.radioButtonTab2.TabIndex = 0;
            this.radioButtonTab2.TabStop = true;
            this.radioButtonTab2.Text = "6 Month";
            this.radioButtonTab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTab2.TextForeColor = System.Drawing.Color.Black;
            this.radioButtonTab2.UseVisualStyleBackColor = true;
            // 
            // radioButtonTab3
            // 
            this.radioButtonTab3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTab3.AutoSize = true;
            this.radioButtonTab3.ColorMouseHovorOff = System.Drawing.Color.LightBlue;
            this.radioButtonTab3.ColorMouseHovorOn = System.Drawing.Color.LightGray;
            this.radioButtonTab3.ColourMouseClick = System.Drawing.Color.SteelBlue;
            this.radioButtonTab3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonTab3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButtonTab3.FlatAppearance.BorderSize = 90;
            this.radioButtonTab3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.radioButtonTab3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.radioButtonTab3.Location = new System.Drawing.Point(3, 3);
            this.radioButtonTab3.MinimumSize = new System.Drawing.Size(50, 50);
            this.radioButtonTab3.Name = "radioButtonTab3";
            this.radioButtonTab3.Size = new System.Drawing.Size(50, 50);
            this.radioButtonTab3.TabIndex = 0;
            this.radioButtonTab3.TabStop = true;
            this.radioButtonTab3.Text = "1 Year";
            this.radioButtonTab3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTab3.TextForeColor = System.Drawing.Color.Black;
            this.radioButtonTab3.UseVisualStyleBackColor = true;
            // 
            // radioButtonTab4
            // 
            this.radioButtonTab4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTab4.AutoSize = true;
            this.radioButtonTab4.ColorMouseHovorOff = System.Drawing.Color.LightBlue;
            this.radioButtonTab4.ColorMouseHovorOn = System.Drawing.Color.LightGray;
            this.radioButtonTab4.ColourMouseClick = System.Drawing.Color.SteelBlue;
            this.radioButtonTab4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonTab4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButtonTab4.FlatAppearance.BorderSize = 90;
            this.radioButtonTab4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.radioButtonTab4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.radioButtonTab4.Location = new System.Drawing.Point(3, 3);
            this.radioButtonTab4.MinimumSize = new System.Drawing.Size(50, 50);
            this.radioButtonTab4.Name = "radioButtonTab4";
            this.radioButtonTab4.Size = new System.Drawing.Size(50, 50);
            this.radioButtonTab4.TabIndex = 0;
            this.radioButtonTab4.TabStop = true;
            this.radioButtonTab4.Text = "2 Year";
            this.radioButtonTab4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTab4.TextForeColor = System.Drawing.Color.Black;
            this.radioButtonTab4.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            //this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(612, 182);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";



            this.tableLayoutPanel.ResumeLayout(false);
            this.panelRow1Col3.ResumeLayout(false);
            this.panelRow1Col3.PerformLayout();
            this.panelRow1Col4.ResumeLayout(false);
            this.panelRow1Col4.PerformLayout();
            this.panelRow1Col5.ResumeLayout(false);
            this.panelRow1Col5.PerformLayout();
            this.panelRow1Col6.ResumeLayout(false);
            this.panelRow1Col6.PerformLayout();
            this.ResumeLayout(false);

            this.Controls.Add(tableLayoutPanel);

        }


        public CustomLineGraph()
        {
            InitializeComponent();
            BackColor = Color.Pink;
        }
    }
}
