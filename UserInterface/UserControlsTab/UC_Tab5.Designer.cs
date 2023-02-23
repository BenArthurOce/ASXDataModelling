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
            this.tpnlInputs = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInputsRow1Col1 = new System.Windows.Forms.Panel();
            this.pnlInputsRow1Col2 = new System.Windows.Forms.Panel();
            this.pnlInputsRow1Col5 = new System.Windows.Forms.Panel();
            this.pnlInputsRow1Col6 = new System.Windows.Forms.Panel();
            this.pnlInputsRow1Col7 = new System.Windows.Forms.Panel();
            this.pnlInputsRow1Col8 = new System.Windows.Forms.Panel();
            this.tpnlOutputs = new System.Windows.Forms.TableLayoutPanel();
            this.pnlOutputsRow1Col1 = new System.Windows.Forms.Panel();
            this.pnlOutputsRow1Col2 = new System.Windows.Forms.Panel();
            this.pnlOutputsRow1Col8 = new System.Windows.Forms.Panel();
            this.pnlOutputsRow2Col1 = new System.Windows.Forms.Panel();
            this.pnlOutputsRow2Col2 = new System.Windows.Forms.Panel();
            this.pnlOutputsRow2Col3 = new System.Windows.Forms.Panel();
            this.pnlOutputsRow2Col4 = new System.Windows.Forms.Panel();
            this.pnlOutputsRow2Col5 = new System.Windows.Forms.Panel();
            this.pnlOutputsRow2Col6 = new System.Windows.Forms.Panel();
            this.pnlOutputsRow2Col7 = new System.Windows.Forms.Panel();
            this.pnlOutputsRow2Col8 = new System.Windows.Forms.Panel();
            this.pnlOutputsRow2Col9 = new System.Windows.Forms.Panel();
            this.pnlOutputsRow2Col10 = new System.Windows.Forms.Panel();
            this.lblFilesImported = new System.Windows.Forms.Label();
            this.pnlOutputsRow1Col10 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentsQueued)).BeginInit();
            this.pnlHeaderUploadPriceData.SuspendLayout();
            this.tpnlInputs.SuspendLayout();
            this.pnlInputsRow1Col2.SuspendLayout();
            this.pnlInputsRow1Col5.SuspendLayout();
            this.pnlInputsRow1Col6.SuspendLayout();
            this.pnlInputsRow1Col8.SuspendLayout();
            this.tpnlOutputs.SuspendLayout();
            this.pnlOutputsRow1Col2.SuspendLayout();
            this.pnlOutputsRow1Col8.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilesQueuedForImport
            // 
            this.lblFilesQueuedForImport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFilesQueuedForImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesQueuedForImport.Location = new System.Drawing.Point(0, 27);
            this.lblFilesQueuedForImport.Name = "lblFilesQueuedForImport";
            this.lblFilesQueuedForImport.Size = new System.Drawing.Size(295, 25);
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
            this.dgvDocumentsQueued.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocumentsQueued.Location = new System.Drawing.Point(0, 0);
            this.dgvDocumentsQueued.Name = "dgvDocumentsQueued";
            this.dgvDocumentsQueued.Size = new System.Drawing.Size(610, 370);
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
            this.btnFindFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFindFiles.Location = new System.Drawing.Point(0, 29);
            this.btnFindFiles.Name = "btnFindFiles";
            this.btnFindFiles.Size = new System.Drawing.Size(85, 23);
            this.btnFindFiles.TabIndex = 2;
            this.btnFindFiles.Text = "Find Files";
            this.btnFindFiles.UseVisualStyleBackColor = true;
            this.btnFindFiles.Click += new System.EventHandler(this.btnFindFiles_Click);
            // 
            // btnSubmitFiles
            // 
            this.btnSubmitFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmitFiles.Location = new System.Drawing.Point(0, 29);
            this.btnSubmitFiles.Name = "btnSubmitFiles";
            this.btnSubmitFiles.Size = new System.Drawing.Size(85, 23);
            this.btnSubmitFiles.TabIndex = 3;
            this.btnSubmitFiles.Text = "Submit Files";
            this.btnSubmitFiles.UseVisualStyleBackColor = true;
            this.btnSubmitFiles.Click += new System.EventHandler(this.btnSubmitFiles_Click);
            // 
            // lBoxDocumentUploadLog
            // 
            this.lBoxDocumentUploadLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBoxDocumentUploadLog.FormattingEnabled = true;
            this.lBoxDocumentUploadLog.Location = new System.Drawing.Point(0, 0);
            this.lBoxDocumentUploadLog.Name = "lBoxDocumentUploadLog";
            this.lBoxDocumentUploadLog.Size = new System.Drawing.Size(190, 370);
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
            // tpnlInputs
            // 
            this.tpnlInputs.ColumnCount = 10;
            this.tpnlInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlInputs.Controls.Add(this.pnlInputsRow1Col8, 7, 0);
            this.tpnlInputs.Controls.Add(this.pnlInputsRow1Col7, 6, 0);
            this.tpnlInputs.Controls.Add(this.pnlInputsRow1Col6, 5, 0);
            this.tpnlInputs.Controls.Add(this.pnlInputsRow1Col5, 4, 0);
            this.tpnlInputs.Controls.Add(this.pnlInputsRow1Col2, 1, 0);
            this.tpnlInputs.Controls.Add(this.pnlInputsRow1Col1, 0, 0);
            this.tpnlInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnlInputs.Location = new System.Drawing.Point(0, 65);
            this.tpnlInputs.Name = "tpnlInputs";
            this.tpnlInputs.RowCount = 1;
            this.tpnlInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlInputs.Size = new System.Drawing.Size(1050, 72);
            this.tpnlInputs.TabIndex = 6;
            // 
            // pnlInputsRow1Col1
            // 
            this.pnlInputsRow1Col1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsRow1Col1.Location = new System.Drawing.Point(10, 10);
            this.pnlInputsRow1Col1.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsRow1Col1.Name = "pnlInputsRow1Col1";
            this.pnlInputsRow1Col1.Size = new System.Drawing.Size(85, 52);
            this.pnlInputsRow1Col1.TabIndex = 0;
            // 
            // pnlInputsRow1Col2
            // 
            this.tpnlInputs.SetColumnSpan(this.pnlInputsRow1Col2, 3);
            this.pnlInputsRow1Col2.Controls.Add(this.lblFilesQueuedForImport);
            this.pnlInputsRow1Col2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsRow1Col2.Location = new System.Drawing.Point(115, 10);
            this.pnlInputsRow1Col2.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsRow1Col2.Name = "pnlInputsRow1Col2";
            this.pnlInputsRow1Col2.Size = new System.Drawing.Size(295, 52);
            this.pnlInputsRow1Col2.TabIndex = 1;
            // 
            // pnlInputsRow1Col5
            // 
            this.pnlInputsRow1Col5.Controls.Add(this.btnFindFiles);
            this.pnlInputsRow1Col5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsRow1Col5.Location = new System.Drawing.Point(430, 10);
            this.pnlInputsRow1Col5.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsRow1Col5.Name = "pnlInputsRow1Col5";
            this.pnlInputsRow1Col5.Size = new System.Drawing.Size(85, 52);
            this.pnlInputsRow1Col5.TabIndex = 4;
            // 
            // pnlInputsRow1Col6
            // 
            this.pnlInputsRow1Col6.Controls.Add(this.btnSubmitFiles);
            this.pnlInputsRow1Col6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsRow1Col6.Location = new System.Drawing.Point(535, 10);
            this.pnlInputsRow1Col6.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsRow1Col6.Name = "pnlInputsRow1Col6";
            this.pnlInputsRow1Col6.Size = new System.Drawing.Size(85, 52);
            this.pnlInputsRow1Col6.TabIndex = 5;
            // 
            // pnlInputsRow1Col7
            // 
            this.pnlInputsRow1Col7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsRow1Col7.Location = new System.Drawing.Point(640, 10);
            this.pnlInputsRow1Col7.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsRow1Col7.Name = "pnlInputsRow1Col7";
            this.pnlInputsRow1Col7.Size = new System.Drawing.Size(85, 52);
            this.pnlInputsRow1Col7.TabIndex = 6;
            // 
            // pnlInputsRow1Col8
            // 
            this.tpnlInputs.SetColumnSpan(this.pnlInputsRow1Col8, 3);
            this.pnlInputsRow1Col8.Controls.Add(this.lblFilesImported);
            this.pnlInputsRow1Col8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsRow1Col8.Location = new System.Drawing.Point(745, 10);
            this.pnlInputsRow1Col8.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsRow1Col8.Name = "pnlInputsRow1Col8";
            this.pnlInputsRow1Col8.Size = new System.Drawing.Size(295, 52);
            this.pnlInputsRow1Col8.TabIndex = 7;
            // 
            // tpnlOutputs
            // 
            this.tpnlOutputs.ColumnCount = 10;
            this.tpnlOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow1Col10, 9, 0);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow2Col10, 9, 1);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow2Col9, 8, 1);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow2Col8, 7, 1);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow2Col7, 6, 1);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow2Col6, 5, 1);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow2Col5, 4, 1);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow2Col4, 3, 1);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow2Col3, 2, 1);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow2Col2, 1, 1);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow2Col1, 0, 1);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow1Col8, 7, 0);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow1Col1, 0, 0);
            this.tpnlOutputs.Controls.Add(this.pnlOutputsRow1Col2, 1, 0);
            this.tpnlOutputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnlOutputs.Location = new System.Drawing.Point(0, 137);
            this.tpnlOutputs.Name = "tpnlOutputs";
            this.tpnlOutputs.RowCount = 2;
            this.tpnlOutputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tpnlOutputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tpnlOutputs.Size = new System.Drawing.Size(1050, 434);
            this.tpnlOutputs.TabIndex = 7;
            // 
            // pnlOutputsRow1Col1
            // 
            this.pnlOutputsRow1Col1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow1Col1.Location = new System.Drawing.Point(10, 10);
            this.pnlOutputsRow1Col1.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow1Col1.Name = "pnlOutputsRow1Col1";
            this.pnlOutputsRow1Col1.Size = new System.Drawing.Size(85, 370);
            this.pnlOutputsRow1Col1.TabIndex = 10;
            // 
            // pnlOutputsRow1Col2
            // 
            this.tpnlOutputs.SetColumnSpan(this.pnlOutputsRow1Col2, 6);
            this.pnlOutputsRow1Col2.Controls.Add(this.dgvDocumentsQueued);
            this.pnlOutputsRow1Col2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow1Col2.Location = new System.Drawing.Point(115, 10);
            this.pnlOutputsRow1Col2.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow1Col2.Name = "pnlOutputsRow1Col2";
            this.pnlOutputsRow1Col2.Size = new System.Drawing.Size(610, 370);
            this.pnlOutputsRow1Col2.TabIndex = 11;
            // 
            // pnlOutputsRow1Col8
            // 
            this.tpnlOutputs.SetColumnSpan(this.pnlOutputsRow1Col8, 2);
            this.pnlOutputsRow1Col8.Controls.Add(this.lBoxDocumentUploadLog);
            this.pnlOutputsRow1Col8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow1Col8.Location = new System.Drawing.Point(745, 10);
            this.pnlOutputsRow1Col8.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow1Col8.Name = "pnlOutputsRow1Col8";
            this.pnlOutputsRow1Col8.Size = new System.Drawing.Size(190, 370);
            this.pnlOutputsRow1Col8.TabIndex = 16;
            // 
            // pnlOutputsRow2Col1
            // 
            this.pnlOutputsRow2Col1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow2Col1.Location = new System.Drawing.Point(10, 400);
            this.pnlOutputsRow2Col1.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow2Col1.Name = "pnlOutputsRow2Col1";
            this.pnlOutputsRow2Col1.Size = new System.Drawing.Size(85, 24);
            this.pnlOutputsRow2Col1.TabIndex = 19;
            // 
            // pnlOutputsRow2Col2
            // 
            this.pnlOutputsRow2Col2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow2Col2.Location = new System.Drawing.Point(115, 400);
            this.pnlOutputsRow2Col2.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow2Col2.Name = "pnlOutputsRow2Col2";
            this.pnlOutputsRow2Col2.Size = new System.Drawing.Size(85, 24);
            this.pnlOutputsRow2Col2.TabIndex = 20;
            // 
            // pnlOutputsRow2Col3
            // 
            this.pnlOutputsRow2Col3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow2Col3.Location = new System.Drawing.Point(220, 400);
            this.pnlOutputsRow2Col3.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow2Col3.Name = "pnlOutputsRow2Col3";
            this.pnlOutputsRow2Col3.Size = new System.Drawing.Size(85, 24);
            this.pnlOutputsRow2Col3.TabIndex = 21;
            // 
            // pnlOutputsRow2Col4
            // 
            this.pnlOutputsRow2Col4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow2Col4.Location = new System.Drawing.Point(325, 400);
            this.pnlOutputsRow2Col4.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow2Col4.Name = "pnlOutputsRow2Col4";
            this.pnlOutputsRow2Col4.Size = new System.Drawing.Size(85, 24);
            this.pnlOutputsRow2Col4.TabIndex = 22;
            // 
            // pnlOutputsRow2Col5
            // 
            this.pnlOutputsRow2Col5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow2Col5.Location = new System.Drawing.Point(430, 400);
            this.pnlOutputsRow2Col5.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow2Col5.Name = "pnlOutputsRow2Col5";
            this.pnlOutputsRow2Col5.Size = new System.Drawing.Size(85, 24);
            this.pnlOutputsRow2Col5.TabIndex = 23;
            // 
            // pnlOutputsRow2Col6
            // 
            this.pnlOutputsRow2Col6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow2Col6.Location = new System.Drawing.Point(535, 400);
            this.pnlOutputsRow2Col6.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow2Col6.Name = "pnlOutputsRow2Col6";
            this.pnlOutputsRow2Col6.Size = new System.Drawing.Size(85, 24);
            this.pnlOutputsRow2Col6.TabIndex = 24;
            // 
            // pnlOutputsRow2Col7
            // 
            this.pnlOutputsRow2Col7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow2Col7.Location = new System.Drawing.Point(640, 400);
            this.pnlOutputsRow2Col7.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow2Col7.Name = "pnlOutputsRow2Col7";
            this.pnlOutputsRow2Col7.Size = new System.Drawing.Size(85, 24);
            this.pnlOutputsRow2Col7.TabIndex = 25;
            // 
            // pnlOutputsRow2Col8
            // 
            this.pnlOutputsRow2Col8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow2Col8.Location = new System.Drawing.Point(745, 400);
            this.pnlOutputsRow2Col8.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow2Col8.Name = "pnlOutputsRow2Col8";
            this.pnlOutputsRow2Col8.Size = new System.Drawing.Size(85, 24);
            this.pnlOutputsRow2Col8.TabIndex = 26;
            // 
            // pnlOutputsRow2Col9
            // 
            this.pnlOutputsRow2Col9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow2Col9.Location = new System.Drawing.Point(850, 400);
            this.pnlOutputsRow2Col9.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow2Col9.Name = "pnlOutputsRow2Col9";
            this.pnlOutputsRow2Col9.Size = new System.Drawing.Size(85, 24);
            this.pnlOutputsRow2Col9.TabIndex = 27;
            // 
            // pnlOutputsRow2Col10
            // 
            this.pnlOutputsRow2Col10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow2Col10.Location = new System.Drawing.Point(955, 400);
            this.pnlOutputsRow2Col10.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow2Col10.Name = "pnlOutputsRow2Col10";
            this.pnlOutputsRow2Col10.Size = new System.Drawing.Size(85, 24);
            this.pnlOutputsRow2Col10.TabIndex = 28;
            // 
            // lblFilesImported
            // 
            this.lblFilesImported.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFilesImported.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesImported.Location = new System.Drawing.Point(0, 27);
            this.lblFilesImported.Name = "lblFilesImported";
            this.lblFilesImported.Size = new System.Drawing.Size(295, 25);
            this.lblFilesImported.TabIndex = 0;
            this.lblFilesImported.Text = "Files Imported:";
            // 
            // pnlOutputsRow1Col10
            // 
            this.pnlOutputsRow1Col10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsRow1Col10.Location = new System.Drawing.Point(955, 10);
            this.pnlOutputsRow1Col10.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsRow1Col10.Name = "pnlOutputsRow1Col10";
            this.pnlOutputsRow1Col10.Size = new System.Drawing.Size(85, 370);
            this.pnlOutputsRow1Col10.TabIndex = 29;
            // 
            // UC_Tab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tpnlOutputs);
            this.Controls.Add(this.tpnlInputs);
            this.Controls.Add(this.pnlHeaderUploadPriceData);
            this.Name = "UC_Tab5";
            this.Size = new System.Drawing.Size(1050, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentsQueued)).EndInit();
            this.pnlHeaderUploadPriceData.ResumeLayout(false);
            this.pnlHeaderUploadPriceData.PerformLayout();
            this.tpnlInputs.ResumeLayout(false);
            this.pnlInputsRow1Col2.ResumeLayout(false);
            this.pnlInputsRow1Col5.ResumeLayout(false);
            this.pnlInputsRow1Col6.ResumeLayout(false);
            this.pnlInputsRow1Col8.ResumeLayout(false);
            this.tpnlOutputs.ResumeLayout(false);
            this.pnlOutputsRow1Col2.ResumeLayout(false);
            this.pnlOutputsRow1Col8.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tpnlInputs;
        private System.Windows.Forms.Panel pnlInputsRow1Col1;
        private System.Windows.Forms.Panel pnlInputsRow1Col8;
        private System.Windows.Forms.Panel pnlInputsRow1Col7;
        private System.Windows.Forms.Panel pnlInputsRow1Col6;
        private System.Windows.Forms.Panel pnlInputsRow1Col5;
        private System.Windows.Forms.Panel pnlInputsRow1Col2;
        private System.Windows.Forms.TableLayoutPanel tpnlOutputs;
        private System.Windows.Forms.Panel pnlOutputsRow2Col10;
        private System.Windows.Forms.Panel pnlOutputsRow2Col9;
        private System.Windows.Forms.Panel pnlOutputsRow2Col8;
        private System.Windows.Forms.Panel pnlOutputsRow2Col7;
        private System.Windows.Forms.Panel pnlOutputsRow2Col6;
        private System.Windows.Forms.Panel pnlOutputsRow2Col5;
        private System.Windows.Forms.Panel pnlOutputsRow2Col4;
        private System.Windows.Forms.Panel pnlOutputsRow2Col3;
        private System.Windows.Forms.Panel pnlOutputsRow2Col2;
        private System.Windows.Forms.Panel pnlOutputsRow2Col1;
        private System.Windows.Forms.Panel pnlOutputsRow1Col8;
        private System.Windows.Forms.Panel pnlOutputsRow1Col1;
        private System.Windows.Forms.Panel pnlOutputsRow1Col2;
        private System.Windows.Forms.Label lblFilesImported;
        private System.Windows.Forms.Panel pnlOutputsRow1Col10;
    }
}
