using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercises
{
    public class Exercise
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }

        public Exercise ParseExercise(string inputLine)
        {
            string[] exerciseParams = inputLine.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Exercise exercise = new Exercise()
            {
                Topic = exerciseParams[0],
                CourseName = exerciseParams[1],
                JudgeContestLink = exerciseParams[2],
                Problems = exerciseParams.Skip(3).ToList()
            };

            return exercise;
        }
    }
}
