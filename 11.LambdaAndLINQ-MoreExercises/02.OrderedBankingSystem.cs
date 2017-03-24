using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OrderedBankingSystem
{
    public class OrderedBankingSystem
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, Dictionary<string, decimal>> bankData = new Dictionary<string, Dictionary<string, decimal>>();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string bank = inputParams[0];
                string account = inputParams[1];
                decimal balance = decimal.Parse(inputParams[2]);

                if (!bankData.ContainsKey(bank))
                {
                    bankData[bank] = new Dictionary<string, decimal>();
                }
                if (!bankData[bank].ContainsKey(account))
                {
                    bankData[bank][account] = 0;
                }

                bankData[bank][account] += balance;

                inputLine = Console.ReadLine();
            }

            bankData = bankData
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToDictionary(bank => bank.Key, bank => bank.Value
                    .OrderByDescending(account => account.Value)
                    .ToDictionary(account => account.Key, account => account.Value));

            foreach (var bankAccountPair in bankData)
            {
                foreach (var accountBalancePair in bankAccountPair.Value)
                {
                    Console.WriteLine($"{accountBalancePair.Key} -> {accountBalancePair.Value} ({bankAccountPair.Key})");
                }
            }
        }
    }
}
