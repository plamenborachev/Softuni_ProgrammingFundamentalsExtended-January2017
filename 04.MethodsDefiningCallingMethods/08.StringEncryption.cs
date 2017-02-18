using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.StringEncryption
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 0; i < N; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                result += Encrypt(letter);
            }

            Console.WriteLine(result);
        }

        private static string Encrypt(char letter)
        {
            string result = string.Empty;
            int asciiCode = letter;
            int firstDigit = 0;
            int lastDigit = asciiCode % 10;

            if (asciiCode <= 99)
            {
                firstDigit = asciiCode / 10;
            }
            else
            {
                firstDigit = asciiCode / 100;
            }
            result = (char)(asciiCode + lastDigit) + firstDigit.ToString() + lastDigit.ToString() + (char)(asciiCode - firstDigit);

            return result;
        }
    }
}
