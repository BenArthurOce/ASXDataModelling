﻿namespace UserInterface.Forms
{
    partial class CreateNewTransactionForm
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
            this.lblContractNote = new System.Windows.Forms.Label();
            this.lblASXCode = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblTradeValue = new System.Windows.Forms.Label();
            this.lblBrokerage = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.tBoxContractNote = new System.Windows.Forms.TextBox();
            this.tBoxASXCode = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.tBoxQuantity = new System.Windows.Forms.TextBox();
            this.tBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.tBoxTradeValue = new System.Windows.Forms.TextBox();
            this.tBoxBrokerage = new System.Windows.Forms.TextBox();
            this.tBoxTotalValue = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPortfolioOwner = new System.Windows.Forms.Label();
            this.tBoxPortfolioOwner = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblContractNote
            // 
            this.lblContractNote.AutoSize = true;
            this.lblContractNote.Location = new System.Drawing.Point(28, 116);
            this.lblContractNote.Name = "lblContractNote";
            this.lblContractNote.Size = new System.Drawing.Size(73, 13);
            this.lblContractNote.TabIndex = 0;
            this.lblContractNote.Text = "Contract Note";
            // 
            // lblASXCode
            // 
            this.lblASXCode.AutoSize = true;
            this.lblASXCode.Location = new System.Drawing.Point(28, 179);
            this.lblASXCode.Name = "lblASXCode";
            this.lblASXCode.Size = new System.Drawing.Size(53, 13);
            this.lblASXCode.TabIndex = 1;
            this.lblASXCode.Text = "ASXCode";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(28, 255);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(28, 336);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(403, 50);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(406, 114);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 5;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblTradeValue
            // 
            this.lblTradeValue.AutoSize = true;
            this.lblTradeValue.Location = new System.Drawing.Point(406, 169);
            this.lblTradeValue.Name = "lblTradeValue";
            this.lblTradeValue.Size = new System.Drawing.Size(65, 13);
            this.lblTradeValue.TabIndex = 6;
            this.lblTradeValue.Text = "Trade Value";
            // 
            // lblBrokerage
            // 
            this.lblBrokerage.AutoSize = true;
            this.lblBrokerage.Location = new System.Drawing.Point(406, 222);
            this.lblBrokerage.Name = "lblBrokerage";
            this.lblBrokerage.Size = new System.Drawing.Size(56, 13);
            this.lblBrokerage.TabIndex = 7;
            this.lblBrokerage.Text = "Brokerage";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(406, 278);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(61, 13);
            this.lblTotalValue.TabIndex = 8;
            this.lblTotalValue.Text = "Total Value";
            // 
            // tBoxContractNote
            // 
            this.tBoxContractNote.Location = new System.Drawing.Point(133, 108);
            this.tBoxContractNote.Name = "tBoxContractNote";
            this.tBoxContractNote.Size = new System.Drawing.Size(100, 20);
            this.tBoxContractNote.TabIndex = 9;
            // 
            // tBoxASXCode
            // 
            this.tBoxASXCode.Location = new System.Drawing.Point(133, 171);
            this.tBoxASXCode.Name = "tBoxASXCode";
            this.tBoxASXCode.Size = new System.Drawing.Size(100, 20);
            this.tBoxASXCode.TabIndex = 10;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(133, 255);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 11;
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            "Buy",
            "Sell",
            "Drp",
            "Other"});
            this.cboxType.Location = new System.Drawing.Point(133, 336);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(121, 21);
            this.cboxType.TabIndex = 12;
            // 
            // tBoxQuantity
            // 
            this.tBoxQuantity.Location = new System.Drawing.Point(499, 50);
            this.tBoxQuantity.Name = "tBoxQuantity";
            this.tBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.tBoxQuantity.TabIndex = 13;
            this.tBoxQuantity.TextChanged += new System.EventHandler(this.tBoxQuantity_TextChanged);
            this.tBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxQuantity_KeyPress);
            // 
            // tBoxUnitPrice
            // 
            this.tBoxUnitPrice.Location = new System.Drawing.Point(499, 114);
            this.tBoxUnitPrice.Name = "tBoxUnitPrice";
            this.tBoxUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tBoxUnitPrice.TabIndex = 14;
            this.tBoxUnitPrice.TextChanged += new System.EventHandler(this.tBoxUnitPrice_TextChanged);
            this.tBoxUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxUnitPrice_KeyPress);
            // 
            // tBoxTradeValue
            // 
            this.tBoxTradeValue.Location = new System.Drawing.Point(499, 169);
            this.tBoxTradeValue.Name = "tBoxTradeValue";
            this.tBoxTradeValue.Size = new System.Drawing.Size(100, 20);
            this.tBoxTradeValue.TabIndex = 15;
            this.tBoxTradeValue.TextChanged += new System.EventHandler(this.tBoxTradeValue_TextChanged);
            this.tBoxTradeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxTradeValue_KeyPress);
            // 
            // tBoxBrokerage
            // 
            this.tBoxBrokerage.Location = new System.Drawing.Point(499, 222);
            this.tBoxBrokerage.Name = "tBoxBrokerage";
            this.tBoxBrokerage.Size = new System.Drawing.Size(100, 20);
            this.tBoxBrokerage.TabIndex = 16;
            this.tBoxBrokerage.TextChanged += new System.EventHandler(this.tBoxBrokerage_TextChanged);
            this.tBoxBrokerage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxBrokerage_KeyPress);
            // 
            // tBoxTotalValue
            // 
            this.tBoxTotalValue.Location = new System.Drawing.Point(499, 278);
            this.tBoxTotalValue.Name = "tBoxTotalValue";
            this.tBoxTotalValue.Size = new System.Drawing.Size(100, 20);
            this.tBoxTotalValue.TabIndex = 17;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(645, 294);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPortfolioOwner
            // 
            this.lblPortfolioOwner.AutoSize = true;
            this.lblPortfolioOwner.Location = new System.Drawing.Point(25, 43);
            this.lblPortfolioOwner.Name = "lblPortfolioOwner";
            this.lblPortfolioOwner.Size = new System.Drawing.Size(79, 13);
            this.lblPortfolioOwner.TabIndex = 19;
            this.lblPortfolioOwner.Text = "Portfolio Owner";
            // 
            // tBoxPortfolioOwner
            // 
            this.tBoxPortfolioOwner.Location = new System.Drawing.Point(133, 43);
            this.tBoxPortfolioOwner.Name = "tBoxPortfolioOwner";
            this.tBoxPortfolioOwner.Size = new System.Drawing.Size(100, 20);
            this.tBoxPortfolioOwner.TabIndex = 20;
            // 
            // CreateNewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.tBoxPortfolioOwner);
            this.Controls.Add(this.lblPortfolioOwner);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tBoxTotalValue);
            this.Controls.Add(this.tBoxBrokerage);
            this.Controls.Add(this.tBoxTradeValue);
            this.Controls.Add(this.tBoxUnitPrice);
            this.Controls.Add(this.tBoxQuantity);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tBoxASXCode);
            this.Controls.Add(this.tBoxContractNote);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblBrokerage);
            this.Controls.Add(this.lblTradeValue);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblASXCode);
            this.Controls.Add(this.lblContractNote);
            this.Name = "CreateNewTransactionForm";
            this.Text = "CreateNewTransactionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContractNote;
        private System.Windows.Forms.Label lblASXCode;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblTradeValue;
        private System.Windows.Forms.Label lblBrokerage;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.TextBox tBoxContractNote;
        private System.Windows.Forms.TextBox tBoxASXCode;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.TextBox tBoxQuantity;
        private System.Windows.Forms.TextBox tBoxUnitPrice;
        private System.Windows.Forms.TextBox tBoxTradeValue;
        private System.Windows.Forms.TextBox tBoxBrokerage;
        private System.Windows.Forms.TextBox tBoxTotalValue;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPortfolioOwner;
        private System.Windows.Forms.TextBox tBoxPortfolioOwner;
    }
}