namespace BookHaven.Forms.Reports
{
    partial class SalesReportForm
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
            dgvSalesReport = new DataGridView();
            btnRefresh = new Button();
            label1 = new Label();
            button1 = new Button();
            btnExit = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnClearSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).BeginInit();
            SuspendLayout();
            // 
            // dgvSalesReport
            // 
            dgvSalesReport.BackgroundColor = Color.White;
            dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesReport.Location = new Point(12, 117);
            dgvSalesReport.Name = "dgvSalesReport";
            dgvSalesReport.RowHeadersWidth = 51;
            dgvSalesReport.Size = new Size(776, 338);
            dgvSalesReport.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(335, 461);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 37);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 26);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 2;
            label1.Text = "Sales Report";
            // 
            // button1
            // 
            button1.Location = new Point(25, 512);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(694, 512);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(198, 84);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 84);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 22;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(298, 84);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(124, 29);
            btnClearSearch.TabIndex = 28;
            btnClearSearch.Text = "CLEAR SEARCH";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // SalesReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(btnClearSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(dgvSalesReport);
            Name = "SalesReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Reports";
            Load += SalesReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSalesReport;
        private Button btnRefresh;
        private Label label1;
        private Button button1;
        private Button btnExit;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClearSearch;
    }
}