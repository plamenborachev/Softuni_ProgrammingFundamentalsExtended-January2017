using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref_Advanced
{
    public class DictRefAdvanced
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, List<int>> nameNumbers = new Dictionary<string, List<int>>();

            while (inputLine != "end")
            {
                string[] input = inputLine.Split(new string[] { " -> " }, StringSplitOptions.None);

                string name = input[0];
                string[] numbersOrName = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int parsed;

                if (int.TryParse(numbersOrName[0], out parsed))
                {
                    if (!nameNumbers.ContainsKey(name))
                    {
                        nameNumbers[name] = new List<int>();
                    }

                    foreach (var number in numbersOrName)
                    {
                        nameNumbers[name].Add(int.Parse(number));
                    }
                }

                else
                {
                    if (nameNumbers.ContainsKey(numbersOrName[0]))
                    {
                        if (!nameNumbers.ContainsKey(name))
                        {
                            nameNumbers[name] = new List<int>();
                        }

                        foreach (var number in nameNumbers[numbersOrName[0]])
                        {
                            nameNumbers[name].Add(number);
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var name in nameNumbers.Keys)
            {
                Console.WriteLine($"{name} === {string.Join(", ", nameNumbers[name])}");
            }
        }
    }
}
