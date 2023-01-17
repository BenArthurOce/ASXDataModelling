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
            // UC_Tab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_tab2_DisplayPriceInfo);
            this.Name = "UC_Tab2";
            this.Size = new System.Drawing.Size(1090, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tab2_DisplayPriceInfo;
    }
}
