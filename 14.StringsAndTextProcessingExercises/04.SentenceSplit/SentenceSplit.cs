using System;

namespace _04.SentenceSplit
{
    public class SentenceSplit
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            string delimeter = Console.ReadLine();

            string[] elements = inputLine.Split(new[] { delimeter}, StringSplitOptions.None);

            Console.WriteLine($"[{string.Join(", ", elements)}]");
        }
    }
}
