using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JapaneseRoulette
{
    public class JapaneseRoulette
    {
        public static void Main()
        {
            int[] cylinder = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] rotation = Console.ReadLine().Split().ToArray();

            bool noOneShot = true;

            int bulletIndex = 0;

            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i] == 1)
                {
                    bulletIndex = i;
                    break;
                }
            }

            for (int i = 0; i < rotation.Length; i++)
            {
                string[] rotationByPlayer = rotation[i].Split(',').ToArray();
                int strength = int.Parse(rotationByPlayer[0]);
                string direction = rotationByPlayer[1];

                if (direction == "Right")
                {
                    bulletIndex += strength;

                    while (bulletIndex >= cylinder.Length)
                    {
                        bulletIndex -= cylinder.Length;
                    }
                }

                else if (direction == "Left")
                {
                    bulletIndex -= strength;

                    while (bulletIndex < 0)
                    {
                        bulletIndex += cylinder.Length;
                    }
                }

                if (bulletIndex == 2)
                {
                    noOneShot = false;
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    break;
                }
                else
                {
                    bulletIndex++;
                }
            }

            if (noOneShot)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
