using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            List<string> blacklisted = Console.ReadLine().Split(' ').ToList();
            List<string> songs = new List<string>();
            string command;

            do
            {
                command = Console.ReadLine();
                bool cleared = true;

                foreach (string word in blacklisted)
                {
                    if (command.Contains(word))
                    {
                        cleared = false;
                        break;
                    }
                }

                if (command != "end" && cleared)
                {
                    songs.Add(command);
                }
            } while (command != "end");

            songs.Sort();

            foreach (string song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }
}
