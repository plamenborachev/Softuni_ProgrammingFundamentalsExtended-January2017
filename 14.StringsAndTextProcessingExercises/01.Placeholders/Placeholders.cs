using System;

namespace _01.Placeholders
{
    public class Placeholders
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string text = inputParams[0];

                string[] elements = inputParams[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    string toReplace = "{" + i + "}";

                    text = text.Replace(toReplace, elements[i]);
                }

                Console.WriteLine(text);

                inputLine = Console.ReadLine();
            }
        }
    }
}
