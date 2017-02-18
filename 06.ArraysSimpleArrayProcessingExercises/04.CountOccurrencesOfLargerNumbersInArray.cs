using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountOccurrencesLargerNumbersArr
{
    public class CountOccurrencesOfLargerNumbersInArray
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();
            double p = double.Parse(Console.ReadLine());

            double[] arrOfRealNumbers = new double[arr.Length];

            int countElementsBiggerThanP = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arrOfRealNumbers[i] = double.Parse(arr[i]);

                if (arrOfRealNumbers[i] > p)
                {
                    countElementsBiggerThanP++;
                }
            }

            Console.WriteLine(countElementsBiggerThanP);
        }
    }
}
