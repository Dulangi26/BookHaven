namespace BookHaven.Forms.Reports
{
    partial class InventoryReportForm
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
            label1 = new Label();
            dgvInventoryReport = new DataGridView();
            btnRefresh = new Button();
            btnback = new Button();
            btnExit = new Button();
            btnExportToExcel = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnClearSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryReport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 26);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 0;
            label1.Text = "Inventory Report";
            label1.Click += label1_Click;
            // 
            // dgvInventoryReport
            // 
            dgvInventoryReport.BackgroundColor = Color.White;
            dgvInventoryReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventoryReport.Location = new Point(24, 125);
            dgvInventoryReport.Name = "dgvInventoryReport";
            dgvInventoryReport.RowHeadersWidth = 51;
            dgvInventoryReport.Size = new Size(764, 308);
            dgvInventoryReport.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(211, 439);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(101, 34);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnback
            // 
            btnback.Location = new Point(24, 466);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 21;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(694, 466);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 20;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportToExcel.Location = new Point(318, 439);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(154, 34);
            btnExportToExcel.TabIndex = 22;
            btnExportToExcel.Text = "ExportToExcel";
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(210, 83);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(24, 83);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 23;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(310, 83);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(124, 29);
            btnClearSearch.TabIndex = 27;
            btnClearSearch.Text = "CLEAR SEARCH";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // InventoryReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(btnClearSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnExportToExcel);
            Controls.Add(btnback);
            Controls.Add(btnExit);
            Controls.Add(btnRefresh);
            Controls.Add(dgvInventoryReport);
            Controls.Add(label1);
            Name = "InventoryReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryReportForm";
            Load += InventoryReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventoryReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvInventoryReport;
        private Button btnRefresh;
        private Button btnback;
        private Button btnExit;
        private Button btnExportToExcel;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClearSearch;
    }
}