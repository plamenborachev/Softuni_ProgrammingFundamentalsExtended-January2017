using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shellbound
{
    public class Shellbound
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, HashSet<int>> regionShells = new Dictionary<string, HashSet<int>>();

            while (inputLine != "Aggregate")
            {
                string[] input = inputLine.Split();

                string regionName = input[0];
                int shellSize = int.Parse(input[1]);

                if (!regionShells.ContainsKey(regionName))
                {
                    regionShells[regionName] = new HashSet<int>();
                }

                regionShells[regionName].Add(shellSize);

                inputLine = Console.ReadLine();
            }

            foreach (var regionShellsPair in regionShells)
            {
                string region = regionShellsPair.Key;
                string shells = string.Join(", ", regionShellsPair.Value);

                int sumOfShells = 0;

                foreach (var shell in regionShellsPair.Value)
                {
                    sumOfShells += shell;
                }

                int giantShell = sumOfShells - sumOfShells / regionShellsPair.Value.Count;

                Console.WriteLine($"{region} -> {shells} ({giantShell})");
            }
        }
    }
}
