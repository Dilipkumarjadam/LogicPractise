using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class PrintPattern   
    {
        public static void Pattern()
        {
            while (true)
            {
                Console.WriteLine("ENTER VALUES TO PRINT PATTERN : \n 1.TRIANGLE  \n 2.INVERSE TRIANGLE  \n 3.DIAMOND  \n 4.SQUARE  \n 5.PYRAMID \n 6.EXIT   ");
                int way = Convert.ToInt32(Console.ReadLine());

                if (way == 1)
                {
                    Console.WriteLine("ENTER A VALUE TO PRINT TRIANGLE :-");
                    int num = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= num; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(" *");
                        }

                        Console.WriteLine();
                    }
                    Console.ReadLine();
                }
                else if (way == 2)
                {
                    Console.WriteLine("ENTER A VALUE TO PRINT INVERSE TRIANGLE :-");
                    int num = Convert.ToInt32(Console.ReadLine());

                    for (int i = num; i >= 0; i--)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write(" *");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();

                }
                else if (way == 3)
                {
                    Console.WriteLine("ENTER A VALUE TO PRINT DIAMOND :-");
                    int num = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= num; i++)
                    {
                        for (int k = 1; k <= num - i; k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(" *");
                        }

                        Console.WriteLine();
                    }
                    for (int i = (num - 1); i >= 1; i--)
                    {
                        for (int k = 0; k < (num - i); k++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(" *");
                        }

                        Console.WriteLine();
                    }
                    Console.ReadLine();

                }
                else if (way == 4)
                {
                    Console.WriteLine("ENTER A VALUE TO PRINT SQUARE :-");
                    int num = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i <= num; i++)
                    {
                        for (int j = 0; j <= num; j++)
                        {
                            Console.Write(" *");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();

                }
                else if (way == 5)
                {
                    Console.WriteLine("ENTER A VALUE TO PRINT PYRAMID :-");
                    int input = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= input; i++)
                    {
                        for (int j = 1; j <= input - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 1; k <= i; k++)
                        {
                            Console.Write(" *");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();

                }
                else if (way == 6) { break; } 
                else { Console.WriteLine("ENTER A VALID VALUE"); }
            }
        }
    }
}

