using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercises
{
    public class Exercises
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            List<Exercise> result = new List<Exercise>();

            while (inputLine != "go go go")
            {
                Exercise exercise = new Exercise();

                exercise = exercise.ParseExercise(inputLine);

                result.Add(exercise);

                inputLine = Console.ReadLine();
            }

            foreach (var exercise in result)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                int count = 1;

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine($"{count}. {problem}");
                    count++;
                }
            }

        }
    }
}
