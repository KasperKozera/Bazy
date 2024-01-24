
using Cassandra;
using TestWydatki.Enums;
using TestWydatki.Transaction;

namespace Bazy

{
    public partial class Main : Form
    {
        private TransactionController transactionController;
        private List<Category> categories;
        private List<TransactionType> transactionTypes;

        List<Category> selectedCategory = new List<Category>();

        public Main()
        {
            var session = CreateCassandraSession();
            var transactionRepository = new TransactionRepository(session);
            transactionRepository.CreateKeyspace();
            transactionController = new TransactionController(transactionRepository);
            InitializeComponent();
        }

        #region Zdarzenia
        private void Main_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            categories = new List<Category>((Category[])Enum.GetValues(typeof(Category)));
            transactionTypes = new List<TransactionType>((TransactionType[])Enum.GetValues(typeof(TransactionType)));

            cbCategory.DataSource = categories;
            cbTransactionType.DataSource = transactionTypes;
        }

        private void RefreshDataGridView()
        {
            try
            {
                var allTransactions = transactionController.GetTransactions();
                gvTransactions.DataSource = allTransactions;

                if (gvTransactions.Columns.Contains("TransactionDate"))
                {
                    gvTransactions.Sort(gvTransactions.Columns["TransactionDate"], System.ComponentModel.ListSortDirection.Descending);
                }
                InitializeCategoryCheckedListBox();
                SumOfExpenses();
                SumOfIncome();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Blad: {ex.Message}");
            }
        }

        private void RefreshDataGridViewCategorized()
        {
            var allCategorizedTransactions = transactionController.FilterTransactionsByCategory(selectedCategory);
            gvTransactions.DataSource = allCategorizedTransactions;
            SumOfExpenses();
            SumOfIncome();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TransactionDraft draft = new TransactionDraft
                {
                    Id = Guid.NewGuid(),
                    Description = txtDescription.Text,
                    Amount = decimal.Parse(txtAmount.Text),
                    TransactionDate = dtpTransactionDate.Value,
                    Category = (Category)cbCategory.SelectedItem,
                    TransactionType = (TransactionType)cbTransactionType.SelectedItem,
                    Price = decimal.Parse(txtPrice.Text)
                };

                transactionController.AddTransaction(draft);

                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Blad: {ex.Message}");
            }

        }

        private void clearData()
        {
            txtDescription.Text = string.Empty;
            txtDescription.Tag = null;

            txtAmount.Text = string.Empty;
            txtAmount.Tag = null;

            dtpTransactionDate.Value = DateTime.UtcNow;

            cbCategory.Text = Category.None.ToString();

            cbTransactionType.Text = TransactionType.Expense.ToString();

            txtPrice.Text = string.Empty;
            txtPrice.Tag = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void dataGridViewTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Guid selectedTransactionId = (Guid)gvTransactions.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gvTransactions.SelectedCells.Count > 0)
            {
                Guid selectedTransactionId = (Guid)gvTransactions.Rows[gvTransactions.SelectedCells[0].RowIndex].Cells["idDataGridViewTextBoxColumn"].Value;
                transactionController.DeleteTransaction(selectedTransactionId);
                RefreshDataGridView();
            }
        }
        private void gvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SumOfIncome()
        {
            if (transactionController.SumIncomes() == 0)
            {
                txtSumOfIncome.Text = string.Empty;
            }
            else
            {
                txtSumOfIncome.Text = transactionController.SumIncomes().ToString();
            }
        }

        private void SumOfExpenses()
        {
            if (transactionController.SumExpenses() == 0)
            {
                txtSumOfExpenses.Text = string.Empty;
            }
            else
            {
                txtSumOfExpenses.Text = transactionController.SumExpenses().ToString();
            }
        }

        private void InitializeCategoryCheckedListBox()
        {
            Array categoryValues = Enum.GetValues(typeof(Category));

            foreach (Category category in categoryValues)
            {
                chblbShowCategory.Items.Add(category, false);
            }
        }
        #endregion

        private ISession CreateCassandraSession()
        {
            var cluster = Cluster.Builder().AddContactPoint("127.0.0.1").WithPort(9042).Build();
            var session = cluster.Connect("system");
            return session;
        }

        private void chblbShowCategory_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked)
            {
                selectedCategory.Add((Category)chblbShowCategory.Items[e.Index]);
            }
            else
            {
                selectedCategory.Remove((Category)chblbShowCategory.Items[e.Index]);
            }

            if(selectedCategory.Count != 0)
            {
                RefreshDataGridViewCategorized();
            }
            else
            {
                RefreshDataGridView();
            }
        }
    }
}
