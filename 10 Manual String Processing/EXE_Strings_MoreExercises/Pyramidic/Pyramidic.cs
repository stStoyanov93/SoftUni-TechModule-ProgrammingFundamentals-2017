using System;
using System.Collections.Generic;
using System.Linq;

class Pyramidic
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> lines = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            lines.Add(input);
        }

        List<string> pyramids = new List<string>();

        for (int i = 0; i < lines.Count; i++)
        {
            string line = lines[i];

            for (int j = 0; j < line.Length; j++)
            {
                char @char = line[j];
                string pyramid = FindPiramids(@char, lines, i);
                pyramids.Add(pyramid);
            }
        }

        string largerst = pyramids.OrderByDescending(p => p.Length).First();

        Console.WriteLine(largerst);
    }

    private static string FindPiramids(char @char, List<string> lines, int lineNum)
    {
        int count = 3;
        string pyramid = "" + @char + Environment.NewLine;
        for (int i = lineNum + 1; i < lines.Count; i++)
        {
            string toFind = new string(@char, count);

            if (lines[i].Contains(toFind))
            {
                pyramid += toFind + Environment.NewLine;
                count += 2;
            }
            else
            {
                return pyramid;
            }
        }
        return pyramid;
    }
}