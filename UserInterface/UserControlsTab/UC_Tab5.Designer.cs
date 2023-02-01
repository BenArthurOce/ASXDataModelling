namespace UserInterface.UserControlsTab
{
    partial class UC_Tab5
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
            this.lblFilesQueuedForImport = new System.Windows.Forms.Label();
            this.dgvDocumentsQueued = new System.Windows.Forms.DataGridView();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUploaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFindFiles = new System.Windows.Forms.Button();
            this.btnSubmitFiles = new System.Windows.Forms.Button();
            this.lBoxDocumentUploadLog = new System.Windows.Forms.ListBox();
            this.pnlHeaderUploadPriceData = new System.Windows.Forms.Panel();
            this.lblHeaderUploadPriceData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentsQueued)).BeginInit();
            this.pnlHeaderUploadPriceData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilesQueuedForImport
            // 
            this.lblFilesQueuedForImport.AutoSize = true;
            this.lblFilesQueuedForImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesQueuedForImport.Location = new System.Drawing.Point(32, 112);
            this.lblFilesQueuedForImport.Name = "lblFilesQueuedForImport";
            this.lblFilesQueuedForImport.Size = new System.Drawing.Size(222, 25);
            this.lblFilesQueuedForImport.TabIndex = 0;
            this.lblFilesQueuedForImport.Text = "Files Queued For Import";
            // 
            // dgvDocumentsQueued
            // 
            this.dgvDocumentsQueued.AllowUserToAddRows = false;
            this.dgvDocumentsQueued.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentsQueued.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilePath,
            this.FileName,
            this.DateUploaded,
            this.FileSize,
            this.RowCount});
            this.dgvDocumentsQueued.Location = new System.Drawing.Point(35, 151);
            this.dgvDocumentsQueued.Name = "dgvDocumentsQueued";
            this.dgvDocumentsQueued.Size = new System.Drawing.Size(713, 360);
            this.dgvDocumentsQueued.TabIndex = 1;
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "File Path";
            this.FilePath.Name = "FilePath";
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            // 
            // DateUploaded
            // 
            this.DateUploaded.HeaderText = "Date Uploaded";
            this.DateUploaded.Name = "DateUploaded";
            // 
            // FileSize
            // 
            this.FileSize.HeaderText = "File Size";
            this.FileSize.Name = "FileSize";
            // 
            // RowCount
            // 
            this.RowCount.HeaderText = "Row Count";
            this.RowCount.Name = "RowCount";
            // 
            // btnFindFiles
            // 
            this.btnFindFiles.Location = new System.Drawing.Point(673, 112);
            this.btnFindFiles.Name = "btnFindFiles";
            this.btnFindFiles.Size = new System.Drawing.Size(75, 23);
            this.btnFindFiles.TabIndex = 2;
            this.btnFindFiles.Text = "Find Files";
            this.btnFindFiles.UseVisualStyleBackColor = true;
            this.btnFindFiles.Click += new System.EventHandler(this.btnFindFiles_Click);
            // 
            // btnSubmitFiles
            // 
            this.btnSubmitFiles.Location = new System.Drawing.Point(673, 541);
            this.btnSubmitFiles.Name = "btnSubmitFiles";
            this.btnSubmitFiles.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitFiles.TabIndex = 3;
            this.btnSubmitFiles.Text = "Submit Files";
            this.btnSubmitFiles.UseVisualStyleBackColor = true;
            this.btnSubmitFiles.Click += new System.EventHandler(this.btnSubmitFiles_Click);
            // 
            // lBoxDocumentUploadLog
            // 
            this.lBoxDocumentUploadLog.FormattingEnabled = true;
            this.lBoxDocumentUploadLog.Location = new System.Drawing.Point(810, 156);
            this.lBoxDocumentUploadLog.Name = "lBoxDocumentUploadLog";
            this.lBoxDocumentUploadLog.Size = new System.Drawing.Size(257, 355);
            this.lBoxDocumentUploadLog.TabIndex = 4;
            // 
            // pnlHeaderUploadPriceData
            // 
            this.pnlHeaderUploadPriceData.BackColor = System.Drawing.Color.White;
            this.pnlHeaderUploadPriceData.Controls.Add(this.lblHeaderUploadPriceData);
            this.pnlHeaderUploadPriceData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderUploadPriceData.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderUploadPriceData.Name = "pnlHeaderUploadPriceData";
            this.pnlHeaderUploadPriceData.Size = new System.Drawing.Size(1050, 65);
            this.pnlHeaderUploadPriceData.TabIndex = 5;
            // 
            // lblHeaderUploadPriceData
            // 
            this.lblHeaderUploadPriceData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeaderUploadPriceData.AutoSize = true;
            this.lblHeaderUploadPriceData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderUploadPriceData.Location = new System.Drawing.Point(431, 21);
            this.lblHeaderUploadPriceData.Name = "lblHeaderUploadPriceData";
            this.lblHeaderUploadPriceData.Size = new System.Drawing.Size(169, 25);
            this.lblHeaderUploadPriceData.TabIndex = 0;
            this.lblHeaderUploadPriceData.Text = "Upload Price Data";
            // 
            // UC_Tab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHeaderUploadPriceData);
            this.Controls.Add(this.lBoxDocumentUploadLog);
            this.Controls.Add(this.btnSubmitFiles);
            this.Controls.Add(this.btnFindFiles);
            this.Controls.Add(this.dgvDocumentsQueued);
            this.Controls.Add(this.lblFilesQueuedForImport);
            this.Name = "UC_Tab5";
            this.Size = new System.Drawing.Size(1050, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentsQueued)).EndInit();
            this.pnlHeaderUploadPriceData.ResumeLayout(false);
            this.pnlHeaderUploadPriceData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilesQueuedForImport;
        private System.Windows.Forms.DataGridView dgvDocumentsQueued;
        private System.Windows.Forms.Button btnFindFiles;
        private System.Windows.Forms.Button btnSubmitFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateUploaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowCount;
        private System.Windows.Forms.ListBox lBoxDocumentUploadLog;
        private System.Windows.Forms.Panel pnlHeaderUploadPriceData;
        private System.Windows.Forms.Label lblHeaderUploadPriceData;
    }
}
