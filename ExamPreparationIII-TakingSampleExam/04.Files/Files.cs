using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Files
{
    public class File
    {
        public string Root { get; set; }

        public string Name { get; set; }

        public ulong Size { get; set; }
    }

    public class Files
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<File> files = new List<File>();

            for (int i = 0; i < n; i++)
            {
                string[] file = Console.ReadLine().Split(new[] { '\\', ';' }, StringSplitOptions.None);

                string root = file[0];
                string fileNameAndExtension = file[file.Length - 2];
                ulong size = ulong.Parse(file[file.Length - 1]);

                File currentFile = new File
                {
                    Root = root,
                    Name = fileNameAndExtension,
                    Size = size
                };

                bool fileExists = false;

                for (int j = 0; j < files.Count; j++)
                {
                    if (files[j].Root == root && files[j].Name == currentFile.Name)
                    {
                        files[j].Size = size;
                        fileExists = true;
                        break;
                    }
                }

                if (fileExists == false)
                {
                    files.Add(currentFile);
                }
            }

            string[] query = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string extensionQuery = query[0];
            string rootQuery = query[2];

            files = files
                .Where(x => x.Root == rootQuery)
                .Where(x => x.Name.Contains($".{extensionQuery}"))
                .OrderByDescending(x => x.Size)
                .ThenBy(x => x.Name)
                .ToList();

            if (files.Any())
            {
                foreach (var item in files)
                {
                    Console.WriteLine($"{item.Name} - {item.Size} KB");
                }
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
