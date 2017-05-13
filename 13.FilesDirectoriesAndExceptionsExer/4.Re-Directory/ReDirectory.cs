using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Re_Directory
{
    public class ReDirectory
    {
        public static void Main()
        {
            string[] filesInDirectory = Directory.GetFiles("../../input");

            HashSet<string> fileExtensions = new HashSet<string>();

            filesInDirectory = filesInDirectory
                .Select(x => x.Replace("../../input\\", ""))
                .ToArray();

            foreach (var file in filesInDirectory)
            {
                string[] fileParts = file.Split('.').Reverse().ToArray();

                string fileExtension = fileParts[0];

                fileExtensions.Add(fileExtension);
            }

            foreach (var extension in fileExtensions)
            {
                string subDirectoryName = $"{extension}s";

                Directory.CreateDirectory($"../../output/{subDirectoryName}");

                foreach (var file in filesInDirectory)
                {
                    string[] fileParts = file.Split('.').Reverse().ToArray();

                    string fileExtension = fileParts[0];

                    if (fileExtension == extension)
                    {
                        File.Move($"../../input/{file}", $"../../output/{subDirectoryName}/{file}");
                    }
                }
            }
        }
    }
}
