namespace UserInterface
{
    partial class CreateNewTransactionType
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
            this.lbl_TransType = new System.Windows.Forms.Label();
            this.tbox_TransType = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TransType
            // 
            this.lbl_TransType.AutoSize = true;
            this.lbl_TransType.Location = new System.Drawing.Point(56, 59);
            this.lbl_TransType.Name = "lbl_TransType";
            this.lbl_TransType.Size = new System.Drawing.Size(61, 13);
            this.lbl_TransType.TabIndex = 0;
            this.lbl_TransType.Text = "TransType:";
            // 
            // tbox_TransType
            // 
            this.tbox_TransType.Location = new System.Drawing.Point(157, 56);
            this.tbox_TransType.Name = "tbox_TransType";
            this.tbox_TransType.Size = new System.Drawing.Size(100, 20);
            this.tbox_TransType.TabIndex = 1;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(300, 56);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // CreateNewTransactionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 199);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tbox_TransType);
            this.Controls.Add(this.lbl_TransType);
            this.Name = "CreateNewTransactionType";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TransType;
        private System.Windows.Forms.TextBox tbox_TransType;
        private System.Windows.Forms.Button btn_Submit;
    }
}

