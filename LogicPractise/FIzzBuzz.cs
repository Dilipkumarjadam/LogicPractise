﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class FizzBuzz
    {
        public static void FIZZBUZZ()
        {
            Console.WriteLine("Check Fizz Buzz");
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }

            }
            Console.ReadLine();
        }
    }
}
