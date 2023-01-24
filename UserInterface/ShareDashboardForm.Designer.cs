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
            this.tabBtn_tab5 = new UserInterface.FormAssets.RadioButtonTab();
            this.tabBtn_tab4 = new UserInterface.FormAssets.RadioButtonTab();
            this.tabBtn_tab3 = new UserInterface.FormAssets.RadioButtonTab();
            this.tabBtn_tab1 = new UserInterface.FormAssets.RadioButtonTab();
            this.tabBtn_tab2 = new UserInterface.FormAssets.RadioButtonTab();
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
            this.panel_Header.Size = new System.Drawing.Size(1358, 61);
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
            this.panel_tab1.Controls.Add(this.tabBtn_tab5);
            this.panel_tab1.Controls.Add(this.tabBtn_tab4);
            this.panel_tab1.Controls.Add(this.tabBtn_tab3);
            this.panel_tab1.Controls.Add(this.tabBtn_tab1);
            this.panel_tab1.Controls.Add(this.tabBtn_tab2);
            this.panel_tab1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_tab1.Location = new System.Drawing.Point(0, 61);
            this.panel_tab1.Name = "panel_tab1";
            this.panel_tab1.Size = new System.Drawing.Size(96, 640);
            this.panel_tab1.TabIndex = 1;
            // 
            // tabBtn_tab5
            // 
            this.tabBtn_tab5.Appearance = System.Windows.Forms.Appearance.Button;
            this.tabBtn_tab5.BoxLocation_X = 0;
            this.tabBtn_tab5.BoxLocation_Y = 0;
            this.tabBtn_tab5.BoxSize = 18;
            this.tabBtn_tab5.DisplayText = "Tab 5";
            this.tabBtn_tab5.EndColor = System.Drawing.Color.DarkBlue;
            this.tabBtn_tab5.ForeColor = System.Drawing.Color.White;
            this.tabBtn_tab5.GradientAngle = 90;
            this.tabBtn_tab5.Location = new System.Drawing.Point(-1, 315);
            this.tabBtn_tab5.MouseHoverColor1 = System.Drawing.Color.Yellow;
            this.tabBtn_tab5.MouseHoverColor2 = System.Drawing.Color.DarkOrange;
            this.tabBtn_tab5.Name = "tabBtn_tab5";
            this.tabBtn_tab5.Size = new System.Drawing.Size(89, 69);
            this.tabBtn_tab5.StartColor = System.Drawing.Color.SteelBlue;
            this.tabBtn_tab5.TabIndex = 7;
            this.tabBtn_tab5.TabStop = true;
            this.tabBtn_tab5.Text = "Tab 5";
            this.tabBtn_tab5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabBtn_tab5.TextLocation_X = 4;
            this.tabBtn_tab5.TextLocation_Y = 5;
            this.tabBtn_tab5.Transparent1 = 150;
            this.tabBtn_tab5.Transparent2 = 150;
            this.tabBtn_tab5.UseVisualStyleBackColor = true;
            this.tabBtn_tab5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabBtn_tab5_MouseClick);
            // 
            // tabBtn_tab4
            // 
            this.tabBtn_tab4.Appearance = System.Windows.Forms.Appearance.Button;
            this.tabBtn_tab4.BoxLocation_X = 0;
            this.tabBtn_tab4.BoxLocation_Y = 0;
            this.tabBtn_tab4.BoxSize = 18;
            this.tabBtn_tab4.DisplayText = "Tab 4";
            this.tabBtn_tab4.EndColor = System.Drawing.Color.DarkBlue;
            this.tabBtn_tab4.ForeColor = System.Drawing.Color.White;
            this.tabBtn_tab4.GradientAngle = 90;
            this.tabBtn_tab4.Location = new System.Drawing.Point(-1, 240);
            this.tabBtn_tab4.MouseHoverColor1 = System.Drawing.Color.Yellow;
            this.tabBtn_tab4.MouseHoverColor2 = System.Drawing.Color.DarkOrange;
            this.tabBtn_tab4.Name = "tabBtn_tab4";
            this.tabBtn_tab4.Size = new System.Drawing.Size(89, 69);
            this.tabBtn_tab4.StartColor = System.Drawing.Color.SteelBlue;
            this.tabBtn_tab4.TabIndex = 6;
            this.tabBtn_tab4.TabStop = true;
            this.tabBtn_tab4.Text = "Tab 4";
            this.tabBtn_tab4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabBtn_tab4.TextLocation_X = 4;
            this.tabBtn_tab4.TextLocation_Y = 5;
            this.tabBtn_tab4.Transparent1 = 150;
            this.tabBtn_tab4.Transparent2 = 150;
            this.tabBtn_tab4.UseVisualStyleBackColor = true;
            this.tabBtn_tab4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabBtn_tab4_MouseClick);
            // 
            // tabBtn_tab3
            // 
            this.tabBtn_tab3.Appearance = System.Windows.Forms.Appearance.Button;
            this.tabBtn_tab3.BoxLocation_X = 0;
            this.tabBtn_tab3.BoxLocation_Y = 0;
            this.tabBtn_tab3.BoxSize = 18;
            this.tabBtn_tab3.DisplayText = "Tab 3";
            this.tabBtn_tab3.EndColor = System.Drawing.Color.DarkBlue;
            this.tabBtn_tab3.ForeColor = System.Drawing.Color.White;
            this.tabBtn_tab3.GradientAngle = 90;
            this.tabBtn_tab3.Location = new System.Drawing.Point(-1, 165);
            this.tabBtn_tab3.MouseHoverColor1 = System.Drawing.Color.Yellow;
            this.tabBtn_tab3.MouseHoverColor2 = System.Drawing.Color.DarkOrange;
            this.tabBtn_tab3.Name = "tabBtn_tab3";
            this.tabBtn_tab3.Size = new System.Drawing.Size(89, 69);
            this.tabBtn_tab3.StartColor = System.Drawing.Color.SteelBlue;
            this.tabBtn_tab3.TabIndex = 5;
            this.tabBtn_tab3.TabStop = true;
            this.tabBtn_tab3.Text = "Tab 3";
            this.tabBtn_tab3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabBtn_tab3.TextLocation_X = 4;
            this.tabBtn_tab3.TextLocation_Y = 5;
            this.tabBtn_tab3.Transparent1 = 150;
            this.tabBtn_tab3.Transparent2 = 150;
            this.tabBtn_tab3.UseVisualStyleBackColor = true;
            this.tabBtn_tab3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabBtn_tab3_MouseClick);
            // 
            // tabBtn_tab1
            // 
            this.tabBtn_tab1.Appearance = System.Windows.Forms.Appearance.Button;
            this.tabBtn_tab1.BoxLocation_X = 0;
            this.tabBtn_tab1.BoxLocation_Y = 0;
            this.tabBtn_tab1.BoxSize = 18;
            this.tabBtn_tab1.DisplayText = "Tab 1";
            this.tabBtn_tab1.EndColor = System.Drawing.Color.DarkBlue;
            this.tabBtn_tab1.ForeColor = System.Drawing.Color.White;
            this.tabBtn_tab1.GradientAngle = 90;
            this.tabBtn_tab1.Location = new System.Drawing.Point(-1, 15);
            this.tabBtn_tab1.MouseHoverColor1 = System.Drawing.Color.Yellow;
            this.tabBtn_tab1.MouseHoverColor2 = System.Drawing.Color.DarkOrange;
            this.tabBtn_tab1.Name = "tabBtn_tab1";
            this.tabBtn_tab1.Size = new System.Drawing.Size(89, 69);
            this.tabBtn_tab1.StartColor = System.Drawing.Color.SteelBlue;
            this.tabBtn_tab1.TabIndex = 3;
            this.tabBtn_tab1.TabStop = true;
            this.tabBtn_tab1.Text = "Tab 1";
            this.tabBtn_tab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabBtn_tab1.TextLocation_X = 4;
            this.tabBtn_tab1.TextLocation_Y = 5;
            this.tabBtn_tab1.Transparent1 = 150;
            this.tabBtn_tab1.Transparent2 = 150;
            this.tabBtn_tab1.UseVisualStyleBackColor = true;
            this.tabBtn_tab1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabBtn_tab1_MouseClick);
            // 
            // tabBtn_tab2
            // 
            this.tabBtn_tab2.Appearance = System.Windows.Forms.Appearance.Button;
            this.tabBtn_tab2.BoxLocation_X = 0;
            this.tabBtn_tab2.BoxLocation_Y = 0;
            this.tabBtn_tab2.BoxSize = 18;
            this.tabBtn_tab2.DisplayText = "Tab 2";
            this.tabBtn_tab2.EndColor = System.Drawing.Color.DarkBlue;
            this.tabBtn_tab2.ForeColor = System.Drawing.Color.White;
            this.tabBtn_tab2.GradientAngle = 90;
            this.tabBtn_tab2.Location = new System.Drawing.Point(-1, 90);
            this.tabBtn_tab2.MouseHoverColor1 = System.Drawing.Color.Yellow;
            this.tabBtn_tab2.MouseHoverColor2 = System.Drawing.Color.DarkOrange;
            this.tabBtn_tab2.Name = "tabBtn_tab2";
            this.tabBtn_tab2.Size = new System.Drawing.Size(89, 69);
            this.tabBtn_tab2.StartColor = System.Drawing.Color.SteelBlue;
            this.tabBtn_tab2.TabIndex = 4;
            this.tabBtn_tab2.TabStop = true;
            this.tabBtn_tab2.Text = "Tab 2";
            this.tabBtn_tab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tabBtn_tab2.TextLocation_X = 4;
            this.tabBtn_tab2.TextLocation_Y = 5;
            this.tabBtn_tab2.Transparent1 = 150;
            this.tabBtn_tab2.Transparent2 = 150;
            this.tabBtn_tab2.UseVisualStyleBackColor = true;
            this.tabBtn_tab2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabBtn_tab2_MouseClick);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(96, 61);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1262, 640);
            this.panelContainer.TabIndex = 2;
            // 
            // ShareDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 701);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel_tab1);
            this.Controls.Add(this.panel_Header);
            this.Name = "ShareDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShareDashboardForm";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel_tab1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Header;
        private Label lblHeader;
        private Panel panel_tab1;

        private Panel panelContainer;
        private FormAssets.RadioButtonTab tabBtn_tab1;
        private FormAssets.RadioButtonTab tabBtn_tab2;
        private FormAssets.RadioButtonTab tabBtn_tab3;
        private FormAssets.RadioButtonTab tabBtn_tab4;
        private FormAssets.RadioButtonTab tabBtn_tab5;
    }
}