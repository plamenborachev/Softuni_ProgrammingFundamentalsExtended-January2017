using System;

namespace _02.Stateless
{
    public class Stateless
    {
        public static void Main()
        {
            string state = Console.ReadLine();
            string fiction = Console.ReadLine();

            while (state != "collapse")
            {
                while (fiction.Length > 0)
                {
                    int index = state.IndexOf(fiction);

                    while (index != -1 && fiction.Length <= state.Length)
                    {
                        state = state.Remove(index, fiction.Length);

                        index = state.IndexOf(fiction);
                    }

                    fiction = fiction.Remove(0, 1);

                    if (fiction.Length > 0)
                    {
                        fiction = fiction.Remove(fiction.Length - 1, 1);
                    }
                }

                state = state.Trim();

                if (state == string.Empty)
                {
                    Console.WriteLine("(void)");
                }

                else
                {
                    Console.WriteLine(state.Trim());
                }

                state = Console.ReadLine();
                fiction = Console.ReadLine();
            }
        }
    }
}
