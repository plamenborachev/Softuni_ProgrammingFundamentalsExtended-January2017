using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SocialMediaPosts
{
    public class SocialMediaPosts
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            Dictionary<string, int> postLikes = new Dictionary<string, int>();

            Dictionary<string, int> postDislikes = new Dictionary<string, int>();

            Dictionary<string, Dictionary<string, List<string>>> postComments = new Dictionary<string, Dictionary<string, List<string>>>();

            while (command != "drop the media")
            {
                string[] tokens = command.Split();

                string firstPart = tokens[0];

                string postName = tokens[1];

                if (tokens.Length == 2)
                {
                    if (firstPart == "post")
                    {
                        if (!postLikes.ContainsKey(postName))
                        {
                            postLikes[postName] = 0;
                            postDislikes[postName] = 0;
                        }
                    }
                    else if (firstPart == "like")
                    {
                        if (!postLikes.ContainsKey(postName))
                        {
                            postLikes[postName] = 0;
                        }
                        postLikes[postName]++;
                    }
                    else if (firstPart == "dislike")
                    {
                        if (!postDislikes.ContainsKey(postName))
                        {
                            postDislikes[postName] = 0;
                        }
                        postDislikes[postName]++;
                    }
                }

                else if (tokens.Length > 2)
                {
                    string commentatorName = tokens[2];

                    if (!postComments.ContainsKey(postName))
                    {
                        postComments[postName] = new Dictionary<string, List<string>>();
                    }

                    if (!postComments[postName].ContainsKey(commentatorName))
                    {
                        postComments[postName][commentatorName] = new List<string>();
                    }

                    List<string> comment = new List<string>();

                    for (int i = 3; i < tokens.Length; i++)
                    {
                        comment.Add(tokens[i]);
                    }

                    postComments[postName][commentatorName].Add(string.Join(" ", comment));
                }

                command = Console.ReadLine();
            }

            foreach (var postLikesPair in postLikes)
            {
                string postName = postLikesPair.Key;
                int likes = postLikesPair.Value;
                int dislikes = postDislikes[postName];

                Console.WriteLine($"Post: {postName} | Likes: {likes} | Dislikes: {dislikes}");

                Console.WriteLine("Comments:");

                if (postComments.Keys.Contains(postName))
                {
                    foreach (var commentatorCommentsPair in postComments[postName])
                    {
                        string commentator = commentatorCommentsPair.Key;
                        string comments = string.Join(" ", commentatorCommentsPair.Value);

                        Console.WriteLine($"*  {commentator}: {comments}");
                    }
                }
                else
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}
