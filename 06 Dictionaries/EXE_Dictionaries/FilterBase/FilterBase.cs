using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> position = new Dictionary<string, string>();
            Dictionary<string, int> age = new Dictionary<string, int>();
            Dictionary<string, double> salary = new Dictionary<string, double>();
            string command;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "filter base")
                {
                    break;
                }

                string[] pair = command.Split(new char[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int a;
                double s;

                if (int.TryParse(pair[1], out a))
                {
                    age[pair[0]] = a;
                }
                else if (double.TryParse(pair[1], out s))
                {
                    salary[pair[0]] = s;
                }
                else
                {
                    position[pair[0]] = pair[1];
                }
            }

            command = Console.ReadLine();

            if (command == "Position")
            {
                foreach (string item in position.Keys)
                {
                    Console.WriteLine($"Name: {item}");
                    Console.WriteLine($"Position: {position[item]}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (command == "Age")
            {
                foreach (string item in age.Keys)
                {
                    Console.WriteLine($"Name: {item}");
                    Console.WriteLine($"Age: {age[item]}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (command == "Salary")
            {
                foreach (string item in salary.Keys)
                {
                    Console.WriteLine($"Name: {item}");
                    Console.WriteLine($"Salary: {salary[item]:F2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
