using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    class Cat
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int IntelligenceQuotient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    class Snake
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int CrueltyCoefficient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }

    class Animals
    {
        public static List<Dog> dogs = new List<Dog>();
        public static List<Cat> cats = new List<Cat>();
        public static List<Snake> snakes = new List<Snake>();

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "I'm your Huckleberry")
            {
                string[] tokens = input.Split();

                if (tokens[0] == "talk")
                {
                    MakeSound(tokens[1]);
                    input = Console.ReadLine();
                    continue;
                }

                string animalClass = tokens[0];
                string name = tokens[1];
                int age = int.Parse(tokens[2]);
                int parameter = int.Parse(tokens[3]);

                switch (animalClass)
                {
                    case "Dog":
                        dogs.Add(new Dog()
                        {
                            Age = age,
                            Name = name,
                            NumberOfLegs = parameter
                        });
                        break;
                    case "Cat":
                        cats.Add(new Cat()
                        {
                            Age = age,
                            Name = name,
                            IntelligenceQuotient = parameter
                        });
                        break;
                    case "Snake":
                        snakes.Add(new Snake()
                        {
                            Age = age,
                            Name = name,
                            CrueltyCoefficient = parameter
                        });
                        break;
                }

                input = Console.ReadLine();
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

        public static void MakeSound(string name)
        {
            foreach (var animal in dogs)
            {
                if (animal.Name == name)
                {
                    animal.ProduceSound();
                    return;
                }
            }

            foreach (var animal in cats)
            {
                if (animal.Name == name)
                {
                    animal.ProduceSound();
                    return;
                }
            }

            foreach (var animal in snakes)
            {
                if (animal.Name == name)
                {
                    animal.ProduceSound();
                    return;
                }
            }
        }
    }
}
