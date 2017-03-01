using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_sBack
{
    public class CamelsBack
    {
        public static void Main()
        {
            List<int> buildingsN = Console.ReadLine().Split().Select(int.Parse).ToList();

            int camelBackSizeM = int.Parse(Console.ReadLine());

            int rounds = (buildingsN.Count - camelBackSizeM) / 2;

            for (int i = 0; i < rounds; i++)
            {
                buildingsN.RemoveAt(0);
                buildingsN.RemoveAt(buildingsN.Count - 1);
            }

            if (rounds == 0)
            {
                Console.WriteLine($"already stable: {string.Join(" ", buildingsN)}");
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildingsN)}");
            }
        }
    }
}
