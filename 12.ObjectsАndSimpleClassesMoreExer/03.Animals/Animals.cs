using System;
using System.Collections.Generic;

namespace _03.Animals
{
    public class Animals
    {
        public static void Main()
        {
            string inputLine = Console.ReadLine();

            List<Dog> dogs = new List<Dog>();

            List<Cat> cats = new List<Cat>();

            List<Snake> snakes = new List<Snake>();

            while (inputLine != "I'm your Huckleberry")
            {
                string[] inputParams = inputLine.Split(' ');

                if (inputParams.Length == 4)
                {
                    string animal = inputParams[0];

                    string name = inputParams[1];

                    int age = int.Parse(inputParams[2]);

                    int parameter = int.Parse(inputParams[3]);

                    if (animal == "Dog")
                    {
                        dogs.Add(new Dog
                        {
                            Name = name,

                            Age = age,

                            NumberOfLegs = parameter
                        }
                        );
                    }
                    else if (animal == "Cat")
                    {
                        cats.Add(new Cat
                        {
                            Name = name,

                            Age = age,

                            IntelligenceQuotient = parameter
                        }
                        );
                    }
                    else if (animal == "Snake")
                    {
                        snakes.Add(new Snake
                        {
                            Name = name,

                            Age = age,

                            CrueltyCoefficient = parameter
                        });
                    }


                }
                else if (inputParams.Length == 2)
                {
                    string name = inputParams[1];

                    foreach (var dog in dogs)
                    {
                        if (dog.Name == name)
                        {
                            dog.ProduceSound();
                        }
                    }

                    foreach (var cat in cats)
                    {
                        if (cat.Name == name)
                        {
                            cat.ProduceSound();
                        }
                    }

                    foreach (var snake in snakes)
                    {
                        if (snake.Name == name)
                        {
                            snake.ProduceSound();
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }

            foreach (var snake in snakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
}
