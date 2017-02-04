using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DistanceToTheStars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYearToKm = 9450000000000m;
            decimal distanceEarthToNearestStar = 4.22m * lightYearToKm;
            decimal distanceToTheCenterOfTheGalaxy = 26000 * lightYearToKm;
            decimal diameterOfTheMilkyWay = 100000 * lightYearToKm;
            decimal distanceFromEarthToTheEdgeOfTheObservableUniverse = 46500000000 * lightYearToKm;

            Console.WriteLine($"{distanceEarthToNearestStar:e2}");
            Console.WriteLine($"{distanceToTheCenterOfTheGalaxy:e2}");
            Console.WriteLine($"{diameterOfTheMilkyWay:e2}");
            Console.WriteLine($"{distanceFromEarthToTheEdgeOfTheObservableUniverse:e2}");
        }
    }
}
