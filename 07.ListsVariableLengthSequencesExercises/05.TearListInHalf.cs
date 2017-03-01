using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TearListInHalf
{
    public class TearListInHalf
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> leftHalf = new List<int>();

            for (int i = 0; i < input.Count / 2; i++)
            {
                leftHalf.Add(input[i]);
            }

            List<int> rightHalf = new List<int>();

            for (int i = input.Count / 2; i < input.Count; i++)
            {
                rightHalf.Add(input[i]);
            }

            List<int> result = new List<int>();

            for (int i = 0; i < leftHalf.Count; i++)
            {
                result.Add(rightHalf[i] / 10);
                result.Add(leftHalf[i]);
                result.Add(rightHalf[i] % 10);
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
