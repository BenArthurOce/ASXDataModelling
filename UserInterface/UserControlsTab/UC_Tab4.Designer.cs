namespace UserInterface.UserControlsTab
{
    partial class UC_Tab4
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
            this.pnlHeaderPortfolioByDay = new System.Windows.Forms.Panel();
            this.lblHeaderPortfolioByDay = new System.Windows.Forms.Label();
            this.pnlHeaderPortfolioByDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderPortfolioByDay
            // 
            this.pnlHeaderPortfolioByDay.BackColor = System.Drawing.Color.White;
            this.pnlHeaderPortfolioByDay.Controls.Add(this.lblHeaderPortfolioByDay);
            this.pnlHeaderPortfolioByDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderPortfolioByDay.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderPortfolioByDay.Name = "pnlHeaderPortfolioByDay";
            this.pnlHeaderPortfolioByDay.Size = new System.Drawing.Size(1248, 65);
            this.pnlHeaderPortfolioByDay.TabIndex = 6;
            // 
            // lblHeaderPortfolioByDay
            // 
            this.lblHeaderPortfolioByDay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeaderPortfolioByDay.AutoSize = true;
            this.lblHeaderPortfolioByDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderPortfolioByDay.Location = new System.Drawing.Point(530, 21);
            this.lblHeaderPortfolioByDay.Name = "lblHeaderPortfolioByDay";
            this.lblHeaderPortfolioByDay.Size = new System.Drawing.Size(150, 25);
            this.lblHeaderPortfolioByDay.TabIndex = 0;
            this.lblHeaderPortfolioByDay.Text = "Portfolio By Day";
            // 
            // UC_Tab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeaderPortfolioByDay);
            this.Name = "UC_Tab4";
            this.Size = new System.Drawing.Size(1248, 640);
            this.pnlHeaderPortfolioByDay.ResumeLayout(false);
            this.pnlHeaderPortfolioByDay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderPortfolioByDay;
        private System.Windows.Forms.Label lblHeaderPortfolioByDay;
    }
}
