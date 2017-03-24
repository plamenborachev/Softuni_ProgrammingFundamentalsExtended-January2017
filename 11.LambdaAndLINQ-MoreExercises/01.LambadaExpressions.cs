using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LambadaExpressions
{
    public class LambadaExpressions
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, string> lambadaExpressions = new Dictionary<string, string>();

            while (inputLine != "lambada")
            {
                string[] tokens = inputLine.Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] != "dance")
                {
                    string selector = tokens[0];
                    string selectorObject = tokens[1];
                    string property = tokens[2];

                    lambadaExpressions[selector] = property;
                }
                else
                {
                    lambadaExpressions = lambadaExpressions.ToDictionary(x => x.Key, x => x.Key + "." + x.Value);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var kvp in lambadaExpressions)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Key}.{kvp.Value}");
            }
        }
    }
}
