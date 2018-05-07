using System;
class TrickyStrings
{
    static void Main(string[] args)
    {
        string delimiter = Console.ReadLine();
        int numberOfStrings = int.Parse(Console.ReadLine());
        string[] result = new string[numberOfStrings];

        for (int i = 0; i < numberOfStrings; i++)
        {
            result[i] = Console.ReadLine();
        }

        Console.WriteLine(String.Join(delimiter, result));

    }
}