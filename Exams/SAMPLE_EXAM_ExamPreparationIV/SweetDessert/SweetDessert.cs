using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            long numberOfGuests = long.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            long portions = numberOfGuests / 6;

            if (numberOfGuests % 6 != 0)
            {
                portions++;
            }

            decimal totalPrice = 2 * bananaPrice + 4 * eggPrice + 0.2M * berriesPrice;
            totalPrice *= portions;

            if (cash >= totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalPrice-cash):F2}lv more.");
            }
        }
    }
}
