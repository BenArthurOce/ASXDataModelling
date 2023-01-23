namespace UserInterface.UserControlsTab
{
    partial class UC_Tab2
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
            this.lbl_tab2_DisplayPriceInfo = new System.Windows.Forms.Label();
            this.btn_tab2_Display = new System.Windows.Forms.Button();
            this.tbox_tab2_ASXShare = new System.Windows.Forms.TextBox();
            this.dgv_tab2_PriceHistory = new System.Windows.Forms.DataGridView();
            this.lbl_tab2_ASXShare = new System.Windows.Forms.Label();
            this.lbl_tab2_Year = new System.Windows.Forms.Label();
            this.tbox_tab2_Year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_tab2_PriceType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tab2_PriceHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tab2_DisplayPriceInfo
            // 
            this.lbl_tab2_DisplayPriceInfo.AutoSize = true;
            this.lbl_tab2_DisplayPriceInfo.Location = new System.Drawing.Point(26, 32);
            this.lbl_tab2_DisplayPriceInfo.Name = "lbl_tab2_DisplayPriceInfo";
            this.lbl_tab2_DisplayPriceInfo.Size = new System.Drawing.Size(92, 13);
            this.lbl_tab2_DisplayPriceInfo.TabIndex = 0;
            this.lbl_tab2_DisplayPriceInfo.Text = "Display Price Info:";
            // 
            // btn_tab2_Display
            // 
            this.btn_tab2_Display.Location = new System.Drawing.Point(138, 182);
            this.btn_tab2_Display.Name = "btn_tab2_Display";
            this.btn_tab2_Display.Size = new System.Drawing.Size(75, 23);
            this.btn_tab2_Display.TabIndex = 1;
            this.btn_tab2_Display.Text = "Display";
            this.btn_tab2_Display.UseVisualStyleBackColor = true;
            this.btn_tab2_Display.Click += new System.EventHandler(this.btn_tab2_Display_Click);
            // 
            // tbox_tab2_ASXShare
            // 
            this.tbox_tab2_ASXShare.Location = new System.Drawing.Point(18, 184);
            this.tbox_tab2_ASXShare.Name = "tbox_tab2_ASXShare";
            this.tbox_tab2_ASXShare.Size = new System.Drawing.Size(100, 20);
            this.tbox_tab2_ASXShare.TabIndex = 2;
            // 
            // dgv_tab2_PriceHistory
            // 
            this.dgv_tab2_PriceHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tab2_PriceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tab2_PriceHistory.Location = new System.Drawing.Point(300, 32);
            this.dgv_tab2_PriceHistory.Name = "dgv_tab2_PriceHistory";
            this.dgv_tab2_PriceHistory.Size = new System.Drawing.Size(655, 345);
            this.dgv_tab2_PriceHistory.TabIndex = 3;
            // 
            // lbl_tab2_ASXShare
            // 
            this.lbl_tab2_ASXShare.AutoSize = true;
            this.lbl_tab2_ASXShare.Location = new System.Drawing.Point(18, 165);
            this.lbl_tab2_ASXShare.Name = "lbl_tab2_ASXShare";
            this.lbl_tab2_ASXShare.Size = new System.Drawing.Size(56, 13);
            this.lbl_tab2_ASXShare.TabIndex = 4;
            this.lbl_tab2_ASXShare.Text = "ASXShare";
            // 
            // lbl_tab2_Year
            // 
            this.lbl_tab2_Year.AutoSize = true;
            this.lbl_tab2_Year.Location = new System.Drawing.Point(18, 101);
            this.lbl_tab2_Year.Name = "lbl_tab2_Year";
            this.lbl_tab2_Year.Size = new System.Drawing.Size(29, 13);
            this.lbl_tab2_Year.TabIndex = 5;
            this.lbl_tab2_Year.Text = "Year";
            // 
            // tbox_tab2_Year
            // 
            this.tbox_tab2_Year.Location = new System.Drawing.Point(18, 118);
            this.tbox_tab2_Year.Name = "tbox_tab2_Year";
            this.tbox_tab2_Year.Size = new System.Drawing.Size(100, 20);
            this.tbox_tab2_Year.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PriceType";
            // 
            // cbox_tab2_PriceType
            // 
            this.cbox_tab2_PriceType.FormattingEnabled = true;
            this.cbox_tab2_PriceType.Items.AddRange(new object[] {
            "Open",
            "Close",
            "High",
            "Low"});
            this.cbox_tab2_PriceType.Location = new System.Drawing.Point(18, 264);
            this.cbox_tab2_PriceType.Name = "cbox_tab2_PriceType";
            this.cbox_tab2_PriceType.Size = new System.Drawing.Size(121, 21);
            this.cbox_tab2_PriceType.TabIndex = 8;
            // 
            // UC_Tab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbox_tab2_PriceType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_tab2_Year);
            this.Controls.Add(this.lbl_tab2_Year);
            this.Controls.Add(this.lbl_tab2_ASXShare);
            this.Controls.Add(this.dgv_tab2_PriceHistory);
            this.Controls.Add(this.tbox_tab2_ASXShare);
            this.Controls.Add(this.btn_tab2_Display);
            this.Controls.Add(this.lbl_tab2_DisplayPriceInfo);
            this.Name = "UC_Tab2";
            this.Size = new System.Drawing.Size(1090, 406);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tab2_PriceHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tab2_DisplayPriceInfo;
        private System.Windows.Forms.Button btn_tab2_Display;
        private System.Windows.Forms.TextBox tbox_tab2_ASXShare;
        private System.Windows.Forms.DataGridView dgv_tab2_PriceHistory;
        private System.Windows.Forms.Label lbl_tab2_ASXShare;
        private System.Windows.Forms.Label lbl_tab2_Year;
        private System.Windows.Forms.TextBox tbox_tab2_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_tab2_PriceType;
    }
}
