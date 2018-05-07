using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatrePromotions
{
    class TheatrePromotions
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(CalculatePrice(day, age) + "$"); 
            }
        }

        public static int CalculatePrice(string day, int age)
        {
            if (day == "weekday")
            {
                if (age <= 18 || age > 64)
                {
                    return 12;
                }
                else
                {
                    return 18;
                }
            }
            else if (day == "weekend")
            {
                if (age <= 18 || age > 64)
                {
                    return 15;
                }
                else
                {
                    return 20;
                }
            }
            else
            {
                if (age <= 18)
                {
                    return 5;
                }
                else if (age > 18 &&  age <= 64)
                {
                    return 12;
                }
                else
                {
                    return 10;
                }
            }
        }
    }
}
