namespace FormUI
{
    partial class Dashboard
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
            this.lstbox_ASXDataFound = new System.Windows.Forms.ListBox();
            this.tbox_ASXInput = new System.Windows.Forms.TextBox();
            this.lbl_ASXInput = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_ASXDataFound = new System.Windows.Forms.DataGridView();
            this.SharePriceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASXCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASXDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumeTraded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ASXDataFound)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbox_ASXDataFound
            // 
            this.lstbox_ASXDataFound.FormattingEnabled = true;
            this.lstbox_ASXDataFound.ItemHeight = 20;
            this.lstbox_ASXDataFound.Location = new System.Drawing.Point(28, 101);
            this.lstbox_ASXDataFound.Name = "lstbox_ASXDataFound";
            this.lstbox_ASXDataFound.Size = new System.Drawing.Size(397, 344);
            this.lstbox_ASXDataFound.TabIndex = 0;
            // 
            // tbox_ASXInput
            // 
            this.tbox_ASXInput.Location = new System.Drawing.Point(124, 37);
            this.tbox_ASXInput.Name = "tbox_ASXInput";
            this.tbox_ASXInput.Size = new System.Drawing.Size(244, 26);
            this.tbox_ASXInput.TabIndex = 1;
            // 
            // lbl_ASXInput
            // 
            this.lbl_ASXInput.AutoSize = true;
            this.lbl_ASXInput.Location = new System.Drawing.Point(24, 43);
            this.lbl_ASXInput.Name = "lbl_ASXInput";
            this.lbl_ASXInput.Size = new System.Drawing.Size(79, 20);
            this.lbl_ASXInput.TabIndex = 2;
            this.lbl_ASXInput.Text = "ASXInput";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(416, 35);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(102, 36);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_ASXDataFound
            // 
            this.dgv_ASXDataFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ASXDataFound.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SharePriceID,
            this.ASXCode,
            this.ASXDate,
            this.PriceOpen,
            this.PriceHigh,
            this.PriceLow,
            this.PriceClose,
            this.VolumeTraded});
            this.dgv_ASXDataFound.Location = new System.Drawing.Point(460, 101);
            this.dgv_ASXDataFound.Name = "dgv_ASXDataFound";
            this.dgv_ASXDataFound.Size = new System.Drawing.Size(900, 344);
            this.dgv_ASXDataFound.TabIndex = 4;
            // 
            // SharePriceID
            // 
            this.SharePriceID.HeaderText = "SharePriceID";
            this.SharePriceID.Name = "SharePriceID";
            // 
            // ASXCode
            // 
            this.ASXCode.HeaderText = "ASXCode";
            this.ASXCode.Name = "ASXCode";
            // 
            // ASXDate
            // 
            this.ASXDate.HeaderText = "ASXDate";
            this.ASXDate.Name = "ASXDate";
            // 
            // PriceOpen
            // 
            this.PriceOpen.HeaderText = "PriceOpen";
            this.PriceOpen.Name = "PriceOpen";
            // 
            // PriceHigh
            // 
            this.PriceHigh.HeaderText = "PriceHigh";
            this.PriceHigh.Name = "PriceHigh";
            // 
            // PriceLow
            // 
            this.PriceLow.HeaderText = "PriceLow";
            this.PriceLow.Name = "PriceLow";
            // 
            // PriceClose
            // 
            this.PriceClose.HeaderText = "PriceClose";
            this.PriceClose.Name = "PriceClose";
            // 
            // VolumeTraded
            // 
            this.VolumeTraded.HeaderText = "VolumeTraded";
            this.VolumeTraded.Name = "VolumeTraded";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 485);
            this.Controls.Add(this.dgv_ASXDataFound);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_ASXInput);
            this.Controls.Add(this.tbox_ASXInput);
            this.Controls.Add(this.lstbox_ASXDataFound);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ASXDataFound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_ASXDataFound;
        private System.Windows.Forms.TextBox tbox_ASXInput;
        private System.Windows.Forms.Label lbl_ASXInput;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_ASXDataFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn SharePriceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASXCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASXDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolumeTraded;
    }
}

