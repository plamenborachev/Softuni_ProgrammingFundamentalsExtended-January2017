using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IncreasingSequenceOfElements
{
    public class IncreasingSequenceOfElements
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            int[] arrayOfIntegers = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrayOfIntegers[i] = int.Parse(arr[i]);
            }

            bool increasingSequence = true;

            int previous = arrayOfIntegers[0];

            for (int i = 1; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] <= previous)
                {
                    increasingSequence = false;
                    break;
                }

                previous = arrayOfIntegers[i];
            }

            if (increasingSequence)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
