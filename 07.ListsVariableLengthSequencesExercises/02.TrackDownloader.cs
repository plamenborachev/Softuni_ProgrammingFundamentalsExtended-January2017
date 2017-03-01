using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrackDownloader
{
    public class TrackDownloader
    {
        public static void Main()
        {
            List<string> blacklistedWords = Console.ReadLine().Split().ToList();

            List<string> filenames = new List<string>();

            string commandOrFilename = string.Empty;

            while (commandOrFilename != "end" && commandOrFilename != "End")
            {
                commandOrFilename = Console.ReadLine();

                if (commandOrFilename != "end" && commandOrFilename != "End")
                {
                    filenames.Add(commandOrFilename);
                }
            }

            for (int i = 0; i < filenames.Count; i++)
            {
                for (int a = 0; a < blacklistedWords.Count; a++)
                {
                    if (filenames[i].Contains(blacklistedWords[a]))
                    {
                        filenames.Remove(filenames[i]);
                        i--;
                        break;
                    }
                }
            }

            filenames.Sort();

            for (int i = 0; i < filenames.Count; i++)
            {
                Console.WriteLine(filenames[i]);
            }
        }
    }
}
