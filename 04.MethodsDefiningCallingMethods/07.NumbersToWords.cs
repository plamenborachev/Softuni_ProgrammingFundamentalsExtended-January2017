using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NumbersToWords
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());


                Console.WriteLine(Letterize(number));
            }
        }

        private static string Letterize(int number)
        {
            string result = string.Empty;

            if ((-999 <= number && number <= -100) || (100 <= number && number <= 999))
            {
                if (-999 <= number && number <= -100)
                {
                    result = "minus " + result;
                }
                number = Math.Abs(number);
                int firstdigit = number / 100;
                int seconddigit = (number / 10) % 10;
                int thirddigit = number % 10;

                if (firstdigit == 1)
                {
                    result += "one-hundred";
                }
                else if (firstdigit == 2)
                {
                    result += "two-hundred";
                }
                else if (firstdigit == 3)
                {
                    result += "three-hundred";
                }
                else if (firstdigit == 4)
                {
                    result += "four-hundred";
                }
                else if (firstdigit == 5)
                {
                    result += "five-hundred";
                }
                else if (firstdigit == 6)
                {
                    result += "six-hundred";
                }
                else if (firstdigit == 7)
                {
                    result += "seven-hundred";
                }
                else if (firstdigit == 8)
                {
                    result += "eight-hundred";
                }
                else if (firstdigit == 9)
                {
                    result += "nine-hundred";
                }

                if (seconddigit == 2)
                {
                    result += " and twenty";
                }
                if (seconddigit == 3)
                {
                    result += " and thirty";
                }
                if (seconddigit == 4)
                {
                    result += " and fourty";
                }
                if (seconddigit == 5)
                {
                    result += " and fifty";
                }
                if (seconddigit == 6)
                {
                    result += " and sixty";
                }
                if (seconddigit == 7)
                {
                    result += " and seventy";
                }
                if (seconddigit == 8)
                {
                    result += " and eighty";
                }
                if (seconddigit == 9)
                {
                    result += " and ninety";
                }

                if (seconddigit == 1 && thirddigit == 9)
                {
                    result += " and nineteen";
                }
                if (seconddigit == 1 && thirddigit == 8)
                {
                    result += " and eighteen";
                }
                if (seconddigit == 1 && thirddigit == 7)
                {
                    result += " and seventeen";
                }
                if (seconddigit == 1 && thirddigit == 6)
                {
                    result += " and sixteen";
                }
                if (seconddigit == 1 && thirddigit == 5)
                {
                    result += " and fifteen";
                }
                if (seconddigit == 1 && thirddigit == 4)
                {
                    result += " and fourteen";
                }
                if (seconddigit == 1 && thirddigit == 3)
                {
                    result += " and thirteen";
                }
                if (seconddigit == 1 && thirddigit == 2)
                {
                    result += " and twelve";
                }
                if (seconddigit == 1 && thirddigit == 1)
                {
                    result += " and eleven";
                }
                if (seconddigit == 1 && thirddigit == 0)
                {
                    result += " and ten";
                }

                if (seconddigit == 0 && thirddigit != 0)
                {
                    result += " and";
                }
                if (thirddigit == 9 && seconddigit != 1)
                {
                    result += " nine";
                }
                if (thirddigit == 8 && seconddigit != 1)
                {
                    result += " eight";
                }
                if (thirddigit == 7 && seconddigit != 1)
                {
                    result += " seven";
                }
                if (thirddigit == 6 && seconddigit != 1)
                {
                    result += " six";
                }
                if (thirddigit == 5 && seconddigit != 1)
                {
                    result += " five";
                }
                if (thirddigit == 4 && seconddigit != 1)
                {
                    result += " four";
                }
                if (thirddigit == 3 && seconddigit != 1)
                {
                    result += " three";
                }
                if (thirddigit == 2 && seconddigit != 1)
                {
                    result += " two";
                }
                if (thirddigit == 1 && seconddigit != 1)
                {
                    result += " one";
                }
            }

            else if (number > 999)
            {
                result = "too large";
            }
            else if (number < -999)
            {
                result = "too small";
            }

            return result;
        }
    }
}
