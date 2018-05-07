using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Input.txt");

            using (StreamWriter writer = new StreamWriter("Output.txt"))
            {
                for (int i = 0; i < lines.Length; i++)
                {                  
                        writer.WriteLine($"{i}. " + lines[i]);
                }
            }
        }
    }
}
