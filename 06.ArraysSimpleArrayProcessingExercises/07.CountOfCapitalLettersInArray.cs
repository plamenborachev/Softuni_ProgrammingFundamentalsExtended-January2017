using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountOfCapitalLettersInArray
{
    public class CountOfCapitalLettersInArray
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            int countCapitalEnglishLetters = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string currentWord = arr[i];

                if (currentWord.Length == 1)
                {
                    char letter = char.Parse(currentWord);

                    if ('A' <= letter && letter <= 'Z')
                    {
                        countCapitalEnglishLetters++;
                    }
                }
            }
            Console.WriteLine(countCapitalEnglishLetters);
        }
    }
}
