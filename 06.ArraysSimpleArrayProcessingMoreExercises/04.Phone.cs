using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    public class Phone
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();

            string command = string.Empty;

            while (command != "done")
            {
                command = Console.ReadLine();

                string[] commands = command.Split();

                for (int i = 0; i < names.Length; i++)
                {
                    string phoneNumber = phoneNumbers[i];

                    if (commands[0] == "call")
                    {
                        if (commands[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"calling {names[i]}...");

                            OddOrEvenSumOfDigits(phoneNumber);
                        }
                        else if (commands[1] == names[i])
                        {
                            Console.WriteLine($"calling {phoneNumbers[i]}...");

                            OddOrEvenSumOfDigits(phoneNumber);
                        }
                    }
                    else if (commands[0] == "message")
                    {
                        if (commands[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");

                            OddOrEvenDifferenceOfTheDigits(phoneNumber);
                        }
                        else if (commands[1] == names[i])
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...");

                            OddOrEvenDifferenceOfTheDigits(phoneNumber);
                        }
                    }
                }
            }
        }

        public static void OddOrEvenDifferenceOfTheDigits(string phoneNumber)
        {
            int diffOfDigits = DifferenceOfTheDigits(phoneNumber);

            if (diffOfDigits % 2 != 0)
            {
                Console.WriteLine("busy");
            }
            else
            {
                Console.WriteLine("meet me there");
            }
        }

        public static int DifferenceOfTheDigits(string phoneNumber)
        {
            char[] ch = phoneNumber.ToCharArray();

            int[] digits = new int[ch.Length];

            for (int i = 0; i < ch.Length; i++)
            {
                if (48 <= ch[i] && ch[i] <= 57)
                {
                    digits[i] = ch[i] - 48;
                }
            }

            int diffOfDigits = digits[0];

            for (int i = 1; i < digits.Length; i++)
            {
                diffOfDigits -= digits[i];
            }

            return diffOfDigits;
        }

        public static void OddOrEvenSumOfDigits(string phoneNumber)
        {
            int sumOfDigits = SumOfDigits(phoneNumber);

            string minSec = string.Format("{0:00}:{1:00}", sumOfDigits / 60, sumOfDigits % 60);

            if (sumOfDigits % 2 != 0)
            {
                Console.WriteLine("no answer");
            }
            else
            {
                Console.WriteLine($"call ended. duration: {minSec}");
            }
        }

        public static int SumOfDigits(string phoneNumber)
        {
            char[] ch = phoneNumber.ToCharArray();

            int[] digits = new int[ch.Length];

            for (int i = 0; i < ch.Length; i++)
            {
                if (48 <= ch[i] && ch[i] <= 57)
                {
                    digits[i] = ch[i] - 48;
                }
            }

            int sumOfDigits = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sumOfDigits += digits[i];
            }

            return sumOfDigits;
        }
    }
}
