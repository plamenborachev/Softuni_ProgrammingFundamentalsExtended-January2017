using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IncrementVariable
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            byte result = 0;
            int overflows = 0;

            for (int i = 0; i < num; i++)
            {
                result++;

                if (result == 0)
                {
                    overflows++;
                }
            }

            Console.WriteLine(result);
            if (overflows > 0)
            {
                Console.WriteLine($"Overflowed {overflows} times");
            }
        }
    }
}
