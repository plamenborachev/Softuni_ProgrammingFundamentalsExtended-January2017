using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ResizableArray
{
    public class ResizableArray
    {
        public static void Main()
        {
            int arraySize = 4;

            int?[] arr = new int?[arraySize];

            string result = string.Empty;

            string[] command = new string[2];

            while (command[0] != "end")
            {
                command = Console.ReadLine().Split();

                bool arrayFull = true;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == null)
                    {
                        arrayFull = false;
                        break;
                    }
                }

                if (command[0] == "push")
                {
                    if (arrayFull)
                    {
                        arraySize *= 2;

                        int?[] current = new int?[arr.Length];

                        for (int i = 0; i < arr.Length; i++)
                        {
                            current[i] = arr[i];
                        }

                        arr = new int?[arraySize];

                        for (int i = 0; i < current.Length; i++)
                        {
                            arr[i] = current[i];
                        }
                    }

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == null)
                        {
                            arr[i] = int.Parse(command[1]);
                            break;
                        }
                    }
                }

                else if (command[0] == "pop")
                {
                    for (int i = arr.Length - 1; i >= 0; i--)
                    {
                        if (arr[i] != null)
                        {
                            arr[i] = null;
                            break;
                        }
                    }

                    arr[arr.Length - 1] = null;
                }

                else if (command[0] == "removeAt")
                {
                    for (int i = int.Parse(command[1]); i < arr.Length; i++)
                    {
                        if (i < arr.Length - 1)
                        {
                            arr[i] = arr[i + 1];
                        }
                    }

                    arr[arr.Length - 1] = null;
                }

                else if (command[0] == "clear")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = null;
                    }
                }

            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    result += arr[i] + " ";
                }
            }

            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("empty array");
            }
        }
    }
}
