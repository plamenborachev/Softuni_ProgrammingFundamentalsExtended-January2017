using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HTMLContents
{
    public class HTMLContents
    {
        public static void Main()
        {
            string[] inputLines = File.ReadAllLines("../../input.txt");

            string title = string.Empty;

            List<string> body = new List<string>();

            for (int i = 0; i < inputLines.Length - 1; i++)
            {
                string[] inputParams = inputLines[i].Split(' ');

                string tag = inputParams[0];
                string content = inputParams[1];

                if (tag == "title")
                {
                    title = $"\t<{tag}>{content}</{tag}>";
                }

                else
                {
                    body.Add($"\t<{tag}>{content}</{tag}>");
                }
            }

            File.AppendAllText("../../index.html", "<!DOCTYPE html>");
            File.AppendAllText("../../index.html", "<html>");
            File.AppendAllText("../../index.html", "<head>");

            if (title != string.Empty)
            {
                File.AppendAllText("../../index.html", title);
            }

            File.AppendAllText("../../index.html", "</head>");
            File.AppendAllText("../../index.html", "<body>");

            if (body.Any())
            {
                File.AppendAllText("../../index.html", string.Join(Environment.NewLine, body));
            }
            
            File.AppendAllText("../../index.html", "</body>");
            File.AppendAllText("../../index.html", "</html>");
        }
    }
}
