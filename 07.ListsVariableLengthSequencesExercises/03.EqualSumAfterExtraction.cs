using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EqualSumAfterExtraction
{
    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < secondList.Count; i++)
            {
                for (int y = 0; y < firstList.Count; y++)
                {
                    if (secondList[i] == firstList[y])
                    {
                        secondList.Remove(secondList[i]);
                        i--;
                        break;
                    }
                }
            }

            int sumFirtsList = 0;

            foreach (var num in firstList)
            {
                sumFirtsList += num;
            }

            int sumSecondList = 0;

            foreach (var num in secondList)
            {
                sumSecondList += num;
            }

            if (sumFirtsList == sumSecondList)
            {
                Console.WriteLine($"Yes. Sum: {sumFirtsList}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumFirtsList - sumSecondList)}");
            }
        }
    }
}
