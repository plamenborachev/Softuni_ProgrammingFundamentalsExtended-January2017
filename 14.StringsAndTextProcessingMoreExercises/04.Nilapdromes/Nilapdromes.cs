using System;

namespace _04.Nilapdromes
{
    public class Nilapdromes
    {
        public static void Main()
        {
            string inputline = Console.ReadLine();

            string borders = string.Empty;

            string core = string.Empty;

            while (inputline != "end")
            {
                for (int i = (inputline.Length - 1) / 2 ; i > 0 ; i--)
                {
                    if (inputline.Substring(0, i) == inputline.Substring(inputline.Length - i, i))
                    {
                        borders = inputline.Substring(0, i);

                        core = inputline.Substring(i, inputline.Length - i * 2);

                        Console.WriteLine(core + borders + core);

                        break;
                    }
                }
                inputline = Console.ReadLine();
            }
        }
    }
}
