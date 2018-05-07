using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string strToFind = Console.ReadLine().ToLower();
            int count = 0;
            int i = 0;
            int index = 0;

            while (true)
            {

                index = text.IndexOf(strToFind, index);
                
                if (index == -1)
                {
                    break;
                }

                index++;
                count++;
                i++;
            }

            Console.WriteLine(count);
        }
    }
}
