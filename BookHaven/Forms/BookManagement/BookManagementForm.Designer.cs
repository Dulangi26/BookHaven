namespace BookHaven.Forms.BookManagement
{
    partial class BookManagementForm
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
            cmbGenre = new ComboBox();
            label4 = new Label();
            txtStockQuantity = new TextBox();
            txtPrice = new TextBox();
            label7 = new Label();
            label9 = new Label();
            btnClear = new Button();
            txtAuthor = new TextBox();
            label5 = new Label();
            txtTitle = new TextBox();
            dgvBooks = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            txtISBN = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            txtBookID = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(468, 52);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(124, 29);
            btnClearSearch.TabIndex = 74;
            btnClearSearch.Text = "CLEAR SEARCH";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(469, 18);
            label8.Name = "label8";
            label8.Size = new Size(191, 28);
            label8.TabIndex = 73;
            label8.Text = "Book Management";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(368, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 72;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(182, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 71;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(224, 685);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 70;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(810, 685);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 69;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbGenre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtStockQuantity);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(dgvBooks);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(txtISBN);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtBookID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(82, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1029, 584);
            groupBox1.TabIndex = 68;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Management";
            // 
            // cmbGenre
            // 
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Location = new Point(651, 459);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(193, 28);
            cmbGenre.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(521, 446);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 27;
            label4.Text = "Genre";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockQuantity.Location = new Point(653, 398);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(329, 30);
            txtStockQuantity.TabIndex = 26;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(653, 352);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(329, 30);
            txtPrice.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(521, 398);
            label7.Name = "label7";
            label7.Size = new Size(124, 23);
            label7.TabIndex = 23;
            label7.Text = "Stock Quantity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(521, 352);
            label9.Name = "label9";
            label9.Size = new Size(47, 23);
            label9.TabIndex = 21;
            label9.Text = "Price";
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
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthor.Location = new Point(159, 453);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(329, 30);
            txtAuthor.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 453);
            label5.Name = "label5";
            label5.Size = new Size(63, 23);
            label5.TabIndex = 14;
            label5.Text = "Author";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(159, 405);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(329, 30);
            txtTitle.TabIndex = 11;
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(29, 42);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(973, 213);
            dgvBooks.TabIndex = 10;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
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
            // txtISBN
            // 
            txtISBN.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtISBN.Location = new Point(159, 499);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(329, 30);
            txtISBN.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 499);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 1;
            label2.Text = "ISBN";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(197, 535);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 33);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "ADD";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtBookID
            // 
            txtBookID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookID.Location = new Point(159, 359);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(329, 30);
            txtBookID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 405);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 2;
            label3.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 359);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 0;
            label1.Text = "Book ID";
            // 
            // BookManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 732);
            Controls.Add(btnClearSearch);
            Controls.Add(label8);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Name = "BookManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookManagementForm";
            Load += BookManagementForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
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
        private ComboBox cmbGenre;
        private Label label4;
        private TextBox txtStockQuantity;
        private TextBox txtPrice;
        private Label label7;
        private Label label9;
        private Button btnClear;
        private TextBox txtAuthor;
        private Label label5;
        private TextBox txtTitle;
        private DataGridView dgvBooks;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtISBN;
        private Label label2;
        private Button btnAdd;
        private TextBox txtBookID;
        private Label label3;
        private Label label1;
    }
}