using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.NetherRealms
{
    public class NetherRealms
    {
        public static void Main()
        {
            string[] demonsNames = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //Regex healthRegex = new Regex(@"[^0-9+\-\*/.]");

            Regex damageRegex = new Regex(@"(-?\d+\.?\d*)|(\/)|(\*)");

            SortedDictionary<string, List<double>> demons = new SortedDictionary<string, List<double>>();

            foreach (var name in demonsNames)
            {
                //MatchCollection healthSymbols = healthRegex.Matches(name);

                char[] healthSymbols = name
                    .Where(x => !char.IsDigit(x) && x != '+' && x != '-' && x != '*' && x != '/' && x != '.')
                    .ToArray(); 

                double health = 0;

                foreach (var symbol in healthSymbols)
                {
                    health += symbol;
                }

                MatchCollection damageSymbols = damageRegex.Matches(name);

                double damage = 0;

                foreach (Match number in damageSymbols)
                {
                    double parsed = 0;

                    if (double.TryParse(number.Groups[1].Value, out parsed))
                    {
                        damage += parsed;
                    }
                }

                foreach (Match symbol in damageSymbols)
                {
                    if (symbol.Groups[2].Value == "/")
                    {
                        damage /= 2;
                    }
                    else if (symbol.Groups[3].Value == "*")
                    {
                        damage *= 2;
                    }
                }

                demons[name] = new List<double>() { health, damage };
            }

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:F2} damage");
            }
        }
    }
}
