using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HornetAssault
{
    public class HornetAssault
    {
        public static void Main()
        {
            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();

            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                long summedPower = hornets.Sum();

                if (hornets.Count == 0)
                {
                    break;
                }

                if (beehives[i] >= summedPower)
                {
                    hornets.RemoveAt(0);
                }

                beehives[i] -= summedPower;
            }

            if (beehives.Any(x => x > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
