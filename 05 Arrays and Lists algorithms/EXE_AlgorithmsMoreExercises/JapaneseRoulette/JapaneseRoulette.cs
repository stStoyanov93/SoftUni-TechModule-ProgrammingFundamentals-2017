using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseRoulette
{
    class JapaneseRoulette
    {
        static void Main(string[] args)
        {
            int[] bullets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] players = Console.ReadLine().Split(' ');
            int indexBulet = 0;
            bool isDead = false;

            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] == 1)
                {
                    indexBulet = i;
                    break;
                }
            }

            for (int i = 0; i < players.Length; i++)
            {
                string[] items = players[i].Split(',');
                string direction = items[1];
                int power = int.Parse(items[0]);

                if (direction == "Right")
                {
                    indexBulet = (indexBulet + power) % bullets.Length;
                }
                else if (direction == "Left")
                {
                    if (indexBulet - power < 0)
                    {
                        indexBulet = bullets.Length - (Math.Abs(indexBulet - power) % bullets.Length);
                    }
                    else
                    {
                        indexBulet = indexBulet - power;
                    }
                }

                if (indexBulet == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    isDead = true;
                    break;
                }

                indexBulet = indexBulet + 1 == bullets.Length ? 0 : indexBulet + 1;
            }

            if (!isDead)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
