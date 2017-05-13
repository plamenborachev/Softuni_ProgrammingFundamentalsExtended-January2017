using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.WormIpsum
{
    public class WormIpsum
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "Worm Ipsum")
            {
                string[] sentences = inputLine.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                if ((65 <= inputLine[0] && inputLine[0] <= 90)
                && inputLine[inputLine.Length - 1] == '.'
                && sentences.Length == 1)
                {
                    string[] words = inputLine.Split(new[] { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\', '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#', '\"', '!' },
                        StringSplitOptions.RemoveEmptyEntries);

                    Dictionary<char, int> charactersInWord = new Dictionary<char, int>();

                    foreach (var word in words)
                    {
                        for (int i = 0; i < word.Length; i++)
                        {
                            char currentCharacter = word[i];

                            if (!charactersInWord.ContainsKey(currentCharacter))
                            {
                                charactersInWord[currentCharacter] = 0;
                            }

                            charactersInWord[currentCharacter]++;
                        }

                        charactersInWord = charactersInWord
                            .Where(x => x.Value > 1)
                            .ToDictionary(x => x.Key, x => x.Value);

                        if (charactersInWord.Any())
                        {
                            charactersInWord = charactersInWord
                                .OrderByDescending(x => x.Value)
                                .Take(1)
                                .ToDictionary(x => x.Key, x => x.Value);

                            string newWord = string.Empty;

                            foreach (var character in charactersInWord)
                            {
                                newWord = new string(character.Key, word.Length);
                            }

                            inputLine = inputLine.Replace(word, newWord);

                            charactersInWord.Clear();
                        }
                    }

                    Console.WriteLine(inputLine);
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
