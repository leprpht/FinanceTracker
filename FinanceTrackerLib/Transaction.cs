namespace FinanceTrackerLib
{
    public class Transaction
    {
        private decimal _amount;
        private string _category;
        private TransactionType _type;
        private DateTime _date;
        public Transaction(decimal amount, string category, TransactionType type, DateTime date)
        {
            _amount = amount;
            _category = category;
            _type = type;
            _date = date;
        }
        public Transaction(decimal amount, string category, TransactionType type)
        {
            _amount = amount;
            _category = category;
            _type = type;
            _date = DateTime.Now;
        }

    }
}
