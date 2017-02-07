using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NthDigit
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            int nthDigit = FindNthDigit(number, index);

            Console.WriteLine(nthDigit);
        }

        private static int FindNthDigit(long number, int index)
        {
            int nthDigit = 0;
            if (index == 1)
            {
                nthDigit = (int)(number % 10);
            }
            else if (index > 1)
            {
                for (int i = 1; i < index; i++)
                {
                    number /= 10;
                }
                nthDigit = (int)(number % 10);
            }
            return nthDigit;
        }
    }
}
