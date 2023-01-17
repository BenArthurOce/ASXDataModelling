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
            this.lbl_tab1_About = new System.Windows.Forms.Label();
            this.tbox_tab1_About = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_tab1_About
            // 
            this.lbl_tab1_About.AutoSize = true;
            this.lbl_tab1_About.Location = new System.Drawing.Point(34, 31);
            this.lbl_tab1_About.Name = "lbl_tab1_About";
            this.lbl_tab1_About.Size = new System.Drawing.Size(35, 13);
            this.lbl_tab1_About.TabIndex = 0;
            this.lbl_tab1_About.Text = "About";
            // 
            // tbox_tab1_About
            // 
            this.tbox_tab1_About.Location = new System.Drawing.Point(37, 58);
            this.tbox_tab1_About.Name = "tbox_tab1_About";
            this.tbox_tab1_About.Size = new System.Drawing.Size(172, 20);
            this.tbox_tab1_About.TabIndex = 1;
            this.tbox_tab1_About.Text = "Input Some information here";
            // 
            // UC_Tab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbox_tab1_About);
            this.Controls.Add(this.lbl_tab1_About);
            this.Name = "UC_Tab1";
            this.Size = new System.Drawing.Size(1090, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tab1_About;
        private System.Windows.Forms.TextBox tbox_tab1_About;
    }
}
