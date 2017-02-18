using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Altitude
{
    public class Altitude
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            double initialAltitude = double.Parse(arr[0]);

            bool crashed = false;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == "up")
                {
                    initialAltitude += double.Parse(arr[i + 1]);
                }
                else if (arr[i] == "down")
                {
                    initialAltitude -= double.Parse(arr[i + 1]);
                }

                if (initialAltitude <= 0)
                {
                    crashed = true;
                    break;
                }
            }

            if (crashed)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {initialAltitude}m");
            }
        }
    }
}
