using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class FactorialOfNum
    {
        public static void Factorial()
        {
            Console.WriteLine("ENTER THE VALUE OF WHICH YOU WANT FACTORIAL");
            int num = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = num; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"FACTORIAL OF {num} IS {factorial}");
            Console.ReadLine();
        } 

    }
}
