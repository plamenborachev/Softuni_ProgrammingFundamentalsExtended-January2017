using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CypherRoulette
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            string cypherString = string.Empty;
            string str = string.Empty;

            bool appendToTheEnd = true;

            for (int i = 0; i < N; i++)
            {
                string prevStr = str;
                str = Console.ReadLine();

                if (str == prevStr)
                {
                    cypherString = string.Empty;

                    if (str == "spin")
                    {
                        i--;
                    }
                    continue;
                }

                if (str == "spin")
                {
                    appendToTheEnd = !appendToTheEnd;
                    i--;
                    continue;
                }

                cypherString = appendToTheEnd ? cypherString + str : str + cypherString;

            }
            Console.WriteLine(cypherString);
        }
    }
}
