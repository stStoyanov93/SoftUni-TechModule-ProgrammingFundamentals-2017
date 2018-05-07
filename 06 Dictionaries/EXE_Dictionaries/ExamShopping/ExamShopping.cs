using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stocks = new Dictionary<string, int>();
            string command;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "shopping time")
                {
                    break;
                }

                string[] pair = command.Split(' ');

                if (stocks.ContainsKey(pair[1]))
                {
                    stocks[pair[1]] += int.Parse(pair[2]);
                }
                else
                {
                    stocks[pair[1]] = int.Parse(pair[2]);
                }
            }

            while (true)
            {
                command = Console.ReadLine();

                if (command == "exam time")
                {
                    break;
                }

                string[] item = command.Split(' ');

                if (!stocks.ContainsKey(item[1]))
                {
                    Console.WriteLine($"{item[1]} doesn't exist");
                }
                else if (stocks[item[1]] <= 0)
                {
                    Console.WriteLine($"{item[1]} out of stock");
                }
                else if (int.Parse(item[2]) >= stocks[item[1]])
                {
                    stocks[item[1]] = 0;
                }
                else
                {
                    stocks[item[1]] -= int.Parse(item[2]);
                }
            }

            foreach (string item in stocks.Keys)
            {
                if (stocks[item] > 0)
                {
                    Console.WriteLine($"{item} -> {stocks[item]}");
                }
            }
        }
    }
}
