namespace BookHaven.Forms.SalesTransaction
{
    partial class PaymentForm
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
            label8 = new Label();
            label1 = new Label();
            lblPaymentID = new Label();
            cmbPaymentMethod = new ComboBox();
            btnConfirmPayment = new Button();
            btnCancelPayment = new Button();
            label2 = new Label();
            lblSaleID = new Label();
            lblCustomerID = new Label();
            lblPaymentDate = new Label();
            lblTotalAmount = new Label();
            label12 = new Label();
            cmbPaymentStatus = new ComboBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(303, 9);
            label8.Name = "label8";
            label8.Size = new Size(104, 28);
            label8.TabIndex = 74;
            label8.Text = "Payments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 283);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 76;
            label1.Text = "Payment Method";
            // 
            // lblPaymentID
            // 
            lblPaymentID.AutoSize = true;
            lblPaymentID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentID.Location = new Point(143, 64);
            lblPaymentID.Name = "lblPaymentID";
            lblPaymentID.Size = new Size(0, 23);
            lblPaymentID.TabIndex = 77;
            lblPaymentID.Click += lblPaymentID_Click;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(303, 278);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(227, 28);
            cmbPaymentMethod.TabIndex = 78;
            cmbPaymentMethod.SelectedIndexChanged += cmbPaymentMethod_SelectedIndexChanged;
            // 
            // btnConfirmPayment
            // 
            btnConfirmPayment.BackColor = Color.SteelBlue;
            btnConfirmPayment.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmPayment.ForeColor = Color.White;
            btnConfirmPayment.Location = new Point(62, 399);
            btnConfirmPayment.Name = "btnConfirmPayment";
            btnConfirmPayment.Size = new Size(211, 52);
            btnConfirmPayment.TabIndex = 80;
            btnConfirmPayment.Text = "Confirm Payment";
            btnConfirmPayment.UseVisualStyleBackColor = false;
            btnConfirmPayment.Click += btnConfirmPayment_Click;
            // 
            // btnCancelPayment
            // 
            btnCancelPayment.BackColor = Color.ForestGreen;
            btnCancelPayment.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelPayment.ForeColor = Color.White;
            btnCancelPayment.Location = new Point(416, 399);
            btnCancelPayment.Name = "btnCancelPayment";
            btnCancelPayment.Size = new Size(211, 52);
            btnCancelPayment.TabIndex = 79;
            btnCancelPayment.Text = "Cancel Payment";
            btnCancelPayment.UseVisualStyleBackColor = false;
            btnCancelPayment.Click += btnCancelPayment_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 325);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 81;
            label2.Text = "Payment Status";
            // 
            // lblSaleID
            // 
            lblSaleID.AutoSize = true;
            lblSaleID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaleID.Location = new Point(143, 109);
            lblSaleID.Name = "lblSaleID";
            lblSaleID.Size = new Size(0, 23);
            lblSaleID.TabIndex = 86;
            lblSaleID.Click += lblSaleID_Click;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerID.Location = new Point(143, 154);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(0, 23);
            lblCustomerID.TabIndex = 87;
            lblCustomerID.Click += lblCustomerID_Click;
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentDate.Location = new Point(143, 204);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(0, 23);
            lblPaymentDate.TabIndex = 88;
            lblPaymentDate.Click += lblPaymentDate_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(144, 241);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 23);
            lblTotalAmount.TabIndex = 89;
            lblTotalAmount.Click += lblTotalAmount_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(303, 325);
            label12.Name = "label12";
            label12.Size = new Size(0, 23);
            label12.TabIndex = 90;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(303, 324);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(227, 28);
            cmbPaymentStatus.TabIndex = 91;
            cmbPaymentStatus.SelectedIndexChanged += cmbPaymentStatus_SelectedIndexChanged;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 463);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(label12);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblPaymentDate);
            Controls.Add(lblCustomerID);
            Controls.Add(lblSaleID);
            Controls.Add(label2);
            Controls.Add(btnConfirmPayment);
            Controls.Add(btnCancelPayment);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(lblPaymentID);
            Controls.Add(label1);
            Controls.Add(label8);
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += PaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label1;
        private Label lblPaymentID;
        private ComboBox cmbPaymentMethod;
        private Button btnConfirmPayment;
        private Button btnCancelPayment;
        private Label label2;
        private Label lblSaleID;
        private Label lblCustomerID;
        private Label lblPaymentDate;
        private Label lblTotalAmount;
        private Label label12;
        private ComboBox cmbPaymentStatus;
    }
}