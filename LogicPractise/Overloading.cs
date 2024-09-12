using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class Overloading
    {
        public int Add(int a, int b)
        {
            return (a + b);

        }

        public float Add(float a, float b, float c)
        {
            return (a + b + c);

        }

        public int Add(int a, int b, int c)
        {
            return (a + b + c);

        }

        public double Add(float a, int b, int c)
        {
            return (a + b - c);

        }

        public static void Overload()
        {
            Console.WriteLine("ENTER A NUMBER");
            Overloading overloading = new Overloading();
            Console.WriteLine("add" + overloading.Add(3.5f, 4, 6));
            Console.ReadLine();
        }
    }
}
