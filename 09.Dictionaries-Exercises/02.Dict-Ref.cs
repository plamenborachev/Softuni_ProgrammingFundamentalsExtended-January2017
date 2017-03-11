using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Dict_Ref
{
    public class DictRef
    {
        public static void Main()
        {
            Dictionary<string, long> result = new Dictionary<string, long>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currentCommand = command.Split();

                long parsedValue;

                if (long.TryParse(currentCommand[2], out parsedValue))
                {
                    result[currentCommand[0]] = parsedValue;
                }

                else
                {
                    if (result.ContainsKey(currentCommand[2]))
                    {
                        result[currentCommand[0]] = result[currentCommand[2]];
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
