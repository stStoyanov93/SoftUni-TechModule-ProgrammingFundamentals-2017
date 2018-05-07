using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FolderSize
{
    class FolderSize
    {
        static void Main(string[] args)
        {
            using(StreamWriter writer = new StreamWriter("output.txt"))
            {
                decimal size = 0M;

                foreach (var item in Directory.GetFiles("TestFolder"))
                {
                    size += new FileInfo(item).Length;
                }

                size = (size / 1024) / 1024;

                writer.WriteLine(size);
            }
        }
    }
}
