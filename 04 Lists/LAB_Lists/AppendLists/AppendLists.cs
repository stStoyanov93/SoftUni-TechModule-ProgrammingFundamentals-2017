using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {         
            string[] str = Console.ReadLine().Split('|');
            List<int> list = new List<int>();

            for (int i = str.Length-1; i >= 0; i--)
            {
                int[] numbers = str[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                list.AddRange(numbers);
            }

            Console.WriteLine(String.Join(" ", list));

        }
    }
}
