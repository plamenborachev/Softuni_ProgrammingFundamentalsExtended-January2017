using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.LetterRepetition
{
    public class LetterRepetition
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            char[] characters = text.ToCharArray();

            Dictionary<char, int> lettersCount = new Dictionary<char, int>();

            for (int i = 0; i < characters.Length; i++)
            {
                if (!lettersCount.ContainsKey(characters[i]))
                {
                    lettersCount[characters[i]] = 1;
                }
                else
                {
                    lettersCount[characters[i]]++;
                }
            }

            foreach (var kvp in lettersCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
