namespace BookHaven.Forms.SalesTransaction
{
    partial class SaleDetailsForm
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
            btnConfirmSale = new Button();
            btnCancelSale = new Button();
            cmbPaymentMethod = new ComboBox();
            label1 = new Label();
            lblTotal = new Label();
            label8 = new Label();
            lblTotalAmount = new Label();
            dgvSaleDetails = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetails).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmSale
            // 
            btnConfirmSale.BackColor = Color.SteelBlue;
            btnConfirmSale.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmSale.ForeColor = Color.White;
            btnConfirmSale.Location = new Point(88, 386);
            btnConfirmSale.Name = "btnConfirmSale";
            btnConfirmSale.Size = new Size(211, 52);
            btnConfirmSale.TabIndex = 87;
            btnConfirmSale.Text = "Confirm Sale";
            btnConfirmSale.UseVisualStyleBackColor = false;
            btnConfirmSale.Click += btnConfirmSale_Click;
            // 
            // btnCancelSale
            // 
            btnCancelSale.BackColor = Color.ForestGreen;
            btnCancelSale.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelSale.ForeColor = Color.White;
            btnCancelSale.Location = new Point(442, 386);
            btnCancelSale.Name = "btnCancelSale";
            btnCancelSale.Size = new Size(211, 52);
            btnCancelSale.TabIndex = 86;
            btnCancelSale.Text = "Cancel Sale";
            btnCancelSale.UseVisualStyleBackColor = false;
            btnCancelSale.Click += btnCancelSale_Click;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(279, 86);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(227, 28);
            cmbPaymentMethod.TabIndex = 85;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 91);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 83;
            label1.Text = "Payment Method";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(119, 47);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(108, 23);
            lblTotal.TabIndex = 82;
            lblTotal.Text = "TotalAmount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(334, 9);
            label8.Name = "label8";
            label8.Size = new Size(132, 28);
            label8.TabIndex = 81;
            label8.Text = "Sales Details";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(279, 47);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 23);
            lblTotalAmount.TabIndex = 88;
            // 
            // dgvSaleDetails
            // 
            dgvSaleDetails.BackgroundColor = Color.White;
            dgvSaleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaleDetails.Location = new Point(70, 140);
            dgvSaleDetails.Name = "dgvSaleDetails";
            dgvSaleDetails.RowHeadersWidth = 51;
            dgvSaleDetails.Size = new Size(646, 227);
            dgvSaleDetails.TabIndex = 89;
            dgvSaleDetails.CellContentClick += dgvSaleDetails_CellContentClick;
            // 
            // SaleDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSaleDetails);
            Controls.Add(lblTotalAmount);
            Controls.Add(btnConfirmSale);
            Controls.Add(btnCancelSale);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Name = "SaleDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SaleDetails";
            Load += SaleDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSaleDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmSale;
        private Button btnCancelSale;
        private ComboBox cmbPaymentMethod;
        private Label label1;
        private Label lblTotal;
        private Label label8;
        private Label lblTotalAmount;
        private DataGridView dgvSaleDetails;
    }
}