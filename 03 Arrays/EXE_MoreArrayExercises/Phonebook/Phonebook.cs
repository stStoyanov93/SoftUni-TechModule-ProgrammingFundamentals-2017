using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();

            string command = string.Empty;

            while (command != "done")
            {
                command = Console.ReadLine();

                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == command)
                    {
                        Console.WriteLine($"{command} -> {numbers[i]}");
                    }
                }
            }
        }
    }
}
