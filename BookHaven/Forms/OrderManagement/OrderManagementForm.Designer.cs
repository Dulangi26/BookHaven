namespace BookHaven.Forms.OrderManagement
{
    partial class OrderManagementForm
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
            btnClearSearch = new Button();
            label8 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            button1 = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            lblTotalAmount = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dtpOrderDate = new DateTimePicker();
            cmbOrderStatus = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            cmbBooks = new ComboBox();
            btnProceedToNext = new Button();
            btnCalculateTotal = new Button();
            cmbCustomer = new ComboBox();
            txtQuantity = new TextBox();
            label5 = new Label();
            dgvOrders = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(456, 62);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(124, 29);
            btnClearSearch.TabIndex = 95;
            btnClearSearch.Text = "CLEAR SEARCH";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(457, 28);
            label8.Name = "label8";
            label8.Size = new Size(197, 28);
            label8.TabIndex = 94;
            label8.Text = "Order Management";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(356, 62);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 93;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(170, 62);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 92;
            // 
            // button1
            // 
            button1.Location = new Point(212, 695);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 91;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(798, 695);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 90;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotalAmount);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(dtpOrderDate);
            groupBox1.Controls.Add(cmbOrderStatus);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmbBooks);
            groupBox1.Controls.Add(btnProceedToNext);
            groupBox1.Controls.Add(btnCalculateTotal);
            groupBox1.Controls.Add(cmbCustomer);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dgvOrders);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(70, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1029, 584);
            groupBox1.TabIndex = 89;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order Management";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(435, 433);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 23);
            lblTotalAmount.TabIndex = 43;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkTurquoise;
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(546, 528);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 33);
            btnClear.TabIndex = 42;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(728, 528);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 33);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.MediumSeaGreen;
            btnEdit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(363, 528);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(99, 33);
            btnEdit.TabIndex = 40;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(189, 528);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 33);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "ADD ADMIN";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(435, 394);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(351, 27);
            dtpOrderDate.TabIndex = 38;
            // 
            // cmbOrderStatus
            // 
            cmbOrderStatus.FormattingEnabled = true;
            cmbOrderStatus.Location = new Point(435, 355);
            cmbOrderStatus.Name = "cmbOrderStatus";
            cmbOrderStatus.Size = new Size(349, 28);
            cmbOrderStatus.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(268, 355);
            label7.Name = "label7";
            label7.Size = new Size(106, 23);
            label7.TabIndex = 36;
            label7.Text = "Order Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(269, 433);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 35;
            label6.Text = "Total Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(269, 394);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 34;
            label4.Text = "Order Date";
            // 
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(435, 257);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(349, 28);
            cmbBooks.TabIndex = 33;
            // 
            // btnProceedToNext
            // 
            btnProceedToNext.BackColor = Color.DarkCyan;
            btnProceedToNext.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceedToNext.ForeColor = Color.White;
            btnProceedToNext.Location = new Point(655, 470);
            btnProceedToNext.Name = "btnProceedToNext";
            btnProceedToNext.Size = new Size(211, 52);
            btnProceedToNext.TabIndex = 32;
            btnProceedToNext.Text = "ProceedToNext";
            btnProceedToNext.UseVisualStyleBackColor = false;
            btnProceedToNext.Click += btnProceedToNext_Click;
            // 
            // btnCalculateTotal
            // 
            btnCalculateTotal.BackColor = Color.ForestGreen;
            btnCalculateTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculateTotal.ForeColor = Color.White;
            btnCalculateTotal.Location = new Point(252, 470);
            btnCalculateTotal.Name = "btnCalculateTotal";
            btnCalculateTotal.Size = new Size(211, 52);
            btnCalculateTotal.TabIndex = 31;
            btnCalculateTotal.Text = "Calculate Total";
            btnCalculateTotal.UseVisualStyleBackColor = false;
            btnCalculateTotal.Click += btnCalculateTotal_Click;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(435, 214);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(349, 28);
            cmbCustomer.TabIndex = 29;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(435, 305);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(345, 30);
            txtQuantity.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(268, 308);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 27;
            label5.Text = "Quantity";
            // 
            // dgvOrders
            // 
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(25, 26);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(973, 176);
            dgvOrders.TabIndex = 10;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 257);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 22;
            label2.Text = "Books";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 214);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 21;
            label1.Text = "Customer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 752);
            Controls.Add(btnClearSearch);
            Controls.Add(label8);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Name = "OrderManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderManagementForm";
            Load += OrderManagementForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClearSearch;
        private Label label8;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button button1;
        private Button btnExit;
        private GroupBox groupBox1;
        private Label lblTotalAmount;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DateTimePicker dtpOrderDate;
        private ComboBox cmbOrderStatus;
        private Label label7;
        private Label label6;
        private Label label4;
        private ComboBox cmbBooks;
        private Button btnProceedToNext;
        private Button btnCalculateTotal;
        private ComboBox cmbCustomer;
        private TextBox txtQuantity;
        private Label label5;
        private DataGridView dgvOrders;
        private Label label2;
        private Label label1;
    }
}