using System;
using System.Text;

namespace _1.SerializeString
{
    public class SerializeString
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (var symbol in inputLine)
            {
                string result = string.Empty;

                if (!sb.ToString().Contains(symbol.ToString()))
                {
                    result = symbol + ":";

                    int index = inputLine.IndexOf(symbol);

                    while (index != -1)
                    {
                        result += ($"{index}/");

                        index = inputLine.IndexOf(symbol, index + 1);
                    }

                    result = result.TrimEnd('/');
                    sb.AppendLine(result);
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd('\n'));
        }
    }
}
