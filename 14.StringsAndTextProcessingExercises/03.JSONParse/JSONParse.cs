using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.JSONParse
{
    public class JSONParse
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            string[] studentsData = inputLine
                .Trim('[', '{', ']')
                .TrimEnd('}')
                .Split(new string[] { "},{" }, StringSplitOptions.None)
                .ToArray();

            for (int i = 0; i < studentsData.Length; i++)
            {
                studentsData[i] = studentsData[i].Replace("name:\"", "").Replace("\",age", "").Replace(",grades", "");
            }

            List<Student> students = new List<Student>();

            foreach (var student in studentsData)
            {
                string[] studentParams = student.Split(':');

                string name = studentParams[0];

                int age = int.Parse(studentParams[1]);

                List<int> grades = studentParams[2]
                    .Trim('[', ']')
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                students.Add(new Student
                {
                    Name = name,

                    Age = age,

                    Grades = grades
                });
            }

            foreach (var student in students)
            {
                if (student.Grades.Any())
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }

                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
                               
            }

        }
    }
}
