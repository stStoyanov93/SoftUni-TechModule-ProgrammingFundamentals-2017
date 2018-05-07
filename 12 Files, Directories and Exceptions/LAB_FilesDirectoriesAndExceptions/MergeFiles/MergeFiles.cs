using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MergeFiles
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            string[] text1 = File.ReadAllText("FileOne.txt").Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string[] text2 = File.ReadAllText("FileTwo.txt").Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            using(StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (var line in text1)
                {
                    writer.WriteLine(line);
                }

                foreach (var line in text2)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
