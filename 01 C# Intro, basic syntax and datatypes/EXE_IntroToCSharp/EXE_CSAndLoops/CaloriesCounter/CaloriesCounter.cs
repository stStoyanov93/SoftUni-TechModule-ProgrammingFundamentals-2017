using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;

            int controlN = int.Parse(Console.ReadLine());
            int totalCalories = 0;

            for (int i = 0; i < controlN; i++)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "cheese")
                {
                    totalCalories += cheese;
                }
                else if (input.ToLower() == "tomato sauce")
                {
                    totalCalories += tomatoSauce;
                }
                else if (input.ToLower() == "salami")
                {
                    totalCalories += salami;
                }
                else if (input.ToLower() == "pepper")
                {
                    totalCalories += pepper;
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
