using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalFormat = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexadecimalFormat, 16));
        }
    }
}
