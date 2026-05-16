namespace BookHaven.Forms
{
    partial class RegistrationForm
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
            btnRegister = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtConfirmPassword = new TextBox();
            label3 = new Label();
            btnCancel = new Button();
            btnClear = new Button();
            label4 = new Label();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.MidnightBlue;
            btnRegister.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(191, 204);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(135, 46);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(226, 76);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(221, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(226, 41);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(221, 27);
            txtUsername.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 76);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 41);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(226, 113);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(221, 27);
            txtConfirmPassword.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 116);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 10;
            label3.Text = "Confirm Password";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SeaGreen;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(400, 248);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 36);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkTurquoise;
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(28, 248);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 33);
            btnClear.TabIndex = 21;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 159);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 22;
            label4.Text = "Role";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(226, 159);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(214, 28);
            cmbRole.TabIndex = 23;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 296);
            Controls.Add(cmbRole);
            Controls.Add(label4);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label3);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private TextBox txtConfirmPassword;
        private Label label3;
        private Button btnCancel;
        private Button btnClear;
        private Label label4;
        private ComboBox cmbRole;
    }
}