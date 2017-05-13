using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Pyramidic
{
    public class Pyramidic
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> inputLines = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();

                inputLines.Add(inputLine);
            }

            HashSet<char> symbols = new HashSet<char>();

            foreach (var line in inputLines)
            {
                foreach (var symbol in line)
                {
                    symbols.Add(symbol);
                }
            }

            List<string> pyramids = new List<string>();

            foreach (var symbol in symbols)
            {
                StringBuilder sb = new StringBuilder();

                int layer = 1;

                for (int i = 0; i < n; i++)
                {
                    string currentLayer = new string(symbol, layer);

                    if (inputLines[i].Contains(currentLayer))
                    {
                        sb.AppendLine(currentLayer);
                        layer += 2;
                    }
                    else
                    {
                        pyramids.Add(sb.ToString().Trim());
                        sb.Clear();
                        layer = 1;
                    }
                }

                pyramids.Add(sb.ToString().Trim());
            }

            Console.WriteLine(pyramids.OrderByDescending(x => x.Length).First());

        }
    }
}
