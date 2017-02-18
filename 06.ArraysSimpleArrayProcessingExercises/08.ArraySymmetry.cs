using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ArraySymmetry
{
    public class ArraySymmetry
    {
        public static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            string[] reversed = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - i - 1];
            }

            bool symmetric = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != reversed[i])
                {
                    symmetric = false;
                }
            }
            if (symmetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
