using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IntegerInsertion
{
    public class IntegerInsertion
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;

            while (command != "end")
            {
                command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                int number = int.Parse(command);

                int firstDigit = number;

                while (firstDigit > 9)
                {
                    firstDigit /= 10;
                }

                numbers.Insert(firstDigit, number);
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
