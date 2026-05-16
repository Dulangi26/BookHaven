namespace BookHaven.Forms.Reports
{
    partial class CustomerReportForm
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
            btnback = new Button();
            btnExit = new Button();
            label1 = new Label();
            btnRefresh = new Button();
            dgvCustomerReport = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClearSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerReport).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Location = new Point(180, 673);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 19;
            btnback.Text = "BACK";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(773, 673);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 18;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(469, 20);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 17;
            label1.Text = "Customer Report";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(456, 637);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 37);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvCustomerReport
            // 
            dgvCustomerReport.BackgroundColor = Color.White;
            dgvCustomerReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerReport.Location = new Point(12, 98);
            dgvCustomerReport.Name = "dgvCustomerReport";
            dgvCustomerReport.RowHeadersWidth = 51;
            dgvCustomerReport.Size = new Size(1134, 533);
            dgvCustomerReport.TabIndex = 15;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(198, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(301, 63);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(124, 29);
            btnClearSearch.TabIndex = 26;
            btnClearSearch.Text = "CLEAR SEARCH";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // CustomerReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 714);
            Controls.Add(btnClearSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnback);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(dgvCustomerReport);
            Name = "CustomerReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerReportForm";
            Load += CustomerReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
        private Button btnExit;
        private Label label1;
        private Button btnRefresh;
        private DataGridView dgvCustomerReport;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClearSearch;
    }
}