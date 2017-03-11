using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ExamShopping
{
    public class ExamShopping
    {
        public static void Main()
        {
            Dictionary<string, int> products = new Dictionary<string, int>();

            string command = Console.ReadLine();

            while (command != "shopping time")
            {
                string[] currentCommand = command.Split();

                if (!products.ContainsKey(currentCommand[1]))
                {
                    products[currentCommand[1]] = int.Parse(currentCommand[2]);
                }
                else
                {
                    products[currentCommand[1]] += int.Parse(currentCommand[2]);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "exam time")
            {
                string[] currentCommand = command.Split();

                if (products.ContainsKey(currentCommand[1]))
                {
                    if (products[currentCommand[1]] <= 0)
                    {
                        Console.WriteLine($"{currentCommand[1]} out of stock");
                    }
                    else
                    {
                        products[currentCommand[1]] -= int.Parse(currentCommand[2]);
                    }
                }
                else
                {
                    Console.WriteLine($"{currentCommand[1]} doesn't exist");
                }

                command = Console.ReadLine();
            }

            foreach (var kvp in products)
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
