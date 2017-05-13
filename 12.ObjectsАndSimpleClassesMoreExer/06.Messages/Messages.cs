using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Messages
{
    public class Messages
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            List<User> users = new List<User>();

            while (inputLine != "exit")
            {
                string[] inputParams = inputLine.Split(' ');

                if (inputParams.Length == 2)
                {
                    User newUser = new User()
                    {
                        Username = inputParams[1],

                        ReceivedMessages = new List<Message>()
                    };

                    if (!users.Contains(newUser))
                    {
                        users.Add(newUser);
                    }
                }

                else
                {
                    string senderUsername = inputParams[0];

                    string recipientUsername = inputParams[2];

                    string messageContent = inputParams[3];

                    bool senderExists = false;

                    foreach (var user in users)
                    {
                        if (user.Username == senderUsername)
                        {
                            senderExists = true;
                            break;
                        }
                    }

                    foreach (var user in users)
                    {
                        if (user.Username == recipientUsername && senderExists)
                        {
                            user.ReceivedMessages.Add(new Message()
                            {
                                Content = messageContent,

                                Sender = new User
                                {
                                    Username = senderUsername
                                }
                            });

                            break;
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            string[] usernames = Console.ReadLine().Split();

            string firstName = usernames[0];

            string secondName = usernames[1];

            User firstUser = new User();

            User secondUser = new User();

            foreach (var user in users)
            {
                if (user.Username == firstName)
                {
                    firstUser = user;
                }
                if (user.Username == secondName)
                {
                    secondUser = user;
                }
            }

            firstUser.ReceivedMessages = firstUser.ReceivedMessages.Where(x => x.Sender.Username == secondName).ToList();

            secondUser.ReceivedMessages = secondUser.ReceivedMessages.Where(x => x.Sender.Username == firstName).ToList();

            if (firstUser.ReceivedMessages.Count == 0 && secondUser.ReceivedMessages.Count == 0)
            {
                Console.WriteLine("No messages");
            }
            else
            {

                for (int i = 0; i < Math.Max(firstUser.ReceivedMessages.Count, secondUser.ReceivedMessages.Count); i++)
                {
                    if (i < secondUser.ReceivedMessages.Count)
                    {
                        Console.WriteLine($"{firstUser.Username}: {secondUser.ReceivedMessages[i].Content}");
                    }
                    if (i < firstUser.ReceivedMessages.Count)
                    {
                        Console.WriteLine($"{firstUser.ReceivedMessages[i].Content} :{secondUser.Username}");
                    }
                }
            }
        }
    }
}
