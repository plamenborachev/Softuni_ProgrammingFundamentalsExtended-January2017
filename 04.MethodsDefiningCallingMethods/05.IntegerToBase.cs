using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntToBase(number, toBase));
        }

        private static string IntToBase(long number, int toBase)
        {
            string result = string.Empty;

            while (number > 0)
            {
                int reminder = (int)(number % toBase);
                result = reminder.ToString() + result;
                number /= toBase;
            }

            return result;
        }
    }
}
