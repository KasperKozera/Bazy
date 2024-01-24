using TestWydatki.Enums;

namespace TestWydatki.Transaction
{
    public class TransactionDraft
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        public Category Category { get; set; }

        public TransactionType TransactionType { get; set; }

        public decimal Price { get; set; }
    }
}
