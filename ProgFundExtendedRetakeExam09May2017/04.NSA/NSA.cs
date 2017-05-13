using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.NSA
{
    public class Nsa
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> countriesSpiesDays = new Dictionary<string, Dictionary<string, int>>();

            while (inputLine != "quit")
            {
                string[] inputParams = inputLine
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string countryName = inputParams[0];
                string spyName = inputParams[1];
                int daysInService = int.Parse(inputParams[2]);

                if (!countriesSpiesDays.ContainsKey(countryName))
                {
                    countriesSpiesDays[countryName] = new Dictionary<string, int>();
                }

                if (!countriesSpiesDays[countryName].ContainsKey(spyName))
                {
                    countriesSpiesDays[countryName].Add(spyName, 0);
                }

                countriesSpiesDays[countryName][spyName] = daysInService;

                inputLine = Console.ReadLine();
            }

            foreach (var country in countriesSpiesDays.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"Country: {country.Key}");

                foreach (var spy in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }
            }
        }
    }
}
