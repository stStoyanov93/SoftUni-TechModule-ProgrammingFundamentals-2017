using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticsTraining
{
    class BallisticsTraining
    {
        static void Main(string[] args)
        {
            long[] targetPosition = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] myCoordinates = Console.ReadLine().Split(' ').ToArray();
            long myX = 0L;
            long myY = 0L;

            for (int i = 0; i < myCoordinates.Length - 1; i += 2)
            {
                if (myCoordinates[i] == "up")
                {
                    myY += long.Parse(myCoordinates[i + 1]);
                }
                else if (myCoordinates[i] == "down")
                {
                    myY -= long.Parse(myCoordinates[i + 1]);
                }
                else if (myCoordinates[i] == "left")
                {
                    myX -= long.Parse(myCoordinates[i + 1]);
                }
                else if (myCoordinates[i] == "right")
                {
                    myX += long.Parse(myCoordinates[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{myX}, {myY}]");

            if (myX == targetPosition[0] && myY == targetPosition[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
