﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(String.Join("", text.ToCharArray().Reverse()));
        }
    }
}
