using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    class Trainers
    {
        static void Main(string[] args)
        {
            checked
            {

                double practicalScore = 0.0;
                double teohraticalScore = 0.0;
                double technicalScore = 0.0;

                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    int distanceInMiles = int.Parse(Console.ReadLine());
                    long distanceInMeters = distanceInMiles * 1600L;

                    double cargo = double.Parse(Console.ReadLine()) * 1000.0;

                    string name = Console.ReadLine();

                    double endMoney = (cargo * 1.5) - (0.7 * distanceInMeters * 2.5);

                    if (name == "Practical")
                    {
                        practicalScore += endMoney;
                    }
                    else if (name == "Theoretical")
                    {
                        teohraticalScore += endMoney;
                    }
                    else if (name == "Technical")
                    {
                        technicalScore += endMoney;
                    }
                }

                var money = Math.Max(technicalScore, Math.Max(teohraticalScore, practicalScore));

                if (money == teohraticalScore)
                {
                    Console.WriteLine($"The Theoretical Trainers win with ${money:F3}.");
                }
                else if (money == practicalScore)
                {
                    Console.WriteLine($"The Practical Trainers win with ${money:F3}.");
                }
                else if (money == technicalScore)
                {
                    Console.WriteLine($"The Technical Trainers win with ${money:F3}.");
                }              
            }   
        }
    }
}
