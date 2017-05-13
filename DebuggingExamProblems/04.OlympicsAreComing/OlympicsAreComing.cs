using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OlympicsAreComing
{
    public class OlympicsAreComing
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, List<string>> countryAthletes = new Dictionary<string, List<string>>();

            while (inputLine != "report")
            {
                string[] inputParams = inputLine.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                string[] athlete = inputParams[0].Trim().Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string[] country = inputParams[1].Trim().Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                string athleteName = string.Join(" ", athlete);
                string countryName = string.Join(" ", country);

                if (!countryAthletes.ContainsKey(countryName))
                {
                    countryAthletes[countryName] = new List<string>();
                }

                countryAthletes[countryName].Add(athleteName);

                inputLine = Console.ReadLine();
            }

            countryAthletes = countryAthletes
                .OrderByDescending(c => c.Value.Count)
                .ToDictionary(c => c.Key, c => c.Value);

            foreach (var country in countryAthletes)
            {
                int numberOfuniqueAthletes = country.Value.Distinct().ToList().Count();

                Console.WriteLine($"{country.Key} ({numberOfuniqueAthletes} participants): {country.Value.Count} wins");
            }
        }
    }
}
