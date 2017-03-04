using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayHistogram
{
    public class ArrayHistogram
    {
        public static void Main()
        {
            string[] str = Console.ReadLine().Split().ToArray();

            List<string> result = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                result.Add(str[i]);

                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        result.Add(str[j]);
                        str[j] = "";
                    }
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == "")
                {
                    result.RemoveAt(i);
                    i--;
                }
            }

            double counter = 1;

            List<double> count = new List<double>();
            List<double> percentage = new List<double>();

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = i + 1; j < result.Count; j++)
                {
                    if (result[i] == result[j])
                    {
                        result.RemoveAt(j);
                        j--;
                        counter++;
                    }
                }

                count.Add(counter);
                percentage.Add(counter / str.Length);
                counter = 1;
            }

            for (int i = 0; i < percentage.Count; i++)
            {
                while (i > 0 && percentage[i - 1] < percentage[i])
                {
                    double temp = percentage[i - 1];
                    percentage[i - 1] = percentage[i];
                    percentage[i] = temp;

                    double tempCounter = count[i - 1];
                    count[i - 1] = count[i];
                    count[i] = tempCounter;

                    string tempResult = result[i - 1];
                    result[i - 1] = result[i];
                    result[i] = tempResult;
                    i--;
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine($"{result[i]} -> {count[i]} times ({percentage[i] * 100:F2}%)");
            }

        }
    }
}
