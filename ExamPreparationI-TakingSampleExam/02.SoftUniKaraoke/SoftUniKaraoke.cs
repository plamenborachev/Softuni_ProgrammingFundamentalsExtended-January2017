using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniKaraoke
{
    public class SoftUniKaraoke
    {
        public static void Main()
        {
            string[] participants = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, SortedSet<string>> participantsAwards = new Dictionary<string, SortedSet<string>>();

            for (int i = 0; i < participants.Length; i++)
            {
                if (!participantsAwards.ContainsKey(participants[i]))
                {
                    participantsAwards.Add(participants[i], new SortedSet<string>());
                }
            }

            string stagePerformance = Console.ReadLine();

            while (stagePerformance != "dawn")
            {
                string[] inputParams = stagePerformance.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                string participant = inputParams[0];

                string song = inputParams[1];

                string award = inputParams[2];

                if (participantsAwards.ContainsKey(participant) && songs.Contains(song))
                {
                    participantsAwards[participant].Add(award);
                }

                stagePerformance = Console.ReadLine();
            }

            participantsAwards = participantsAwards
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            bool noAwards = true;

            foreach (var participant in participantsAwards)
            {
                if (participant.Value.Any())
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");

                    foreach (var award in participant.Value)
                    {
                        Console.WriteLine($"--{award}");
                    }

                    noAwards = false;
                }
            }

            if (noAwards)
            {
                Console.WriteLine("No awards");
            }
        }

    }
}
