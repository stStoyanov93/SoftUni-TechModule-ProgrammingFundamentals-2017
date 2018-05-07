using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPM
{
    class BPM
    {
        static void Main(string[] args)
        {
            int bpm = int.Parse(Console.ReadLine());
            int bCount = int.Parse(Console.ReadLine());

            double seconds = bCount * 60.0 / bpm;
            int minutes = (int)seconds / 60;
            seconds -= minutes * 60;

            Console.WriteLine($"{Math.Round(bCount / 4.0, 1)} bars - {minutes}m {Math.Floor(seconds)}s");
           
        }
    }
}
