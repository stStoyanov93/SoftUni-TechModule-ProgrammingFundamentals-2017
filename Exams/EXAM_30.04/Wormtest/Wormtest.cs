using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    public class Wormtest
    {
        public static void Main()
        {
            int lenght = int.Parse(Console.ReadLine()) * 100;
            double width = double.Parse(Console.ReadLine());

            if (width == 0 || lenght % width == 0)
            {
                Console.WriteLine($"{Math.Round(width * lenght, 2):F2}");
            }
            else
            {
                Console.WriteLine($"{Math.Round(lenght / width * 100, 2):F2}%");
            }
        }
    }
}
