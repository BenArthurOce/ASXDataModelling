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
            this.fpnlShareTransactions = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlHeaderShareTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderShareTransactions
            // 
            this.pnlHeaderShareTransactions.BackColor = System.Drawing.Color.White;
            this.pnlHeaderShareTransactions.Controls.Add(this.button1);
            this.pnlHeaderShareTransactions.Controls.Add(this.lblHeaderShareTransactions);
            this.pnlHeaderShareTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderShareTransactions.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderShareTransactions.Name = "pnlHeaderShareTransactions";
            this.pnlHeaderShareTransactions.Size = new System.Drawing.Size(1262, 65);
            this.pnlHeaderShareTransactions.TabIndex = 0;
            // 
            // lblHeaderShareTransactions
            // 
            this.lblHeaderShareTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeaderShareTransactions.AutoSize = true;
            this.lblHeaderShareTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderShareTransactions.Location = new System.Drawing.Point(537, 21);
            this.lblHeaderShareTransactions.Name = "lblHeaderShareTransactions";
            this.lblHeaderShareTransactions.Size = new System.Drawing.Size(183, 25);
            this.lblHeaderShareTransactions.TabIndex = 0;
            this.lblHeaderShareTransactions.Text = "Share Transactions";
            // 
            // fpnlShareTransactions
            // 
            this.fpnlShareTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlShareTransactions.Location = new System.Drawing.Point(0, 65);
            this.fpnlShareTransactions.Name = "fpnlShareTransactions";
            this.fpnlShareTransactions.Size = new System.Drawing.Size(1262, 575);
            this.fpnlShareTransactions.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_Tab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpnlShareTransactions);
            this.Controls.Add(this.pnlHeaderShareTransactions);
            this.Name = "UC_Tab3";
            this.Size = new System.Drawing.Size(1262, 640);
            this.pnlHeaderShareTransactions.ResumeLayout(false);
            this.pnlHeaderShareTransactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderShareTransactions;
        private System.Windows.Forms.Label lblHeaderShareTransactions;
        private System.Windows.Forms.FlowLayoutPanel fpnlShareTransactions;
        private System.Windows.Forms.Button button1;
    }
}
