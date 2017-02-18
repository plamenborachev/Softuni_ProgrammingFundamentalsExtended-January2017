using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EqualSequenceOfElementsInArray
{
    public class EqualSequenceOfElementsInArray
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            int[] arrayOfIntegers = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrayOfIntegers[i] = int.Parse(arr[i]);
            }

            int previuos = arrayOfIntegers[0];
            
            bool elementsInTheArrayAreTheSame = true;

            for (int i = 1; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] != previuos)
                {
                    elementsInTheArrayAreTheSame = false;
                    break;
                }

                previuos = arrayOfIntegers[i];
            }

            if (elementsInTheArrayAreTheSame)
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
