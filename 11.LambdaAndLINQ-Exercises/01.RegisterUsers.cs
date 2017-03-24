using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace _01.RegisterUsers
{
    public class RegisterUsers
    {
        public static void Main()
        {
            Dictionary<string, DateTime> registry = new Dictionary<string, DateTime>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string username = tokens[0];
                DateTime date = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!registry.ContainsKey(username))
                {
                    registry[username] = new DateTime();
                }

                registry[username] = date;

                input = Console.ReadLine();
            }

            registry = registry.Reverse().OrderBy(x => x.Value).Take(5).OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);


            foreach (var username in registry.Keys)
            {
                Console.WriteLine(username);
            }
        }
    }
}
