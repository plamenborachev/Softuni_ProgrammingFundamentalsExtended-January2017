using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IncreasingCrisis
{
    public class IncreasingCrisis
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (result.Count == 0)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        result.Add(numbers[j]);
                    }

                    RemoveBrokenElements(result);
                }

                else /*(result.Count > 0)*/
                {
                    for (int j = result.Count - 1; j >= 0; j--)
                    {
                        if (result[j] <= numbers[0])
                        {
                            if (j == result.Count - 1)
                            {
                                for (int k = 0; k < numbers.Length; k++)
                                {
                                    result.Add(numbers[k]);
                                }

                                RemoveBrokenElements(result);
                                break;
                            }
                            else /*(j != result.Count - 1)*/
                            {
                                for (int k = 0; k < numbers.Length; k++)
                                {
                                    if (result[j] <= numbers[k])
                                    {
                                        result.Insert(j + 1, numbers[k]);
                                        j++;

                                        if (numbers[k] > result[j + 1])
                                        {
                                            while (result.Count > j + 1)
                                            {
                                                result.RemoveAt(j + 1);
                                            }
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        while (result.Count > j + 1)
                                        {
                                            result.RemoveAt(j + 1);
                                        }
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static void RemoveBrokenElements(List<int> result)
        {
            for (int i = 0; i < result.Count - 1; i++)
            {
                if (result[i] > result[i + 1])
                {
                    while (result.Count > i + 1)
                    {
                        result.RemoveAt(i + 1);
                    }
                    break;
                }
            }
        }
    }
}
