using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FootballLeague
{
    public class FootballLeague
    {
        public static void Main()
        {
            string key = Console.ReadLine();

            string inputLine = Console.ReadLine();

            Dictionary<string, List<long>> standingsTable = new Dictionary<string, List<long>>();

            while (inputLine != "final")
            {
                string[] inputParams = inputLine.Split();

                string encryptedTeamA = inputParams[0];
                string encryptedTeamB = inputParams[1];
                int[] score = inputParams[2].Split(':').Select(int.Parse).ToArray();

                string teamA = ExtractTeamName(key, encryptedTeamA);
                string teamB = ExtractTeamName(key, encryptedTeamB);

                long scoreTeamA = score[0];
                long scoreTeamB = score[1];

                long pointsTeamA, pointsTeamB;
                CalculatePointsFromMatch(scoreTeamA, scoreTeamB, out pointsTeamA, out pointsTeamB);

                AddFootballMatchToStandingsTable(standingsTable, teamA, scoreTeamA, pointsTeamA);
                AddFootballMatchToStandingsTable(standingsTable, teamB, scoreTeamB, pointsTeamB);

                inputLine = Console.ReadLine();
            }

            standingsTable = standingsTable
                .OrderByDescending(x => x.Value[0])
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("League standings:");
            int count = 1;

            foreach (var team in standingsTable)
            {
                Console.WriteLine($"{count++}. {team.Key} {team.Value[0]}");
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var team in standingsTable
                .OrderByDescending(x => x.Value[1])
                .ThenBy(x => x.Key)
                .Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value[1]}");
            }
        }

        private static string ExtractTeamName(string key, string encryptedTeam)
        {
            int startIndexOfTeam = encryptedTeam.IndexOf(key) + key.Length;

            int teamNameLength = encryptedTeam.LastIndexOf(key) - startIndexOfTeam;

            return new string(encryptedTeam.Substring(startIndexOfTeam, teamNameLength).ToUpper().Reverse().ToArray());
        }

        private static void CalculatePointsFromMatch(long scoreTeamA, long scoreTeamB, out long pointsTeamA, out long pointsTeamB)
        {
            pointsTeamA = 0;
            pointsTeamB = 0;

            if (scoreTeamA > scoreTeamB)
            {
                pointsTeamA = 3;
            }
            else if (scoreTeamA == scoreTeamB)
            {
                pointsTeamA = 1;
                pointsTeamB = 1;
            }
            else
            {
                pointsTeamB = 3;
            }
        }

        private static void AddFootballMatchToStandingsTable(Dictionary<string, List<long>> standingsTable, string team, long scoreTeam, long pointsTeam)
        {
            if (!standingsTable.ContainsKey(team))
            {
                standingsTable[team] = new List<long> { 0, 0 };
            }

            standingsTable[team][0] += pointsTeam;
            standingsTable[team][1] += scoreTeam;
        }
    }
}
