using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayElementsEqualToTheirIndex
{
    public class ArrayElementsEqualToTheirIndex
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            int[] arrOfInt = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrOfInt[i] = int.Parse(arr[i]);
            }

            string result = string.Empty;

            for (int i = 0; i < arrOfInt.Length; i++)
            {
                if (arrOfInt[i] == i)
                {
                    result += arrOfInt[i] + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
