using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05.Commits
{
    public class Commits
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            string pattern = @"https:\/\/github.com\/([A-Za-z0-9-]+)\/([A-Za-z-_]+)\/commit\/([a-f0-9]{40}),([^\n]+),([0-9]+),([0-9]+)";

            Regex regex = new Regex(pattern);

            SortedDictionary<string, SortedDictionary<string, List<Commit>>> usersRepos = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

            while (inputLine != "git push")
            {
                bool isMatch = regex.IsMatch(inputLine);

                if (isMatch)
                {
                    Match match = regex.Match(inputLine);

                    string user = match.Groups[1].Value;
                    string repo = match.Groups[2].Value;
                    string commitHash = match.Groups[3].Value;
                    string message = match.Groups[4].Value;
                    decimal additions = decimal.Parse(match.Groups[5].Value);
                    decimal deletions = decimal.Parse(match.Groups[6].Value);

                    if (!usersRepos.ContainsKey(user))
                    {
                        usersRepos[user] = new SortedDictionary<string, List<Commit>>();
                    }

                    if (!usersRepos[user].ContainsKey(repo))
                    {
                        usersRepos[user][repo] = new List<Commit>();
                    }

                    usersRepos[user][repo].Add(new Commit
                    {
                        CommitHash = commitHash,

                        Message = message,

                        Additions = additions,

                        Deletions = deletions
                    });
                }

                inputLine = Console.ReadLine();
            }

            foreach (var user in usersRepos)
            {
                Console.WriteLine($"{user.Key}:");

                decimal totalAdditionsCount = 0;
                decimal totalDeletionsCount = 0;

                foreach (var repo in user.Value)
                {
                    Console.WriteLine($"  {repo.Key}:");

                    foreach (var commit in repo.Value)
                    {
                        Console.WriteLine($"    commit {commit.CommitHash}: {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");

                        totalAdditionsCount += commit.Additions;
                        totalDeletionsCount += commit.Deletions;
                    }
                }

                Console.WriteLine($"    Total: {totalAdditionsCount} additions, {totalDeletionsCount} deletions");
            }
        }
    }
}
