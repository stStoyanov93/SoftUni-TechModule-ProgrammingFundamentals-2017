using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int numberOfPeope = int.Parse(Console.ReadLine());
            string typeOfPackage = Console.ReadLine();

            if (numberOfPeope > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                double totalPrice = 0;
                totalPrice += GetHallPrice(numberOfPeope) + GetPackage(typeOfPackage);
                totalPrice -= GetDiscount(totalPrice, typeOfPackage);

                Console.WriteLine($"We can offer you the {GetHall(numberOfPeope)}");
                Console.WriteLine($"The price per person is {(totalPrice / numberOfPeope):F2}$");
            }
        }

        public static int GetHallPrice(int people)
        {
            if (people <= 50)
            {
                return 2500;
            }
            else if (people <= 100)
            {
                return 5000;
            }
            else
            {
                return 7500;
            }
        }
        public static string GetHall(int people)
        {
            if (people <= 50)
            {
                return "Small Hall";
            }
            else if (people <= 100)
            {
                return "Terrace";
            }
            else
            {
                return "Great Hall";
            }
        }
        public static int GetPackage(string package)
        {
            if (package == "Normal")
            {
                return 500;
            }
            else if (package == "Gold")
            {
                return 750;
            }
            else
            {
                return 1000;
            }
        }
        public static double GetDiscount(double price, string package)
        {
            if (package == "Normal")
            {
                return price * 0.05;
            }
            else if (package == "Gold")
            {
                return price * 0.1;
            }
            else
            {
                return price * 0.15;
            }
        }

    }
}
