namespace BookHaven.Forms.Admin
{
    partial class AdminDashboardForm
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
            grpTotalBooks = new GroupBox();
            pictureBox1 = new PictureBox();
            lblTotalBooks = new Label();
            grpTotalCustomers = new GroupBox();
            pictureBox2 = new PictureBox();
            lblTotalCustomers = new Label();
            grpTotalSales = new GroupBox();
            pictureBox3 = new PictureBox();
            lblTotalSales = new Label();
            grpLowStock = new GroupBox();
            pictureBox4 = new PictureBox();
            lblLowStock = new Label();
            groupBox2 = new GroupBox();
            btnpayment = new Button();
            btnSecurity = new Button();
            btnAdControl = new Button();
            btnSupplierManagement = new Button();
            btnOrderManagement = new Button();
            btnLogout = new Button();
            btnReports = new Button();
            btnSales = new Button();
            btnCustomers = new Button();
            btnBooks = new Button();
            label1 = new Label();
            grpTotalBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpTotalCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            grpTotalSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grpTotalBooks
            // 
            grpTotalBooks.BackColor = SystemColors.ButtonHighlight;
            grpTotalBooks.Controls.Add(pictureBox1);
            grpTotalBooks.Controls.Add(lblTotalBooks);
            grpTotalBooks.Location = new Point(325, 12);
            grpTotalBooks.Name = "grpTotalBooks";
            grpTotalBooks.Size = new Size(200, 100);
            grpTotalBooks.TabIndex = 0;
            grpTotalBooks.TabStop = false;
            grpTotalBooks.Text = "Total Books";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.book;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(15, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 62);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.AutoSize = true;
            lblTotalBooks.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBooks.ForeColor = Color.DarkGreen;
            lblTotalBooks.Location = new Point(137, 30);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(0, 41);
            lblTotalBooks.TabIndex = 0;
            // 
            // grpTotalCustomers
            // 
            grpTotalCustomers.BackColor = SystemColors.ButtonHighlight;
            grpTotalCustomers.Controls.Add(pictureBox2);
            grpTotalCustomers.Controls.Add(lblTotalCustomers);
            grpTotalCustomers.Location = new Point(531, 12);
            grpTotalCustomers.Name = "grpTotalCustomers";
            grpTotalCustomers.Size = new Size(200, 100);
            grpTotalCustomers.TabIndex = 1;
            grpTotalCustomers.TabStop = false;
            grpTotalCustomers.Text = "Total Customers";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.customer;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(15, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 62);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCustomers.ForeColor = Color.DarkGreen;
            lblTotalCustomers.Location = new Point(144, 30);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(0, 41);
            lblTotalCustomers.TabIndex = 1;
            // 
            // grpTotalSales
            // 
            grpTotalSales.BackColor = SystemColors.ButtonHighlight;
            grpTotalSales.Controls.Add(pictureBox3);
            grpTotalSales.Controls.Add(lblTotalSales);
            grpTotalSales.Location = new Point(737, 12);
            grpTotalSales.Name = "grpTotalSales";
            grpTotalSales.Size = new Size(200, 100);
            grpTotalSales.TabIndex = 2;
            grpTotalSales.TabStop = false;
            grpTotalSales.Text = "Total Sales Revenue";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.sales;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(16, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 62);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.ForeColor = Color.DarkGreen;
            lblTotalSales.Location = new Point(143, 30);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(0, 41);
            lblTotalSales.TabIndex = 1;
            // 
            // grpLowStock
            // 
            grpLowStock.BackColor = SystemColors.ButtonHighlight;
            grpLowStock.Controls.Add(pictureBox4);
            grpLowStock.Controls.Add(lblLowStock);
            grpLowStock.Location = new Point(943, 12);
            grpLowStock.Name = "grpLowStock";
            grpLowStock.Size = new Size(200, 100);
            grpLowStock.TabIndex = 3;
            grpLowStock.TabStop = false;
            grpLowStock.Text = "Low Stock Alerts";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.reports;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(18, 26);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(58, 62);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.ForeColor = Color.Red;
            lblLowStock.Location = new Point(149, 30);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(0, 41);
            lblLowStock.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gainsboro;
            groupBox2.Controls.Add(btnpayment);
            groupBox2.Controls.Add(btnSecurity);
            groupBox2.Controls.Add(btnAdControl);
            groupBox2.Controls.Add(btnSupplierManagement);
            groupBox2.Controls.Add(btnOrderManagement);
            groupBox2.Controls.Add(btnLogout);
            groupBox2.Controls.Add(btnReports);
            groupBox2.Controls.Add(btnSales);
            groupBox2.Controls.Add(btnCustomers);
            groupBox2.Controls.Add(btnBooks);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 595);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // btnpayment
            // 
            btnpayment.BackColor = Color.CornflowerBlue;
            btnpayment.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpayment.ForeColor = Color.White;
            btnpayment.Location = new Point(20, 417);
            btnpayment.Name = "btnpayment";
            btnpayment.Size = new Size(269, 42);
            btnpayment.TabIndex = 10;
            btnpayment.Text = "Payment Management";
            btnpayment.UseVisualStyleBackColor = false;
            btnpayment.Click += btnpayment_Click;
            // 
            // btnSecurity
            // 
            btnSecurity.BackColor = Color.CornflowerBlue;
            btnSecurity.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSecurity.ForeColor = Color.White;
            btnSecurity.Location = new Point(20, 465);
            btnSecurity.Name = "btnSecurity";
            btnSecurity.Size = new Size(269, 42);
            btnSecurity.TabIndex = 9;
            btnSecurity.Text = "Security";
            btnSecurity.UseVisualStyleBackColor = false;
            btnSecurity.Click += btnSecurity_Click;
            // 
            // btnAdControl
            // 
            btnAdControl.BackColor = Color.CornflowerBlue;
            btnAdControl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdControl.ForeColor = Color.White;
            btnAdControl.Location = new Point(20, 79);
            btnAdControl.Name = "btnAdControl";
            btnAdControl.Size = new Size(269, 42);
            btnAdControl.TabIndex = 8;
            btnAdControl.Text = "Admin Controls";
            btnAdControl.UseVisualStyleBackColor = false;
            btnAdControl.Click += btnAdControl_Click;
            // 
            // btnSupplierManagement
            // 
            btnSupplierManagement.BackColor = Color.CornflowerBlue;
            btnSupplierManagement.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupplierManagement.ForeColor = Color.White;
            btnSupplierManagement.Location = new Point(20, 369);
            btnSupplierManagement.Name = "btnSupplierManagement";
            btnSupplierManagement.Size = new Size(269, 42);
            btnSupplierManagement.TabIndex = 7;
            btnSupplierManagement.Text = "Supplier Management\n";
            btnSupplierManagement.UseVisualStyleBackColor = false;
            btnSupplierManagement.Click += btnSupplierManagement_Click;
            // 
            // btnOrderManagement
            // 
            btnOrderManagement.BackColor = Color.CornflowerBlue;
            btnOrderManagement.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderManagement.ForeColor = Color.White;
            btnOrderManagement.Location = new Point(20, 321);
            btnOrderManagement.Name = "btnOrderManagement";
            btnOrderManagement.Size = new Size(269, 42);
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
            btnLogout.Location = new Point(20, 538);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(269, 42);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.CornflowerBlue;
            btnReports.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(20, 273);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(269, 42);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.CornflowerBlue;
            btnSales.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(20, 225);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(269, 42);
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
            btnCustomers.Location = new Point(20, 177);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(269, 42);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "Customer Management";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnBooks
            // 
            btnBooks.BackColor = Color.CornflowerBlue;
            btnBooks.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooks.ForeColor = Color.White;
            btnBooks.Location = new Point(20, 129);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(269, 42);
            btnBooks.TabIndex = 1;
            btnBooks.Text = "Book Management";
            btnBooks.UseVisualStyleBackColor = false;
            btnBooks.Click += btnBooks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(15, 23);
            label1.Name = "label1";
            label1.Size = new Size(244, 31);
            label1.TabIndex = 0;
            label1.Text = "ADMIN DASHBOARD";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1155, 619);
            Controls.Add(groupBox2);
            Controls.Add(grpLowStock);
            Controls.Add(grpTotalSales);
            Controls.Add(grpTotalCustomers);
            Controls.Add(grpTotalBooks);
            ForeColor = Color.Cornsilk;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminDashboardForm_Load;
            grpTotalBooks.ResumeLayout(false);
            grpTotalBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpTotalCustomers.ResumeLayout(false);
            grpTotalCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            grpTotalSales.ResumeLayout(false);
            grpTotalSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpLowStock.ResumeLayout(false);
            grpLowStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpTotalBooks;
        private GroupBox grpTotalCustomers;
        private GroupBox grpTotalSales;
        private GroupBox grpLowStock;
        private Label lblTotalBooks;
        private Label lblTotalCustomers;
        private Label lblTotalSales;
        private Label lblLowStock;
        private GroupBox groupBox2;
        private Label label1;
        private Button btnLogout;
        private Button btnReports;
        private Button btnSales;
        private Button btnCustomers;
        private Button btnBooks;
        private Button btnSupplierManagement;
        private Button btnOrderManagement;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnAdControl;
        private Button btnSecurity;
        private Button btnpayment;
    }
}