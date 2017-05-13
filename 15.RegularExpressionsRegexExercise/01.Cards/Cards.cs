using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    public class Cards
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            string pattern = @"(([0-9]+)|[JQKA])[SHDC]";

            Regex regex = new Regex(pattern);

            MatchCollection cards = regex.Matches(inputLine);

            List<string> validCards = new List<string>();

            foreach (Match card in cards)
            {
                int parsed = 0;

                if (int.TryParse(card.Groups[1].Value, out parsed))
                {
                    if (2 <= parsed && parsed <= 10)
                    {
                        validCards.Add(card.Groups[0].Value);
                    }
                }
                else
                {
                    validCards.Add(card.Groups[0].Value);
                }
            }

            Console.WriteLine(string.Join(", ", validCards));
        }
    }
}
