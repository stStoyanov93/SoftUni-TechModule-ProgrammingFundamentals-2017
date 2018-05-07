using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteStatistics
{
    class NoteStatistics
    {         
        static void Main(string[] args)
        {
            Dictionary<string, double> notesToFrequency = new Dictionary<string, double>
            {
                { "C", 261.63},
                { "C#", 277.18},
                { "D", 293.66},
                { "D#", 311.13},
                { "E", 329.63},
                { "F", 349.23},
                { "F#", 369.99},
                { "G", 392.00},
                { "G#", 415.30},
                { "A", 440.00},
                { "A#", 466.16},
                { "B", 493.88}
            };

            List<double> frequences = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<string> allNotes = new List<string>();
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();
            double sumNaturals = 0;
            double sumSharps = 0;

            foreach (double item in frequences)
            {               
                bool isNatural = item == 261.63 || item == 293.66 || item == 329.63 || item == 349.23 || item == 392.00 || item == 440.00 || item == 493.88;

                if (isNatural)
                {
                    foreach (string i in notesToFrequency.Keys)
                    {
                        if (item == notesToFrequency[i])
                        {
                            naturals.Add(i);
                            allNotes.Add(i);
                            break;                          
                        }
                    }

                    sumNaturals += item;
                }
                else
                {
                    foreach (string i in notesToFrequency.Keys)
                    {
                        if (item == notesToFrequency[i])
                        {
                            sharps.Add(i);
                            allNotes.Add(i);
                            break;
                        }
                    }

                    sumSharps += item;
                }
            }

            Console.WriteLine($"Notes: {String.Join(" ", allNotes)}");
            Console.WriteLine($"Naturals: {String.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {String.Join(", ", sharps)}");
            Console.WriteLine($"Naturals sum: {Math.Round(sumNaturals, 2)}");
            Console.WriteLine($"Sharps sum: {Math.Round(sumSharps, 2)}");
        }
    }
}
