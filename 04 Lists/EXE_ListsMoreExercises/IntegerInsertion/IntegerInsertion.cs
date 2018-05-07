using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = string.Empty;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "end")
                {
                    Console.WriteLine(String.Join(" ", list));
                    break;
                }

                int index = (int)(command[0] - '0');
                list.Insert(index, Convert.ToInt32(command));
            }

        }
    }
}
