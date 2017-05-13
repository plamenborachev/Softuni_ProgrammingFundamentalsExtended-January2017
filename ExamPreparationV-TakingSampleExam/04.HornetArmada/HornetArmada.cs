using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.HornetArmada
{
    public class HornetArmada
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> legionsByActivity = new Dictionary<string, int>();

            Dictionary<string, Dictionary<string, long>> legionBySoldierTypeAndCount = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();

                string[] inputParams = inputLine.Split(new[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(inputParams[0]);
                string legionName = inputParams[1];
                string soldierType = inputParams[2];
                long soldierCount = long.Parse(inputParams[3]);

                if (!legionBySoldierTypeAndCount.ContainsKey(legionName))
                {
                    legionBySoldierTypeAndCount.Add(legionName, new Dictionary<string, long>());
                }
                if (!legionBySoldierTypeAndCount[legionName].ContainsKey(soldierType))
                {
                    legionBySoldierTypeAndCount[legionName].Add(soldierType, 0L);
                }

                legionBySoldierTypeAndCount[legionName][soldierType] += soldierCount;

                if (!legionsByActivity.ContainsKey(legionName))
                {
                    legionsByActivity.Add(legionName, lastActivity);
                }
                if (lastActivity > legionsByActivity[legionName])
                {
                    legionsByActivity[legionName] = lastActivity;
                }
            }

            string[] command = Console.ReadLine().Split('\\');

            if (command.Length > 1)
            {
                int activity = int.Parse(command[0]);
                string soldierType = command[1];

                foreach (var legion in legionBySoldierTypeAndCount
                    .Where(x => x.Value.ContainsKey(soldierType))
                    .OrderByDescending(x => x.Value[soldierType]))
                {
                    string legionName = legion.Key;
                    long soldierCount = legion.Value[soldierType];

                    if (legionsByActivity[legionName] < activity)
                    {
                        Console.WriteLine($"{legionName} -> {soldierCount}");
                    }
                }
            }
            else
            {
                string soldierType = command[0];

                foreach (var legion in legionsByActivity.OrderByDescending(x => x.Value))
                {
                    string legionName = legion.Key;
                    long lastActivity = legion.Value;

                    if (legionBySoldierTypeAndCount[legionName].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{lastActivity} : {legionName}");
                    }
                }
            }
        }
    }
}
