using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class Swapping
    {
        public static void swap()
        {
            Console.WriteLine("swap using 3 variable type 3 or type 2 to swap using 2 variable");
            string ans = Console.ReadLine();
            int way = Convert.ToInt32(ans);
            if (way == 3)
            {

                Console.WriteLine("swapping number using 3 variable");

                int c = 0;

                Console.WriteLine("ENTER NUMBER 1");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ENTER NUMBER 2");
                int b = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine($"BEFORE SWAPPING THE VALUE OF NUM 1 IS {a} AND NUM 2 IS {b}");

                c = a;
                a = b;
                b = c;

                Console.WriteLine($"AFTER SWAPPING THE VALUE OF NUM 1 IS {a} AND NUM 2 IS {b}");
                Console.ReadLine();
            }
            else
            {

                Console.WriteLine("swapping number using 2 variable");
                Console.WriteLine("ENTER NUMBER 1");

                string Num1 = Console.ReadLine();
                int a = Convert.ToInt32(Num1);

                Console.WriteLine("ENTER NUMBER 2");
                string Num2 = Console.ReadLine();
                int b = Convert.ToInt32(Num2);


                Console.WriteLine($"BEFORE SWAPPING THE VALUE OF NUM 1 IS {a} AND NUM 2 IS {b}");

                a = a + b;
                b = a - b;
                a = a - b;

                Console.WriteLine($"AFTER SWAPPING THE VALUE OF NUM 1 IS {a} AND NUM 2 IS {b}");
                Console.ReadLine();
            }
        }
    }

}
