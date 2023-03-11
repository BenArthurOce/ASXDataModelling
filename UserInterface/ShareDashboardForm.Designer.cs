using System.Windows.Forms;

namespace UserInterface
{
    partial class ShareDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel_tab1 = new System.Windows.Forms.Panel();
            this.radioButtonTab5 = new UserInterface.FormAssets.RadioButtonTab();
            this.radioButtonTab4 = new UserInterface.FormAssets.RadioButtonTab();
            this.radioButtonTab3 = new UserInterface.FormAssets.RadioButtonTab();
            this.radioButtonTab2 = new UserInterface.FormAssets.RadioButtonTab();
            this.radioButtonTab1 = new UserInterface.FormAssets.RadioButtonTab();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel_Header.SuspendLayout();
            this.panel_tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel_Header.Controls.Add(this.lblHeader);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1160, 61);
            this.panel_Header.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(23, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(65, 21);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Header";
            // 
            // panel_tab1
            // 
            this.panel_tab1.BackColor = System.Drawing.Color.White;
            this.panel_tab1.Controls.Add(this.radioButtonTab5);
            this.panel_tab1.Controls.Add(this.radioButtonTab4);
            this.panel_tab1.Controls.Add(this.radioButtonTab3);
            this.panel_tab1.Controls.Add(this.radioButtonTab2);
            this.panel_tab1.Controls.Add(this.radioButtonTab1);
            this.panel_tab1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_tab1.Location = new System.Drawing.Point(0, 61);
            this.panel_tab1.Name = "panel_tab1";
            this.panel_tab1.Size = new System.Drawing.Size(110, 640);
            this.panel_tab1.TabIndex = 1;
            // 
            // radioButtonTab5
            // 
            this.radioButtonTab5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTab5.AutoSize = true;
            this.radioButtonTab5.ColorMouseHovorOff = System.Drawing.Color.LightBlue;
            this.radioButtonTab5.ColorMouseHovorOn = System.Drawing.Color.LightGray;
            this.radioButtonTab5.ColourMouseClick = System.Drawing.Color.SteelBlue;
            this.radioButtonTab5.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTab5.Location = new System.Drawing.Point(0, 307);
            this.radioButtonTab5.MaximumSize = new System.Drawing.Size(105, 70);
            this.radioButtonTab5.MinimumSize = new System.Drawing.Size(105, 70);
            this.radioButtonTab5.Name = "radioButtonTab5";
            this.radioButtonTab5.Size = new System.Drawing.Size(105, 70);
            this.radioButtonTab5.TabIndex = 4;
            this.radioButtonTab5.TabStop = true;
            this.radioButtonTab5.Text = "Upload Documents";
            this.radioButtonTab5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTab5.TextForeColor = System.Drawing.Color.Black;
            this.radioButtonTab5.UseVisualStyleBackColor = true;
            this.radioButtonTab5.CheckedChanged += new System.EventHandler(this.radioButtonTab5_CheckedChanged);
            // 
            // radioButtonTab4
            // 
            this.radioButtonTab4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTab4.AutoSize = true;
            this.radioButtonTab4.ColorMouseHovorOff = System.Drawing.Color.LightBlue;
            this.radioButtonTab4.ColorMouseHovorOn = System.Drawing.Color.LightGray;
            this.radioButtonTab4.ColourMouseClick = System.Drawing.Color.SteelBlue;
            this.radioButtonTab4.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTab4.Location = new System.Drawing.Point(0, 231);
            this.radioButtonTab4.MaximumSize = new System.Drawing.Size(105, 70);
            this.radioButtonTab4.MinimumSize = new System.Drawing.Size(105, 70);
            this.radioButtonTab4.Name = "radioButtonTab4";
            this.radioButtonTab4.Size = new System.Drawing.Size(105, 70);
            this.radioButtonTab4.TabIndex = 3;
            this.radioButtonTab4.TabStop = true;
            this.radioButtonTab4.Text = "Portfolio History";
            this.radioButtonTab4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTab4.TextForeColor = System.Drawing.Color.Black;
            this.radioButtonTab4.UseVisualStyleBackColor = true;
            this.radioButtonTab4.CheckedChanged += new System.EventHandler(this.radioButtonTab4_CheckedChanged);
            // 
            // radioButtonTab3
            // 
            this.radioButtonTab3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTab3.AutoSize = true;
            this.radioButtonTab3.ColorMouseHovorOff = System.Drawing.Color.LightBlue;
            this.radioButtonTab3.ColorMouseHovorOn = System.Drawing.Color.LightGray;
            this.radioButtonTab3.ColourMouseClick = System.Drawing.Color.SteelBlue;
            this.radioButtonTab3.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTab3.Location = new System.Drawing.Point(0, 155);
            this.radioButtonTab3.MaximumSize = new System.Drawing.Size(105, 70);
            this.radioButtonTab3.MinimumSize = new System.Drawing.Size(105, 70);
            this.radioButtonTab3.Name = "radioButtonTab3";
            this.radioButtonTab3.Size = new System.Drawing.Size(105, 70);
            this.radioButtonTab3.TabIndex = 2;
            this.radioButtonTab3.TabStop = true;
            this.radioButtonTab3.Text = "Share Transactions";
            this.radioButtonTab3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTab3.TextForeColor = System.Drawing.Color.Black;
            this.radioButtonTab3.UseVisualStyleBackColor = true;
            this.radioButtonTab3.CheckedChanged += new System.EventHandler(this.radioButtonTab3_CheckedChanged);
            // 
            // radioButtonTab2
            // 
            this.radioButtonTab2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTab2.AutoSize = true;
            this.radioButtonTab2.ColorMouseHovorOff = System.Drawing.Color.LightBlue;
            this.radioButtonTab2.ColorMouseHovorOn = System.Drawing.Color.LightGray;
            this.radioButtonTab2.ColourMouseClick = System.Drawing.Color.SteelBlue;
            this.radioButtonTab2.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTab2.Location = new System.Drawing.Point(0, 79);
            this.radioButtonTab2.MaximumSize = new System.Drawing.Size(105, 70);
            this.radioButtonTab2.MinimumSize = new System.Drawing.Size(105, 70);
            this.radioButtonTab2.Name = "radioButtonTab2";
            this.radioButtonTab2.Size = new System.Drawing.Size(105, 70);
            this.radioButtonTab2.TabIndex = 1;
            this.radioButtonTab2.TabStop = true;
            this.radioButtonTab2.Text = "Portfolio Summary";
            this.radioButtonTab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTab2.TextForeColor = System.Drawing.Color.Black;
            this.radioButtonTab2.UseVisualStyleBackColor = true;
            this.radioButtonTab2.CheckedChanged += new System.EventHandler(this.radioButtonTab2_CheckedChanged);
            // 
            // radioButtonTab1
            // 
            this.radioButtonTab1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTab1.AutoSize = true;
            this.radioButtonTab1.ColorMouseHovorOff = System.Drawing.Color.LightBlue;
            this.radioButtonTab1.ColorMouseHovorOn = System.Drawing.Color.LightGray;
            this.radioButtonTab1.ColourMouseClick = System.Drawing.Color.SteelBlue;
            this.radioButtonTab1.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTab1.Location = new System.Drawing.Point(0, 3);
            this.radioButtonTab1.MaximumSize = new System.Drawing.Size(105, 70);
            this.radioButtonTab1.MinimumSize = new System.Drawing.Size(105, 70);
            this.radioButtonTab1.Name = "radioButtonTab1";
            this.radioButtonTab1.Size = new System.Drawing.Size(105, 70);
            this.radioButtonTab1.TabIndex = 0;
            this.radioButtonTab1.TabStop = true;
            this.radioButtonTab1.Text = "Share Price History";
            this.radioButtonTab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTab1.TextForeColor = System.Drawing.Color.Black;
            this.radioButtonTab1.UseVisualStyleBackColor = true;
            this.radioButtonTab1.CheckedChanged += new System.EventHandler(this.radioButtonTab1_CheckedChanged);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(110, 61);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1050, 640);
            this.panelContainer.TabIndex = 2;
            // 
            // ShareDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 701);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel_tab1);
            this.Controls.Add(this.panel_Header);
            this.Name = "ShareDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShareDashboardForm";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel_tab1.ResumeLayout(false);
            this.panel_tab1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Header;
        private Label lblHeader;
        private Panel panel_tab1;
        private Panel panelContainer;
        private FormAssets.RadioButtonTab radioButtonTab5;
        private FormAssets.RadioButtonTab radioButtonTab4;
        private FormAssets.RadioButtonTab radioButtonTab3;
        private FormAssets.RadioButtonTab radioButtonTab2;
        private FormAssets.RadioButtonTab radioButtonTab1;
    }
}