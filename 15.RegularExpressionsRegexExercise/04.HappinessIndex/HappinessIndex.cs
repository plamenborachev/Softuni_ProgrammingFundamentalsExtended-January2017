using System;
using System.Text.RegularExpressions;

namespace _04.HappinessIndex
{
    public class HappinessIndex
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            string happyEmoticonsPatern = @"((:\))|(:D)|(;\))|(:\*)|(:\])|(;\])|(:\})|(;\})|(\(:)|(\*:)|(c:)|(\[:)|(\[;))";
            string sadEmoticonsPatern = @"((:\()|(D:)|(;\()|(:\[)|(;\[)|(:\{)|(;\{)|(\):)|(:c)|(\]:)|(\];))";

            Regex regexHappiness = new Regex(happyEmoticonsPatern);
            Regex regexSadness = new Regex(sadEmoticonsPatern);

            MatchCollection happinessMatches = regexHappiness.Matches(inputLine);
            MatchCollection sadnessMatches = regexSadness.Matches(inputLine);

            double happinessIndex = (double)happinessMatches.Count / sadnessMatches.Count;

            string emoticon = string.Empty;

            if (happinessIndex >= 2)
            {
                emoticon = ":D";
            }
            else if (happinessIndex > 1)
            {
                emoticon = ":)";
            }
            else if (happinessIndex == 1)
            {
                emoticon = ":|";
            }
            else
            {
                emoticon = ":(";
            }

            Console.WriteLine($"Happiness index: {happinessIndex:F2} {emoticon}");

            Console.WriteLine($"[Happy count: {happinessMatches.Count}, Sad count: {sadnessMatches.Count}]");
        }
    }
}
