﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int countOfOdds = 0;
            int i = 1;

            while (countOfOdds < n)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    countOfOdds++;
                }

                i++;              
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
