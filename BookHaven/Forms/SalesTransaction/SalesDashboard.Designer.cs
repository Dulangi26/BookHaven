namespace BookHaven.Forms
{
    partial class SalesDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDashboardForm));
            lblSalesDashboardTitle = new Label();
            groupBox1 = new GroupBox();
            salesChart = new LiveCharts.WinForms.CartesianChart();
            groupBox2 = new GroupBox();
            pictureBox4 = new PictureBox();
            lblAvgSaleAmount = new Label();
            pictureBox3 = new PictureBox();
            lblTotalQuantitySold = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblTotalSales = new Label();
            lblTotalTransactions = new Label();
            btnUpdateChart = new Button();
            btnViewDetailedSales = new Button();
            dgvSalesDetails = new DataGridView();
            button1 = new Button();
            btnExit = new Button();
            groupBox3 = new GroupBox();
            btnBookManagement = new Button();
            btnReport = new Button();
            label1 = new Label();
            btnOrderManagement = new Button();
            btnLogout = new Button();
            btnSales = new Button();
            btnCustomers = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalesDetails).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblSalesDashboardTitle
            // 
            lblSalesDashboardTitle.AutoSize = true;
            lblSalesDashboardTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesDashboardTitle.ForeColor = Color.FromArgb(0, 0, 64);
            lblSalesDashboardTitle.Location = new Point(443, 9);
            lblSalesDashboardTitle.Name = "lblSalesDashboardTitle";
            lblSalesDashboardTitle.Size = new Size(230, 31);
            lblSalesDashboardTitle.TabIndex = 5;
            lblSalesDashboardTitle.Text = "SALES DASHBOARD";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(salesChart);
            groupBox1.Location = new Point(278, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1054, 316);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sales Chart";
            // 
            // salesChart
            // 
            salesChart.BackColor = Color.White;
            salesChart.Dock = DockStyle.Fill;
            salesChart.Location = new Point(3, 23);
            salesChart.Name = "salesChart";
            salesChart.Size = new Size(1048, 290);
            salesChart.TabIndex = 0;
            salesChart.Text = "cartesianChart1";
            salesChart.ChildChanged += salesChart_ChildChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(lblAvgSaleAmount);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(lblTotalQuantitySold);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(lblTotalSales);
            groupBox2.Controls.Add(lblTotalTransactions);
            groupBox2.Location = new Point(281, 460);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1051, 203);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sales Summary";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(20, 128);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 69);
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // lblAvgSaleAmount
            // 
            lblAvgSaleAmount.AutoSize = true;
            lblAvgSaleAmount.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblAvgSaleAmount.Location = new Point(95, 150);
            lblAvgSaleAmount.Name = "lblAvgSaleAmount";
            lblAvgSaleAmount.Size = new Size(160, 25);
            lblAvgSaleAmount.TabIndex = 13;
            lblAvgSaleAmount.Text = "AvgSaleAmount :";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(487, 118);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 69);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // lblTotalQuantitySold
            // 
            lblTotalQuantitySold.AutoSize = true;
            lblTotalQuantitySold.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalQuantitySold.Location = new Point(562, 140);
            lblTotalQuantitySold.Name = "lblTotalQuantitySold";
            lblTotalQuantitySold.Size = new Size(186, 25);
            lblTotalQuantitySold.TabIndex = 11;
            lblTotalQuantitySold.Text = "Total Quantity Sold :";
            lblTotalQuantitySold.Click += lblProfit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.salestoday;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(487, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 69);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.totalsales;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(20, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 69);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalSales.Location = new Point(95, 58);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(112, 25);
            lblTotalSales.TabIndex = 7;
            lblTotalSales.Text = "Total Sales :";
            lblTotalSales.Click += lblTotalSales_Click;
            // 
            // lblTotalTransactions
            // 
            lblTotalTransactions.AutoSize = true;
            lblTotalTransactions.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalTransactions.Location = new Point(562, 48);
            lblTotalTransactions.Name = "lblTotalTransactions";
            lblTotalTransactions.Size = new Size(176, 25);
            lblTotalTransactions.TabIndex = 8;
            lblTotalTransactions.Text = "Total Transactions :";
            lblTotalTransactions.Click += lblTotalExpenses_Click;
            // 
            // btnUpdateChart
            // 
            btnUpdateChart.BackColor = Color.ForestGreen;
            btnUpdateChart.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateChart.ForeColor = Color.White;
            btnUpdateChart.Location = new Point(537, 392);
            btnUpdateChart.Name = "btnUpdateChart";
            btnUpdateChart.Size = new Size(211, 52);
            btnUpdateChart.TabIndex = 27;
            btnUpdateChart.Text = "Update Chart";
            btnUpdateChart.UseVisualStyleBackColor = false;
            btnUpdateChart.Click += btnUpdateChart_Click;
            // 
            // btnViewDetailedSales
            // 
            btnViewDetailedSales.BackColor = Color.DarkCyan;
            btnViewDetailedSales.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewDetailedSales.ForeColor = Color.White;
            btnViewDetailedSales.Location = new Point(858, 392);
            btnViewDetailedSales.Name = "btnViewDetailedSales";
            btnViewDetailedSales.Size = new Size(211, 52);
            btnViewDetailedSales.TabIndex = 28;
            btnViewDetailedSales.Text = "View Detailed Sales";
            btnViewDetailedSales.UseVisualStyleBackColor = false;
            btnViewDetailedSales.Click += btnViewDetailedSales_Click;
            // 
            // dgvSalesDetails
            // 
            dgvSalesDetails.BackgroundColor = Color.White;
            dgvSalesDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesDetails.Location = new Point(281, 682);
            dgvSalesDetails.Name = "dgvSalesDetails";
            dgvSalesDetails.RowHeadersWidth = 51;
            dgvSalesDetails.Size = new Size(1051, 188);
            dgvSalesDetails.TabIndex = 29;
            dgvSalesDetails.CellContentClick += dgvSalesDetails_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(301, 876);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 41;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1225, 876);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 40;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Gainsboro;
            groupBox3.Controls.Add(btnBookManagement);
            groupBox3.Controls.Add(btnReport);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btnOrderManagement);
            groupBox3.Controls.Add(btnLogout);
            groupBox3.Controls.Add(btnSales);
            groupBox3.Controls.Add(btnCustomers);
            groupBox3.Location = new Point(12, 38);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(260, 832);
            groupBox3.TabIndex = 42;
            groupBox3.TabStop = false;
            // 
            // btnBookManagement
            // 
            btnBookManagement.BackColor = Color.CornflowerBlue;
            btnBookManagement.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookManagement.ForeColor = Color.White;
            btnBookManagement.Location = new Point(20, 305);
            btnBookManagement.Name = "btnBookManagement";
            btnBookManagement.Size = new Size(230, 42);
            btnBookManagement.TabIndex = 45;
            btnBookManagement.Text = "Book Management";
            btnBookManagement.UseVisualStyleBackColor = false;
            btnBookManagement.Click += btnBookManagement_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.CornflowerBlue;
            btnReport.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Location = new Point(20, 246);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(230, 42);
            btnReport.TabIndex = 44;
            btnReport.Text = "Reports";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(20, 23);
            label1.Name = "label1";
            label1.Size = new Size(230, 31);
            label1.TabIndex = 43;
            label1.Text = "SALES DASHBOARD";
            // 
            // btnOrderManagement
            // 
            btnOrderManagement.BackColor = Color.CornflowerBlue;
            btnOrderManagement.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderManagement.ForeColor = Color.White;
            btnOrderManagement.Location = new Point(20, 188);
            btnOrderManagement.Name = "btnOrderManagement";
            btnOrderManagement.Size = new Size(230, 42);
            btnOrderManagement.TabIndex = 6;
            btnOrderManagement.Text = "Order Management";
            btnOrderManagement.UseVisualStyleBackColor = false;
            btnOrderManagement.Click += btnOrderManagement_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.CornflowerBlue;
            btnLogout.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(20, 773);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(230, 42);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.CornflowerBlue;
            btnSales.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(20, 131);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(230, 42);
            btnSales.TabIndex = 3;
            btnSales.Text = "Sales Transactions";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.CornflowerBlue;
            btnCustomers.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(20, 73);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(230, 42);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "Customer Management";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // SalesDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 917);
            Controls.Add(groupBox3);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(dgvSalesDetails);
            Controls.Add(btnViewDetailedSales);
            Controls.Add(btnUpdateChart);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblSalesDashboardTitle);
            Name = "SalesDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesDashboard";
            Load += SalesDashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalesDetails).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalesDashboardTitle;
        private GroupBox groupBox1;
        private LiveCharts.WinForms.CartesianChart salesChart;
        private GroupBox groupBox2;
        private PictureBox pictureBox3;
        private Label lblTotalQuantitySold;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblTotalSales;
        private Label lblTotalTransactions;
        private Button btnUpdateChart;
        private Button btnViewDetailedSales;
        private DataGridView dgvSalesDetails;
        private Button button1;
        private Button btnExit;
        private GroupBox groupBox3;
        private Label label1;
        private Button btnOrderManagement;
        private Button btnLogout;
        private Button btnSales;
        private Button btnCustomers;
        private PictureBox pictureBox4;
        private Label lblAvgSaleAmount;
        private Button btnReport;
        private Button btnBookManagement;
    }
}