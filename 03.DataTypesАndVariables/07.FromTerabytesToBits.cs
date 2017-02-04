using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FromTerabytesToBits
{
    class Program
    {
        static void Main(string[] args)
        {
            double terabytes = double.Parse(Console.ReadLine());
            double bits = terabytes * 8796093022208;

            Console.WriteLine(bits);
        }
    }
}
