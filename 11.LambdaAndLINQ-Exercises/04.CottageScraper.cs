using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CottageScraper
{
    public class CottageScraper
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, List<decimal>> typeLength = new Dictionary<string, List<decimal>>();

            while (inputLine != "chop chop")
            {
                string[] tokens = inputLine.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string type = tokens[0];

                decimal length = decimal.Parse(tokens[1]);

                if (!typeLength.ContainsKey(type))
                {
                    typeLength[type] = new List<decimal>();
                }

                typeLength[type].Add(length);

                inputLine = Console.ReadLine();
            }

            string cottageScraperTree = Console.ReadLine();

            decimal minimumLengthPerTree = decimal.Parse(Console.ReadLine());

            List<decimal> usedLogs = new List<decimal>();

            if (typeLength.ContainsKey(cottageScraperTree))
            {
                usedLogs = typeLength[cottageScraperTree].Where(x => x >= minimumLengthPerTree).ToList();
            }

            List<decimal> unusedLogs = new List<decimal>();

            foreach (var kvp in typeLength)
            {
                if (kvp.Key != cottageScraperTree)
                {
                    unusedLogs = unusedLogs.Concat(kvp.Value).ToList();
                }
                else
                {
                    unusedLogs = unusedLogs.Concat(kvp.Value.Where(x => x < minimumLengthPerTree)).ToList();
                }
            }

            decimal pricePerMeter = Math.Round((usedLogs.Sum() + unusedLogs.Sum()) / (usedLogs.Count + unusedLogs.Count), 2);

            decimal usedLogsPrice = Math.Round(usedLogs.Sum() * pricePerMeter, 2);

            decimal unusedLogsPrice = Math.Round(unusedLogs.Sum() * pricePerMeter * 0.25m, 2);

            decimal totalPrice = Math.Round(usedLogsPrice + unusedLogsPrice, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter}");

            Console.WriteLine($"Used logs price: ${usedLogsPrice}");

            Console.WriteLine($"Unused logs price: ${unusedLogsPrice}");

            Console.WriteLine($"CottageScraper subtotal: ${totalPrice}");
        }
    }
}
