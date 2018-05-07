using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelsBack
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            List<int> city = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelBackSize = int.Parse(Console.ReadLine());
            int round = 0;
            int index = 0;

            while (city.Count > camelBackSize)
            {
                city.RemoveAt(index);
                city.RemoveAt(city.Count - index - 1);
                round++;
            }

            if (round == 0)
            {
                Console.WriteLine($"already stable: {String.Join(" ", city)}");
            }
            else
            {
                Console.WriteLine($"{round} rounds");
                Console.WriteLine($"remaining: {String.Join(" ", city)}");
            }
        }
    }
}
