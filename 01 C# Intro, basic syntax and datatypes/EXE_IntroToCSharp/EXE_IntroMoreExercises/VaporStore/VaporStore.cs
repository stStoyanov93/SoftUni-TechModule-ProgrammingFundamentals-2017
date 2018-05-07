using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> games = new Dictionary<string, decimal>();
            games.Add("OutFall 4", 39.99M);
            games.Add("CS: OG", 15.99M);
            games.Add("Zplinter Zell", 19.99M);
            games.Add("Honored 2", 59.99M);
            games.Add("RoverWatch", 29.99M);
            games.Add("RoverWatch Origins Edition", 39.99M);

            decimal currentBalance = decimal.Parse(Console.ReadLine());
            decimal spent = 0.0M;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Game Time")
                {
                    break;
                }               

                if (
                   input == "OutFall 4" ||
                   input == "CS: OG" ||
                   input == "Zplinter Zell" ||
                   input == "Honored 2" ||
                   input == "RoverWatch" ||
                   input == "RoverWatch Origins Edition"
                   )
                {
                    if (currentBalance >= games[input] )
                    {
                        currentBalance -= games[input];
                        spent += games[input];
                        Console.WriteLine($"Bought {input}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }               
            }

            if (currentBalance <= 0M)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${currentBalance:F2}");
            }
        }
    }
}
