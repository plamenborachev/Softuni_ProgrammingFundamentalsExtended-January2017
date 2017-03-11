using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.UserLogins
{
    public class UserLogins
    {
        public static void Main()
        {
            Dictionary<string, string> usersLoginDetails = new Dictionary<string, string>();

            string command = Console.ReadLine();

            int countOfUnsuccessfulLoginAttempts = 0;

            while (command != "login")
            {
                string[] currentCommand = command.Split();

                usersLoginDetails[currentCommand[0]] = currentCommand[2];

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "end")
            {
                string[] currentCommand = command.Split();

                string password;

                if (usersLoginDetails.TryGetValue(currentCommand[0], out password))
                {
                    if (usersLoginDetails[currentCommand[0]] == currentCommand[2])
                    {
                        Console.WriteLine($"{currentCommand[0]}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{currentCommand[0]}: login failed");
                        countOfUnsuccessfulLoginAttempts++;
                    }
                }
                else
                {
                    Console.WriteLine($"{currentCommand[0]}: login failed");
                    countOfUnsuccessfulLoginAttempts++;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {countOfUnsuccessfulLoginAttempts}");
        }
    }
}
