using System;
using System.Linq;

namespace _02.CommandInterpreter
{
    public class CommandInterpreter
    {
        public static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandParams = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (commandParams[0] == "reverse" || commandParams[0] == "sort")
                {
                    int startIndex = int.Parse(commandParams[2]);
                    int count = int.Parse(commandParams[4]);

                    if ((0 <= startIndex && startIndex < inputLine.Length) && (0 <= count && (count + startIndex) <= inputLine.Length))
                    {
                        if (commandParams[0] == "reverse")
                        {
                            for (int i = 0; i < count / 2; i++)
                            {
                                string temp = inputLine[startIndex + i];
                                inputLine[startIndex + i] = inputLine[startIndex + count - 1 - i];
                                inputLine[startIndex + count - 1 - i] = temp;
                            }
                        }

                        else if (commandParams[0] == "sort")
                        {
                            string[] temp = new string[count];

                            for (int i = 0; i < count; i++)
                            {
                                temp[i] = inputLine[startIndex + i];
                            }

                            temp = temp.OrderBy(x => x).ToArray();

                            for (int i = 0; i < count; i++)
                            {
                                inputLine[startIndex + i] = temp[i];
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }

                else if (commandParams[0] == "rollLeft" || commandParams[0] == "rollRight")
                {
                    int count = int.Parse(commandParams[1]);

                    int rotations = count % inputLine.Length;

                    if (0 <= count)
                    {
                        if (commandParams[0] == "rollLeft")
                        {
                            for (int i = 0; i < rotations; i++)
                            {
                                string temp = inputLine[0];

                                for (int j = 0; j < inputLine.Length - 1; j++)
                                {
                                    inputLine[j] = inputLine[j + 1];
                                }

                                inputLine[inputLine.Length - 1] = temp;
                            }
                        }

                        else if (commandParams[0] == "rollRight")
                        {
                            for (int i = 0; i < rotations; i++)
                            {
                                string temp = inputLine[inputLine.Length - 1];

                                for (int j = inputLine.Length - 1; j > 0; j--)
                                {
                                    inputLine[j] = inputLine[j - 1];
                                }

                                inputLine[0] = temp;
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", inputLine)}]");
        }
    }
}
