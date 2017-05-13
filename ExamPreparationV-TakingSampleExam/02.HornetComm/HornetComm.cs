using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.HornetComm
{
    public class Message
    {
        public string Code { get; set; }

        public string MessageText { get; set; }
    }

    public class Broadcast
    {
        public string MessageBody { get; set; }

        public string Frequency { get; set; }
    }

    public class HornetComm
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            string messagePattern = @"^(\d+) <-> ([A-Za-z0-9]+)$";

            string broadcastPattern = @"^([^0-9]+) <-> ([A-Za-z0-9]+)$";

            Regex messageRegex = new Regex(messagePattern);

            Regex broadcastRegex = new Regex(broadcastPattern);

            List<Message> messages = new List<Message>();

            List<Broadcast> broadcasts = new List<Broadcast>();

            while (inputLine != "Hornet is Green")
            {
                Match messageMatch = messageRegex.Match(inputLine);

                Match broadcastMatch = broadcastRegex.Match(inputLine);

                if (messageMatch.Success)
                {
                    string recipientsCode = new string(messageMatch.Groups[1].Value.Reverse().ToArray());
                    string messageText = messageMatch.Groups[2].Value;

                    messages.Add(new Message
                    {
                        Code = recipientsCode,

                        MessageText = messageText
                    });

                }

                if (broadcastMatch.Success)
                {
                    string messageBody = broadcastMatch.Groups[1].Value;
                    string frequencyInput = broadcastMatch.Groups[2].Value;

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < frequencyInput.Length; i++)
                    {
                        if (65 <= frequencyInput[i] && frequencyInput[i] <= 90)
                        {
                            sb.Append(frequencyInput[i].ToString().ToLower());
                        }
                        else if (97 <= frequencyInput[i] && frequencyInput[i] <= 122)
                        {
                            sb.Append(frequencyInput[i].ToString().ToUpper());
                        }
                        else
                        {
                            sb.Append(frequencyInput[i]);
                        }
                    }

                    string frequency = sb.ToString();

                    broadcasts.Add(new Broadcast
                    {
                        MessageBody = messageBody,

                        Frequency = frequency
                    });
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");

            if (broadcasts.Any())
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine($"{broadcast.Frequency} -> {broadcast.MessageBody}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            if (messages.Any())
            {
                foreach (var message in messages)
                {
                    Console.WriteLine($"{message.Code} -> {message.MessageText}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
