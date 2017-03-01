using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveElementsatOddPositions
{
    public class RemoveElementsatOddPositions
    {
        public static void Main()
        {
            List<string> text = Console.ReadLine().Split().ToList();

            List<string> result = new List<string>();

            for (int i = 1; i < text.Count; i += 2)
            {
                result.Add(text[i]);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
