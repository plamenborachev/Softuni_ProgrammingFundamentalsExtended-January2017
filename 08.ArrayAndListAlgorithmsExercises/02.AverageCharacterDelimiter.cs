using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageCharacterDelimiter
{
    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            string[] str = Console.ReadLine().Split().ToArray();

            double sum = 0;
            int symbolsCount = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                char[] strToChars = str[i].ToCharArray();

                foreach (var symbol in strToChars)
                {
                    sum += symbol;
                    symbolsCount++;
                }
            }

            string delimeter = Char.ToUpper((char)Math.Floor(sum / symbolsCount)).ToString();

            Console.WriteLine(string.Join(delimeter, str));
        }
    }
}
