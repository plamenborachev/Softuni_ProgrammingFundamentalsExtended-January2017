using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.GUnit
{
    public class GUnit
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Regex regex = new Regex(@"^([A-Z][A-Za-z0-9]+) \| ([A-Z][A-Za-z0-9]+) \| ([A-Z][A-Za-z0-9]+)$");

            Dictionary<string, Dictionary<string, List<string>>> database = new Dictionary<string, Dictionary<string, List<string>>>();

            while (inputLine != "It's testing time!")
            {
                if (regex.IsMatch(inputLine))
                {
                    Match match = regex.Match(inputLine);

                    string className = match.Groups[1].Value;
                    string methodName = match.Groups[2].Value;
                    string unitTestName = match.Groups[3].Value;

                    if (!database.ContainsKey(className))
                    {
                        database[className] = new Dictionary<string, List<string>>();
                    }

                    if (!database[className].ContainsKey(methodName))
                    {
                        database[className][methodName] = new List<string>();
                    }

                    if (!database[className][methodName].Contains(unitTestName))
                    {
                        database[className][methodName].Add(unitTestName);
                    }
                }

                inputLine = Console.ReadLine();
            }

            database = database
                .OrderByDescending(className => className.Value.Values.Sum(unitTests => unitTests.Count))
                .ThenBy(className => className.Value.Count)
                .ThenBy(className => className.Key, StringComparer.Ordinal)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var className in database)
            {
                Console.WriteLine($"{className.Key}:");

                Dictionary<string, List<string>> sortedMethods = className.Value
                    .OrderByDescending(method => method.Value.Count)
                    .ThenBy(method => method.Key, StringComparer.Ordinal)
                    .ToDictionary(method => method.Key, method => method.Value);

                foreach (var method in sortedMethods)
                {
                    Console.WriteLine($"##{method.Key}");

                    List<string> sortedUnitTests = method.Value
                        .OrderBy(unitTest => unitTest.Length)
                        .ThenBy(unitTest => unitTest, StringComparer.Ordinal)
                        .ToList();

                    foreach (var unitTest in sortedUnitTests)
                    {
                        Console.WriteLine($"####{unitTest}");
                    }
                }
            }
        }
    }
}
