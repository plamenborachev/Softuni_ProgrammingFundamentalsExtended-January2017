using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortArrayOfStrings
{
    public class SortArrayOfStrings
    {
        public static void Main()
        {
            string[] str = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < str.Length; i++)
            {
                while (i > 0 && str[i - 1].CompareTo(str[i]) > 0)
                {
                    string temp = str[i - 1];
                    str[i - 1] = str[i];
                    str[i] = temp;
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ", str));
        }
    }
}
