using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RabbitHole
{
    public class RabbitHole
    {
        public static void Main()
        {
            List<string> obstacles = Console.ReadLine().Split().ToList();
            int energy = int.Parse(Console.ReadLine());

            int currentIndex = 0;

            while (energy > 0)
            {
                if (obstacles[currentIndex] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
                else
                {
                    string[] command = obstacles[currentIndex].Split('|').ToArray();
                    string currentCommand = command[0];
                    int value = int.Parse(command[1]);
                    int reminder = value % obstacles.Count;

                    if (currentCommand == "Left")
                    {
                        currentIndex = Math.Abs(currentIndex - value) % obstacles.Count;
                        energy -= value;

                        if (energy <= 0)
                        {
                            Console.WriteLine("You are tired. You can't continue the mission.");
                            break;
                        }
                    }
                    else if (currentCommand == "Right")
                    {
                        currentIndex = (currentIndex + value) % obstacles.Count;
                        energy -= value;

                        if (energy <= 0)
                        {
                            Console.WriteLine("You are tired. You can't continue the mission.");
                            break;
                        }
                    }
                    else if (currentCommand == "Bomb")
                    {
                        obstacles.RemoveAt(currentIndex);
                        energy -= value;
                        currentIndex = 0;

                        if (energy <= 0)
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            break;
                        }
                    }
                }

                if (obstacles[obstacles.Count - 1] != "RabbitHole")
                {
                    obstacles.RemoveAt(obstacles.Count - 1);
                }

                obstacles.Add($"Bomb|{energy.ToString()}");
            }
        }
    }
}
