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

        public double Add(double a, int b, int c)
        {
            return (a + b - c);

        }

        public static void Overload()
        {
            Console.WriteLine("ENTER A NUMBER");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("ENTER A NUMBER");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER A NUMBER");
            int c = Convert.ToInt32(Console.ReadLine());
            Overloading overloading = new Overloading();
            Console.WriteLine("add" + overloading.Add(a,b,c));
          Console.ReadLine();
        }
    }
}
