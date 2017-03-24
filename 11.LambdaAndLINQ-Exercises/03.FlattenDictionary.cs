using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FlattenDictionary
{
    public class FlattenDictionary
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split();

                if (tokens[0] != "flatten")
                {
                    string key = tokens[0];
                    string innerKey = tokens[1];
                    string innerValue = tokens[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new Dictionary<string, string>();
                    }

                    dictionary[key][innerKey] = innerValue;
                }
                else
                {
                    string flattenKey = tokens[1];

                    dictionary[flattenKey] = dictionary[flattenKey].ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                inputLine = Console.ReadLine();
            }

            dictionary = dictionary.OrderByDescending(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}");
                int counter = 1;

                Dictionary<string, string> orderedInnerDictionary = kvp.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in orderedInnerDictionary)
                {
                    Console.WriteLine($"{counter}. {item.Key} - {item.Value}");
                    counter++;
                }

                Dictionary<string, string> flattened = kvp.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in flattened)
                {
                    Console.WriteLine($"{counter}. {item.Key}");
                    counter++;
                }
            }
        }
    }
}
