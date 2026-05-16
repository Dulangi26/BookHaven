namespace BookHaven.Forms.Login
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ===== Title =====
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(150, 20);
            this.lblTitle.Text = "BOOK HAVEN LOGIN";

            // ===== Username Label =====
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 90);
            this.label1.Text = "Username";

            // ===== Password Label =====
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 130);
            this.label2.Text = "Password";

            // ===== Username TextBox =====
            this.txtUsername.Location = new System.Drawing.Point(170, 90);
            this.txtUsername.Size = new System.Drawing.Size(230, 27);

            // ===== Password TextBox =====
            this.txtPassword.Location = new System.Drawing.Point(170, 130);
            this.txtPassword.Size = new System.Drawing.Size(230, 27);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);

            // ===== Login Button =====
            this.btnLogin.Location = new System.Drawing.Point(200, 180);
            this.btnLogin.Size = new System.Drawing.Size(130, 45);
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // ===== Clear Button =====
            this.btnClear.Location = new System.Drawing.Point(50, 250);
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.Text = "CLEAR";
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // ===== Exit Button =====
            this.btnExit.Location = new System.Drawing.Point(370, 250);
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.Text = "EXIT";
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // ===== Register Button =====
            this.btnRegister.Location = new System.Drawing.Point(20, 20);
            this.btnRegister.Size = new System.Drawing.Size(120, 35);
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // ===== Form Settings =====
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegister);

            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}