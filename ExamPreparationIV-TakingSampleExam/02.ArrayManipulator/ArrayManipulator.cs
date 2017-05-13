using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandParams = command.Split();

                if (commandParams[0] == "exchange")
                {
                    int splitIndex = int.Parse(commandParams[1]);

                    if (0 <= splitIndex && splitIndex < numbers.Count)
                    {
                        for (int i = 0; i <= splitIndex; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                else if (commandParams[0] == "max")
                {
                    int indexOfMaxElement = -1;

                    if (commandParams[1] == "even" && numbers.Where(x => x % 2 == 0).Any())
                    {
                        int maxEven = numbers.Where(x => x % 2 == 0).Max();

                        indexOfMaxElement = numbers.LastIndexOf(maxEven);
                    }
                    else if (commandParams[1] == "odd" && numbers.Where(x => x % 2 != 0).Any())
                    {
                        int maxOdd = numbers.Where(x => x % 2 != 0).Max();

                        indexOfMaxElement = numbers.LastIndexOf(maxOdd);
                    }

                    if (indexOfMaxElement != -1)
                    {
                        Console.WriteLine(indexOfMaxElement);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }

                else if (commandParams[0] == "min")
                {
                    int indexOfMinElement = -1;

                    if (commandParams[1] == "even" && numbers.Where(x => x % 2 == 0).Any())
                    {
                        int minEven = numbers.Where(x => x % 2 == 0).Min();

                        indexOfMinElement = numbers.LastIndexOf(minEven);
                    }
                    else if (commandParams[1] == "odd" && numbers.Where(x => x % 2 != 0).Any())
                    {
                        int minOdd = numbers.Where(x => x % 2 != 0).Min();

                        indexOfMinElement = numbers.LastIndexOf(minOdd);
                    }

                    if (indexOfMinElement != -1)
                    {
                        Console.WriteLine(indexOfMinElement);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                }

                else if (commandParams[0] == "first")
                {
                    int count = int.Parse(commandParams[1]);

                    if (count > numbers.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        List<int> firstElements = new List<int>();

                        if (commandParams[2] == "even" && numbers.Where(x => x % 2 == 0).Any())
                        {
                            firstElements = numbers.Where(x => x % 2 == 0).Take(count).ToList();
                        }
                        else if (commandParams[2] == "odd" && numbers.Where(x => x % 2 != 0).Any())
                        {
                            firstElements = numbers.Where(x => x % 2 != 0).Take(count).ToList();
                        }

                        Console.WriteLine($"[{string.Join(", ", firstElements)}]");
                    }
                }

                else if (commandParams[0] == "last")
                {
                    int count = int.Parse(commandParams[1]);

                    if (count > numbers.Count)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        List<int> firstElements = new List<int>();

                        if (commandParams[2] == "even" && numbers.Where(x => x % 2 == 0).Any())
                        {
                            firstElements = numbers.Where(x => x % 2 == 0).Reverse().Take(count).Reverse().ToList();
                        }
                        else if (commandParams[2] == "odd" && numbers.Where(x => x % 2 != 0).Any())
                        {
                            firstElements = numbers.Where(x => x % 2 != 0).Reverse().Take(count).Reverse().ToList();
                        }

                        Console.WriteLine($"[{string.Join(", ", firstElements)}]");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
