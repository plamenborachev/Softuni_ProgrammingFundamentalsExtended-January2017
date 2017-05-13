using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LadybugsFromVideo
{
    public class LadybugsFromVideo
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = new int[fieldSize];

            foreach (var index in indexes)
            {
                if (0 <= index && index < fieldSize)
                {
                    field[index] = 1;
                }
            }

            //for (int i = 0; i < field.Length; i++)
            //{
            //    if (indexes.Contains(i))
            //    {
            //        field[i] = 1;
            //    }
            //}

            while (true)
            {
                string command = Console.ReadLine();

                if (command != "end")
                {
                    break;
                }

                string[] commandParams = command.Split();

                int currentLadybugIndex = int.Parse(commandParams[0]);
                string direction = commandParams[1];
                int flyLength = int.Parse(commandParams[2]);

                if (currentLadybugIndex < 0 || currentLadybugIndex >= fieldSize)
                {
                    continue;
                }

                if (field[currentLadybugIndex] == 0)
                {
                    continue;
                }

                field[currentLadybugIndex] = 0;

                int position = currentLadybugIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        position += flyLength;
                    }
                    else if (direction == "left")
                    {
                        position -= flyLength;
                    }

                    if (position < 0 || position >= fieldSize)
                    {
                        break;
                    }

                    if (field[position] == 0)
                    {
                        field[position] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
