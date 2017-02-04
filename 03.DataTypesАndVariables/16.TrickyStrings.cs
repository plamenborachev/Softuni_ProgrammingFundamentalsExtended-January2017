using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.TrickyStrings
{
    class Program
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());

            string result = null;

            for (int i = 1; i <= N; i++)
            {
                string custom = Console.ReadLine();

                if (i < N)
                {
                    result += custom + delimiter;
                }
                else
                {
                    result += custom;
                }
            }
            Console.WriteLine(result);
        }
    }
}
