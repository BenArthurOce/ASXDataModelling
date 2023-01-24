namespace UserInterface.UserControlsTab
{
    partial class UC_Tab1
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
            this.btn_tab1_Display = new System.Windows.Forms.Button();
            this.tbox_tab1_ASXShare = new System.Windows.Forms.TextBox();
            this.dgvPriceHistory1 = new System.Windows.Forms.DataGridView();
            this.lbl_tab1_ASXShare = new System.Windows.Forms.Label();
            this.lbl_tab1_Year = new System.Windows.Forms.Label();
            this.tbox_tab1_Year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_tab1_PriceType = new System.Windows.Forms.ComboBox();
            this.dgvPriceHistory2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceHistory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceHistory2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tab1_Display
            // 
            this.btn_tab1_Display.Location = new System.Drawing.Point(532, 36);
            this.btn_tab1_Display.Name = "btn_tab1_Display";
            this.btn_tab1_Display.Size = new System.Drawing.Size(75, 23);
            this.btn_tab1_Display.TabIndex = 4;
            this.btn_tab1_Display.Text = "Display";
            this.btn_tab1_Display.UseVisualStyleBackColor = true;
            this.btn_tab1_Display.Click += new System.EventHandler(this.btn_tab2_Display_Click);
            // 
            // tbox_tab1_ASXShare
            // 
            this.tbox_tab1_ASXShare.Location = new System.Drawing.Point(194, 38);
            this.tbox_tab1_ASXShare.Name = "tbox_tab1_ASXShare";
            this.tbox_tab1_ASXShare.Size = new System.Drawing.Size(100, 20);
            this.tbox_tab1_ASXShare.TabIndex = 2;
            // 
            // dgvPriceHistory1
            // 
            this.dgvPriceHistory1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPriceHistory1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriceHistory1.Location = new System.Drawing.Point(17, 86);
            this.dgvPriceHistory1.Name = "dgvPriceHistory1";
            this.dgvPriceHistory1.Size = new System.Drawing.Size(606, 345);
            this.dgvPriceHistory1.TabIndex = 3;
            // 
            // lbl_tab1_ASXShare
            // 
            this.lbl_tab1_ASXShare.AutoSize = true;
            this.lbl_tab1_ASXShare.Location = new System.Drawing.Point(194, 19);
            this.lbl_tab1_ASXShare.Name = "lbl_tab1_ASXShare";
            this.lbl_tab1_ASXShare.Size = new System.Drawing.Size(56, 13);
            this.lbl_tab1_ASXShare.TabIndex = 4;
            this.lbl_tab1_ASXShare.Text = "ASXShare";
            // 
            // lbl_tab1_Year
            // 
            this.lbl_tab1_Year.AutoSize = true;
            this.lbl_tab1_Year.Location = new System.Drawing.Point(17, 19);
            this.lbl_tab1_Year.Name = "lbl_tab1_Year";
            this.lbl_tab1_Year.Size = new System.Drawing.Size(29, 13);
            this.lbl_tab1_Year.TabIndex = 5;
            this.lbl_tab1_Year.Text = "Year";
            // 
            // tbox_tab1_Year
            // 
            this.tbox_tab1_Year.Location = new System.Drawing.Point(17, 36);
            this.tbox_tab1_Year.Name = "tbox_tab1_Year";
            this.tbox_tab1_Year.Size = new System.Drawing.Size(100, 20);
            this.tbox_tab1_Year.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "PriceType";
            // 
            // cbox_tab1_PriceType
            // 
            this.cbox_tab1_PriceType.FormattingEnabled = true;
            this.cbox_tab1_PriceType.Items.AddRange(new object[] {
            "Open",
            "Close",
            "High",
            "Low"});
            this.cbox_tab1_PriceType.Location = new System.Drawing.Point(354, 38);
            this.cbox_tab1_PriceType.Name = "cbox_tab1_PriceType";
            this.cbox_tab1_PriceType.Size = new System.Drawing.Size(121, 21);
            this.cbox_tab1_PriceType.TabIndex = 3;
            // 
            // dgvPriceHistory2
            // 
            this.dgvPriceHistory2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPriceHistory2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriceHistory2.Location = new System.Drawing.Point(629, 86);
            this.dgvPriceHistory2.Name = "dgvPriceHistory2";
            this.dgvPriceHistory2.Size = new System.Drawing.Size(606, 345);
            this.dgvPriceHistory2.TabIndex = 9;
            // 
            // UC_Tab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPriceHistory2);
            this.Controls.Add(this.cbox_tab1_PriceType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbox_tab1_Year);
            this.Controls.Add(this.lbl_tab1_Year);
            this.Controls.Add(this.lbl_tab1_ASXShare);
            this.Controls.Add(this.dgvPriceHistory1);
            this.Controls.Add(this.tbox_tab1_ASXShare);
            this.Controls.Add(this.btn_tab1_Display);
            this.Name = "UC_Tab1";
            this.Size = new System.Drawing.Size(1262, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceHistory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceHistory2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_tab1_Display;
        private System.Windows.Forms.TextBox tbox_tab1_ASXShare;
        private System.Windows.Forms.DataGridView dgvPriceHistory1;
        private System.Windows.Forms.Label lbl_tab1_ASXShare;
        private System.Windows.Forms.Label lbl_tab1_Year;
        private System.Windows.Forms.TextBox tbox_tab1_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_tab1_PriceType;
        private System.Windows.Forms.DataGridView dgvPriceHistory2;
    }
}
