using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BevarageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyPer100Ml = int.Parse(Console.ReadLine());
            int sugarPer100Ml = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{volume * energyPer100Ml / 100.0}kcal, {sugarPer100Ml * volume/ 100.0}g sugars");

        }
    }
}
