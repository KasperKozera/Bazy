using TestWydatki.Enums;

namespace TestWydatki.Transaction

{
    public class TransactionController
    {
        private TransactionRepository repository;

        public TransactionController(TransactionRepository repository)
        {
            this.repository = repository;
        }

        public void AddTransaction(TransactionDraft transaction)
        {
            repository.AddTransaction(transaction);
        }

        public List<TransactionDraft> GetTransactions()
        {
            return repository.GetAllTransactions();
        }

        //public TransactionDraft GetTransactionById(Guid id)
        //{
        //    return repository.GetTransaction(id);
        //}

        //public void UpdateTransation(TransactionDraft transaction)
        //{
        //    repository.UpdateTransaction(transaction);
        //}

        public void DeleteTransaction(Guid id)
        {
            repository.DeleteTransaction(id);
        }

        public List<TransactionDraft> GetTransactionByType(TransactionType type)
        {
            return repository.GetTransactionsByType(type);
        }

        //public List<TransactionDraft> FilterTransactionsByDate(DateTime startDate, DateTime endDate)
        //{
        //    var allTransactions = repository.GetAllTransactions();
        //    return allTransactions.Where(t => t.TransactionDate >= startDate && t.TransactionDate <= endDate).ToList();
        //}

        public List<TransactionDraft> FilterTransactionsByCategory(List<Category>? category/*, List<TransactionType>? transactionType*/)
        {
            var allTransactions = repository.GetAllTransactionsCategorized(category/*, transactionType*/);
            return allTransactions.Where(t => category.Contains(t.Category)).ToList();
        }

        //public List<TransactionDraft> FilterTransactionsByDateAndCategory(DateTime startDate, DateTime endDate, Category category)
        //{
        //    var allTransactions = repository.GetAllTransactions();
        //    return allTransactions.Where(t => t.TransactionDate >= startDate && t.TransactionDate <= endDate && t.Category == category).ToList();
        //}

        //public List<TransactionDraft> FilterTransactionsByAmount(decimal amount)
        //{
        //    var allTransactions = repository.GetAllTransactions();
        //    return allTransactions.Where(t => t.Amount == amount).ToList();
        //}

        public decimal SumExpenses(List<Category> selectedCategories)
        {
            var expenseTransactions = repository.GetTransactionsByType(TransactionType.Expense);
            if( selectedCategories != null && selectedCategories.Any())
            {
                expenseTransactions = expenseTransactions.Where(t=>selectedCategories.Contains(t.Category)).ToList();
            }
            return expenseTransactions.Sum(t => t.Amount * t.Price);
        }

        public decimal SumIncomes(List<Category> selectedCategories)
        {
            var incomeTransactions = repository.GetTransactionsByType(TransactionType.Income);
            if (selectedCategories != null && selectedCategories.Any())
            {
                incomeTransactions = incomeTransactions.Where(t => selectedCategories.Contains(t.Category)).ToList();
            }
            return incomeTransactions.Sum(t => t.Amount * t.Price);
        }

        //public decimal SumIncomesInMonth(int year, int month)
        //{
        //    var startDate = new DateTime(year, month, 1);
        //    var endDate = startDate.AddMonths(1).AddDays(-1);


        //    var incomeTransactionsInMonth = repository.GetTransactionsByType(TransactionType.Income).Where(t => t.TransactionDate >= startDate && t.TransactionDate <= endDate);
        //    return incomeTransactionsInMonth.Sum(t => t.Amount * t.Price);
        //}
    }
}
