namespace UserInterface.Forms
{
    partial class TransactionFilterForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlContainerTransactionFilters = new System.Windows.Forms.Panel();
            this.tlpnlTransactionFilters = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeaderFilterType = new System.Windows.Forms.Panel();
            this.lblHeaderFilterType = new System.Windows.Forms.Label();
            this.pnlHeaderFilterCode = new System.Windows.Forms.Panel();
            this.lblHeaderFilterCode = new System.Windows.Forms.Label();
            this.pnlHeaderFilterSector = new System.Windows.Forms.Panel();
            this.lblHeaderFilterSector = new System.Windows.Forms.Label();
            this.pnlHeaderFilterDate = new System.Windows.Forms.Panel();
            this.lblHeaderFilterDate = new System.Windows.Forms.Label();
            this.pnlFooterFilterType = new System.Windows.Forms.Panel();
            this.cboxFilterType = new System.Windows.Forms.ComboBox();
            this.pnlFooterFilterCode = new System.Windows.Forms.Panel();
            this.tboxFilterCode = new System.Windows.Forms.TextBox();
            this.pnlFooterFilterSector = new System.Windows.Forms.Panel();
            this.cboxFilterSector = new System.Windows.Forms.ComboBox();
            this.pnlFooterFilterDateStart = new System.Windows.Forms.Panel();
            this.dtpFilterDateStart = new System.Windows.Forms.DateTimePicker();
            this.pnlFooterFilterDateEnd = new System.Windows.Forms.Panel();
            this.dtpFilterDateEnd = new System.Windows.Forms.DateTimePicker();
            this.pnlHeaderFilterAmount = new System.Windows.Forms.Panel();
            this.lblHeaderFilterAmount = new System.Windows.Forms.Label();
            this.pnlHeaderRow8 = new System.Windows.Forms.Panel();
            this.pnlFooterFilterAmountStart = new System.Windows.Forms.Panel();
            this.ntboxFilterAmountStart = new UserInterface.FormAssets.NumericTextBox();
            this.pnlFooterFilterAmountEnd = new System.Windows.Forms.Panel();
            this.ntboxFilterAmountEnd = new UserInterface.FormAssets.NumericTextBox();
            this.pnlFooterRow8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.fpnlCurrentFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlButtonFilterType = new System.Windows.Forms.Panel();
            this.btnFilterAddType = new System.Windows.Forms.Button();
            this.pnlButtonFilterCode = new System.Windows.Forms.Panel();
            this.btnFilterAddCode = new System.Windows.Forms.Button();
            this.pnlButtonFilterSector = new System.Windows.Forms.Panel();
            this.btnFilterAddSector = new System.Windows.Forms.Button();
            this.pnlButtonFilterDate = new System.Windows.Forms.Panel();
            this.btnFilterAddDate = new System.Windows.Forms.Button();
            this.pnlButtonFilterAmount = new System.Windows.Forms.Panel();
            this.btnFilterAddAmount = new System.Windows.Forms.Button();
            this.pnlButtonRow8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlButtonRow9 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContainerTransactionFilters.SuspendLayout();
            this.tlpnlTransactionFilters.SuspendLayout();
            this.pnlHeaderFilterType.SuspendLayout();
            this.pnlHeaderFilterCode.SuspendLayout();
            this.pnlHeaderFilterSector.SuspendLayout();
            this.pnlHeaderFilterDate.SuspendLayout();
            this.pnlFooterFilterType.SuspendLayout();
            this.pnlFooterFilterCode.SuspendLayout();
            this.pnlFooterFilterSector.SuspendLayout();
            this.pnlFooterFilterDateStart.SuspendLayout();
            this.pnlFooterFilterDateEnd.SuspendLayout();
            this.pnlHeaderFilterAmount.SuspendLayout();
            this.pnlFooterFilterAmountStart.SuspendLayout();
            this.pnlFooterFilterAmountEnd.SuspendLayout();
            this.pnlFooterRow8.SuspendLayout();
            this.pnlButtonFilterType.SuspendLayout();
            this.pnlButtonFilterCode.SuspendLayout();
            this.pnlButtonFilterSector.SuspendLayout();
            this.pnlButtonFilterDate.SuspendLayout();
            this.pnlButtonFilterAmount.SuspendLayout();
            this.pnlButtonRow9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(873, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(330, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(93, 13);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Transaction Filters";
            // 
            // pnlContainerTransactionFilters
            // 
            this.pnlContainerTransactionFilters.Controls.Add(this.tlpnlTransactionFilters);
            this.pnlContainerTransactionFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainerTransactionFilters.Location = new System.Drawing.Point(0, 65);
            this.pnlContainerTransactionFilters.Name = "pnlContainerTransactionFilters";
            this.pnlContainerTransactionFilters.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContainerTransactionFilters.Size = new System.Drawing.Size(873, 385);
            this.pnlContainerTransactionFilters.TabIndex = 1;
            // 
            // tlpnlTransactionFilters
            // 
            this.tlpnlTransactionFilters.ColumnCount = 6;
            this.tlpnlTransactionFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpnlTransactionFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpnlTransactionFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpnlTransactionFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlTransactionFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnlTransactionFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpnlTransactionFilters.Controls.Add(this.pnlHeaderFilterType, 3, 1);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlHeaderFilterCode, 3, 2);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlHeaderFilterSector, 3, 3);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlHeaderFilterDate, 3, 4);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlFooterFilterType, 4, 1);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlFooterFilterCode, 4, 2);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlFooterFilterSector, 4, 3);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlFooterFilterDateStart, 4, 4);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlFooterFilterDateEnd, 4, 5);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlHeaderFilterAmount, 3, 6);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlHeaderRow8, 3, 8);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlFooterFilterAmountStart, 4, 6);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlFooterFilterAmountEnd, 4, 7);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlFooterRow8, 4, 8);
            this.tlpnlTransactionFilters.Controls.Add(this.fpnlCurrentFilters, 1, 1);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlButtonFilterType, 5, 1);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlButtonFilterCode, 5, 2);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlButtonFilterSector, 5, 3);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlButtonFilterDate, 5, 4);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlButtonFilterAmount, 5, 6);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlButtonRow8, 5, 8);
            this.tlpnlTransactionFilters.Controls.Add(this.button2, 3, 9);
            this.tlpnlTransactionFilters.Controls.Add(this.pnlButtonRow9, 5, 9);
            this.tlpnlTransactionFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnlTransactionFilters.Location = new System.Drawing.Point(10, 10);
            this.tlpnlTransactionFilters.Name = "tlpnlTransactionFilters";
            this.tlpnlTransactionFilters.RowCount = 10;
            this.tlpnlTransactionFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpnlTransactionFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpnlTransactionFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpnlTransactionFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpnlTransactionFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpnlTransactionFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpnlTransactionFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpnlTransactionFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpnlTransactionFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpnlTransactionFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpnlTransactionFilters.Size = new System.Drawing.Size(853, 365);
            this.tlpnlTransactionFilters.TabIndex = 0;
            // 
            // pnlHeaderFilterType
            // 
            this.pnlHeaderFilterType.Controls.Add(this.lblHeaderFilterType);
            this.pnlHeaderFilterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderFilterType.Location = new System.Drawing.Point(435, 31);
            this.pnlHeaderFilterType.Margin = new System.Windows.Forms.Padding(10);
            this.pnlHeaderFilterType.Name = "pnlHeaderFilterType";
            this.pnlHeaderFilterType.Size = new System.Drawing.Size(150, 20);
            this.pnlHeaderFilterType.TabIndex = 1;
            // 
            // lblHeaderFilterType
            // 
            this.lblHeaderFilterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderFilterType.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderFilterType.Name = "lblHeaderFilterType";
            this.lblHeaderFilterType.Size = new System.Drawing.Size(150, 20);
            this.lblHeaderFilterType.TabIndex = 0;
            this.lblHeaderFilterType.Text = "Type:";
            this.lblHeaderFilterType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlHeaderFilterCode
            // 
            this.pnlHeaderFilterCode.Controls.Add(this.lblHeaderFilterCode);
            this.pnlHeaderFilterCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderFilterCode.Location = new System.Drawing.Point(435, 71);
            this.pnlHeaderFilterCode.Margin = new System.Windows.Forms.Padding(10);
            this.pnlHeaderFilterCode.Name = "pnlHeaderFilterCode";
            this.pnlHeaderFilterCode.Size = new System.Drawing.Size(150, 20);
            this.pnlHeaderFilterCode.TabIndex = 2;
            // 
            // lblHeaderFilterCode
            // 
            this.lblHeaderFilterCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderFilterCode.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderFilterCode.Name = "lblHeaderFilterCode";
            this.lblHeaderFilterCode.Size = new System.Drawing.Size(150, 20);
            this.lblHeaderFilterCode.TabIndex = 1;
            this.lblHeaderFilterCode.Text = "Code:";
            this.lblHeaderFilterCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlHeaderFilterSector
            // 
            this.pnlHeaderFilterSector.Controls.Add(this.lblHeaderFilterSector);
            this.pnlHeaderFilterSector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderFilterSector.Location = new System.Drawing.Point(435, 111);
            this.pnlHeaderFilterSector.Margin = new System.Windows.Forms.Padding(10);
            this.pnlHeaderFilterSector.Name = "pnlHeaderFilterSector";
            this.pnlHeaderFilterSector.Size = new System.Drawing.Size(150, 20);
            this.pnlHeaderFilterSector.TabIndex = 3;
            // 
            // lblHeaderFilterSector
            // 
            this.lblHeaderFilterSector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderFilterSector.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderFilterSector.Name = "lblHeaderFilterSector";
            this.lblHeaderFilterSector.Size = new System.Drawing.Size(150, 20);
            this.lblHeaderFilterSector.TabIndex = 1;
            this.lblHeaderFilterSector.Text = "Sector";
            this.lblHeaderFilterSector.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlHeaderFilterDate
            // 
            this.pnlHeaderFilterDate.Controls.Add(this.lblHeaderFilterDate);
            this.pnlHeaderFilterDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderFilterDate.Location = new System.Drawing.Point(435, 151);
            this.pnlHeaderFilterDate.Margin = new System.Windows.Forms.Padding(10);
            this.pnlHeaderFilterDate.Name = "pnlHeaderFilterDate";
            this.tlpnlTransactionFilters.SetRowSpan(this.pnlHeaderFilterDate, 2);
            this.pnlHeaderFilterDate.Size = new System.Drawing.Size(150, 60);
            this.pnlHeaderFilterDate.TabIndex = 4;
            // 
            // lblHeaderFilterDate
            // 
            this.lblHeaderFilterDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderFilterDate.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderFilterDate.Name = "lblHeaderFilterDate";
            this.lblHeaderFilterDate.Size = new System.Drawing.Size(150, 60);
            this.lblHeaderFilterDate.TabIndex = 1;
            this.lblHeaderFilterDate.Text = "Date Between:";
            this.lblHeaderFilterDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFooterFilterType
            // 
            this.pnlFooterFilterType.Controls.Add(this.cboxFilterType);
            this.pnlFooterFilterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooterFilterType.Location = new System.Drawing.Point(605, 31);
            this.pnlFooterFilterType.Margin = new System.Windows.Forms.Padding(10);
            this.pnlFooterFilterType.Name = "pnlFooterFilterType";
            this.pnlFooterFilterType.Size = new System.Drawing.Size(150, 20);
            this.pnlFooterFilterType.TabIndex = 6;
            // 
            // cboxFilterType
            // 
            this.cboxFilterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxFilterType.FormattingEnabled = true;
            this.cboxFilterType.Location = new System.Drawing.Point(0, 0);
            this.cboxFilterType.Name = "cboxFilterType";
            this.cboxFilterType.Size = new System.Drawing.Size(150, 21);
            this.cboxFilterType.TabIndex = 0;
            // 
            // pnlFooterFilterCode
            // 
            this.pnlFooterFilterCode.Controls.Add(this.tboxFilterCode);
            this.pnlFooterFilterCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooterFilterCode.Location = new System.Drawing.Point(605, 71);
            this.pnlFooterFilterCode.Margin = new System.Windows.Forms.Padding(10);
            this.pnlFooterFilterCode.Name = "pnlFooterFilterCode";
            this.pnlFooterFilterCode.Size = new System.Drawing.Size(150, 20);
            this.pnlFooterFilterCode.TabIndex = 7;
            // 
            // tboxFilterCode
            // 
            this.tboxFilterCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxFilterCode.Location = new System.Drawing.Point(0, 0);
            this.tboxFilterCode.Name = "tboxFilterCode";
            this.tboxFilterCode.Size = new System.Drawing.Size(150, 20);
            this.tboxFilterCode.TabIndex = 0;
            // 
            // pnlFooterFilterSector
            // 
            this.pnlFooterFilterSector.Controls.Add(this.cboxFilterSector);
            this.pnlFooterFilterSector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooterFilterSector.Location = new System.Drawing.Point(605, 111);
            this.pnlFooterFilterSector.Margin = new System.Windows.Forms.Padding(10);
            this.pnlFooterFilterSector.Name = "pnlFooterFilterSector";
            this.pnlFooterFilterSector.Size = new System.Drawing.Size(150, 20);
            this.pnlFooterFilterSector.TabIndex = 8;
            // 
            // cboxFilterSector
            // 
            this.cboxFilterSector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxFilterSector.FormattingEnabled = true;
            this.cboxFilterSector.Location = new System.Drawing.Point(0, 0);
            this.cboxFilterSector.Name = "cboxFilterSector";
            this.cboxFilterSector.Size = new System.Drawing.Size(150, 21);
            this.cboxFilterSector.TabIndex = 0;
            // 
            // pnlFooterFilterDateStart
            // 
            this.pnlFooterFilterDateStart.Controls.Add(this.dtpFilterDateStart);
            this.pnlFooterFilterDateStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooterFilterDateStart.Location = new System.Drawing.Point(605, 151);
            this.pnlFooterFilterDateStart.Margin = new System.Windows.Forms.Padding(10);
            this.pnlFooterFilterDateStart.Name = "pnlFooterFilterDateStart";
            this.pnlFooterFilterDateStart.Size = new System.Drawing.Size(150, 20);
            this.pnlFooterFilterDateStart.TabIndex = 9;
            // 
            // dtpFilterDateStart
            // 
            this.dtpFilterDateStart.CustomFormat = "dd/MM/yyyy";
            this.dtpFilterDateStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFilterDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterDateStart.Location = new System.Drawing.Point(0, 0);
            this.dtpFilterDateStart.Name = "dtpFilterDateStart";
            this.dtpFilterDateStart.Size = new System.Drawing.Size(150, 20);
            this.dtpFilterDateStart.TabIndex = 0;
            // 
            // pnlFooterFilterDateEnd
            // 
            this.pnlFooterFilterDateEnd.Controls.Add(this.dtpFilterDateEnd);
            this.pnlFooterFilterDateEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooterFilterDateEnd.Location = new System.Drawing.Point(605, 191);
            this.pnlFooterFilterDateEnd.Margin = new System.Windows.Forms.Padding(10);
            this.pnlFooterFilterDateEnd.Name = "pnlFooterFilterDateEnd";
            this.pnlFooterFilterDateEnd.Size = new System.Drawing.Size(150, 20);
            this.pnlFooterFilterDateEnd.TabIndex = 10;
            // 
            // dtpFilterDateEnd
            // 
            this.dtpFilterDateEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpFilterDateEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFilterDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFilterDateEnd.Location = new System.Drawing.Point(0, 0);
            this.dtpFilterDateEnd.Name = "dtpFilterDateEnd";
            this.dtpFilterDateEnd.Size = new System.Drawing.Size(150, 20);
            this.dtpFilterDateEnd.TabIndex = 0;
            // 
            // pnlHeaderFilterAmount
            // 
            this.pnlHeaderFilterAmount.Controls.Add(this.lblHeaderFilterAmount);
            this.pnlHeaderFilterAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderFilterAmount.Location = new System.Drawing.Point(435, 231);
            this.pnlHeaderFilterAmount.Margin = new System.Windows.Forms.Padding(10);
            this.pnlHeaderFilterAmount.Name = "pnlHeaderFilterAmount";
            this.tlpnlTransactionFilters.SetRowSpan(this.pnlHeaderFilterAmount, 2);
            this.pnlHeaderFilterAmount.Size = new System.Drawing.Size(150, 60);
            this.pnlHeaderFilterAmount.TabIndex = 11;
            // 
            // lblHeaderFilterAmount
            // 
            this.lblHeaderFilterAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderFilterAmount.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderFilterAmount.Name = "lblHeaderFilterAmount";
            this.lblHeaderFilterAmount.Size = new System.Drawing.Size(150, 60);
            this.lblHeaderFilterAmount.TabIndex = 0;
            this.lblHeaderFilterAmount.Text = "Amount Between:";
            this.lblHeaderFilterAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeaderRow8
            // 
            this.pnlHeaderRow8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderRow8.Location = new System.Drawing.Point(435, 311);
            this.pnlHeaderRow8.Margin = new System.Windows.Forms.Padding(10);
            this.pnlHeaderRow8.Name = "pnlHeaderRow8";
            this.pnlHeaderRow8.Size = new System.Drawing.Size(150, 20);
            this.pnlHeaderRow8.TabIndex = 13;
            // 
            // pnlFooterFilterAmountStart
            // 
            this.pnlFooterFilterAmountStart.Controls.Add(this.ntboxFilterAmountStart);
            this.pnlFooterFilterAmountStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooterFilterAmountStart.Location = new System.Drawing.Point(605, 231);
            this.pnlFooterFilterAmountStart.Margin = new System.Windows.Forms.Padding(10);
            this.pnlFooterFilterAmountStart.Name = "pnlFooterFilterAmountStart";
            this.pnlFooterFilterAmountStart.Size = new System.Drawing.Size(150, 20);
            this.pnlFooterFilterAmountStart.TabIndex = 14;
            // 
            // ntboxFilterAmountStart
            // 
            this.ntboxFilterAmountStart.AllowsDecimals = true;
            this.ntboxFilterAmountStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntboxFilterAmountStart.Location = new System.Drawing.Point(0, 0);
            this.ntboxFilterAmountStart.Name = "ntboxFilterAmountStart";
            this.ntboxFilterAmountStart.Size = new System.Drawing.Size(150, 20);
            this.ntboxFilterAmountStart.TabIndex = 0;
            // 
            // pnlFooterFilterAmountEnd
            // 
            this.pnlFooterFilterAmountEnd.Controls.Add(this.ntboxFilterAmountEnd);
            this.pnlFooterFilterAmountEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooterFilterAmountEnd.Location = new System.Drawing.Point(605, 271);
            this.pnlFooterFilterAmountEnd.Margin = new System.Windows.Forms.Padding(10);
            this.pnlFooterFilterAmountEnd.Name = "pnlFooterFilterAmountEnd";
            this.pnlFooterFilterAmountEnd.Size = new System.Drawing.Size(150, 20);
            this.pnlFooterFilterAmountEnd.TabIndex = 15;
            // 
            // ntboxFilterAmountEnd
            // 
            this.ntboxFilterAmountEnd.AllowsDecimals = true;
            this.ntboxFilterAmountEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ntboxFilterAmountEnd.Location = new System.Drawing.Point(0, 0);
            this.ntboxFilterAmountEnd.Name = "ntboxFilterAmountEnd";
            this.ntboxFilterAmountEnd.Size = new System.Drawing.Size(150, 20);
            this.ntboxFilterAmountEnd.TabIndex = 0;
            // 
            // pnlFooterRow8
            // 
            this.pnlFooterRow8.Controls.Add(this.button1);
            this.pnlFooterRow8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooterRow8.Location = new System.Drawing.Point(605, 311);
            this.pnlFooterRow8.Margin = new System.Windows.Forms.Padding(10);
            this.pnlFooterRow8.Name = "pnlFooterRow8";
            this.pnlFooterRow8.Size = new System.Drawing.Size(150, 20);
            this.pnlFooterRow8.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fpnlCurrentFilters
            // 
            this.fpnlCurrentFilters.AutoScroll = true;
            this.fpnlCurrentFilters.AutoSize = true;
            this.fpnlCurrentFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlCurrentFilters.Location = new System.Drawing.Point(52, 31);
            this.fpnlCurrentFilters.Margin = new System.Windows.Forms.Padding(10);
            this.fpnlCurrentFilters.Name = "fpnlCurrentFilters";
            this.tlpnlTransactionFilters.SetRowSpan(this.fpnlCurrentFilters, 8);
            this.fpnlCurrentFilters.Size = new System.Drawing.Size(321, 300);
            this.fpnlCurrentFilters.TabIndex = 17;
            // 
            // pnlButtonFilterType
            // 
            this.pnlButtonFilterType.Controls.Add(this.btnFilterAddType);
            this.pnlButtonFilterType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonFilterType.Location = new System.Drawing.Point(775, 31);
            this.pnlButtonFilterType.Margin = new System.Windows.Forms.Padding(10);
            this.pnlButtonFilterType.Name = "pnlButtonFilterType";
            this.pnlButtonFilterType.Size = new System.Drawing.Size(68, 20);
            this.pnlButtonFilterType.TabIndex = 18;
            // 
            // btnFilterAddType
            // 
            this.btnFilterAddType.AutoSize = true;
            this.btnFilterAddType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterAddType.Location = new System.Drawing.Point(0, 0);
            this.btnFilterAddType.Name = "btnFilterAddType";
            this.btnFilterAddType.Size = new System.Drawing.Size(68, 20);
            this.btnFilterAddType.TabIndex = 0;
            this.btnFilterAddType.Text = "Add";
            this.btnFilterAddType.UseVisualStyleBackColor = true;
            this.btnFilterAddType.Click += new System.EventHandler(this.btnFilterAddType_Click);
            // 
            // pnlButtonFilterCode
            // 
            this.pnlButtonFilterCode.Controls.Add(this.btnFilterAddCode);
            this.pnlButtonFilterCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonFilterCode.Location = new System.Drawing.Point(775, 71);
            this.pnlButtonFilterCode.Margin = new System.Windows.Forms.Padding(10);
            this.pnlButtonFilterCode.Name = "pnlButtonFilterCode";
            this.pnlButtonFilterCode.Size = new System.Drawing.Size(68, 20);
            this.pnlButtonFilterCode.TabIndex = 19;
            // 
            // btnFilterAddCode
            // 
            this.btnFilterAddCode.AutoSize = true;
            this.btnFilterAddCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterAddCode.Location = new System.Drawing.Point(0, 0);
            this.btnFilterAddCode.Name = "btnFilterAddCode";
            this.btnFilterAddCode.Size = new System.Drawing.Size(68, 20);
            this.btnFilterAddCode.TabIndex = 0;
            this.btnFilterAddCode.Text = "Add";
            this.btnFilterAddCode.UseVisualStyleBackColor = true;
            this.btnFilterAddCode.Click += new System.EventHandler(this.btnFilterAddCode_Click);
            // 
            // pnlButtonFilterSector
            // 
            this.pnlButtonFilterSector.Controls.Add(this.btnFilterAddSector);
            this.pnlButtonFilterSector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonFilterSector.Location = new System.Drawing.Point(775, 111);
            this.pnlButtonFilterSector.Margin = new System.Windows.Forms.Padding(10);
            this.pnlButtonFilterSector.Name = "pnlButtonFilterSector";
            this.pnlButtonFilterSector.Size = new System.Drawing.Size(68, 20);
            this.pnlButtonFilterSector.TabIndex = 20;
            // 
            // btnFilterAddSector
            // 
            this.btnFilterAddSector.AutoSize = true;
            this.btnFilterAddSector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterAddSector.Location = new System.Drawing.Point(0, 0);
            this.btnFilterAddSector.Name = "btnFilterAddSector";
            this.btnFilterAddSector.Size = new System.Drawing.Size(68, 20);
            this.btnFilterAddSector.TabIndex = 0;
            this.btnFilterAddSector.Text = "Add";
            this.btnFilterAddSector.UseVisualStyleBackColor = true;
            this.btnFilterAddSector.Click += new System.EventHandler(this.btnFilterAddSector_Click);
            // 
            // pnlButtonFilterDate
            // 
            this.pnlButtonFilterDate.Controls.Add(this.btnFilterAddDate);
            this.pnlButtonFilterDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonFilterDate.Location = new System.Drawing.Point(775, 171);
            this.pnlButtonFilterDate.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.pnlButtonFilterDate.Name = "pnlButtonFilterDate";
            this.tlpnlTransactionFilters.SetRowSpan(this.pnlButtonFilterDate, 2);
            this.pnlButtonFilterDate.Size = new System.Drawing.Size(68, 20);
            this.pnlButtonFilterDate.TabIndex = 21;
            // 
            // btnFilterAddDate
            // 
            this.btnFilterAddDate.AutoSize = true;
            this.btnFilterAddDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterAddDate.Location = new System.Drawing.Point(0, 0);
            this.btnFilterAddDate.Name = "btnFilterAddDate";
            this.btnFilterAddDate.Size = new System.Drawing.Size(68, 20);
            this.btnFilterAddDate.TabIndex = 0;
            this.btnFilterAddDate.Text = "Add";
            this.btnFilterAddDate.UseVisualStyleBackColor = true;
            this.btnFilterAddDate.Click += new System.EventHandler(this.btnFilterAddDate_Click);
            // 
            // pnlButtonFilterAmount
            // 
            this.pnlButtonFilterAmount.Controls.Add(this.btnFilterAddAmount);
            this.pnlButtonFilterAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonFilterAmount.Location = new System.Drawing.Point(775, 251);
            this.pnlButtonFilterAmount.Margin = new System.Windows.Forms.Padding(10, 30, 10, 30);
            this.pnlButtonFilterAmount.Name = "pnlButtonFilterAmount";
            this.tlpnlTransactionFilters.SetRowSpan(this.pnlButtonFilterAmount, 2);
            this.pnlButtonFilterAmount.Size = new System.Drawing.Size(68, 20);
            this.pnlButtonFilterAmount.TabIndex = 23;
            // 
            // btnFilterAddAmount
            // 
            this.btnFilterAddAmount.AutoSize = true;
            this.btnFilterAddAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilterAddAmount.Location = new System.Drawing.Point(0, 0);
            this.btnFilterAddAmount.Name = "btnFilterAddAmount";
            this.btnFilterAddAmount.Size = new System.Drawing.Size(68, 20);
            this.btnFilterAddAmount.TabIndex = 0;
            this.btnFilterAddAmount.Text = "Add";
            this.btnFilterAddAmount.UseVisualStyleBackColor = true;
            this.btnFilterAddAmount.Click += new System.EventHandler(this.btnFilterAddAmount_Click);
            // 
            // pnlButtonRow8
            // 
            this.pnlButtonRow8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonRow8.Location = new System.Drawing.Point(775, 311);
            this.pnlButtonRow8.Margin = new System.Windows.Forms.Padding(10);
            this.pnlButtonRow8.Name = "pnlButtonRow8";
            this.pnlButtonRow8.Size = new System.Drawing.Size(68, 20);
            this.pnlButtonRow8.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 18);
            this.button2.TabIndex = 26;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlButtonRow9
            // 
            this.pnlButtonRow9.Controls.Add(this.btnClose);
            this.pnlButtonRow9.Location = new System.Drawing.Point(768, 344);
            this.pnlButtonRow9.Name = "pnlButtonRow9";
            this.pnlButtonRow9.Size = new System.Drawing.Size(82, 18);
            this.pnlButtonRow9.TabIndex = 27;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 18);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // TransactionFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.pnlContainerTransactionFilters);
            this.Controls.Add(this.pnlHeader);
            this.Name = "TransactionFilterForm";
            this.Text = "TransactionFilterForm";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContainerTransactionFilters.ResumeLayout(false);
            this.tlpnlTransactionFilters.ResumeLayout(false);
            this.tlpnlTransactionFilters.PerformLayout();
            this.pnlHeaderFilterType.ResumeLayout(false);
            this.pnlHeaderFilterCode.ResumeLayout(false);
            this.pnlHeaderFilterSector.ResumeLayout(false);
            this.pnlHeaderFilterDate.ResumeLayout(false);
            this.pnlFooterFilterType.ResumeLayout(false);
            this.pnlFooterFilterCode.ResumeLayout(false);
            this.pnlFooterFilterCode.PerformLayout();
            this.pnlFooterFilterSector.ResumeLayout(false);
            this.pnlFooterFilterDateStart.ResumeLayout(false);
            this.pnlFooterFilterDateEnd.ResumeLayout(false);
            this.pnlHeaderFilterAmount.ResumeLayout(false);
            this.pnlFooterFilterAmountStart.ResumeLayout(false);
            this.pnlFooterFilterAmountStart.PerformLayout();
            this.pnlFooterFilterAmountEnd.ResumeLayout(false);
            this.pnlFooterFilterAmountEnd.PerformLayout();
            this.pnlFooterRow8.ResumeLayout(false);
            this.pnlButtonFilterType.ResumeLayout(false);
            this.pnlButtonFilterType.PerformLayout();
            this.pnlButtonFilterCode.ResumeLayout(false);
            this.pnlButtonFilterCode.PerformLayout();
            this.pnlButtonFilterSector.ResumeLayout(false);
            this.pnlButtonFilterSector.PerformLayout();
            this.pnlButtonFilterDate.ResumeLayout(false);
            this.pnlButtonFilterDate.PerformLayout();
            this.pnlButtonFilterAmount.ResumeLayout(false);
            this.pnlButtonFilterAmount.PerformLayout();
            this.pnlButtonRow9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlContainerTransactionFilters;
        private System.Windows.Forms.TableLayoutPanel tlpnlTransactionFilters;
        private System.Windows.Forms.Panel pnlHeaderFilterType;
        private System.Windows.Forms.Label lblHeaderFilterType;
        private System.Windows.Forms.Panel pnlHeaderFilterCode;
        private System.Windows.Forms.Panel pnlHeaderFilterSector;
        private System.Windows.Forms.Panel pnlHeaderFilterDate;
        private System.Windows.Forms.Panel pnlFooterFilterType;
        private System.Windows.Forms.Panel pnlFooterFilterCode;
        private System.Windows.Forms.Panel pnlFooterFilterSector;
        private System.Windows.Forms.Panel pnlFooterFilterDateStart;
        private System.Windows.Forms.Panel pnlFooterFilterDateEnd;
        private System.Windows.Forms.Label lblHeaderFilterCode;
        private System.Windows.Forms.Label lblHeaderFilterSector;
        private System.Windows.Forms.Label lblHeaderFilterDate;
        private System.Windows.Forms.Panel pnlHeaderFilterAmount;
        private System.Windows.Forms.Panel pnlHeaderRow8;
        private System.Windows.Forms.Panel pnlFooterFilterAmountStart;
        private System.Windows.Forms.Panel pnlFooterFilterAmountEnd;
        private System.Windows.Forms.Panel pnlFooterRow8;
        private System.Windows.Forms.Label lblHeaderFilterAmount;
        private System.Windows.Forms.FlowLayoutPanel fpnlCurrentFilters;
        private System.Windows.Forms.Panel pnlButtonFilterType;
        private System.Windows.Forms.Panel pnlButtonFilterCode;
        private System.Windows.Forms.Panel pnlButtonFilterSector;
        private System.Windows.Forms.Panel pnlButtonFilterDate;
        private System.Windows.Forms.Panel pnlButtonFilterAmount;
        private System.Windows.Forms.Panel pnlButtonRow8;
        private System.Windows.Forms.Button btnFilterAddType;
        private System.Windows.Forms.Button btnFilterAddCode;
        private System.Windows.Forms.Button btnFilterAddSector;
        private System.Windows.Forms.Button btnFilterAddDate;
        private System.Windows.Forms.Button btnFilterAddAmount;
        private System.Windows.Forms.ComboBox cboxFilterType;
        private System.Windows.Forms.TextBox tboxFilterCode;
        private System.Windows.Forms.ComboBox cboxFilterSector;
        private System.Windows.Forms.DateTimePicker dtpFilterDateStart;
        private System.Windows.Forms.DateTimePicker dtpFilterDateEnd;
        private FormAssets.NumericTextBox ntboxFilterAmountStart;
        private FormAssets.NumericTextBox ntboxFilterAmountEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlButtonRow9;
        private System.Windows.Forms.Button btnClose;
    }
}