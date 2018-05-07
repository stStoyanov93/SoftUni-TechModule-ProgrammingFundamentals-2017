using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            List<int> primal = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> currentSelection = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                List<int> primalCopy = new List<int>(primal);

                foreach (int item in currentSelection)
                {
                    if (primal.Contains(item))
                    {
                        primal.Remove(item);
                    }
                }

                foreach (int item in currentSelection)
                {
                    if (!primalCopy.Contains(item))
                    {
                        primal.Add(item);
                    }
                }


                //primal.RemoveAll(x => currentSelection.Any(y => y == x));


            }
            primal.Sort();

            Console.WriteLine(String.Join(" ", primal));
        }
    }
}
