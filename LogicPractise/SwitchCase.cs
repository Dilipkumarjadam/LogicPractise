using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class SwitchCase
    {
        public static void PrintDays()
        {
            Console.WriteLine("Enter Days in Number You Want to Print");
            string days = Console.ReadLine();

            switch (days)
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default: Console.WriteLine("Holiday Bruhh");
                    break;
            }
            Console.ReadLine();
        }
    }
}