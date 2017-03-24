using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefaultValues
{
    public class DefaultValues
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string key = tokens[0];
                string value = tokens[1];

                dictionary[key] = value;

                inputLine = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();

            Dictionary<string, string> notReplaced = 
                dictionary
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, string> replaced = dictionary
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var kvp in notReplaced)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }

            foreach (var kvp in replaced)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
        }
    }
}
