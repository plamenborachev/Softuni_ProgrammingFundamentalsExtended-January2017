using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.UserDatabase
{
    public class UserDatabase
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, User> registerList = new Dictionary<string, User>();

            while (inputLine != "exit")
            {
                string[] inputParams = inputLine.Split(' ');

                string command = inputParams[0];

                if (command == "register")
                {
                    string username = inputParams[1];

                    string password = inputParams[2];

                    string confirmPassword = inputParams[3];

                    if (password == confirmPassword)
                    {
                        if (!registerList.ContainsKey(username))
                        {
                            registerList[username] = new User
                            {
                                Username = username,

                                Password = password,

                                LoggedIn = false
                            };
                        }

                        else
                        {
                            Console.WriteLine("The given username already exists.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The two passwords must match.");
                    }
                }
                else if (command == "login")
                {
                    string username = inputParams[1];

                    string password = inputParams[2];

                    if (!registerList.ContainsKey(username))
                    {
                        Console.WriteLine("There is no user with the given username.");
                    }
                    else if (registerList[username].LoggedIn)
                    {
                        Console.WriteLine("There is already a logged in user.");
                    }
                    else if (registerList[username].Password != password)
                    {
                        Console.WriteLine("The password you entered is incorrect.");
                    }
                    else
                    {
                        registerList[username].LoggedIn = true;
                    }
                }
                else if (command == "logout")
                {
                    bool noLoggedInUser = true;

                    foreach (var user in registerList)
                    {
                        if (user.Value.LoggedIn)
                        {
                            user.Value.LoggedIn = false;
                            noLoggedInUser = false;
                        }
                    }

                    if (noLoggedInUser)
                    {
                        Console.WriteLine("There is no currently logged in user.");
                    }
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
