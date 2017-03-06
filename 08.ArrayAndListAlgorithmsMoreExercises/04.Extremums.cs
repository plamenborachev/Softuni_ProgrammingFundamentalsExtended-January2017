using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Extremums
{
    public class Extremums
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split().ToArray();
            string command = Console.ReadLine();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                List<char> chars = numbers[i].ToList();

                List<int> digits = new List<int>();

                for (int j = 0; j < chars.Count; j++)
                {
                    digits.Add(chars[j] - 48);
                }

                if (command == "Min")
                {
                    int minNumber = int.Parse(numbers[i]);

                    minNumber = FindMinNumber(digits, minNumber);

                    result.Add(minNumber);
                }
                else if (command == "Max")
                {
                    int maxNumber = int.Parse(numbers[i]);

                    maxNumber = FindMaxNumber(digits, maxNumber);

                    result.Add(maxNumber);
                }
            }

            int sum = 0;

            foreach (var number in result)
            {
                sum += number;
            }

            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(sum);
        }

        private static int FindMaxNumber(List<int> digits, int maxNumber)
        {
            for (int k = 0; k < digits.Count - 1; k++)
            {
                int first = digits[0];
                digits.RemoveAt(0);
                digits.Add(first);

                string tempResult = string.Empty;

                for (int l = 0; l < digits.Count; l++)
                {
                    tempResult += digits[l];
                }

                if (int.Parse(tempResult) > maxNumber)
                {
                    maxNumber = int.Parse(tempResult);
                }
            }

            return maxNumber;
        }

        private static int FindMinNumber(List<int> digits, int minNumber)
        {
            for (int k = 0; k < digits.Count - 1; k++)
            {
                int first = digits[0];
                digits.RemoveAt(0);
                digits.Add(first);

                string tempResult = string.Empty;

                for (int l = 0; l < digits.Count; l++)
                {
                    tempResult += digits[l];
                }

                if (int.Parse(tempResult) < minNumber)
                {
                    minNumber = int.Parse(tempResult);
                }
            }

            return minNumber;
        }
    }
}
