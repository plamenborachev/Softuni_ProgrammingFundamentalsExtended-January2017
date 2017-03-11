using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MixedPhones
{
    public class MixedPhones
    {
        public static void Main()
        {
            SortedDictionary<string, long> phonebook = new SortedDictionary<string, long>();

            string command = Console.ReadLine();

            while (command != "Over")
            {
                string[] currentCommand = command.Split();

                long parsedPhoneNumber;

                if (long.TryParse(currentCommand[2], out parsedPhoneNumber))
                {
                    phonebook[currentCommand[0]] = parsedPhoneNumber;
                }
                else
                {
                    phonebook[currentCommand[2]] = int.Parse(currentCommand[0]);
                }

                command = Console.ReadLine();
            }

            foreach (var kvp in phonebook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}
