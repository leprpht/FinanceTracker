using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTrackerLib
{
    public class TransactionHistory
    {
        List<Transaction> _transactions = new List<Transaction>();
        public decimal Funds { get; private set; }
        public void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
            if (transaction.Type == TransactionType.Income)
                Funds += transaction.Amount;
            else
                Funds -= transaction.Amount;
        }
        public void PrintTransactions()
        {
            foreach (Transaction transaction in _transactions)
            {
                Console.WriteLine($"{transaction.Date} - {transaction.Type} - {transaction.Category} - {transaction.Amount}\n");
            }
        }
        public void SortByDate() => _transactions.Sort((x, y) => x.Date.CompareTo(y.Date));
        public void SortByAmount() => _transactions.Sort((x, y) => x.Amount.CompareTo(y.Amount));
        public void SortByCategory() => _transactions.Sort((x, y) => x.Category.CompareTo(y.Category));
    }
}
