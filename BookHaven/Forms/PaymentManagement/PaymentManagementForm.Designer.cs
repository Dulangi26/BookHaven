namespace BookHaven.Forms.PaymentManagement
{
    partial class PaymentManagementForm
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
            groupBox1 = new GroupBox();
            cmbPaymentStatus = new ComboBox();
            txtCustomerID = new TextBox();
            label9 = new Label();
            txtSaleID = new TextBox();
            label7 = new Label();
            txtPaymentID = new TextBox();
            dtpPaymentDate = new DateTimePicker();
            cmbPaymentMethod = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            btnClearFields = new Button();
            txtAmount = new TextBox();
            label5 = new Label();
            txtOrderID = new TextBox();
            dgvPayments = new DataGridView();
            btnDeletePayment = new Button();
            btnEditPayment = new Button();
            label2 = new Label();
            btnAddPayment = new Button();
            label3 = new Label();
            label1 = new Label();
            btnClearSearch = new Button();
            label8 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnBack = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPaymentStatus);
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtSaleID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtPaymentID);
            groupBox1.Controls.Add(dtpPaymentDate);
            groupBox1.Controls.Add(cmbPaymentMethod);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnClearFields);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtOrderID);
            groupBox1.Controls.Add(dgvPayments);
            groupBox1.Controls.Add(btnDeletePayment);
            groupBox1.Controls.Add(btnEditPayment);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAddPayment);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(40, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1029, 584);
            groupBox1.TabIndex = 75;
            groupBox1.TabStop = false;
            groupBox1.Text = "Payment Management";
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(710, 494);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(298, 28);
            cmbPaymentStatus.TabIndex = 31;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerID.Location = new Point(212, 451);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(299, 30);
            txtCustomerID.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(57, 451);
            label9.Name = "label9";
            label9.Size = new Size(106, 23);
            label9.TabIndex = 29;
            label9.Text = "Customer ID";
            // 
            // txtSaleID
            // 
            txtSaleID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSaleID.Location = new Point(710, 355);
            txtSaleID.Name = "txtSaleID";
            txtSaleID.Size = new Size(299, 30);
            txtSaleID.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(555, 355);
            label7.Name = "label7";
            label7.Size = new Size(63, 23);
            label7.TabIndex = 27;
            label7.Text = "Sale ID";
            // 
            // txtPaymentID
            // 
            txtPaymentID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPaymentID.Location = new Point(212, 355);
            txtPaymentID.Name = "txtPaymentID";
            txtPaymentID.Size = new Size(299, 30);
            txtPaymentID.TabIndex = 26;
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Location = new Point(710, 451);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(298, 27);
            dtpPaymentDate.TabIndex = 25;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(710, 403);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(298, 28);
            cmbPaymentMethod.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(554, 445);
            label4.Name = "label4";
            label4.Size = new Size(114, 23);
            label4.TabIndex = 23;
            label4.Text = "PaymentDate\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(555, 499);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 21;
            label6.Text = "Status ";
            // 
            // btnClearFields
            // 
            btnClearFields.BackColor = Color.DarkTurquoise;
            btnClearFields.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearFields.ForeColor = Color.White;
            btnClearFields.Location = new Point(554, 535);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(99, 33);
            btnClearFields.TabIndex = 20;
            btnClearFields.Text = "CLEAR";
            btnClearFields.UseVisualStyleBackColor = false;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(212, 499);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(299, 30);
            txtAmount.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 499);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 14;
            label5.Text = "Amount\n";
            // 
            // txtOrderID
            // 
            txtOrderID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderID.Location = new Point(212, 401);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(299, 30);
            txtOrderID.TabIndex = 11;
            // 
            // dgvPayments
            // 
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Location = new Point(29, 42);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(973, 294);
            dgvPayments.TabIndex = 10;
            // 
            // btnDeletePayment
            // 
            btnDeletePayment.BackColor = Color.Red;
            btnDeletePayment.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletePayment.ForeColor = Color.White;
            btnDeletePayment.Location = new Point(736, 535);
            btnDeletePayment.Name = "btnDeletePayment";
            btnDeletePayment.Size = new Size(99, 33);
            btnDeletePayment.TabIndex = 9;
            btnDeletePayment.Text = "DELETE";
            btnDeletePayment.UseVisualStyleBackColor = false;
            btnDeletePayment.Click += btnDeletePayment_Click;
            // 
            // btnEditPayment
            // 
            btnEditPayment.BackColor = Color.MediumSeaGreen;
            btnEditPayment.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditPayment.ForeColor = Color.White;
            btnEditPayment.Location = new Point(371, 535);
            btnEditPayment.Name = "btnEditPayment";
            btnEditPayment.Size = new Size(99, 33);
            btnEditPayment.TabIndex = 8;
            btnEditPayment.Text = "EDIT";
            btnEditPayment.UseVisualStyleBackColor = false;
            btnEditPayment.Click += btnEditPayment_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(554, 399);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 1;
            label2.Text = "PaymentMethod";
            // 
            // btnAddPayment
            // 
            btnAddPayment.BackColor = Color.SteelBlue;
            btnAddPayment.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPayment.ForeColor = Color.White;
            btnAddPayment.Location = new Point(197, 535);
            btnAddPayment.Name = "btnAddPayment";
            btnAddPayment.Size = new Size(99, 33);
            btnAddPayment.TabIndex = 6;
            btnAddPayment.Text = "ADD ADMIN";
            btnAddPayment.UseVisualStyleBackColor = false;
            btnAddPayment.Click += btnAddPayment_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 401);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 2;
            label3.Text = "OrderID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 355);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 0;
            label1.Text = "PaymentID";
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(483, 55);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(124, 29);
            btnClearSearch.TabIndex = 74;
            btnClearSearch.Text = "CLEAR SEARCH";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(383, 9);
            label8.Name = "label8";
            label8.Size = new Size(226, 28);
            label8.TabIndex = 73;
            label8.Text = "Payment Management";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(383, 55);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 72;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(197, 55);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 71;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(239, 688);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 70;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(825, 688);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 69;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // PaymentManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 739);
            Controls.Add(groupBox1);
            Controls.Add(btnClearSearch);
            Controls.Add(label8);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Name = "PaymentManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentManagementForm";
            Load += PaymentManagementForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpPaymentDate;
        private ComboBox cmbPaymentMethod;
        private Label label4;
        private Label label6;
        private Button btnClearFields;
        private TextBox txtAmount;
        private Label label5;
        private TextBox txtOrderID;
        private DataGridView dgvPayments;
        private Button btnDeletePayment;
        private Button btnEditPayment;
        private Label label2;
        private Button btnAddPayment;
        private Label label3;
        private Label label1;
        private Button btnClearSearch;
        private Label label8;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnBack;
        private Button btnExit;
        private TextBox txtPaymentID;
        private TextBox txtSaleID;
        private Label label7;
        private TextBox txtCustomerID;
        private Label label9;
        private ComboBox cmbPaymentStatus;
    }
}