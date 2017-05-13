using System;

namespace _05.CapitalizeWords
{
    public class CapitalizeWords
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] words = inputLine
                    .ToLower()
                    .Split(new[] { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\', '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#', '\"', '!' },
                    StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1);
                }

                Console.WriteLine(string.Join(", ", words));

                inputLine = Console.ReadLine();
            }
        }
    }
}

