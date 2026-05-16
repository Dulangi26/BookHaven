namespace BookHaven.Forms.CustomerManagement
{
    partial class CustomerManagementForm
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
            btnClear = new Button();
            txtEmail = new TextBox();
            label5 = new Label();
            txtContact = new TextBox();
            dgvCustomers = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtName = new TextBox();
            txtCustomerID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(391, 53);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(124, 29);
            btnClearSearch.TabIndex = 32;
            btnClearSearch.Text = "CLEAR SEARCH";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(392, 19);
            label8.Name = "label8";
            label8.Size = new Size(233, 28);
            label8.TabIndex = 31;
            label8.Text = "Customer Management";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(291, 53);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 30;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(105, 53);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 29;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(119, 591);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 28;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(705, 591);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 27;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtContact);
            groupBox1.Controls.Add(dgvCustomers);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(105, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 489);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Management";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkTurquoise;
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(413, 434);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 33);
            btnClear.TabIndex = 20;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(306, 383);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 30);
            txtEmail.TabIndex = 15;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(174, 383);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 14;
            label5.Text = "Email";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(306, 335);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(222, 30);
            txtContact.TabIndex = 11;
            txtContact.TextChanged += txtContact_TextChanged;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(27, 26);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(683, 205);
            dgvCustomers.TabIndex = 10;
            dgvCustomers.CellContentClick += dgvBooks_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(595, 434);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 33);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.MediumSeaGreen;
            btnEdit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(230, 434);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(99, 33);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(56, 434);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 33);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD ADMIN";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(306, 293);
            txtName.Name = "txtName";
            txtName.Size = new Size(222, 30);
            txtName.TabIndex = 4;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerID.Location = new Point(306, 253);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(222, 30);
            txtCustomerID.TabIndex = 3;
            txtCustomerID.TextChanged += txtCustomerID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(174, 335);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 2;
            label3.Text = "Contact";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(174, 293);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 253);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 0;
            label1.Text = "CustomerID";
            // 
            // CustomerManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 629);
            Controls.Add(btnClearSearch);
            Controls.Add(label8);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(button1);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Name = "CustomerManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Management";
            Load += CustomerManagementForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
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
        private Button btnClear;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtContact;
        private DataGridView dgvCustomers;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox txtName;
        private TextBox txtCustomerID;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}