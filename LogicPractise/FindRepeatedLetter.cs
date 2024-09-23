using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class FindRepeatedLetter
    {
        public static void Repeat()
        {
            string name = "hannah";
            int[] letterCounts = new int[256]; // ASCII character set size

            // Count occurrences of each character
            foreach (char letter in name)
            {
                letterCounts[letter]++;
            }

            Console.WriteLine("Repeated letters and their counts:");
            for (char i = 'a'; i <= 'z'; i++) // Assuming only lowercase letters
            {
                if (letterCounts[i] > 1) // Check if the letter is repeated
                {
                    Console.WriteLine($"{i}: {letterCounts[i]}");
                }
            }
            Console.ReadLine();
        }
    }
}
