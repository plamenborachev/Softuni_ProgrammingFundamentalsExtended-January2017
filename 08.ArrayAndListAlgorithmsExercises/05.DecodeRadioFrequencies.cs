using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DecodeRadioFrequencies
{
    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            double[] frequencies = Console.ReadLine().Split().Select(double.Parse).ToArray();

            List<string> result = new List<string>();

            for (int i = 0; i < frequencies.Length; i++)
            {
                char leftPart = (char)(int)frequencies[i];
                result.Add(leftPart.ToString());


            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
