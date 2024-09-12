using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class ReverseString
    {
        public static void Reverse() {

            Console.WriteLine("ENTER A NAME YOU WANT TO REVERSE ");
            String Name = Console.ReadLine();
            String revName = " ";

            for (int i = Name.Length-1; i >= 0; i--)
            {
                revName = revName + Name[i];
                
            }
            Console.WriteLine($"REVERSE OF {Name} IS {revName}");
            Console.ReadLine();

        }
    }
}
