using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.WordEncounter
{
    public class WordEncounter
    {
        public static void Main()
        {
            string filter = Console.ReadLine();

            char filterCharacter = filter[0];
            int filterDigit = int.Parse(filter[1].ToString());

            string inputLine = Console.ReadLine();

            List<string> wordsResult = new List<string>();

            while (inputLine != "end")
            {
                Regex validSentence = new Regex(@"^[A-Z].+[.?!]$");
                
                Match matchValidSentence = validSentence.Match(inputLine);

                if (matchValidSentence.Success)
                {
                    Regex splitToWords = new Regex(@"\w+");

                    MatchCollection words = splitToWords.Matches(inputLine);

                    foreach (Match word in words)
                    {
                        int counter = 0;

                        foreach (var symbol in word.Groups[0].Value)
                        {
                            if (symbol == filterCharacter)
                            {
                                counter++;
                            }
                        }

                        if (counter >= filterDigit)
                        {
                            wordsResult.Add(word.Groups[0].Value);
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", wordsResult));
        }
    }
}
