using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last3ConsecutiveEqualStrings
{
    public class Last3ConsecutiveEqualStrings
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            string lastThreeConsecutiveEqualStrings = string.Empty;

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i - 2] == arr[i - 1] && arr[i - 1] == arr[i])
                {
                    lastThreeConsecutiveEqualStrings = arr[i];
                }
            }

            Console.WriteLine($"{lastThreeConsecutiveEqualStrings} {lastThreeConsecutiveEqualStrings} {lastThreeConsecutiveEqualStrings}");
        }
    }
}
