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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeaderSinglePriceData = new System.Windows.Forms.Panel();
            this.lblHeaderSinglePriceData = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.tboxASXShare = new System.Windows.Forms.TextBox();
            this.lblASXShare = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.tboxYear = new System.Windows.Forms.TextBox();
            this.lblPriceType = new System.Windows.Forms.Label();
            this.cboxPriceType = new System.Windows.Forms.ComboBox();
            this.pnlContainerSinglePriceData = new System.Windows.Forms.Panel();
            this.tpnlOutputsSinglePriceData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlOutputsCol2 = new System.Windows.Forms.Panel();
            this.dgvAllSharePrices = new System.Windows.Forms.DataGridView();
            this.Jan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOutputsCol1 = new System.Windows.Forms.Panel();
            this.pnlOutputsCol3 = new System.Windows.Forms.Panel();
            this.tpnlInputsSinglePriceData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInputsCol8 = new System.Windows.Forms.Panel();
            this.lblFooterHighestPrice = new System.Windows.Forms.Label();
            this.lblFooterLowestPrice = new System.Windows.Forms.Label();
            this.pnlInputsCol7 = new System.Windows.Forms.Panel();
            this.lblHeaderHighestPrice = new System.Windows.Forms.Label();
            this.lblHeaderLowestPrice = new System.Windows.Forms.Label();
            this.pnlInputsCol6 = new System.Windows.Forms.Panel();
            this.pnlInputsCol5 = new System.Windows.Forms.Panel();
            this.pnlInputsCol4 = new System.Windows.Forms.Panel();
            this.pnlInputsCol3 = new System.Windows.Forms.Panel();
            this.pnlInputsCol2 = new System.Windows.Forms.Panel();
            this.pnlInputsCol1 = new System.Windows.Forms.Panel();
            this.pnlHeaderSinglePriceData.SuspendLayout();
            this.pnlContainerSinglePriceData.SuspendLayout();
            this.tpnlOutputsSinglePriceData.SuspendLayout();
            this.pnlOutputsCol2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSharePrices)).BeginInit();
            this.tpnlInputsSinglePriceData.SuspendLayout();
            this.pnlInputsCol8.SuspendLayout();
            this.pnlInputsCol7.SuspendLayout();
            this.pnlInputsCol6.SuspendLayout();
            this.pnlInputsCol5.SuspendLayout();
            this.pnlInputsCol4.SuspendLayout();
            this.pnlInputsCol3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderSinglePriceData
            // 
            this.pnlHeaderSinglePriceData.BackColor = System.Drawing.Color.White;
            this.pnlHeaderSinglePriceData.Controls.Add(this.lblHeaderSinglePriceData);
            this.pnlHeaderSinglePriceData.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderSinglePriceData.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderSinglePriceData.Name = "pnlHeaderSinglePriceData";
            this.pnlHeaderSinglePriceData.Size = new System.Drawing.Size(1050, 65);
            this.pnlHeaderSinglePriceData.TabIndex = 10;
            // 
            // lblHeaderSinglePriceData
            // 
            this.lblHeaderSinglePriceData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeaderSinglePriceData.AutoSize = true;
            this.lblHeaderSinglePriceData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderSinglePriceData.Location = new System.Drawing.Point(431, 21);
            this.lblHeaderSinglePriceData.Name = "lblHeaderSinglePriceData";
            this.lblHeaderSinglePriceData.Size = new System.Drawing.Size(162, 25);
            this.lblHeaderSinglePriceData.TabIndex = 0;
            this.lblHeaderSinglePriceData.Text = "Single Price Data";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisplay.Location = new System.Drawing.Point(0, 0);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(108, 50);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btn_tab2_Display_Click);
            // 
            // tboxASXShare
            // 
            this.tboxASXShare.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tboxASXShare.Location = new System.Drawing.Point(0, 30);
            this.tboxASXShare.Name = "tboxASXShare";
            this.tboxASXShare.Size = new System.Drawing.Size(108, 20);
            this.tboxASXShare.TabIndex = 2;
            this.tboxASXShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblASXShare
            // 
            this.lblASXShare.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblASXShare.Location = new System.Drawing.Point(0, 0);
            this.lblASXShare.Margin = new System.Windows.Forms.Padding(3);
            this.lblASXShare.Name = "lblASXShare";
            this.lblASXShare.Size = new System.Drawing.Size(108, 23);
            this.lblASXShare.TabIndex = 4;
            this.lblASXShare.Text = "ASXShare";
            this.lblASXShare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblYear
            // 
            this.lblYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYear.Location = new System.Drawing.Point(0, 0);
            this.lblYear.Margin = new System.Windows.Forms.Padding(3);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(108, 23);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tboxYear
            // 
            this.tboxYear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tboxYear.Location = new System.Drawing.Point(0, 30);
            this.tboxYear.Name = "tboxYear";
            this.tboxYear.Size = new System.Drawing.Size(108, 20);
            this.tboxYear.TabIndex = 1;
            this.tboxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPriceType
            // 
            this.lblPriceType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPriceType.Location = new System.Drawing.Point(0, 0);
            this.lblPriceType.Margin = new System.Windows.Forms.Padding(3);
            this.lblPriceType.Name = "lblPriceType";
            this.lblPriceType.Size = new System.Drawing.Size(108, 23);
            this.lblPriceType.TabIndex = 7;
            this.lblPriceType.Text = "PriceType";
            this.lblPriceType.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cboxPriceType
            // 
            this.cboxPriceType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboxPriceType.FormattingEnabled = true;
            this.cboxPriceType.Items.AddRange(new object[] {
            "Open",
            "Close",
            "High",
            "Low"});
            this.cboxPriceType.Location = new System.Drawing.Point(0, 29);
            this.cboxPriceType.Name = "cboxPriceType";
            this.cboxPriceType.Size = new System.Drawing.Size(108, 21);
            this.cboxPriceType.TabIndex = 3;
            // 
            // pnlContainerSinglePriceData
            // 
            this.pnlContainerSinglePriceData.BackColor = System.Drawing.Color.White;
            this.pnlContainerSinglePriceData.Controls.Add(this.tpnlOutputsSinglePriceData);
            this.pnlContainerSinglePriceData.Controls.Add(this.tpnlInputsSinglePriceData);
            this.pnlContainerSinglePriceData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainerSinglePriceData.Location = new System.Drawing.Point(0, 65);
            this.pnlContainerSinglePriceData.Name = "pnlContainerSinglePriceData";
            this.pnlContainerSinglePriceData.Padding = new System.Windows.Forms.Padding(10);
            this.pnlContainerSinglePriceData.Size = new System.Drawing.Size(1050, 575);
            this.pnlContainerSinglePriceData.TabIndex = 1;
            // 
            // tpnlOutputsSinglePriceData
            // 
            this.tpnlOutputsSinglePriceData.ColumnCount = 3;
            this.tpnlOutputsSinglePriceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tpnlOutputsSinglePriceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tpnlOutputsSinglePriceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tpnlOutputsSinglePriceData.Controls.Add(this.pnlOutputsCol2, 1, 0);
            this.tpnlOutputsSinglePriceData.Controls.Add(this.pnlOutputsCol1, 0, 0);
            this.tpnlOutputsSinglePriceData.Controls.Add(this.pnlOutputsCol3, 2, 0);
            this.tpnlOutputsSinglePriceData.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnlOutputsSinglePriceData.Location = new System.Drawing.Point(10, 80);
            this.tpnlOutputsSinglePriceData.Name = "tpnlOutputsSinglePriceData";
            this.tpnlOutputsSinglePriceData.RowCount = 1;
            this.tpnlOutputsSinglePriceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlOutputsSinglePriceData.Size = new System.Drawing.Size(1030, 451);
            this.tpnlOutputsSinglePriceData.TabIndex = 3;
            // 
            // pnlOutputsCol2
            // 
            this.pnlOutputsCol2.Controls.Add(this.dgvAllSharePrices);
            this.pnlOutputsCol2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsCol2.Location = new System.Drawing.Point(81, 30);
            this.pnlOutputsCol2.Margin = new System.Windows.Forms.Padding(30);
            this.pnlOutputsCol2.Name = "pnlOutputsCol2";
            this.pnlOutputsCol2.Size = new System.Drawing.Size(867, 391);
            this.pnlOutputsCol2.TabIndex = 12;
            // 
            // dgvAllSharePrices
            // 
            this.dgvAllSharePrices.AllowUserToAddRows = false;
            this.dgvAllSharePrices.AllowUserToDeleteRows = false;
            this.dgvAllSharePrices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllSharePrices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllSharePrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllSharePrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jan,
            this.Feb,
            this.Mar,
            this.Apr,
            this.May,
            this.Jun,
            this.Jul,
            this.Aug,
            this.Sep,
            this.Oct,
            this.Nov,
            this.Dec});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllSharePrices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllSharePrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllSharePrices.Location = new System.Drawing.Point(0, 0);
            this.dgvAllSharePrices.Margin = new System.Windows.Forms.Padding(0);
            this.dgvAllSharePrices.Name = "dgvAllSharePrices";
            this.dgvAllSharePrices.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllSharePrices.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllSharePrices.RowHeadersWidth = 50;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAllSharePrices.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllSharePrices.Size = new System.Drawing.Size(867, 391);
            this.dgvAllSharePrices.TabIndex = 11;
            // 
            // Jan
            // 
            this.Jan.HeaderText = "Jan";
            this.Jan.Name = "Jan";
            this.Jan.ReadOnly = true;
            // 
            // Feb
            // 
            this.Feb.HeaderText = "Feb";
            this.Feb.Name = "Feb";
            this.Feb.ReadOnly = true;
            // 
            // Mar
            // 
            this.Mar.HeaderText = "Mar";
            this.Mar.Name = "Mar";
            this.Mar.ReadOnly = true;
            // 
            // Apr
            // 
            this.Apr.HeaderText = "Apr";
            this.Apr.Name = "Apr";
            this.Apr.ReadOnly = true;
            // 
            // May
            // 
            this.May.HeaderText = "May";
            this.May.Name = "May";
            this.May.ReadOnly = true;
            // 
            // Jun
            // 
            this.Jun.HeaderText = "Jun";
            this.Jun.Name = "Jun";
            this.Jun.ReadOnly = true;
            // 
            // Jul
            // 
            this.Jul.HeaderText = "Jul";
            this.Jul.Name = "Jul";
            this.Jul.ReadOnly = true;
            // 
            // Aug
            // 
            this.Aug.HeaderText = "Aug";
            this.Aug.Name = "Aug";
            this.Aug.ReadOnly = true;
            // 
            // Sep
            // 
            this.Sep.HeaderText = "Sep";
            this.Sep.Name = "Sep";
            this.Sep.ReadOnly = true;
            // 
            // Oct
            // 
            this.Oct.HeaderText = "Oct";
            this.Oct.Name = "Oct";
            this.Oct.ReadOnly = true;
            // 
            // Nov
            // 
            this.Nov.HeaderText = "Nov";
            this.Nov.Name = "Nov";
            this.Nov.ReadOnly = true;
            // 
            // Dec
            // 
            this.Dec.HeaderText = "Dec";
            this.Dec.Name = "Dec";
            this.Dec.ReadOnly = true;
            // 
            // pnlOutputsCol1
            // 
            this.pnlOutputsCol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsCol1.Location = new System.Drawing.Point(10, 10);
            this.pnlOutputsCol1.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsCol1.Name = "pnlOutputsCol1";
            this.pnlOutputsCol1.Size = new System.Drawing.Size(31, 431);
            this.pnlOutputsCol1.TabIndex = 13;
            // 
            // pnlOutputsCol3
            // 
            this.pnlOutputsCol3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutputsCol3.Location = new System.Drawing.Point(988, 10);
            this.pnlOutputsCol3.Margin = new System.Windows.Forms.Padding(10);
            this.pnlOutputsCol3.Name = "pnlOutputsCol3";
            this.pnlOutputsCol3.Size = new System.Drawing.Size(32, 431);
            this.pnlOutputsCol3.TabIndex = 14;
            // 
            // tpnlInputsSinglePriceData
            // 
            this.tpnlInputsSinglePriceData.ColumnCount = 8;
            this.tpnlInputsSinglePriceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlInputsSinglePriceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlInputsSinglePriceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlInputsSinglePriceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlInputsSinglePriceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlInputsSinglePriceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlInputsSinglePriceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlInputsSinglePriceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tpnlInputsSinglePriceData.Controls.Add(this.pnlInputsCol8, 7, 0);
            this.tpnlInputsSinglePriceData.Controls.Add(this.pnlInputsCol7, 6, 0);
            this.tpnlInputsSinglePriceData.Controls.Add(this.pnlInputsCol6, 5, 0);
            this.tpnlInputsSinglePriceData.Controls.Add(this.pnlInputsCol5, 4, 0);
            this.tpnlInputsSinglePriceData.Controls.Add(this.pnlInputsCol4, 3, 0);
            this.tpnlInputsSinglePriceData.Controls.Add(this.pnlInputsCol3, 2, 0);
            this.tpnlInputsSinglePriceData.Controls.Add(this.pnlInputsCol2, 1, 0);
            this.tpnlInputsSinglePriceData.Controls.Add(this.pnlInputsCol1, 0, 0);
            this.tpnlInputsSinglePriceData.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpnlInputsSinglePriceData.Location = new System.Drawing.Point(10, 10);
            this.tpnlInputsSinglePriceData.Name = "tpnlInputsSinglePriceData";
            this.tpnlInputsSinglePriceData.RowCount = 1;
            this.tpnlInputsSinglePriceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpnlInputsSinglePriceData.Size = new System.Drawing.Size(1030, 70);
            this.tpnlInputsSinglePriceData.TabIndex = 2;
            // 
            // pnlInputsCol8
            // 
            this.pnlInputsCol8.Controls.Add(this.lblFooterHighestPrice);
            this.pnlInputsCol8.Controls.Add(this.lblFooterLowestPrice);
            this.pnlInputsCol8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsCol8.Location = new System.Drawing.Point(906, 10);
            this.pnlInputsCol8.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsCol8.Name = "pnlInputsCol8";
            this.pnlInputsCol8.Size = new System.Drawing.Size(114, 50);
            this.pnlInputsCol8.TabIndex = 8;
            // 
            // lblFooterHighestPrice
            // 
            this.lblFooterHighestPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooterHighestPrice.Location = new System.Drawing.Point(0, 27);
            this.lblFooterHighestPrice.Margin = new System.Windows.Forms.Padding(3);
            this.lblFooterHighestPrice.Name = "lblFooterHighestPrice";
            this.lblFooterHighestPrice.Size = new System.Drawing.Size(114, 23);
            this.lblFooterHighestPrice.TabIndex = 11;
            this.lblFooterHighestPrice.Text = "0";
            this.lblFooterHighestPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFooterLowestPrice
            // 
            this.lblFooterLowestPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFooterLowestPrice.Location = new System.Drawing.Point(0, 0);
            this.lblFooterLowestPrice.Margin = new System.Windows.Forms.Padding(3);
            this.lblFooterLowestPrice.Name = "lblFooterLowestPrice";
            this.lblFooterLowestPrice.Size = new System.Drawing.Size(114, 23);
            this.lblFooterLowestPrice.TabIndex = 10;
            this.lblFooterLowestPrice.Text = "0";
            this.lblFooterLowestPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInputsCol7
            // 
            this.pnlInputsCol7.Controls.Add(this.lblHeaderHighestPrice);
            this.pnlInputsCol7.Controls.Add(this.lblHeaderLowestPrice);
            this.pnlInputsCol7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsCol7.Location = new System.Drawing.Point(778, 10);
            this.pnlInputsCol7.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsCol7.Name = "pnlInputsCol7";
            this.pnlInputsCol7.Size = new System.Drawing.Size(108, 50);
            this.pnlInputsCol7.TabIndex = 7;
            // 
            // lblHeaderHighestPrice
            // 
            this.lblHeaderHighestPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHeaderHighestPrice.Location = new System.Drawing.Point(0, 27);
            this.lblHeaderHighestPrice.Margin = new System.Windows.Forms.Padding(3);
            this.lblHeaderHighestPrice.Name = "lblHeaderHighestPrice";
            this.lblHeaderHighestPrice.Size = new System.Drawing.Size(108, 23);
            this.lblHeaderHighestPrice.TabIndex = 9;
            this.lblHeaderHighestPrice.Text = "Highest:";
            this.lblHeaderHighestPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHeaderLowestPrice
            // 
            this.lblHeaderLowestPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderLowestPrice.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderLowestPrice.Margin = new System.Windows.Forms.Padding(3);
            this.lblHeaderLowestPrice.Name = "lblHeaderLowestPrice";
            this.lblHeaderLowestPrice.Size = new System.Drawing.Size(108, 23);
            this.lblHeaderLowestPrice.TabIndex = 8;
            this.lblHeaderLowestPrice.Text = "Lowest:";
            this.lblHeaderLowestPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlInputsCol6
            // 
            this.pnlInputsCol6.Controls.Add(this.btnDisplay);
            this.pnlInputsCol6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsCol6.Location = new System.Drawing.Point(650, 10);
            this.pnlInputsCol6.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsCol6.Name = "pnlInputsCol6";
            this.pnlInputsCol6.Size = new System.Drawing.Size(108, 50);
            this.pnlInputsCol6.TabIndex = 10;
            // 
            // pnlInputsCol5
            // 
            this.pnlInputsCol5.Controls.Add(this.lblPriceType);
            this.pnlInputsCol5.Controls.Add(this.cboxPriceType);
            this.pnlInputsCol5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsCol5.Location = new System.Drawing.Point(522, 10);
            this.pnlInputsCol5.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsCol5.Name = "pnlInputsCol5";
            this.pnlInputsCol5.Size = new System.Drawing.Size(108, 50);
            this.pnlInputsCol5.TabIndex = 5;
            // 
            // pnlInputsCol4
            // 
            this.pnlInputsCol4.Controls.Add(this.lblASXShare);
            this.pnlInputsCol4.Controls.Add(this.tboxASXShare);
            this.pnlInputsCol4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsCol4.Location = new System.Drawing.Point(394, 10);
            this.pnlInputsCol4.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsCol4.Name = "pnlInputsCol4";
            this.pnlInputsCol4.Size = new System.Drawing.Size(108, 50);
            this.pnlInputsCol4.TabIndex = 4;
            // 
            // pnlInputsCol3
            // 
            this.pnlInputsCol3.Controls.Add(this.lblYear);
            this.pnlInputsCol3.Controls.Add(this.tboxYear);
            this.pnlInputsCol3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsCol3.Location = new System.Drawing.Point(266, 10);
            this.pnlInputsCol3.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsCol3.Name = "pnlInputsCol3";
            this.pnlInputsCol3.Size = new System.Drawing.Size(108, 50);
            this.pnlInputsCol3.TabIndex = 3;
            // 
            // pnlInputsCol2
            // 
            this.pnlInputsCol2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsCol2.Location = new System.Drawing.Point(138, 10);
            this.pnlInputsCol2.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsCol2.Name = "pnlInputsCol2";
            this.pnlInputsCol2.Size = new System.Drawing.Size(108, 50);
            this.pnlInputsCol2.TabIndex = 2;
            // 
            // pnlInputsCol1
            // 
            this.pnlInputsCol1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputsCol1.Location = new System.Drawing.Point(10, 10);
            this.pnlInputsCol1.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInputsCol1.Name = "pnlInputsCol1";
            this.pnlInputsCol1.Size = new System.Drawing.Size(108, 50);
            this.pnlInputsCol1.TabIndex = 1;
            // 
            // UC_Tab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainerSinglePriceData);
            this.Controls.Add(this.pnlHeaderSinglePriceData);
            this.Name = "UC_Tab1";
            this.Size = new System.Drawing.Size(1050, 640);
            this.pnlHeaderSinglePriceData.ResumeLayout(false);
            this.pnlHeaderSinglePriceData.PerformLayout();
            this.pnlContainerSinglePriceData.ResumeLayout(false);
            this.tpnlOutputsSinglePriceData.ResumeLayout(false);
            this.pnlOutputsCol2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSharePrices)).EndInit();
            this.tpnlInputsSinglePriceData.ResumeLayout(false);
            this.pnlInputsCol8.ResumeLayout(false);
            this.pnlInputsCol7.ResumeLayout(false);
            this.pnlInputsCol6.ResumeLayout(false);
            this.pnlInputsCol5.ResumeLayout(false);
            this.pnlInputsCol4.ResumeLayout(false);
            this.pnlInputsCol4.PerformLayout();
            this.pnlInputsCol3.ResumeLayout(false);
            this.pnlInputsCol3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeaderSinglePriceData;
        private System.Windows.Forms.Label lblHeaderSinglePriceData;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox tboxASXShare;
        private System.Windows.Forms.Label lblASXShare;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox tboxYear;
        private System.Windows.Forms.Label lblPriceType;
        private System.Windows.Forms.ComboBox cboxPriceType;
        private System.Windows.Forms.Panel pnlContainerSinglePriceData;
        private System.Windows.Forms.TableLayoutPanel tpnlInputsSinglePriceData;
        private System.Windows.Forms.Panel pnlInputsCol1;
        private System.Windows.Forms.Panel pnlInputsCol2;
        private System.Windows.Forms.Panel pnlInputsCol3;
        private System.Windows.Forms.Panel pnlInputsCol4;
        private System.Windows.Forms.Panel pnlInputsCol8;
        private System.Windows.Forms.Panel pnlInputsCol7;
        private System.Windows.Forms.Panel pnlInputsCol6;
        private System.Windows.Forms.Panel pnlInputsCol5;
        private System.Windows.Forms.TableLayoutPanel tpnlOutputsSinglePriceData;
        private System.Windows.Forms.DataGridView dgvAllSharePrices;
        private System.Windows.Forms.Panel pnlOutputsCol1;
        private System.Windows.Forms.Panel pnlOutputsCol2;
        private System.Windows.Forms.Panel pnlOutputsCol3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apr;
        private System.Windows.Forms.DataGridViewTextBoxColumn May;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dec;
        private System.Windows.Forms.Label lblFooterHighestPrice;
        private System.Windows.Forms.Label lblFooterLowestPrice;
        private System.Windows.Forms.Label lblHeaderHighestPrice;
        private System.Windows.Forms.Label lblHeaderLowestPrice;
    }
}
