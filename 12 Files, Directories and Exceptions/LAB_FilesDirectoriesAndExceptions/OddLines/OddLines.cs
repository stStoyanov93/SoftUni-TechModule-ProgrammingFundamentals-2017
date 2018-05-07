using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Input.txt");

            using(StreamWriter writer = new StreamWriter("Output.txt"))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        writer.WriteLine(lines[i]);
                    }
                }
            }
        }
    }
}
