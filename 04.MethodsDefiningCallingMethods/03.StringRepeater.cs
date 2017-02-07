using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringRepeater
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(str, count));
        }

        private static string RepeatString(string str, int count)
        {
            string repeatString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                repeatString += str;
            }
            return repeatString;
        }
    }
}
