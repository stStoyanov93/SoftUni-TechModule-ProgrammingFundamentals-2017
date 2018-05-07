using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuckZipper
{
    class StuckZipper
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int minNumberOfDigits = MinNumberOfDigits(firstList, secondList);

            RemoveLargerItems(firstList, minNumberOfDigits);
            RemoveLargerItems(secondList, minNumberOfDigits);

            int index = 1;

            for (int i = 0; i < firstList.Count; i++)
            {
                int currentElement = firstList[i];
                secondList.Insert(Math.Min(index, secondList.Count), currentElement);
                index += 2;
            }

            Console.WriteLine(string.Join(" ", secondList));
        }

        static void RemoveLargerItems(List<int> list, int minNumberOfDigits)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int currentElement = list[i];
                int currentNumberOfDigits = CalculateNumberOfDigits(currentElement);

                if (currentNumberOfDigits > minNumberOfDigits)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }

        static int MinNumberOfDigits(List<int> firstList, List<int> secondList)
        {
            var idealNumberOfDigits = int.MaxValue;

            foreach (var item in firstList)
            {
                var numberOfDigits = CalculateNumberOfDigits(item);

                if (numberOfDigits < idealNumberOfDigits)
                {
                    idealNumberOfDigits = numberOfDigits;
                }
            }

            foreach (var item in secondList)
            {
                var numberOfDigits = CalculateNumberOfDigits(item);

                if (numberOfDigits < idealNumberOfDigits)
                {
                    idealNumberOfDigits = numberOfDigits;
                }
            }
            return idealNumberOfDigits;
        }

        static int CalculateNumberOfDigits(int number)
        {
            number = Math.Abs(number);

            var numberOfDigits = 0;

            while (number > 0)
            {
                numberOfDigits++;
                number /= 10;
            }
            return numberOfDigits;
        }
    }
}
