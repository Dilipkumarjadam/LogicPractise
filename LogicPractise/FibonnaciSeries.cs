using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class FibonnaciSeries
    {
        public static void fibonnaci()
        {
            Console.WriteLine(" PROGRAM TO PRINT FIBONNACI SERIES");

            Console.WriteLine("ENTER HOW MUCH FIBONNACI YOU NEED");

            int a = 0;
            int b = 1;
            int c = 0;

            int stopsequence = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" FIBONNACI SERIES :- ");

            for (int i = 0; i <= stopsequence; i++)
            {
                Console.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
