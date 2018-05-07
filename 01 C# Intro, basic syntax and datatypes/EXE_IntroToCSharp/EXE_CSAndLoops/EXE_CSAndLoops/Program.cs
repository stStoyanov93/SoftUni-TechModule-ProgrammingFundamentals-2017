using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_CSAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (input)
            {
                case "Athlete":
                    Console.WriteLine($"The Athlete has to pay {quantity * 0.7:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {input} has to pay {quantity * 1.0:F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {input} has to pay {quantity * 1.7:F2}.");
                    break;
                 default:
                    Console.WriteLine($"The {input} has to pay {quantity * 1.2:F2}.");
                    break;
            }
        }
    }
}
