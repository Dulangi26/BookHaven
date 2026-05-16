namespace BookHaven.Forms.OrderManagement
{
    partial class OrderConfirmationForm
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
            btnExit = new Button();
            button1 = new Button();
            btnConfirmOrder = new Button();
            lblConfirmation = new Label();
            lblCustomerName = new Label();
            lblQuantity = new Label();
            lblBookTitle = new Label();
            lblTotalAmount = new Label();
            lblConfirmationMessage = new Label();
            lblOrderStatus = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(800, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 74;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(60, 387);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 73;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.BackColor = Color.SteelBlue;
            btnConfirmOrder.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmOrder.ForeColor = Color.White;
            btnConfirmOrder.Location = new Point(363, 337);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(211, 52);
            btnConfirmOrder.TabIndex = 72;
            btnConfirmOrder.Text = "Confirm Order";
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // lblConfirmation
            // 
            lblConfirmation.AutoSize = true;
            lblConfirmation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmation.Location = new Point(377, 45);
            lblConfirmation.Name = "lblConfirmation";
            lblConfirmation.Size = new Size(197, 28);
            lblConfirmation.TabIndex = 71;
            lblConfirmation.Text = "Order Confirmation";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(338, 118);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(0, 23);
            lblCustomerName.TabIndex = 80;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(338, 194);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(0, 23);
            lblQuantity.TabIndex = 81;
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookTitle.Location = new Point(338, 156);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(0, 23);
            lblBookTitle.TabIndex = 82;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(338, 270);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 23);
            lblTotalAmount.TabIndex = 83;
            // 
            // lblConfirmationMessage
            // 
            lblConfirmationMessage.AutoSize = true;
            lblConfirmationMessage.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmationMessage.Location = new Point(338, 304);
            lblConfirmationMessage.Name = "lblConfirmationMessage";
            lblConfirmationMessage.Size = new Size(0, 23);
            lblConfirmationMessage.TabIndex = 84;
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderStatus.Location = new Point(338, 230);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(0, 23);
            lblOrderStatus.TabIndex = 86;
            // 
            // OrderConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(970, 440);
            Controls.Add(lblOrderStatus);
            Controls.Add(lblConfirmationMessage);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblBookTitle);
            Controls.Add(lblQuantity);
            Controls.Add(lblCustomerName);
            Controls.Add(btnExit);
            Controls.Add(button1);
            Controls.Add(btnConfirmOrder);
            Controls.Add(lblConfirmation);
            Name = "OrderConfirmationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderConfirmationForm";
            Load += OrderConfirmationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button button1;
        private Button btnConfirmOrder;
        private Label lblConfirmation;
        private Label lblCustomerName;
        private Label lblQuantity;
        private Label lblBookTitle;
        private Label lblTotalAmount;
        private Label lblConfirmationMessage;
        private Label lblOrderStatus;
    }
}