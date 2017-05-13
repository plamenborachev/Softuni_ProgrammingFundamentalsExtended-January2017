using System;
using System.Text.RegularExpressions;

namespace _04.WinningTicket
{
    public class WinningTicket
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            string[] tickets = inputLine.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string leftHalf = ticket.Substring(0, 10);
                    string rightHalf = ticket.Substring(10);

                    string pattern = @"([@#$^])\1{5,9}";

                    Regex regex = new Regex(pattern);

                    Match matchLeftHalf = regex.Match(leftHalf);
                    Match matchRightHalf = regex.Match(rightHalf);

                    int minMatchLength = Math.Min(matchLeftHalf.Value.Length, matchRightHalf.Value.Length);

                    if (matchLeftHalf.Value != "" && matchRightHalf.Value != "")
                    {
                        if (6 <= minMatchLength && minMatchLength <= 9)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {minMatchLength}{matchLeftHalf.Groups[1]}");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {minMatchLength}{matchLeftHalf.Groups[1]} Jackpot!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
