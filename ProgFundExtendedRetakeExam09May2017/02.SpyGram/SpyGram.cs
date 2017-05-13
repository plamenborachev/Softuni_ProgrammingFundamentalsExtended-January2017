using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.SpyGram
{
    public class SpyGram
    {
        public static void Main()
        {
            string privateKey = Console.ReadLine();
            string message = Console.ReadLine();

            string pattern = @"^TO: ([A-Z]+); MESSAGE: (.+);$";
            Regex regex = new Regex(pattern);

            Dictionary<string, List<string>> messagesByRecipient = new Dictionary<string, List<string>>();

            while (message != "END")
            {
                Match match = regex.Match(message);

                if (match.Success)
                {
                    string recipient = match.Groups[1].Value;

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < message.Length; i++)
                    {
                        int privateKeyCurrentCharacterValue = int.Parse(privateKey[i % privateKey.Length].ToString());
                        sb.Append((char)(message[i] + privateKeyCurrentCharacterValue));
                    }

                    string encryptedMessage = sb.ToString();

                    if (!messagesByRecipient.ContainsKey(recipient))
                    {
                        messagesByRecipient[recipient] = new List<string>();
                    }

                    messagesByRecipient[recipient].Add(encryptedMessage);
                }

                message = Console.ReadLine();
            }

            foreach (var recipient in messagesByRecipient.OrderBy(x => x.Key))
            {
                foreach (var item in recipient.Value)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
