using System;
using System.Linq;

namespace _03.EnduranceRally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            string[] drivers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double[] zones = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            int[] checkpoints = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var driver in drivers)
            {
                double fuel = driver[0];

                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
            }
        }
    }
}
