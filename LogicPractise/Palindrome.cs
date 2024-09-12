using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class Palindrome
    {
        public static void Palind()
        {

            Console.WriteLine("ENTER A NUMBER OR NAME YOU WANT TO CHECK");
            String Name = Console.ReadLine();
            String revName = "";

            for (int i = Name.Length - 1; i >= 0; i--)
            {
                revName = revName + Name[i];

            }
            Console.WriteLine($"REVERSE OF {Name} IS {revName}");
            if (revName.Equals(Name))
            {
                Console.WriteLine($"{revName} IS PALINDROME");
            }
            else
            {
                Console.WriteLine($"{Name} IS NOT AN PALINDROME");
            }
            Console.ReadLine();

        }
    }
}
