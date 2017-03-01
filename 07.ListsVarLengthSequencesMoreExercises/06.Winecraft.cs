using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Winecraft
{
    public class Winecraft
    {
        public static void Main()
        {
            List<int> grapes = Console.ReadLine().Split().Select(int.Parse).ToList();

            int growthDays = int.Parse(Console.ReadLine());

            while (grapes.Count >= growthDays)
            {
                for (int day = 1; day <= growthDays; day++)
                {
                    for (int i = 1; i < grapes.Count - 1; i++)
                    {
                        if (grapes[i - 1] < grapes[i])
                        {
                            if (grapes[i] > grapes[i + 1])
                            {
                                if (grapes[i - 1] > 0)
                                {
                                    grapes[i - 1]--;
                                    grapes[i] ++;
                                }

                                if (grapes[i + 1] > 0)
                                {
                                    grapes[i]++;
                                    grapes[i + 1]--;
                                }

                                if (i + 2 == grapes.Count - 1)
                                {
                                    grapes[i + 2]++;
                                }

                                i++;
                            }
                            else if (grapes[i] == grapes[i + 1])
                            {
                                grapes[i - 1]++;
                                grapes[i]++;
                            }
                            else /*grapes[i] < grapes[i + 1]*/
                            {
                                grapes[i - 1]++;
                            }
                        }

                        else /*(grapes[i - 1] >= grapes[i])*/
                        {
                            grapes[i - 1]++;

                            if (grapes[i] >= grapes[i + 1])
                            {
                                grapes[i]++;
                            }
                        }
                    }

                }

                for (int i = 0; i < grapes.Count; i++)
                {
                    if (grapes[i] <= growthDays)
                    {
                        grapes.RemoveAt(i);
                        i--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", grapes));
        }
    }
}
