using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DataOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());

            string num1Type = null;
            
            if (byte.MinValue <= num1 && num1 <= byte.MaxValue)
            {
                num1Type = "byte";
            }
            else if (num1 <= ushort.MaxValue)
            {
                num1Type = "ushort";
            }
            else if (num1 <= uint.MaxValue)
            {
                num1Type = "uint";
            }
            else if (num1 <= ulong.MaxValue)
            {
                num1Type = "ulong";
            }

            string num2Type = null;

            if (byte.MinValue <= num2 && num2 <= byte.MaxValue)
            {
                num2Type = "byte";
            }
            else if (num2 <= ushort.MaxValue)
            {
                num2Type = "ushort";
            }
            else if (num2 <= uint.MaxValue)
            {
                num2Type = "uint";
            }
            else if (num2 <= ulong.MaxValue)
            {
                num2Type = "ulong";
            }

            if (num1 > num2)
            {
                Console.WriteLine($"bigger type: {num1Type}");
                Console.WriteLine($"smaller type: {num2Type}");

                double overflows = 0;

                if (num2Type == "byte")
                {
                    overflows = Math.Round(((double)num1 / byte.MaxValue), 0);
                }
                else if (num2Type == "ushort")
                {
                    overflows = Math.Round(((double)num1 / ushort.MaxValue), 0);
                }
                else if (num2Type == "uint")
                {
                    overflows = Math.Round(((double)num1 / uint.MaxValue), 0);
                }
                else if (num2Type == "ulong")
                {
                    overflows = Math.Round(((double)num1 / ulong.MaxValue), 0);
                }

                Console.WriteLine($"{num1} can overflow {num2Type} {overflows} times");
            }
            else
            {
                Console.WriteLine($"bigger type: {num2Type}");
                Console.WriteLine($"smaller type: {num1Type}");

                double overflows = 0;

                if (num1Type == "byte")
                {
                    overflows = Math.Round(((double)num2 / byte.MaxValue), 0);
                }
                else if (num1Type == "ushort")
                {
                    overflows = Math.Round(((double)num2 / ushort.MaxValue), 0);
                }
                else if (num1Type == "uint")
                {
                    overflows = Math.Round(((double)num2 / uint.MaxValue), 0);
                }
                else if (num1Type == "ulong")
                {
                    overflows = Math.Round(((double)num2 / ulong.MaxValue), 0);
                }

                Console.WriteLine($"{num2} can overflow {num1Type} {overflows} times");
            }

        }
    }
}
