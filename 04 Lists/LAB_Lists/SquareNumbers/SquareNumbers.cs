using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squares = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (Math.Sqrt(list[i]) == (int) Math.Sqrt(list[i]))
                {
                    squares.Add(list[i]);
                }
            }

            squares.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(String.Join(" ", squares));
        }
    }
}
