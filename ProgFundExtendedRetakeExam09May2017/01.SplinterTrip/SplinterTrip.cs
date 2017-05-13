using System;

namespace _01.SplinterTrip
{
    public class SplinterTrip
    {
        public static void Main()
        {
            double tripDistance = double.Parse(Console.ReadLine());
            double fuelTankCapacity = double.Parse(Console.ReadLine());
            double milesHeavyWinds = double.Parse(Console.ReadLine());

            double milesNonHeavyWinds = tripDistance - milesHeavyWinds;
            double nonHeavyWindsConsumption = milesNonHeavyWinds * 25;
            double heavyWindsConsumption = milesHeavyWinds * 25 * 1.5;
            double fuelConsumption = nonHeavyWindsConsumption + heavyWindsConsumption;
            double tolerance = fuelConsumption * 5 / 100;
            double totalFuelConsumption = fuelConsumption + tolerance;

            Console.WriteLine($"Fuel needed: {totalFuelConsumption:F2}L");

            if (fuelTankCapacity >= totalFuelConsumption)
            {
                Console.WriteLine($"Enough with {fuelTankCapacity - totalFuelConsumption:F2}L to spare!");
            }
            else
            {
                Console.WriteLine($"We need {totalFuelConsumption - fuelTankCapacity:F2}L more fuel.");
            }

        }
    }
}
