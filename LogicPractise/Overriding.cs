using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class Overriding
    {
        public int math(int a, int b)
        {
            return a + b;
        }

        public void Animal () {

            Console.WriteLine("\nIn Parent Animal is Walking");
            Console.ReadLine();
        }
    }

    public class Overridechild : Overriding
    {
        public int math(int a, int b, int c)
        {
            return a - b - c;
        }
        public void Animal()
        {
            Console.WriteLine("\nIn child Animal is Running");
        }
        public static void over()
        {
            Console.WriteLine("Enter Numbers to perform overriding \n\n Enter number one");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number three");
            int c = Convert.ToInt32(Console.ReadLine());

            Overridechild chil = new Overridechild();
            Overriding par = new Overriding();
            Console.WriteLine("subtraction of all 3 given number is "+ chil.math(a,b,c));
            Console.WriteLine("Addition of first 2 given number is " + par.math(a,b));
            chil.Animal();
            par.Animal();
            Console.ReadLine();
        }

    }
}
