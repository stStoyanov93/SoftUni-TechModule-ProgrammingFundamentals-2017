using System;
using System.Collections.Generic;
using System.Linq;

namespace BoomingCannon
{
    class BoomingCannon
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skipCount = arr[0];
            int lenght = arr[1];

            var s = Console.ReadLine();
            var splittedS = s.Split(new[] {@"\<<<"}, StringSplitOptions.RemoveEmptyEntries);
            var list = new List<string>();
            int startIndex = 0;

            if (!s.StartsWith(@"\<<<"))
            {
                startIndex = 1;
            }

            for (int i = startIndex; i < splittedS.Length; i++)
            {

                var temp = String.Join("", splittedS[i].Skip(skipCount).Take(lenght));
                list.Add(temp);
            }

            var newL = list.Where(x => x != string.Empty);
            Console.WriteLine(String.Join("/\\", newL));
        }
    }
}
