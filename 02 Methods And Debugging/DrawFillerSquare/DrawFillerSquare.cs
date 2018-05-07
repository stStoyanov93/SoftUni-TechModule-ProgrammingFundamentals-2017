using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFillerSquare
{
    class DrawFillerSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintLines(n);
            PrintMiddle(n);
            PrintLines(n);
        }

        public static void PrintLines(int n)
        {
            int l = 2 * n;

            for (int i = 0; i < l; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }
        public static void PrintMiddle(int n)
        {
           

            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("-");

                for (int i = 0; i < n - 1; i++)
                {
                    Console.Write("\\/");
                }

                Console.Write("-");
                Console.WriteLine();
            }
            
        }
    }
}
