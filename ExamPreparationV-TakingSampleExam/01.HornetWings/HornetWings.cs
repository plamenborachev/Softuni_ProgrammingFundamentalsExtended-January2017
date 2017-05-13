using System;

namespace _01.HornetWings
{
    public class HornetWings
    {
        public static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            decimal metersPerThousandWingFlaps = decimal.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            decimal distance = (wingFlaps / 1000) * metersPerThousandWingFlaps;

            decimal time = (wingFlaps / 100) + (wingFlaps / endurance) * 5;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{time} s.");
        }
    }
}
