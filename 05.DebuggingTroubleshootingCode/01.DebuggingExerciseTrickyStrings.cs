using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DebuggingExerciseTrickyStrings
{
    class Program
    {
        static void Main()
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());

            var currentString = string.Empty;
            var result = string.Empty;

            for (int i = 0; i < numberOfStrings - 1; i++)
            {
                currentString = Console.ReadLine();
                result += currentString + delimiter;
            }
            currentString = Console.ReadLine();
            result += currentString;

            Console.WriteLine(result);
        }
    }
}
