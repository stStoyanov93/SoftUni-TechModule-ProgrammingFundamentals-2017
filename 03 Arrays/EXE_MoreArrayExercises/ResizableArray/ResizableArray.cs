using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizableArray
{
    class ResizableArray
    {
        static int[] items;
        static int itemsLength;
        static void Main()
        {         
            string[] arr = Console.ReadLine().Split(' ');
            items = new int[4];
            itemsLength = 0;

            while (arr[0] != "end")
            {
                string command = arr[0];

                if (command == "push")
                {
                    items[itemsLength] = int.Parse(arr[1]);
                    itemsLength++;

                    if (itemsLength >= items.Length)
                    {
                        IncreaseTheItemsNumber();
                    }
                }
                else if (command == "pop")
                {
                    items[itemsLength] = 0;
                    itemsLength--;
                }
                else if (command == "removeAt")
                {
                    int index = int.Parse(arr[1]);
                    RemoveAnItem(index);
                    itemsLength--;
                }
                else if (command == "clear")
                {
                    itemsLength = 0;
                }                       

                arr = Console.ReadLine().Split(' ');
            }

            PrintItems();
        }

        static void PrintItems()
        {
            for (int i = 0; i < itemsLength; i++)
            {
                Console.Write(items[i] + " ");
            }

            Console.WriteLine();
        }

        static void IncreaseTheItemsNumber()
        {
            int[] newArray = new int[itemsLength * 2];

            for (int i = 0; i < itemsLength; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }

        static void RemoveAnItem(int index)
        {
            for (int i = index + 1; i < itemsLength; i++)
            {
                items[i - 1] = items[i];
            }
        }
    }
}
