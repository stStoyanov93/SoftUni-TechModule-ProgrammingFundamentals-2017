using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            long initialAltitude = long.Parse(commands[0]);
            bool isSafe = true;

            for (int i = 1; i < commands.Length; i++)
            {
                if (i % 2 != 0 && commands[i] == "up")
                {
                    initialAltitude += long.Parse(commands[i + 1]);

                }
                else if (i % 2 != 0 && commands[i] == "down")
                {
                    initialAltitude -= long.Parse(commands[i + 1]);

                    if (initialAltitude <= 0)
                    {
                        isSafe = false;
                        break;
                    }

                }
            }

            if (isSafe)
            {
                Console.WriteLine($"got through safely. current altitude: {initialAltitude}m");
            }
            else
            {
                Console.WriteLine("crashed");
            }
        }
    }
}
