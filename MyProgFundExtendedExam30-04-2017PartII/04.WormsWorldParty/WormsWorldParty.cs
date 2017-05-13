using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.WormsWorldParty
{
    public class WormsWorldParty
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            HashSet<string> worms = new HashSet<string>();

            Dictionary<string, Dictionary<string, long>> teamsWormsScore = new Dictionary<string, Dictionary<string, long>>();

            while (inputLine != "quit")
            {
                string[] inputParams = inputLine.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                string wormName = inputParams[0].Trim();
                string teamName = inputParams[1].Trim();
                long wormScore = long.Parse(inputParams[2]);

                if (!worms.Contains(wormName))
                {
                    worms.Add(wormName);

                    if (!teamsWormsScore.ContainsKey(teamName))
                    {
                        teamsWormsScore[teamName] = new Dictionary<string, long>();
                    }

                    teamsWormsScore[teamName][wormName] = wormScore;
                }

                inputLine = Console.ReadLine();
            }

            teamsWormsScore = teamsWormsScore
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            int count = 1;

            foreach (var team in teamsWormsScore)
            {
                Console.WriteLine($"{count++}. Team: {team.Key} - {team.Value.Values.Sum()}");

                foreach (var worm in team.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
            }
        }
    }
}
