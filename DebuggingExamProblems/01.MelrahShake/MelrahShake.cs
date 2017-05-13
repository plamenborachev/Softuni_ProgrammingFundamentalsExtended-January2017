using System;

namespace _01.MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            string inputString = Console.ReadLine();
            string inputPattern = Console.ReadLine();

            int veryFirstMatchIndex = inputString.IndexOf(inputPattern);
            int veryLastMatchIndex = inputString.LastIndexOf(inputPattern);

            while (inputPattern.Length != 0 && veryFirstMatchIndex != -1 && veryLastMatchIndex != -1)
            {
                inputString = inputString.Remove(veryLastMatchIndex, inputPattern.Length);

                inputString = inputString.Remove(veryFirstMatchIndex, inputPattern.Length);

                inputPattern = inputPattern.Remove(inputPattern.Length / 2, 1);

                Console.WriteLine("Shaked it.");

                veryFirstMatchIndex = inputString.IndexOf(inputPattern);
                veryLastMatchIndex = inputString.LastIndexOf(inputPattern);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(inputString);
        }
    }
}
