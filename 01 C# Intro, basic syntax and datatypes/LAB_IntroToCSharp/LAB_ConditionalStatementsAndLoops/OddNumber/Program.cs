﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int number = Math.Abs(int.Parse(Console.ReadLine()));

                if (number % 2 != 0)
                {
                    Console.WriteLine($"The number is: {number}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }
        }
    }
}
