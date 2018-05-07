using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int photoSize =  int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{minute:D2}");

            if (photoSize < 1000)
            {
                Console.WriteLine($"Size: {photoSize}B");             
            }
            else if (photoSize <= 1000000)
            {
                Console.WriteLine($"Size: {photoSize / 1000}KB");
            }
            else
            {
                Console.WriteLine($"Size: {photoSize / 1000000}MB");
            }

            if (width == height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
            else if(width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
        }
    }
}
