using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StuckZipper
{
    public class StuckZipper
    {
        public static void Main()
        {
            List<int> firstInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            int minDigits = 7;

            foreach (var number in firstInput)
            {
                if (Length(number) < minDigits)
                {
                    minDigits = Length(number);
                }
            }

            foreach (var number in secondInput)
            {
                if (Length(number) < minDigits)
                {
                    minDigits = Length(number);
                }
            }

            for (int i = 0; i < firstInput.Count; i++)
            {
                if (Length(firstInput[i]) > minDigits)
                {
                    firstInput.Remove(firstInput[i]);
                    i--;
                }
            }

            for (int i = 0; i < secondInput.Count; i++)
            {
                if (Length(secondInput[i]) > minDigits)
                {
                    secondInput.Remove(secondInput[i]);
                    i--;
                }
            }

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(firstInput.Count, secondInput.Count); i++)
            {
                result.Add(secondInput[i]);
                result.Add(firstInput[i]);
            }

            if (firstInput.Count > secondInput.Count)
            {
                for (int i = secondInput.Count; i < firstInput.Count; i++)
                {
                    result.Add(firstInput[i]);
                }
            }

            else if (firstInput.Count < secondInput.Count)
            {
                for (int i = firstInput.Count; i < secondInput.Count; i++)
                {
                    result.Add(secondInput[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        public static int Length(int number)
        {
            number = Math.Abs(number);

            int length = 1;

            while ((number /= 10) >= 1)
            {
                length++;
            }
                
            return length;
        }
    }
}
