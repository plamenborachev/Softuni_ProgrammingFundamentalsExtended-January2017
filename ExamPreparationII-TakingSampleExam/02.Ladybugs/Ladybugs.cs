using System;
using System.Linq;

namespace _02.Ladybugs
{
    public class Ladybugs
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

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandParams = command.Split();

                int currentLadybugIndex = int.Parse(commandParams[0]);
                string direction = commandParams[1];
                int flyLength = int.Parse(commandParams[2]);

                if (0 <= currentLadybugIndex && currentLadybugIndex < fieldSize && field[currentLadybugIndex] == 1)
                {
                    int nextLadybugIndex = 0;

                    if (direction == "right")
                    {
                        field[currentLadybugIndex] = 0;
                        nextLadybugIndex = currentLadybugIndex + flyLength;

                        if (nextLadybugIndex < field.Length)
                        {
                            if (field[nextLadybugIndex] == 0)
                            {
                                field[nextLadybugIndex] = 1;
                            }
                            else
                            {
                                for (int i = nextLadybugIndex + flyLength; i < field.Length; i += flyLength)
                                {
                                    if (field[i] == 0)
                                    {
                                        field[i] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    else if (direction == "left")
                    {
                        field[currentLadybugIndex] = 0;
                        nextLadybugIndex = currentLadybugIndex - flyLength;

                        if (0 <= nextLadybugIndex)
                        {
                            if (field[nextLadybugIndex] == 0)
                            {
                                field[nextLadybugIndex] = 1;
                            }
                            else
                            {
                                for (int i = nextLadybugIndex - flyLength; i >= 0; i -= flyLength)
                                {
                                    if (field[i] == 0)
                                    {
                                        field[i] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
