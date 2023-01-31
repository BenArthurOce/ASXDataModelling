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
            this.pnlHeaderPortfolioSummary = new System.Windows.Forms.Panel();
            this.lblHeaderPortfolioSummary = new System.Windows.Forms.Label();
            this.dgvPortfolioItems = new System.Windows.Forms.DataGridView();
            this.tBoxPortfolioName = new System.Windows.Forms.TextBox();
            this.tBoxPortfolioStartDate = new System.Windows.Forms.TextBox();
            this.tBoxPortfolioEndDate = new System.Windows.Forms.TextBox();
            this.btnPortfolioGenerate = new System.Windows.Forms.Button();
            this.pnlHeaderPortfolioSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortfolioItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeaderPortfolioSummary
            // 
            this.pnlHeaderPortfolioSummary.BackColor = System.Drawing.Color.White;
            this.pnlHeaderPortfolioSummary.Controls.Add(this.lblHeaderPortfolioSummary);
            this.pnlHeaderPortfolioSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderPortfolioSummary.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderPortfolioSummary.Name = "pnlHeaderPortfolioSummary";
            this.pnlHeaderPortfolioSummary.Size = new System.Drawing.Size(1248, 65);
            this.pnlHeaderPortfolioSummary.TabIndex = 6;
            // 
            // lblHeaderPortfolioSummary
            // 
            this.lblHeaderPortfolioSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeaderPortfolioSummary.AutoSize = true;
            this.lblHeaderPortfolioSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderPortfolioSummary.Location = new System.Drawing.Point(530, 21);
            this.lblHeaderPortfolioSummary.Name = "lblHeaderPortfolioSummary";
            this.lblHeaderPortfolioSummary.Size = new System.Drawing.Size(171, 25);
            this.lblHeaderPortfolioSummary.TabIndex = 0;
            this.lblHeaderPortfolioSummary.Text = "Portfolio Summary";
            // 
            // dgvPortfolioItems
            // 
            this.dgvPortfolioItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPortfolioItems.Location = new System.Drawing.Point(30, 139);
            this.dgvPortfolioItems.Name = "dgvPortfolioItems";
            this.dgvPortfolioItems.Size = new System.Drawing.Size(1167, 370);
            this.dgvPortfolioItems.TabIndex = 7;
            // 
            // tBoxPortfolioName
            // 
            this.tBoxPortfolioName.Location = new System.Drawing.Point(30, 84);
            this.tBoxPortfolioName.Name = "tBoxPortfolioName";
            this.tBoxPortfolioName.Size = new System.Drawing.Size(100, 20);
            this.tBoxPortfolioName.TabIndex = 8;
            // 
            // tBoxPortfolioStartDate
            // 
            this.tBoxPortfolioStartDate.Location = new System.Drawing.Point(208, 83);
            this.tBoxPortfolioStartDate.Name = "tBoxPortfolioStartDate";
            this.tBoxPortfolioStartDate.Size = new System.Drawing.Size(100, 20);
            this.tBoxPortfolioStartDate.TabIndex = 9;
            // 
            // tBoxPortfolioEndDate
            // 
            this.tBoxPortfolioEndDate.Location = new System.Drawing.Point(404, 84);
            this.tBoxPortfolioEndDate.Name = "tBoxPortfolioEndDate";
            this.tBoxPortfolioEndDate.Size = new System.Drawing.Size(100, 20);
            this.tBoxPortfolioEndDate.TabIndex = 10;
            // 
            // btnPortfolioGenerate
            // 
            this.btnPortfolioGenerate.Location = new System.Drawing.Point(587, 80);
            this.btnPortfolioGenerate.Name = "btnPortfolioGenerate";
            this.btnPortfolioGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnPortfolioGenerate.TabIndex = 11;
            this.btnPortfolioGenerate.Text = "Generate";
            this.btnPortfolioGenerate.UseVisualStyleBackColor = true;
            this.btnPortfolioGenerate.Click += new System.EventHandler(this.btnPortfolioGenerate_Click);
            // 
            // UC_Tab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPortfolioGenerate);
            this.Controls.Add(this.tBoxPortfolioEndDate);
            this.Controls.Add(this.tBoxPortfolioStartDate);
            this.Controls.Add(this.tBoxPortfolioName);
            this.Controls.Add(this.dgvPortfolioItems);
            this.Controls.Add(this.pnlHeaderPortfolioSummary);
            this.Name = "UC_Tab2";
            this.Size = new System.Drawing.Size(1248, 640);
            this.pnlHeaderPortfolioSummary.ResumeLayout(false);
            this.pnlHeaderPortfolioSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortfolioItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderPortfolioSummary;
        private System.Windows.Forms.Label lblHeaderPortfolioSummary;
        private System.Windows.Forms.DataGridView dgvPortfolioItems;
        private System.Windows.Forms.TextBox tBoxPortfolioName;
        private System.Windows.Forms.TextBox tBoxPortfolioStartDate;
        private System.Windows.Forms.TextBox tBoxPortfolioEndDate;
        private System.Windows.Forms.Button btnPortfolioGenerate;
    }
}
