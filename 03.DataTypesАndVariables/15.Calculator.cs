using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char calculationType = char.Parse(Console.ReadLine()); 
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;

            switch (calculationType)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{num1} {calculationType} {num2} = {result}");
        }
    }
}
