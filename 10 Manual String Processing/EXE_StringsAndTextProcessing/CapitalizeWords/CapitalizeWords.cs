using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeWords
{
    class CapitalizeWords
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                List<StringBuilder> list = new List<StringBuilder>();
                string[] arr = input
                    .Split(new char[] { ' ', ',', '.', '!', '?', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', ';', ':' }, 
                    StringSplitOptions.RemoveEmptyEntries);

                

                for (int i = 0; i < arr.Length; i++)
                {
                    StringBuilder sb = new StringBuilder(arr[i]);
                    sb[0] = char.ToUpperInvariant(sb[0]);

                    for (int j = 1; j < sb.Length; j++)
                    {
                        sb[j] = char.ToLowerInvariant(sb[j]);
                    }

                    list.Add(sb);
                }
                

                Console.WriteLine(String.Join(", ", list));
                input = Console.ReadLine();
            }
        }
    }
}
