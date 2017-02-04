using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TravelingAtLightSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());
            decimal totalSeconds = lightYears * 9450000000000 / 300000;
            decimal weeks = Math.Floor(totalSeconds / (7 * 24 * 60 * 60));
            decimal days = Math.Floor((totalSeconds - (weeks * 7 * 24 * 60 * 60)) / (24 * 60 * 60));
            decimal hours = Math.Floor((totalSeconds - (weeks * 7 * 24 * 60 * 60) - (days * 24 * 60 * 60)) / (60 * 60));
            decimal minutes = Math.Floor((totalSeconds - (weeks * 7 * 24 * 60 * 60) - (days * 24 * 60 * 60) - (hours * 60 * 60)) / 60);
            decimal seconds = totalSeconds - (weeks * 7 * 24 * 60 * 60) - (days * 24 * 60 * 60) - (hours * 60 * 60) - (minutes * 60);

            Console.WriteLine($"{weeks:f0} weeks");
            Console.WriteLine($"{days:f0} days");
            Console.WriteLine($"{hours:f0} hours");
            Console.WriteLine($"{minutes:f0} minutes");
            Console.WriteLine($"{seconds:f0} seconds");
        }
    }
}
