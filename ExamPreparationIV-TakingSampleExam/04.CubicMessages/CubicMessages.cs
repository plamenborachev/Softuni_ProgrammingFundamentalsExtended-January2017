using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.CubicMessages
{
    public class CubicMessages
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            string pattern = @"^(\d+)([A-Za-z]+)([^A-Za-z]*)$";

            Regex regex = new Regex(pattern);

            while (inputLine != "Over!")
            {
                int messageLength = int.Parse(Console.ReadLine());

                Match match = regex.Match(inputLine);

                if (match.Success)
                {
                    string numberBefore = match.Groups[1].Value;
                    string message = match.Groups[2].Value;
                    string stringAfter = match.Groups[3].Value;

                    if (message.Length == messageLength)
                    {
                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < numberBefore.Length; i++)
                        {
                            int currentDigit = int.Parse(numberBefore[i].ToString());

                            if (0 <= currentDigit && currentDigit < message.Length)
                            {
                                sb.Append(message[currentDigit]);
                            }
                            else
                            {
                                sb.Append(" ");
                            }
                        }

                        for (int i = 0; i < stringAfter.Length; i++)
                        {
                            int parsedIndex = 0;

                            if (int.TryParse(stringAfter[i].ToString(), out parsedIndex))
                            {
                                if (0 <= parsedIndex && parsedIndex < message.Length)
                                {
                                    sb.Append(message[parsedIndex]);
                                }
                                else
                                {
                                    sb.Append(" ");
                                }
                            }
                        }

                        if (sb.Length > 0)
                        {
                            string verificationCode = sb.ToString();

                            Console.WriteLine($"{message} == {verificationCode}");
                        }
                        else
                        {
                            Console.WriteLine(message);
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
