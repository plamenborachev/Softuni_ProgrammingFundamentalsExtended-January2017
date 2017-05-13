using System;
using System.Linq;

namespace _03.Wormhole
{
    public class Wormhole
    {
        public static void Main()
        {
            int[] wormholes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int steps = 0;
            int currentIndex = 0;

            for (int i = 0; i < wormholes.Length; i++)
            {
                currentIndex = i;

                if (wormholes[i] == 0)
                {
                    steps++;
                }
                else
                {
                    i = wormholes[i] - 1;
                    wormholes[currentIndex] = 0;
                }
            }
            Console.WriteLine(steps);
        }
    }
}
