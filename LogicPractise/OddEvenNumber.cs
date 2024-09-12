using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class OddEvenNumber
    {
        public static void OENumber()
        {
            while (true)
            {
                Console.WriteLine("ENTER VALUE : \n 1. TO CHECK NUMBER \n 2. TO PRINT ODD EVEN NUMBER \n 3. TO EXIT");
                string way = Console.ReadLine();

                switch (way)
                {
                    case "1":
                        Console.WriteLine("ENTER NUMBER TO CHECK IS EVEN OR ODD NUMBER");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num % 2 == 0)
                        {
                            Console.WriteLine($"{num} IS EVEN NUMBER");
                        }
                        else
                        {
                            Console.WriteLine($"{num} IS ODD NUMBER");
                        }
                        Console.ReadLine();
                        break;


                    case "2":
                        Console.WriteLine("ENTER NUMBER TO PRINT EVEN AND ODD NUMBER");
                        int Num = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i <= Num; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine($"{i} IS EVEN NUMBER");
                            }
                            else
                            {
                                Console.WriteLine($"{i} IS ODD NUMBER");
                            }

                        }
                        Console.ReadLine();
                        break;

                    default: Console.WriteLine("ENTER VALID VALUE");
                        break;

                    case "3": return;
                }
            }
        }
    }
}
