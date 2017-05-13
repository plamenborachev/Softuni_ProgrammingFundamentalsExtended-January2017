using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Spyfer
{
    public class Spyfer
    {
        public static void Main()
        {
            List<int> coordinates = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < coordinates.Count; i++)
            {
                if (i == 0 && coordinates[i] == coordinates[i + 1])
                {
                    coordinates.RemoveAt(i + 1);
                    i = 0;
                }

                else if(i != 0 && i != coordinates.Count - 1 && coordinates[i] == coordinates[i - 1] + coordinates[i + 1])
                {
                    coordinates.RemoveAt(i + 1);
                    coordinates.RemoveAt(i - 1);
                    i = 0;
                }

                else if (i == coordinates.Count - 1 && coordinates[i - 1] == coordinates[i])
                {
                    coordinates.RemoveAt(i - 1);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", coordinates));
        }
    }
}
