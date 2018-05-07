using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class CollectionOfExercises
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeLink { get; set; }
        public List<string> Exercises { get; set; }
    }

    class Exercises
    {
        static void Main(string[] args)
        {
            List<CollectionOfExercises> list = new List<CollectionOfExercises>();

            string input = Console.ReadLine();

            while (input != "go go go")
            {
                string[] tokens = input.Split(new string[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries);

                List<string> exes = new List<string>();

                for (int i = 3; i < tokens.Length; i++)
                {
                    exes.Add(tokens[i]);
                }

                list.Add(new CollectionOfExercises()
                {
                    Topic = tokens[0],
                    CourseName = tokens[1],
                    JudgeLink = tokens[2],
                    Exercises = exes                   
                });

                input = Console.ReadLine();
            }

            foreach (var item in list)
            {
                int index = 1;

                Console.WriteLine($"Exercises: {item.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{item.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {item.JudgeLink}");

                foreach (string exe in item.Exercises)
                {
                    Console.WriteLine($"{index}. {exe}");
                    ++index;
                }
            }
        }
    }
}
