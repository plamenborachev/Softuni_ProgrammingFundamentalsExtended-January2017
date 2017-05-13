using System;
using System.Globalization;

namespace _01.SinoTheWalker
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            DateTime timeLeaving = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            decimal stepsNumber = decimal.Parse(Console.ReadLine());

            decimal secondsPerStep = decimal.Parse(Console.ReadLine());

            int secondsInDay = 24 * 60 * 60;

            var totalSecondsNeeded = (int)(stepsNumber * secondsPerStep % secondsInDay);

            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", timeLeaving.AddSeconds(totalSecondsNeeded));
        }
    }
}
