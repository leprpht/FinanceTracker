using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceTrackerLib;

namespace FinanceTrackerConsole
{
    public static class UserInterface
    {
        public static void PrintMenu()
        {
            Console.WriteLine("1. Add transaction");
            Console.WriteLine("2. Print transactions");
            Console.WriteLine("3. Sort by date");
            Console.WriteLine("4. Sort by amount");
            Console.WriteLine("5. Sort by category");
            Console.WriteLine("6. Exit");
        }
        public static void PrintTransaction(Transaction transaction) => transaction.PrintTransaction();
    }
}
