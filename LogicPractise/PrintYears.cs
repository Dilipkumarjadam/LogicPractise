using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class PrintYears
    {
        public static void PrintYear()
        {
            int b = 2022;
            int Temp = 0;
            for (int i = 0; i < 10; i++)
            {
                Temp = b;
                b = b + 1;
                Console.WriteLine($"{Temp}-{b}");
            }
            Console.ReadLine();
        }
    }

}
