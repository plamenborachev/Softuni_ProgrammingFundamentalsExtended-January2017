using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.RageQuit
{
    public class RageQuit
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine().ToUpper();

            Regex regex = new Regex(@"(\D+)(\d+)");

            MatchCollection matches = regex.Matches(inputLine);

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                for (int i = 0; i < int.Parse(match.Groups[2].Value); i++)
                {
                    sb.Append(match.Groups[1].Value);
                }
            }

            int uniqueSymbolsCount = sb.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");
            Console.WriteLine(sb);
        }
    }
}
