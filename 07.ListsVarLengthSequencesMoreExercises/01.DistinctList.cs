using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DistinctList
{
    public class DistinctList
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int a = i + 1; a < numbers.Count; a++)
                {
                    if (numbers[i] == numbers[a])
                    {
                        numbers.RemoveAt(a);
                        a--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
