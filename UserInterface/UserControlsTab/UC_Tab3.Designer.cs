namespace UserInterface.UserControlsTab
{
    partial class UC_Tab3
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
            this.pnlHeaderShareTransactions = new System.Windows.Forms.Panel();
            this.lblHeaderShareTransactions = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblFilters = new System.Windows.Forms.Label();
            this.fpnlShareTransactions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.pnlHeaderShareTransactions.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderShareTransactions
            // 
            this.pnlHeaderShareTransactions.BackColor = System.Drawing.Color.White;
            this.pnlHeaderShareTransactions.Controls.Add(this.lblHeaderShareTransactions);
            this.pnlHeaderShareTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderShareTransactions.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderShareTransactions.Name = "pnlHeaderShareTransactions";
            this.pnlHeaderShareTransactions.Size = new System.Drawing.Size(1248, 65);
            this.pnlHeaderShareTransactions.TabIndex = 6;
            // 
            // lblHeaderShareTransactions
            // 
            this.lblHeaderShareTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeaderShareTransactions.AutoSize = true;
            this.lblHeaderShareTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderShareTransactions.Location = new System.Drawing.Point(530, 21);
            this.lblHeaderShareTransactions.Name = "lblHeaderShareTransactions";
            this.lblHeaderShareTransactions.Size = new System.Drawing.Size(183, 25);
            this.lblHeaderShareTransactions.TabIndex = 0;
            this.lblHeaderShareTransactions.Text = "Share Transactions";
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnNewTransaction);
            this.pnlFilter.Controls.Add(this.btnGenerate);
            this.pnlFilter.Controls.Add(this.lblFilters);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 65);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1248, 69);
            this.pnlFilter.TabIndex = 7;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(1146, 9);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilters.Location = new System.Drawing.Point(21, 13);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(56, 20);
            this.lblFilters.TabIndex = 0;
            this.lblFilters.Text = "Filters:";
            // 
            // fpnlShareTransactions
            // 
            this.fpnlShareTransactions.AutoScroll = true;
            this.fpnlShareTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlShareTransactions.Location = new System.Drawing.Point(0, 134);
            this.fpnlShareTransactions.Name = "fpnlShareTransactions";
            this.fpnlShareTransactions.Size = new System.Drawing.Size(1248, 506);
            this.fpnlShareTransactions.TabIndex = 8;
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Location = new System.Drawing.Point(1028, 13);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnNewTransaction.TabIndex = 2;
            this.btnNewTransaction.Text = "Add";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // UC_Tab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpnlShareTransactions);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlHeaderShareTransactions);
            this.Name = "UC_Tab3";
            this.Size = new System.Drawing.Size(1248, 640);
            this.pnlHeaderShareTransactions.ResumeLayout(false);
            this.pnlHeaderShareTransactions.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderShareTransactions;
        private System.Windows.Forms.Label lblHeaderShareTransactions;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.FlowLayoutPanel fpnlShareTransactions;
        private System.Windows.Forms.Button btnNewTransaction;
    }
}
