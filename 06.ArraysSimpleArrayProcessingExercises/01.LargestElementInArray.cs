using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestElementInArray
{
    public class LargestElementInArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int largestNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] > largestNum)
                {
                    largestNum = arr[i];
                }
            }

            Console.WriteLine(largestNum);
        }
    }
}
