using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Websites
{
    public class Websites
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            List<Website> websites = new List<Website>();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);

                Website website = new Website()
                {
                    Host = inputParams[0],

                    Domain = inputParams[1],

                    Queries = inputParams.Skip(2).ToList()
                };

                websites.Add(website);

                inputLine = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                Console.Write($"https://www.{website.Host}.{website.Domain}");

                if (website.Queries.Count > 0)
                {
                    Console.WriteLine($"/query?=[{string.Join("]&[", website.Queries)}]");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
