namespace BookHaven.Forms.SupplierManagement
{
    partial class SupplierManagementForm
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
            btnBack = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            txtEmail = new TextBox();
            label5 = new Label();
            txtContact = new TextBox();
            dgvSuppliers = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            txtAddress = new TextBox();
            label2 = new Label();
            btnAddSupplier = new Button();
            txtSupplierName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(474, 61);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(124, 29);
            btnClearSearch.TabIndex = 53;
            btnClearSearch.Text = "CLEAR SEARCH";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(475, 27);
            label8.Name = "label8";
            label8.Size = new Size(221, 28);
            label8.TabIndex = 52;
            label8.Text = "Supplier Management";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(374, 61);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 51;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(188, 61);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 50;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(230, 694);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 49;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(816, 694);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 48;
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
            groupBox1.Controls.Add(dgvSuppliers);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAddSupplier);
            groupBox1.Controls.Add(txtSupplierName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(88, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1029, 584);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Supplier Management";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkTurquoise;
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(554, 535);
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
            txtEmail.Location = new Point(351, 453);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(471, 30);
            txtEmail.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(219, 453);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 14;
            label5.Text = "Email";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(351, 405);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(471, 30);
            txtContact.TabIndex = 11;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.BackgroundColor = Color.White;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(29, 42);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(973, 301);
            dgvSuppliers.TabIndex = 10;
            dgvSuppliers.CellContentClick += dgvSuppliers_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(736, 535);
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
            btnEdit.Location = new Point(371, 535);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(99, 33);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(351, 499);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(471, 30);
            txtAddress.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(219, 499);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 1;
            label2.Text = "Address ";
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = Color.SteelBlue;
            btnAddSupplier.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSupplier.ForeColor = Color.White;
            btnAddSupplier.Location = new Point(197, 535);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(99, 33);
            btnAddSupplier.TabIndex = 6;
            btnAddSupplier.Text = "ADD ADMIN";
            btnAddSupplier.UseVisualStyleBackColor = false;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierName.Location = new Point(351, 359);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(471, 30);
            txtSupplierName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(219, 405);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 2;
            label3.Text = "Contact";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 359);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 0;
            label1.Text = "Supplier Name";
            // 
            // SupplierManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 750);
            Controls.Add(btnClearSearch);
            Controls.Add(label8);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Name = "SupplierManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SupplierManagementForm";
            Load += SupplierManagementForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClearSearch;
        private Label label8;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnBack;
        private Button btnExit;
        private GroupBox groupBox1;
        private Button btnClear;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtContact;
        private DataGridView dgvSuppliers;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtAddress;
        private Label label2;
        private Button btnAddSupplier;
        private TextBox txtSupplierName;
        private Label label3;
        private Label label1;
    }
}