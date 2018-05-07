using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Megapixels
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double pixels = ((ulong)width * (ulong)height) / 1000000.0;
            Console.WriteLine($"{width}x{height} => {Math.Round(pixels, 1)}MP");
        }
    }
}
