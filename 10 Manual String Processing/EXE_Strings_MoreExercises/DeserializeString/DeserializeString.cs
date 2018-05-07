using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeString
{
    class DeserializeString
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> dict = new SortedDictionary<int, string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] arr = input.Split(new char[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 1; i < arr.Length; i++)
                {
                    dict[int.Parse(arr[i])] = arr[0];
                }

                input = Console.ReadLine();
            }

            StringBuilder builder = new StringBuilder();        

            foreach (var item in dict)
            {
                builder.Append(item.Value);
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
