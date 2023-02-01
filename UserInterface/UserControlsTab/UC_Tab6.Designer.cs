namespace UserInterface.UserControlsTab
{
    partial class UC_Tab6
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeaderTab6 = new System.Windows.Forms.Panel();
            this.lblHeaderTab6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tpnlTesting = new System.Windows.Forms.TableLayoutPanel();
            this.customRowPanelData1 = new UserInterface.FormAssets.CustomRowOfLabels();
            this.pnlHeaderTab6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderTab6
            // 
            this.pnlHeaderTab6.BackColor = System.Drawing.Color.White;
            this.pnlHeaderTab6.Controls.Add(this.lblHeaderTab6);
            this.pnlHeaderTab6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderTab6.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderTab6.Name = "pnlHeaderTab6";
            this.pnlHeaderTab6.Size = new System.Drawing.Size(1050, 65);
            this.pnlHeaderTab6.TabIndex = 6;
            // 
            // lblHeaderTab6
            // 
            this.lblHeaderTab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeaderTab6.AutoSize = true;
            this.lblHeaderTab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTab6.Location = new System.Drawing.Point(431, 21);
            this.lblHeaderTab6.Name = "lblHeaderTab6";
            this.lblHeaderTab6.Size = new System.Drawing.Size(58, 25);
            this.lblHeaderTab6.TabIndex = 0;
            this.lblHeaderTab6.Text = "Tab6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(998, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpnlTesting
            // 
            this.tpnlTesting.AutoScroll = true;
            this.tpnlTesting.BackColor = System.Drawing.Color.Yellow;
            this.tpnlTesting.ColumnCount = 1;
            this.tpnlTesting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlTesting.Location = new System.Drawing.Point(28, 146);
            this.tpnlTesting.Name = "tpnlTesting";
            this.tpnlTesting.RowCount = 4;
            this.tpnlTesting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlTesting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlTesting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlTesting.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpnlTesting.Size = new System.Drawing.Size(1045, 391);
            this.tpnlTesting.TabIndex = 18;
            // 
            // customRowPanelData1
            // 
            this.customRowPanelData1.Column1Text = "1a";
            this.customRowPanelData1.Column2Text = "2b";
            this.customRowPanelData1.Column3Text = "3c";
            this.customRowPanelData1.Column4Text = "d4";
            this.customRowPanelData1.Column5Text = "e5";
            this.customRowPanelData1.Column6Text = "f6";
            this.customRowPanelData1.Column7Text = "g7";
            this.customRowPanelData1.DistanceBetweenLabels = 130;
            this.customRowPanelData1.DistanceIndent = 0;
            this.customRowPanelData1.Font = new System.Drawing.Font("Arial", 11F);
            this.customRowPanelData1.Location = new System.Drawing.Point(28, 93);
            this.customRowPanelData1.Margin = new System.Windows.Forms.Padding(0);
            this.customRowPanelData1.Name = "customRowPanelData1";
            this.customRowPanelData1.Padding = new System.Windows.Forms.Padding(5);
            this.customRowPanelData1.Size = new System.Drawing.Size(826, 23);
            this.customRowPanelData1.TabIndex = 19;
            this.customRowPanelData1.Text = "customRowPanelData1";
            // 
            // UC_Tab6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customRowPanelData1);
            this.Controls.Add(this.tpnlTesting);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlHeaderTab6);
            this.Name = "UC_Tab6";
            this.Size = new System.Drawing.Size(1050, 640);
            this.pnlHeaderTab6.ResumeLayout(false);
            this.pnlHeaderTab6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderTab6;
        private System.Windows.Forms.Label lblHeaderTab6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tpnlTesting;
        private FormAssets.CustomRowOfLabels customRowPanelData1;
    }
}
