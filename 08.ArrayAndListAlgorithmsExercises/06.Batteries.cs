using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    public class Batteries
    {
        public static void Main()
        {
            double[] capacities = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int hoursStressTest = int.Parse(Console.ReadLine());

            List<double> finalCapacities = new List<double>();

            for (int i = 0; i < capacities.Length; i++)
            {
                finalCapacities.Add(capacities[i]);
            }

            List<int> hoursLasted = new List<int>();

            for (int i = 0; i < capacities.Length; i++)
            {
                hoursLasted.Add(0);

                int hours = hoursStressTest;

                while (finalCapacities[i] > 0 && hours > 0)
                {
                    finalCapacities[i] -= usagePerHour[i];
                    hours--;
                    hoursLasted[i]++;
                }
            }

            for (int i = 0; i < capacities.Length; i++)
            {
                if (finalCapacities[i] > 0)
                {
                    Console.WriteLine("Battery {0}: {1:F2} mAh ({2:F2})%",
                        i + 1,
                        finalCapacities[i],
                        finalCapacities[i] * 100 / capacities[i]);
                }
                else
                {
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)",
                        i + 1,
                        hoursLasted[i]);
                }
            }
        }
    }
}
