using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FlipListSides
{
    public class FlipListSides
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            result.Add(numbers[0]);

            for (int i = numbers.Count - 2; i >= (numbers.Count + 1) / 2; i--)
            {
                result.Add(numbers[i]);
            }

            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count / 2]);
            }

            for (int i = numbers.Count / 2 - 1; i >= 1; i--)
            {
                result.Add(numbers[i]);
            }

            result.Add(numbers[numbers.Count - 1]);

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
