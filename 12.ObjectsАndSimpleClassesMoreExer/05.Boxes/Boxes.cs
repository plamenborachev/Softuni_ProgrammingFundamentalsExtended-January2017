using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Boxes
{
    public class Boxes
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (inputLine != "end")
            {
                int[] inputParams = inputLine
                    .Split(new[] { ' ', ':', '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                Box newBox = new Box()
                {
                    UpperLeft = new Point()
                    {
                        X = inputParams[0],
                        Y = inputParams[1]
                    },
                    UpperRight = new Point()
                    {
                        X = inputParams[2],
                        Y = inputParams[3]
                    },
                    BottomLeft = new Point()
                    {
                        X = inputParams[4],
                        Y = inputParams[5]
                    },
                    BottomRight = new Point()
                    {
                        X = inputParams[6],
                        Y = inputParams[7]
                    }
                };

                boxes.Add(newBox);

                inputLine = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {box.CalculatePerimeter(box.Width, box.Height)}");
                Console.WriteLine($"Area: {box.CalculateArea(box.Width, box.Height)}");
            }
        }
    }
}
