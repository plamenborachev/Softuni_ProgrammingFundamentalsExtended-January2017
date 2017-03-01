using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PowerPlants
{
    public class PowerPlants
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            int[] powerLevel = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                powerLevel[i] = int.Parse(arr[i]);
            }

            int days = 0;
            int seasons = 0;
            int sum = 1;

            while (sum != 0)
            {
                for (int currentDay = 0; currentDay < powerLevel.Length; currentDay++)
                {
                    sum = 0;

                    for (int plantIndex = 0; plantIndex < powerLevel.Length; plantIndex++)
                    {
                        if (plantIndex != currentDay && powerLevel[plantIndex] > 0)
                        {
                            powerLevel[plantIndex]--;
                        }

                        sum += powerLevel[plantIndex];
                    }

                    if (currentDay == powerLevel.Length - 1 && sum != 0)
                    {
                        for (int i = 0; i < powerLevel.Length; i++)
                        {
                            if (powerLevel[i] > 0)
                            {
                                powerLevel[i]++;
                            }
                        }

                        seasons++;
                    }

                    if (sum == 0)
                    {
                        days++;
                        break;
                    }

                    days++;
                }
            }

            Console.Write($"survived {days} days ");

            if (seasons == 1)
            {
                Console.WriteLine($"({seasons} season)");
            }
            else
            {
                Console.WriteLine($"({seasons} seasons)");
            }
        }
    }
}
