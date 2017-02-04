using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCIIString
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string final = null;
            for (int i = 0; i < N; i++)
            {
                byte asciiCode = byte.Parse(Console.ReadLine());
                char letter = (char)asciiCode;
                final = final + letter;
            }
            Console.WriteLine(final);
        }
    }
}
