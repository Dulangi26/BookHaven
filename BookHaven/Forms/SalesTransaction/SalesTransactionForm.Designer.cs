namespace BookHaven.Forms.SalesTransaction
{
    partial class SalesTransactionForm
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
            cmbPayment = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            dateTimePickerTransactionDate = new DateTimePicker();
            comboBoxCustomers = new ComboBox();
            txtTotalAmount = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            dataGridViewTransactions = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            SuspendLayout();
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(477, 64);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(124, 29);
            btnClearSearch.TabIndex = 67;
            btnClearSearch.Text = "CLEAR SEARCH";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(478, 30);
            label8.Name = "label8";
            label8.Size = new Size(181, 28);
            label8.TabIndex = 66;
            label8.Text = "Sales Transaction ";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(377, 64);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 65;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(191, 64);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 64;
            // 
            // button1
            // 
            button1.Location = new Point(233, 697);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 63;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(819, 697);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 62;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPayment);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(dateTimePickerTransactionDate);
            groupBox1.Controls.Add(comboBoxCustomers);
            groupBox1.Controls.Add(txtTotalAmount);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridViewTransactions);
            groupBox1.Location = new Point(91, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1029, 584);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sales Transaction";
            // 
            // cmbPayment
            // 
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Location = new Point(358, 171);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(349, 28);
            cmbPayment.TabIndex = 33;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkCyan;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(567, 515);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(211, 52);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Cancel ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(246, 515);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(211, 52);
            btnSave.TabIndex = 31;
            btnSave.Text = "Save ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePickerTransactionDate
            // 
            dateTimePickerTransactionDate.Location = new Point(358, 80);
            dateTimePickerTransactionDate.Name = "dateTimePickerTransactionDate";
            dateTimePickerTransactionDate.Size = new Size(351, 27);
            dateTimePickerTransactionDate.TabIndex = 30;
            // 
            // comboBoxCustomers
            // 
            comboBoxCustomers.FormattingEnabled = true;
            comboBoxCustomers.Location = new Point(360, 32);
            comboBoxCustomers.Name = "comboBoxCustomers";
            comboBoxCustomers.Size = new Size(349, 28);
            comboBoxCustomers.TabIndex = 29;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(358, 125);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(345, 30);
            txtTotalAmount.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(197, 125);
            label5.Name = "label5";
            label5.Size = new Size(113, 23);
            label5.TabIndex = 27;
            label5.Text = "Total Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 171);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 22;
            label2.Text = "Payment Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(197, 77);
            label3.Name = "label3";
            label3.Size = new Size(138, 23);
            label3.TabIndex = 23;
            label3.Text = "Transaction Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 31);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 21;
            label1.Text = "Customer";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTransactions.BackgroundColor = Color.White;
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactions.Location = new Point(28, 208);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowHeadersWidth = 51;
            dataGridViewTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTransactions.Size = new Size(973, 301);
            dataGridViewTransactions.TabIndex = 10;
            // 
            // SalesTransactionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 757);
            Controls.Add(btnClearSearch);
            Controls.Add(label8);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Name = "SalesTransactionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesTransactionForm";
            Load += SalesTransactionForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
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
        private DataGridView dataGridViewTransactions;
        private TextBox txtTotalAmount;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label1;
        private DateTimePicker dateTimePickerTransactionDate;
        private ComboBox comboBoxCustomers;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox cmbPayment;
    }
}