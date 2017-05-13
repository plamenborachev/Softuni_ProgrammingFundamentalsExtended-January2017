using System;
using System.Collections.Generic;
using System.Linq;

namespace OptimizedBankingSystem
{
    public class BankAccount
    {
        public string Name { get; set; }

        public string Bank { get; set; }

        public decimal Balance { get; set; }

        public BankAccount ParseBankAccount(string inputLine)
        {
            string[] inputParams = inputLine.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

            BankAccount account = new BankAccount()
            {
                Name = inputParams[1],

                Bank = inputParams[0],

                Balance = decimal.Parse(inputParams[2])
            };

            return account;
        }
    }
}
