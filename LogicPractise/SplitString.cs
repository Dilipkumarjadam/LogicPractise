using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class SplitString
    {
        public void Split()
        {
            string name = "Ayush Patange hu Bhai Me Toh";
            string[] parts = name.Split(' '); // Split the string at each space

            foreach (string part in parts)
            {
                Console.WriteLine(part); // Print each part on a new line
            }
            Console.ReadLine();
        }
    }
}
