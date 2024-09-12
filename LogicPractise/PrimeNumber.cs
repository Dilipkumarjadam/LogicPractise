using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class PrimeNumber
    {
        public static void Prime()
        {

            Console.WriteLine("Enter 1 to check num is prime or not and 2 to print prime numbers ");
            int way = Convert.ToInt32(Console.ReadLine());
            if (way == 1)
            {
                Console.WriteLine("Enter number you want to check ");
                int maxNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Prime numbers up to {maxNumber}:");

                int Count = 0;

                for (int num = 1; num <= maxNumber; num++)
                {
                    if (maxNumber % num == 0)
                    {
                        Count++;

                    }

                }
                if (Count == 2)
                {
                    Console.WriteLine($" {maxNumber}  is prime number ");
                }
                else
                {
                    Console.WriteLine($" {maxNumber}  is not prime number ");
                }
                Console.ReadLine();
            }
            else {
                Console.WriteLine("Enter number ");
                int MaxNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Prime numbers up to {MaxNumber}:");

               
                for (int number = 1; number <= MaxNumber; number++)
                {
                     int Count = 0;
                    for (int i = 1; i <= MaxNumber; i++)
                    {
                        if (number % i == 0)
                        {
                            Count++;

                        }

                    }
                    if (Count == 2)
                    {
                        Console.WriteLine($" {number}  is prime number ");
                    }else if ( Count > 2) {
                        Console.WriteLine($" {number}  is a composite number ");
                    }else { Console.WriteLine($"{number} is not a prime or composite");
                    }

                }
                Console.ReadLine();
            }


        }
    }
}
                
    

