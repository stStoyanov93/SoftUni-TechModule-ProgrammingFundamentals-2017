using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            string operand = Console.ReadLine();
            int secondN = int.Parse(Console.ReadLine());

            switch (operand)
            {
                case "+":
                    Console.WriteLine($"{firstN} + {secondN} = {firstN + secondN}");
                    break;
                case "-":
                    Console.WriteLine($"{firstN} - {secondN} = {firstN - secondN}");
                    break;
                case "*":
                    Console.WriteLine($"{firstN} * {secondN} = {firstN * secondN}");
                    break;
                case "/":
                    Console.WriteLine($"{firstN} / {secondN} = {firstN / secondN}");
                    break;
            }
        }
    }
}
