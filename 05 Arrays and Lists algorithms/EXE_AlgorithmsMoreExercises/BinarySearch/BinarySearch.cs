using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int elementToFind = int.Parse(Console.ReadLine());
            int countLinear = 0;
            int countBinary = 0;
            

            foreach (int item in list)
            {
                countLinear++;

                if (item == elementToFind)
                {                 
                    break;
                }
            }

            list.Sort();

            int low = 0;
            int high = list.Count - 1;
            

            while (low <= high)
            {
                int midpoint = (high + low) / 2;
                countBinary++;

                if (list[midpoint] == elementToFind)
                {
                    break;
                }
                
                if (list[midpoint] < elementToFind)
                {
                    low = midpoint + 1;
                }
                else if (list[midpoint] > elementToFind)
                {
                    high = midpoint - 1;                 
                }                             
            }

            if (list.Contains(elementToFind))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine($"Linear search made {countLinear} iterations");
            Console.WriteLine($"Binary search made {countBinary} iterations");
        }
    }
}
