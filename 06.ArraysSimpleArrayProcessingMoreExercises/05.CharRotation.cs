using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharRotation
{
    public class CharRotation
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string[] numbers = Console.ReadLine().Split();

            int[] intArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                intArray[i] = int.Parse(numbers[i]);
            }

            char[] textToChars = text.ToCharArray();

            string result = string.Empty;

            for (int i = 0; i < textToChars.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    result += (char)(textToChars[i] - intArray[i]);
                }
                else
                {
                    result += (char)(textToChars[i] + (char)intArray[i]);
                }
            }

            Console.WriteLine(result);
        }
    }
}
