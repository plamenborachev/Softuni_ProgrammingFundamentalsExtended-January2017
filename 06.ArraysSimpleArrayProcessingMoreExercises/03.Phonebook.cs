using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();

            string command = string.Empty;

            while (command != "done")
            {
                command = Console.ReadLine();

                for (int i = 0; i < names.Length; i++)
                {
                    if (command == names[i])
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    }
                }
            }
        }
    }
}
