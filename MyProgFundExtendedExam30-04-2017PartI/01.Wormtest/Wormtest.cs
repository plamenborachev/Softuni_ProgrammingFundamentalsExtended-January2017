using System;

namespace _01.Wormtest
{
    public class Wormtest
    {
        public static void Main()
        {
            long wormLengthInMeters = long.Parse(Console.ReadLine());
            decimal wormWidth = decimal.Parse(Console.ReadLine());

            long wormLengthInCm = wormLengthInMeters * 100;

            decimal result = 0m;

            try
            {
                decimal reminder = wormLengthInCm % wormWidth;

                if (reminder == 0)
                {
                    result = wormLengthInCm * wormWidth;
                    Console.WriteLine($"{result:f2}");
                }
                else
                {
                    result = (wormLengthInCm / wormWidth) * 100;
                    Console.WriteLine($"{result:f2}%");
                }
            }
            catch (Exception)
            {
                result = wormLengthInCm * wormWidth;
                Console.WriteLine($"{result:f2}");
            }
        }
    }
}
