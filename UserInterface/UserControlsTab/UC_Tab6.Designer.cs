﻿namespace UserInterface.UserControlsTab
{
    partial class UC_Tab6
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
            this.pnlHeaderTab6 = new System.Windows.Forms.Panel();
            this.lblHeaderTab6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCollapseAll = new System.Windows.Forms.Button();
            this.btnTestExpand = new System.Windows.Forms.Button();
            this.fpnlTesting = new UserInterface.FormAssets.CustomFlowPanel();
            this.pnlHeaderTab6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderTab6
            // 
            this.pnlHeaderTab6.BackColor = System.Drawing.Color.White;
            this.pnlHeaderTab6.Controls.Add(this.lblHeaderTab6);
            this.pnlHeaderTab6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderTab6.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderTab6.Name = "pnlHeaderTab6";
            this.pnlHeaderTab6.Size = new System.Drawing.Size(1248, 65);
            this.pnlHeaderTab6.TabIndex = 6;
            // 
            // lblHeaderTab6
            // 
            this.lblHeaderTab6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeaderTab6.AutoSize = true;
            this.lblHeaderTab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTab6.Location = new System.Drawing.Point(530, 21);
            this.lblHeaderTab6.Name = "lblHeaderTab6";
            this.lblHeaderTab6.Size = new System.Drawing.Size(58, 25);
            this.lblHeaderTab6.TabIndex = 0;
            this.lblHeaderTab6.Text = "Tab6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCollapseAll
            // 
            this.btnCollapseAll.Location = new System.Drawing.Point(656, 145);
            this.btnCollapseAll.Name = "btnCollapseAll";
            this.btnCollapseAll.Size = new System.Drawing.Size(75, 23);
            this.btnCollapseAll.TabIndex = 13;
            this.btnCollapseAll.Text = "CollapseAll";
            this.btnCollapseAll.UseVisualStyleBackColor = true;
            this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
            // 
            // btnTestExpand
            // 
            this.btnTestExpand.Location = new System.Drawing.Point(656, 196);
            this.btnTestExpand.Name = "btnTestExpand";
            this.btnTestExpand.Size = new System.Drawing.Size(75, 23);
            this.btnTestExpand.TabIndex = 14;
            this.btnTestExpand.Text = "TestExpand";
            this.btnTestExpand.UseVisualStyleBackColor = true;
            this.btnTestExpand.Click += new System.EventHandler(this.btnTestExpand_Click);
            // 
            // fpnlTesting
            // 
            this.fpnlTesting.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fpnlTesting.Location = new System.Drawing.Point(68, 161);
            this.fpnlTesting.Name = "fpnlTesting";
            this.fpnlTesting.Size = new System.Drawing.Size(300, 400);
            this.fpnlTesting.TabIndex = 12;
            // 
            // UC_Tab6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTestExpand);
            this.Controls.Add(this.btnCollapseAll);
            this.Controls.Add(this.fpnlTesting);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlHeaderTab6);
            this.Name = "UC_Tab6";
            this.Size = new System.Drawing.Size(1248, 640);
            this.pnlHeaderTab6.ResumeLayout(false);
            this.pnlHeaderTab6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderTab6;
        private System.Windows.Forms.Label lblHeaderTab6;
        private System.Windows.Forms.Button button1;
        private FormAssets.CustomFlowPanel fpnlTesting;
        private System.Windows.Forms.Button btnCollapseAll;
        private System.Windows.Forms.Button btnTestExpand;
    }
}