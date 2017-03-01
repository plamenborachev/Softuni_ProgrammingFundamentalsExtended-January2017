using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnunionLists
{
    public class UnunionLists
    {
        public static void Main()
        {
            List<int> primalList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                List<int> currentSequence = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int a = 0; a < currentSequence.Count; a++)
                {
                    bool primalListDoesNotContain = true;

                    for (int b = 0; b < primalList.Count; b++)
                    {
                        if (currentSequence[a] == primalList[b])
                        {
                            primalListDoesNotContain = false;
                            break;
                        }
                    }

                    if (primalListDoesNotContain)
                    {
                        primalList.Add(currentSequence[a]);
                        currentSequence.RemoveAt(a);
                        a--;
                    }
                }

                for (int a = 0; a < currentSequence.Count; a++)
                {
                    for (int b = 0; b < primalList.Count; b++)
                    {
                        if (currentSequence[a] == primalList[b])
                        {
                            primalList.RemoveAt(b);
                            b--;
                        }
                    }
                }
            }

            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
