using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinMethod
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int smallerNumber = GetMin(num1, GetMin(num2, num3));

            Console.WriteLine(smallerNumber);
        }

        private static int GetMin(int a, int b)
        {
            int minNumber = 0;
            if (a > b)
            {
                minNumber = b;
            }
            else if (a < b)
            {
                minNumber = a;
            }
            return minNumber;
        }
    }
}
