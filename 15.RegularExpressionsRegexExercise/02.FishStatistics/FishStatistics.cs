using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.FishStatistics
{
    public class FishStatistics
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            string pattern = @"(>*)<(\(+)(['\-x])>";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(inputLine);

            List<Fish> fishes = new List<Fish>();

            foreach (Match match in matches)
            {
                string type = match.Groups[0].Value;

                int tailLenght = match.Groups[1].Length * 2;

                string tailType = string.Empty;

                if (tailLenght > 10)
                {
                    tailType = "Long";
                }
                else if (tailLenght > 2)
                {
                    tailType = "Medium";
                }
                else if (tailLenght == 2)
                {
                    tailType = "Short";
                }

                int bodyLength = match.Groups[2].Length * 2;

                string bodyType = string.Empty;

                if (bodyLength > 20)
                {
                    bodyType = "Long";
                }
                else if (bodyLength > 10)
                {
                    bodyType = "Medium";
                }
                else
                {
                    bodyType = "Short";
                }

                string status = string.Empty;

                if (match.Groups[3].Value == "'")
                {
                    status = "Awake";
                }
                else if (match.Groups[3].Value == "-")
                {
                    status = "Asleep";
                }
                else if (match.Groups[3].Value == "x")
                {
                    status = "Dead";
                }

                fishes.Add(new Fish
                {
                    Type = type,

                    TailType = tailType,

                    TailLength = tailLenght,

                    BodyType = bodyType,

                    BodyLength = bodyLength,

                    Status = status
                });
            }

            if (fishes.Any())
            {
                int counter = 1;

                foreach (var fish in fishes)
                {
                    Console.WriteLine($"Fish {counter}: {fish.Type}");

                    if (fish.TailLength == 0)
                    {
                        Console.WriteLine($"  Tail type: None");
                    }
                    else
                    {
                        Console.WriteLine($"  Tail type: {fish.TailType} ({fish.TailLength} cm)");
                    }

                    Console.WriteLine($"  Body type: {fish.BodyType} ({fish.BodyLength} cm)");
                    Console.WriteLine($"  Status: {fish.Status}");

                    counter++;
                }
            }
            else
            {
                Console.WriteLine("No fish found.");
            }
        }
    }
}
