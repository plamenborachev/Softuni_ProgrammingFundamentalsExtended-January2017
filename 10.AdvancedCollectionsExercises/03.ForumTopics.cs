using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ForumTopics
{
    public class ForumTopics
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, HashSet<string>> topicAndTags = new Dictionary<string, HashSet<string>>();

            while (input != "filter")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string topic = tokens[0];
                string[] tags = tokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (!topicAndTags.ContainsKey(topic))
                {
                    topicAndTags[topic] = new HashSet<string>();
                }

                for (int i = 0; i < tags.Length; i++)
                {
                    topicAndTags[topic].Add(tags[i]);
                }

                input = Console.ReadLine();
            }

            string[] sequenceOfTags = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var topic in topicAndTags.Keys)
            {
                bool topicContainsTag = true;

                for (int i = 0; i < sequenceOfTags.Length; i++)
                {
                    if (!topicAndTags[topic].Contains(sequenceOfTags[i]))
                    {
                        topicContainsTag = false;
                        break;
                    }
                }

                if (topicContainsTag)
                {
                    Console.WriteLine($"{topic} | #{string.Join(", #", topicAndTags[topic])}");
                }
            }
        }
    }
}
