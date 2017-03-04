using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShootListElements
{
    public class ShootListElements
    {
        public static void Main()
        {
            List<int> result = new List<int>();

            string command = string.Empty;

            int lastRemovedInt = 0;

            while (command != "stop")
            {
                command = Console.ReadLine();

                if (command != "bang" && command != "stop")
                {
                    result.Insert(0, int.Parse(command));
                }

                else if (command == "bang")
                {
                    if (result.Count > 1)
                    {
                        double resultSum = 0.0;

                        foreach (var number in result)
                        {
                            resultSum += number;
                        }

                        double average = resultSum / result.Count;

                        for (int i = 0; i < result.Count; i++)
                        {
                            if (result[i] < average)
                            {
                                Console.WriteLine($"shot {result[i]}");
                                result.RemoveAt(i);

                                for (int a = 0; a < result.Count; a++)
                                {
                                    result[a]--;
                                }

                                break;
                            }
                        }
                    }

                    else if (result.Count == 1)
                    {
                        Console.WriteLine($"shot {result[0]}");
                        lastRemovedInt = result[0];
                        result.RemoveAt(0);
                    }

                    else if (result.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemovedInt}");
                        break;
                    }
                }

                else if (command == "stop")
                {
                    if (result.Count > 0)
                    {
                        Console.WriteLine("survivors: {0}", string.Join(" ", result));
                    }
                    else
                    {
                        Console.WriteLine($"you shot them all. last one was {lastRemovedInt}");
                    }
                }
            }
        }
    }
}
