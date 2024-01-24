namespace Bazy
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gvTransactions = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            transactionDraftBindingSource = new BindingSource(components);
            lblDescription = new Label();
            lblAmount = new Label();
            lblTransactionDate = new Label();
            lblCategory = new Label();
            lblTransactionType = new Label();
            lblPrice = new Label();
            txtDescription = new TextBox();
            txtAmount = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            lblAddTransaction = new Label();
            dtpTransactionDate = new DateTimePicker();
            cbCategory = new ComboBox();
            cbTransactionType = new ComboBox();
            txtSumOfExpenses = new TextBox();
            lblSumOfExpenses = new Label();
            lblSumOfIncome = new Label();
            txtSumOfIncome = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chblbShowCategory = new CheckedListBox();
            lblCheckedCategory = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)gvTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionDraftBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gvTransactions
            // 
            gvTransactions.AutoGenerateColumns = false;
            gvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvTransactions.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, transactionDateDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, transactionTypeDataGridViewTextBoxColumn, Price });
            gvTransactions.DataSource = transactionDraftBindingSource;
            gvTransactions.Location = new Point(367, 12);
            gvTransactions.Name = "gvTransactions";
            gvTransactions.ReadOnly = true;
            gvTransactions.Size = new Size(643, 466);
            gvTransactions.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionTypeDataGridViewTextBoxColumn
            // 
            transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
            transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
            transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
            transactionTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // transactionDraftBindingSource
            // 
            transactionDraftBindingSource.DataSource = typeof(TestWydatki.Transaction.TransactionDraft);
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 132);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(12, 161);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "Amount";
            // 
            // lblTransactionDate
            // 
            lblTransactionDate.AutoSize = true;
            lblTransactionDate.Location = new Point(12, 190);
            lblTransactionDate.Name = "lblTransactionDate";
            lblTransactionDate.Size = new Size(94, 15);
            lblTransactionDate.TabIndex = 6;
            lblTransactionDate.Text = "Transaction Date";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 219);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // lblTransactionType
            // 
            lblTransactionType.AutoSize = true;
            lblTransactionType.Location = new Point(12, 248);
            lblTransactionType.Name = "lblTransactionType";
            lblTransactionType.Size = new Size(94, 15);
            lblTransactionType.TabIndex = 8;
            lblTransactionType.Text = "Transaction Type";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 277);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(112, 129);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(121, 23);
            txtDescription.TabIndex = 10;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(112, 158);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(121, 23);
            txtAmount.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(112, 274);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(31, 327);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(112, 327);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblAddTransaction
            // 
            lblAddTransaction.AutoSize = true;
            lblAddTransaction.Location = new Point(112, 80);
            lblAddTransaction.Name = "lblAddTransaction";
            lblAddTransaction.Size = new Size(91, 15);
            lblAddTransaction.TabIndex = 18;
            lblAddTransaction.Text = "Add transaction";
            // 
            // dtpTransactionDate
            // 
            dtpTransactionDate.Location = new Point(112, 187);
            dtpTransactionDate.Name = "dtpTransactionDate";
            dtpTransactionDate.Size = new Size(200, 23);
            dtpTransactionDate.TabIndex = 19;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(112, 219);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(121, 23);
            cbCategory.TabIndex = 20;
            // 
            // cbTransactionType
            // 
            cbTransactionType.FormattingEnabled = true;
            cbTransactionType.Location = new Point(112, 248);
            cbTransactionType.Name = "cbTransactionType";
            cbTransactionType.Size = new Size(121, 23);
            cbTransactionType.TabIndex = 21;
            // 
            // txtSumOfExpenses
            // 
            txtSumOfExpenses.Location = new Point(469, 511);
            txtSumOfExpenses.Name = "txtSumOfExpenses";
            txtSumOfExpenses.Size = new Size(100, 23);
            txtSumOfExpenses.TabIndex = 22;
            // 
            // lblSumOfExpenses
            // 
            lblSumOfExpenses.AutoSize = true;
            lblSumOfExpenses.Location = new Point(367, 514);
            lblSumOfExpenses.Name = "lblSumOfExpenses";
            lblSumOfExpenses.Size = new Size(96, 15);
            lblSumOfExpenses.TabIndex = 23;
            lblSumOfExpenses.Text = "Sum of expenses";
            // 
            // lblSumOfIncome
            // 
            lblSumOfIncome.AutoSize = true;
            lblSumOfIncome.Location = new Point(367, 576);
            lblSumOfIncome.Name = "lblSumOfIncome";
            lblSumOfIncome.Size = new Size(88, 15);
            lblSumOfIncome.TabIndex = 25;
            lblSumOfIncome.Text = "Sum of income";
            // 
            // txtSumOfIncome
            // 
            txtSumOfIncome.Location = new Point(469, 573);
            txtSumOfIncome.Name = "txtSumOfIncome";
            txtSumOfIncome.Size = new Size(100, 23);
            txtSumOfIncome.TabIndex = 24;
            // 
            // chblbShowCategory
            // 
            chblbShowCategory.FormattingEnabled = true;
            chblbShowCategory.Location = new Point(612, 514);
            chblbShowCategory.Name = "chblbShowCategory";
            chblbShowCategory.Size = new Size(166, 94);
            chblbShowCategory.TabIndex = 26;
            chblbShowCategory.ItemCheck += chblbShowCategory_ItemCheck;
            // 
            // lblCheckedCategory
            // 
            lblCheckedCategory.AutoSize = true;
            lblCheckedCategory.Location = new Point(612, 496);
            lblCheckedCategory.Name = "lblCheckedCategory";
            lblCheckedCategory.Size = new Size(98, 15);
            lblCheckedCategory.TabIndex = 27;
            lblCheckedCategory.Text = "Filter by category";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(193, 327);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1022, 627);
            Controls.Add(btnDelete);
            Controls.Add(lblCheckedCategory);
            Controls.Add(chblbShowCategory);
            Controls.Add(lblSumOfIncome);
            Controls.Add(txtSumOfIncome);
            Controls.Add(lblSumOfExpenses);
            Controls.Add(txtSumOfExpenses);
            Controls.Add(cbTransactionType);
            Controls.Add(cbCategory);
            Controls.Add(dtpTransactionDate);
            Controls.Add(lblAddTransaction);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtAmount);
            Controls.Add(txtDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblTransactionType);
            Controls.Add(lblCategory);
            Controls.Add(lblTransactionDate);
            Controls.Add(lblAmount);
            Controls.Add(lblDescription);
            Controls.Add(gvTransactions);
            Name = "Main";
            Text = "Home budget";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)gvTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionDraftBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView gvTransactions;
        private BindingSource transactionDraftBindingSource;
        private Label lblDescription;
        private Label lblAmount;
        private Label lblTransactionDate;
        private Label lblCategory;
        private Label lblTransactionType;
        private Label lblPrice;
        private TextBox txtDescription;
        private TextBox txtAmount;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnClear;
        private Label lblAddTransaction;
        private DateTimePicker dtpTransactionDate;
        private ComboBox cbCategory;
        private ComboBox cbTransactionType;
        private DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private TextBox txtSumOfExpenses;
        private Label lblSumOfExpenses;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Price;
        private Label lblSumOfIncome;
        private TextBox txtSumOfIncome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckedListBox chblbShowCategory;
        private Label lblCheckedCategory;
        private Button btnDelete;
    }
}
