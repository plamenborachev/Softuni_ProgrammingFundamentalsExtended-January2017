using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BallisticsTraining
{
    public class BallisticsTraining
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            int[] targetCoordinates = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                targetCoordinates[i] = int.Parse(arr[i]);
            }

            string[] commands = Console.ReadLine().Split();

            int x = 0;
            int y = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    y += int.Parse(commands[i + 1]);
                }
                else if (commands[i] == "down")
                {
                    y -= int.Parse(commands[i + 1]);
                }
                else if (commands[i] == "left")
                {
                    x -= int.Parse(commands[i + 1]);
                }
                else if (commands[i] == "right")
                {
                    x += int.Parse(commands[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{x}, {y}]");

            if (x == targetCoordinates[0] && y == targetCoordinates[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
            
        }
    }
}
