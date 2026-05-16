namespace BookHaven.Forms.Reports
{
    partial class Reportdashboard
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
            label1 = new Label();
            btnCusRep = new Button();
            btnInRep = new Button();
            btnSalRep = new Button();
            btnBack = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(436, 50);
            label1.Name = "label1";
            label1.Size = new Size(128, 41);
            label1.TabIndex = 18;
            label1.Text = "Reports";
            // 
            // btnCusRep
            // 
            btnCusRep.BackColor = Color.LightSeaGreen;
            btnCusRep.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCusRep.ForeColor = Color.White;
            btnCusRep.Location = new Point(96, 132);
            btnCusRep.Name = "btnCusRep";
            btnCusRep.Size = new Size(250, 95);
            btnCusRep.TabIndex = 32;
            btnCusRep.Text = "Customer Reports";
            btnCusRep.UseVisualStyleBackColor = false;
            btnCusRep.Click += btnCusRep_Click;
            // 
            // btnInRep
            // 
            btnInRep.BackColor = Color.Orchid;
            btnInRep.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInRep.ForeColor = Color.White;
            btnInRep.Location = new Point(369, 132);
            btnInRep.Name = "btnInRep";
            btnInRep.Size = new Size(250, 95);
            btnInRep.TabIndex = 33;
            btnInRep.Text = "Inventory Reports";
            btnInRep.UseVisualStyleBackColor = false;
            btnInRep.Click += btnInRep_Click;
            // 
            // btnSalRep
            // 
            btnSalRep.BackColor = Color.LightSalmon;
            btnSalRep.Font = new Font("Adobe Gothic Std B", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalRep.ForeColor = Color.White;
            btnSalRep.Location = new Point(641, 132);
            btnSalRep.Name = "btnSalRep";
            btnSalRep.Size = new Size(250, 95);
            btnSalRep.TabIndex = 34;
            btnSalRep.Text = "Sales Reports";
            btnSalRep.UseVisualStyleBackColor = false;
            btnSalRep.Click += btnSalRep_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(118, 303);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 36;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(787, 303);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 35;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Reportdashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 344);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Controls.Add(btnSalRep);
            Controls.Add(btnInRep);
            Controls.Add(btnCusRep);
            Controls.Add(label1);
            Name = "Reportdashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportdashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCusRep;
        private Button btnInRep;
        private Button btnSalRep;
        private Button btnBack;
        private Button btnExit;
    }
}