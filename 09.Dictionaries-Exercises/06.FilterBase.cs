using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FilterBase
{
    public class FilterBase
    {
        public static void Main()
        {
            Dictionary<string, int> nameAge = new Dictionary<string, int>();

            Dictionary<string, double> nameSalary = new Dictionary<string, double>();

            Dictionary<string, string> namePosition = new Dictionary<string, string>();

            string command = Console.ReadLine();

            while (command != "filter base")
            {
                string[] currentCommand = command.Split();

                int parsedAge;

                if (int.TryParse(currentCommand[2], out parsedAge))
                {
                    nameAge[currentCommand[0]] = parsedAge;
                }
                else
                {
                    double parsedSalary;

                    if (double.TryParse(currentCommand[2], out parsedSalary))
                    {
                        nameSalary[currentCommand[0]] = parsedSalary;
                    }
                    else
                    {
                        namePosition[currentCommand[0]] = currentCommand[2];
                    }
                }

                command = Console.ReadLine();
            }

            string typeOfDataNeededForPrint = Console.ReadLine();

            if (typeOfDataNeededForPrint == "Age")
            {
                foreach (var kvp in nameAge)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Age: {kvp.Value}");
                    Console.WriteLine("====================");
                }
            }
            else if (typeOfDataNeededForPrint == "Salary")
            {
                foreach (var kvp in nameSalary)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Salary: {kvp.Value:f2}");
                    Console.WriteLine("====================");
                }
            }
            else if (typeOfDataNeededForPrint == "Position")
            {
                foreach (var kvp in namePosition)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Position: {kvp.Value}");
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
