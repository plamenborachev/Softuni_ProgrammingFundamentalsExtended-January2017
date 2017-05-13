using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.JSONStringify
{
    public class JSONStringify
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (inputLine != "stringify")
            {
                string[] inputParams = inputLine.Split(new[] { ':', ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string name = inputParams[0];

                int age = int.Parse(inputParams[1]);

                List<int> grades = inputParams.Skip(2).Select(int.Parse).ToList();

                students.Add(new Student
                {
                    Name = name,

                    Age = age,

                    Grades = grades
                });


                inputLine = Console.ReadLine();
            }

            StringBuilder sb = new StringBuilder();

            foreach (var student in students)
            {

                sb.Append("{name:"
                    + $"\"{student.Name}\""
                    + ",age:"
                    + student.Age
                    + ",grades:["
                    + string.Join(", ", student.Grades)
                    + "]},");

            }

            Console.WriteLine($"[{sb.ToString().TrimEnd(',')}]");

        }
    }
}
