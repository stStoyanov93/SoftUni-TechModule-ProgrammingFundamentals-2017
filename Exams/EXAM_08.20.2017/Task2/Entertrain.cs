using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Entertrain
    {
        static void Main(string[] args)
        {
            int locomotivePower = int.Parse(Console.ReadLine());
            List<int> wagons = new List<int>();

            string input;

            while ((input = Console.ReadLine()) != "All ofboard!")
            {
                int nextWagon = int.Parse(input);

                wagons.Add(nextWagon);

                if (wagons.Sum() > locomotivePower)
                {
                    var average = (int)wagons.Average();
                    var nearest = wagons.OrderBy(x => Math.Abs((long)x - average)).First();
                    wagons.Remove(nearest);
                }
            }

            wagons.Reverse();
            Console.WriteLine($"{String.Join(" ", wagons)} {locomotivePower}");
        }
    }
}
