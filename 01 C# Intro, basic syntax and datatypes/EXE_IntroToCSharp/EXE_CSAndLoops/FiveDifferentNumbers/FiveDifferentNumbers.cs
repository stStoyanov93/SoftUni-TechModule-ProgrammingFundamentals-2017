using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveDifferentNumbers
{
    class FiveDifferentNumbers
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (second - first < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int firstNumber = first; firstNumber <= second - 4; firstNumber++)
                {
                    for (int secondNumber = firstNumber + 1; secondNumber <= second - 3; secondNumber++)
                    {
                        for (int thirdNumber = secondNumber + 1; thirdNumber <= second - 2; thirdNumber++)
                        {
                            for (int fourthNumber = thirdNumber + 1; fourthNumber <= second - 1; fourthNumber++)
                            {
                                for (int fifthNumber = fourthNumber + 1; fifthNumber <= second; fifthNumber++)
                                {
                                    Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber} {fourthNumber} {fifthNumber}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

