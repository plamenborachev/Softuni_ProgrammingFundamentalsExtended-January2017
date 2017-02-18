using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountOfGivenElementInArray
{
    public class CountOfGivenElementInArray
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();
            int element = int.Parse(Console.ReadLine());

            int countOfElement = 0;

            int[] arrOfIntegers = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrOfIntegers[i] = int.Parse(arr[i]);

                if (arrOfIntegers[i] == element)
                {
                    countOfElement++;
                }
            }

            Console.WriteLine(countOfElement);


        }
    }
}
