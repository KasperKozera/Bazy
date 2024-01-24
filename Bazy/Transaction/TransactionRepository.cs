using Cassandra;
using TestWydatki.Enums;

namespace TestWydatki.Transaction
{
    public class TransactionRepository
    {
        private const string KeyspaceName = "home_budget";
        private const string TableName = "transaction";

        private ISession session;

        public TransactionRepository(ISession session)
        {
            this.session = session;
        }

        public void CreateKeyspace()
        {
            session.Execute($"CREATE KEYSPACE IF NOT EXISTS {KeyspaceName} WITH REPLICATION = {{'class' : 'SimpleStrategy', 'replication_factor' : 1}}");
            session.Execute($"USE {KeyspaceName}");

            session.Execute($"CREATE TABLE IF NOT EXISTS {TableName} (id UUID PRIMARY KEY, description TEXT, amount DECIMAL,transactionDate TIMESTAMP, category TEXT,transactionType TEXT,price DECIMAL )");
        }

        public void AddTransaction(TransactionDraft transactionDraft)
        {
            var insertQuery = $"INSERT INTO {TableName} (id, description, amount, transactionDate, category, transactionType, price) VALUES (?, ?, ?, ?, ?, ?, ?)";

            var statement = session.Prepare(insertQuery);
            var boundStatement = statement.Bind(transactionDraft.Id, transactionDraft.Description.ToString(), transactionDraft.Amount, transactionDraft.TransactionDate,
                transactionDraft.Category.ToString(), transactionDraft.TransactionType.ToString(), transactionDraft.Price);

            session.Execute(boundStatement);
        }

        public List<TransactionDraft> GetAllTransactions()
        {
            var selectQuery = $"SELECT * FROM {TableName}";
            var rows = session.Execute(selectQuery);

            var transactions = new List<TransactionDraft>();

            foreach ( var row in rows)
            {
                var transactionDraft = new TransactionDraft
                {
                    Id = row.GetValue<Guid>("id"),
                    Description = row.GetValue<string>("description"),
                    Amount = row.GetValue<decimal>("amount"),
                    TransactionDate = row.GetValue<DateTime>("transactiondate"),
                    Category = Enum.Parse<Category>(row.GetValue<string>("category")),
                    TransactionType = Enum.Parse<TransactionType>(row.GetValue<string>("transactiontype")),
                    Price = row.GetValue<decimal>("price")
                };

                transactions.Add(transactionDraft);
            }

            return transactions;
        }

        public List<TransactionDraft> GetAllTransactionsCategorized(List<Category> selectedCategories, List<TransactionType> selectedTransactionTypes)
        {
            string parameterListCategory = string.Join(",", selectedCategories.Select((category, index) => $"'{category}'"));
            string parameterListTransactionType = string.Join(",", selectedTransactionTypes.Select((TransactionType, index) => $"'{TransactionType}'"));

            string selectQuery = string.Empty;

            if (selectedCategories.Count >= 1 && selectedTransactionTypes.Count == 0)
            {
                selectQuery = $"SELECT * FROM {TableName} WHERE category IN ({parameterListCategory}) ALLOW FILTERING";
            }
            else if (selectedTransactionTypes.Count >= 1 && selectedCategories.Count == 0)
            {
                selectQuery = $"SELECT * FROM {TableName} WHERE transactionType IN ({parameterListTransactionType}) ALLOW FILTERING";
            }
            else
            {
                selectQuery = $"SELECT * FROM {TableName} WHERE category IN ({parameterListCategory}) AND transactionType in ({parameterListTransactionType}) ALLOW FILTERING";
            }

            var rows = session.Execute(selectQuery);

            var transactions = new List<TransactionDraft>();

            foreach (var row in rows)
            {
                var transactionDraft = new TransactionDraft
                {
                    Id = row.GetValue<Guid>("id"),
                    Description = row.GetValue<string>("description"),
                    Amount = row.GetValue<decimal>("amount"),
                    TransactionDate = row.GetValue<DateTime>("transactiondate"),
                    Category = Enum.Parse<Category>(row.GetValue<string>("category")),
                    TransactionType = Enum.Parse<TransactionType>(row.GetValue<string>("transactiontype")),
                    Price = row.GetValue<decimal>("price")
                };

                transactions.Add(transactionDraft);
            }

            return transactions;
        }

        public TransactionDraft GetTransaction(Guid id)
        {
            var selectQuery = $"SELECT * FROM {TableName} WHERE id = ? ALLOW FILTERING";

            var statement = session.Prepare(selectQuery);

            var boundStatement = statement.Bind(id);
            var row = session.Execute(boundStatement).FirstOrDefault();

            if(row != null)
            {
                var transaction = new TransactionDraft
                {
                    Id = row.GetValue<Guid>("id"),
                    Description = row.GetValue<string>("description"),
                    Amount = row.GetValue<decimal>("amount"),
                    TransactionDate = row.GetValue<DateTime>("transactiondate"),
                    Category = Enum.Parse<Category>(row.GetValue<string>("category")),
                    TransactionType = Enum.Parse<TransactionType>(row.GetValue<string>("transactiontype")),
                    Price = row.GetValue<decimal>("price")
                };

                return transaction;
            }

            return null;
        }

        public List<TransactionDraft> GetTransactionsByType(TransactionType type)
            {
            var selectQuery = $"SELECT * FROM {TableName} WHERE transactiontype = ? ALLOW FILTERING";

            var statement = session.Prepare(selectQuery);

            var boundStatement = statement.Bind(type.ToString());
            var rows = session.Execute(boundStatement);

            var transactions = new List<TransactionDraft>();

            foreach (var row in rows)
            {
                var transaction = new TransactionDraft
                {
                    Id = row.GetValue<Guid>("id"),
                    Description = row.GetValue<string>("description"),
                    Amount = row.GetValue<decimal>("amount"),
                    TransactionDate = row.GetValue<DateTime>("transactiondate"),
                    Category = Enum.Parse<Category>(row.GetValue<string>("category")),
                    TransactionType = Enum.Parse<TransactionType>(row.GetValue<string>("transactiontype")),
                    Price = row.GetValue<decimal>("price")
                };

                transactions.Add(transaction);
            }

            return transactions;
        }

        public void UpdateTransaction(TransactionDraft transactionDraft)
        {
            var updateQuerry = $"UPDATE {TableName} SET description = ?, amount = ?, transactionDate = ?, category = ?, transactionType = ?, price = ? WHERE id = ?";

            var statement = session.Prepare(updateQuerry);
            var boundStatement = statement.Bind(transactionDraft.Description.ToString() ,transactionDraft.Amount, transactionDraft.TransactionDate, 
                transactionDraft.Category.ToString(), transactionDraft.TransactionType.ToString(), transactionDraft.Price, transactionDraft.Id);

            session.Execute(boundStatement);
        }

        public void DeleteTransaction(Guid transactionId)
        {
            var deleteQuery = $"DELETE FROM {TableName} WHERE id = ?";

            var statement = session.Prepare(deleteQuery);
            var boundStatement = statement.Bind(transactionId);

            session.Execute(boundStatement);
        }
    }
}
