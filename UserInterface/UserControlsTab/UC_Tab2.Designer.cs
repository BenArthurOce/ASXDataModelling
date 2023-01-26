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
            this.pnlHeaderPortfolioSummary.SuspendLayout();
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
            // UC_Tab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeaderPortfolioSummary);
            this.Name = "UC_Tab2";
            this.Size = new System.Drawing.Size(1248, 640);
            this.pnlHeaderPortfolioSummary.ResumeLayout(false);
            this.pnlHeaderPortfolioSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderPortfolioSummary;
        private System.Windows.Forms.Label lblHeaderPortfolioSummary;
    }
}
