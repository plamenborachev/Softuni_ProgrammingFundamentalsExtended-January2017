using System;
using System.Collections.Generic;
using System.Linq;

namespace OptimizedBankingSystem
{
    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            List<BankAccount> accounts = new List<BankAccount>();

            while (inputLine != "end")
            {
                BankAccount account = new BankAccount();

                account = account.ParseBankAccount(inputLine);

                accounts.Add(account);

                inputLine = Console.ReadLine();
            }

            accounts = accounts.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length).ToList();

            foreach (var account in accounts)
            {
                Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
            }
        }
    }
}
