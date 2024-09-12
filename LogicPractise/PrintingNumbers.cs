using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class PrintingNumbers
    {
        public static void PrintNumb()
        {
            Console.WriteLine("ENTER HOW MUCH NUMBERS YOU WANT TO PRINT ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
                Console.ReadLine();
        }
    }
}
