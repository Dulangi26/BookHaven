namespace BookHaven.Forms.Security
{
    partial class SecurityForm
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
            btnBack = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            dgvUsers = new DataGridView();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            cmbRole = new ComboBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(29, 573);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 49;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(805, 573);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 50;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvUsers);
            groupBox1.Controls.Add(btnDeleteUser);
            groupBox1.Controls.Add(btnEditUser);
            groupBox1.Controls.Add(btnAddUser);
            groupBox1.Controls.Add(cmbRole);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(919, 505);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Security";
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(106, 246);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(717, 253);
            dgvUsers.TabIndex = 59;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Red;
            btnDeleteUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(570, 191);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(99, 33);
            btnDeleteUser.TabIndex = 58;
            btnDeleteUser.Text = "DELETE";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.MediumSeaGreen;
            btnEditUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditUser.ForeColor = Color.White;
            btnEditUser.Location = new Point(394, 191);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(99, 33);
            btnEditUser.TabIndex = 57;
            btnEditUser.Text = "EDIT";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.SteelBlue;
            btnAddUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(223, 191);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(99, 33);
            btnAddUser.TabIndex = 56;
            btnAddUser.Text = "ADD ADMIN";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(361, 144);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(248, 28);
            cmbRole.TabIndex = 55;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(364, 96);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(245, 27);
            txtPassword.TabIndex = 54;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(364, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(245, 27);
            txtUsername.TabIndex = 53;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(253, 138);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 52;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(253, 96);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 51;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 56);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 50;
            label1.Text = "Username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(452, 20);
            label8.Name = "label8";
            label8.Size = new Size(89, 28);
            label8.TabIndex = 49;
            label8.Text = "Security";
            // 
            // SecurityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 609);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(label8);
            Name = "SecurityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SecurityForm";
            Load += SecurityForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Button btnBack;
        private Button btnExit;
        private GroupBox groupBox1;
        private DataGridView dgvUsers;
        private Button btnDeleteUser;
        private Button btnEditUser;
        private Button btnAddUser;
        private ComboBox cmbRole;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
    }
}