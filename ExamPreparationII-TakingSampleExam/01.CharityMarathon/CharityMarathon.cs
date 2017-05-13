using System;

namespace _01.CharityMarathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int lapsPerRunner = int.Parse(Console.ReadLine());
            long trackLength = int.Parse(Console.ReadLine());
            int trackCapacityPerDay = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            int trackCapacity = trackCapacityPerDay * days;

            long totalMeters = Math.Min(runners, trackCapacity) * lapsPerRunner * trackLength;

            long totalKm = totalMeters / 1000;

            double moneyRaised = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
