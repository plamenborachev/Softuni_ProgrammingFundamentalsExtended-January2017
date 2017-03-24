using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LINQuistics
{
    public class LINQuistics
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, List<string>> collectionMethods = new Dictionary<string, List<string>>();

            while (inputLine != "exit")
            {
                string[] inputParams = inputLine.Split(new[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                string collection = inputParams[0];

                if (inputParams.Length > 1)
                {
                    if (!collectionMethods.ContainsKey(collection))
                    {
                        collectionMethods[collection] = new List<string>();
                    }

                    for (int i = 1; i < inputParams.Length; i++)
                    {
                        if (!collectionMethods[collection].Contains(inputParams[i]))
                        {
                            collectionMethods[collection].Add(inputParams[i]);
                        }
                    }
                }

                else
                {
                    int n;

                    if (int.TryParse(collection, out n))
                    {
                        Dictionary<string, List<string>> collectionWithMostMethods = collectionMethods
                                    .OrderByDescending(x => x.Value.Count)
                                    .Take(1)
                                    .ToDictionary(x => x.Key, x => x.Value);

                        foreach (var pair in collectionWithMostMethods)
                        {
                            List<string> mostMethodsCollection = pair.Value
                                     .OrderBy(x => x.Length)
                                     .Take(n)
                                     .ToList();

                            foreach (var method in mostMethodsCollection)
                            {
                                Console.WriteLine($"* {method}");
                            }
                        }
                    }

                    else
                    {
                        if (collectionMethods.ContainsKey(collection))
                        {
                            List<string> selectedCollectionMethods = collectionMethods[collection]
                                    .OrderByDescending(method => method.Length)
                                    .ThenByDescending(method => method.ToCharArray().Distinct().Count())
                                    .ToList();

                            foreach (var method in selectedCollectionMethods)
                            {
                                Console.WriteLine($"* {method}");
                            }
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            string lastInputLine = Console.ReadLine();

            string[] lastInputParams = lastInputLine.Split();

            collectionMethods = collectionMethods
                .OrderByDescending(x => x.Value.Count)
                .ThenByDescending(x => x.Value.ToList().Select(m => m.Length).Min())
                .ToDictionary(x => x.Key, x => x.Value);

            if (lastInputParams[1] == "collection")
            {
                foreach (var kvp in collectionMethods)
                {
                    if (kvp.Value.Contains(lastInputParams[0]))
                    {
                        Console.WriteLine($"{kvp.Key}");
                    }
                }
            }
            else if (lastInputParams[1] == "all")
            {
                foreach (var kvp in collectionMethods)
                {
                    if (kvp.Value.Contains(lastInputParams[0]))
                    {
                        Console.WriteLine($"{kvp.Key}");

                        List<string> methods = kvp.Value
                            .OrderByDescending(x => x.Length)
                            .ToList();

                        foreach (var method in methods)
                        {
                            Console.WriteLine($"* {method}");
                        }
                    }
                }
            }
        }
    }
}
