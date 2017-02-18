using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountOfNegativeElementsInArray
{
    public class CountOfNegativeElementsInArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int countNegativeNumbers = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] < 0)
                {
                    countNegativeNumbers++;
                }
            }

            Console.WriteLine(countNegativeNumbers);
        }
    }
}
