using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FilterExtensions
{
    public class FilterExtensions
    {
        public static void Main()
        {
            string[] filenames = Directory.GetFiles("../../input");

            string inputExtension = Console.ReadLine();

            filenames = filenames
                .Select(x => x.Replace("../../input\\", ""))
                .ToArray();

            foreach (var file in filenames)
            {
                string[] fileParams = file.Split('.');

                string extension = fileParams[fileParams.Length - 1];

                if (extension == inputExtension)
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}
