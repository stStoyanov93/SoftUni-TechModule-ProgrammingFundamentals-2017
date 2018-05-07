using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorImage
{
    class MirrorImage
    {
        static void Main(string[] args)
        {
           string[] arr = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Print")
                {
                    Console.WriteLine(String.Join(" ", arr));
                    break;
                }

                int index = int.Parse(command);

                for (int i = 0; i < index / 2; i++)
                {
                    string temp = arr[i];
                    arr[i] = arr[index - i - 1];
                    arr[index - i - 1] = temp;
                }

                Array.Reverse(arr);

                for (int i = 0; i < (arr.Length - 1 - index)  / 2; i++)
                {
                    string temp = arr[i];
                    arr[i] = arr[arr.Length - 2 - index - i];
                    arr[arr.Length - 2 - index - i] = temp;
                }

                Array.Reverse(arr);
            }            
        }
    }
}
