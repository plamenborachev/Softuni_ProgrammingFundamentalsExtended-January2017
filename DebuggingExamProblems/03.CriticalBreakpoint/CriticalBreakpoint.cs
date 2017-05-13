using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _03.CriticalBreakpoint
{
    public class Line
    {
        public BigInteger X1 { get; set; }

        public BigInteger Y1 { get; set; }

        public BigInteger X2 { get; set; }

        public BigInteger Y2 { get; set; }

        public BigInteger CriticalRatio { get; set; }
    }

    public class CriticalBreakpoint
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            BigInteger actualCriticalRatio = 0;

            bool criticalBreakpointExists = true;

            List<Line> lines = new List<Line>();

            while (inputLine != "Break it.")
            {
                int[] lineParams = inputLine.Split().Select(int.Parse).ToArray();

                int x1 = lineParams[0];
                int y1 = lineParams[1];
                int x2 = lineParams[2];
                int y2 = lineParams[3];

                BigInteger criticalRatio = BigInteger.Abs(((long)x2 + y2) - ((long)x1 + y1));

                Line currentLine = new Line
                {
                    X1 = x1,
                    Y1 = y1,
                    X2 = x2,
                    Y2 = y2,
                    CriticalRatio = criticalRatio
                };

                lines.Add(currentLine);

                if (currentLine.CriticalRatio != 0 && actualCriticalRatio == 0)
                {
                    actualCriticalRatio = currentLine.CriticalRatio;
                }

                if (currentLine.CriticalRatio != 0
                    && currentLine.CriticalRatio != actualCriticalRatio)
                {
                    criticalBreakpointExists = false;
                    break;
                }

                inputLine = Console.ReadLine();
            }

            if (criticalBreakpointExists && actualCriticalRatio != 0)
            {
                BigInteger totalRatio = BigInteger.Pow(actualCriticalRatio, lines.Count);

                BigInteger criticalBreakpoint = 0;

                BigInteger.DivRem(totalRatio, lines.Count, out criticalBreakpoint);

                foreach (var line in lines)
                {
                    Console.WriteLine($"Line: [{line.X1}, {line.Y1}, {line.X2}, {line.Y2}]");
                }

                Console.WriteLine($"Critical Breakpoint: {criticalBreakpoint}");
            }

            else
            {
                Console.WriteLine("Critical breakpoint does not exist.");
            }
        }
    }
}
