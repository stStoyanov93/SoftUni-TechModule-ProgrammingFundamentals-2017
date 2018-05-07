using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLetter
{
    class FindTheLetter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] itemToFind = Console.ReadLine().Split();
            string letter = itemToFind[0];
            int occurence = int.Parse(itemToFind[1]);
            int timesFound = 0;
            int index = 0;

            while (true)
            {
                if (input.IndexOf(letter, index) > -1)
                {
                    timesFound++;
                    index = input.IndexOf(letter, index);

                    if (timesFound == occurence)
                    {
                        Console.WriteLine(index);
                        break;
                    }

                    index++;
                }
                else
                {
                    Console.WriteLine("Find the letter yourself!");
                    break;
                }
            }
        }
    }
}
