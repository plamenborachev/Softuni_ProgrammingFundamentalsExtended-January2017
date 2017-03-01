using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.NoteStatistics
{
    public class NoteStatistics
    {
        public static void Main()
        {
            List<double> inputFrequencies = Console.ReadLine().Split().Select(double.Parse).ToList();

            List<string> defaultNotes = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            List<double> defaultFrequency = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            List<string> notes = new List<string>();

            for (int i = 0; i < inputFrequencies.Count; i++)
            {
                for (int a = 0; a < defaultFrequency.Count; a++)
                {
                    if (inputFrequencies[i] == defaultFrequency[a])
                    {
                        notes.Add(defaultNotes[a]);
                        break;
                    }
                }
            }

            Console.WriteLine($"Notes: {string.Join(" ", notes)}");

            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();

            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].Count() == 1)
                {
                    naturals.Add(notes[i]);
                }
                else
                {
                    sharps.Add(notes[i]);
                }
            }

            double sumNaturals = 0;

            for (int i = 0; i < naturals.Count; i++)
            {
                for (int a = 0; a < defaultNotes.Count; a++)
                {
                    if (naturals[i] == defaultNotes[a])
                    {
                        sumNaturals += defaultFrequency[a];
                        break;
                    }
                }
            }

            double sumSharps = 0;

            for (int i = 0; i < sharps.Count; i++)
            {
                for (int a = 0; a < defaultNotes.Count; a++)
                {
                    if (sharps[i] == defaultNotes[a])
                    {
                        sumSharps += defaultFrequency[a];
                        break;
                    }
                }
            }
            
            Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");

            if (sumNaturals == 0)
            {
                Console.WriteLine($"Naturals sum: {sumNaturals:f0}");
            }
            else
            {
                Console.WriteLine($"Naturals sum: {sumNaturals:f2}");
            }

            if (sumSharps == 0)
            {
                Console.WriteLine($"Sharps sum: {sumSharps:f0}");
            }
            else
            {
                Console.WriteLine($"Sharps sum: {sumSharps:f2}");
            }

        }
    }
}
