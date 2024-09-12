using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPractise
{
    public class RemoveDuplicate
    {
        public static void RemoveDup() {

            Console.WriteLine("ENTER A STRING FROM WHICH YOU WANT TO REMOVE DUPLICATE");
            string name = Console.ReadLine();
            string newName = string.Empty;

            for (int i = 0; i < name.Length; i++)
            {
                if (!newName.Contains(name[i]))
                {
                    newName += name[i]; 
                }
            }
            Console.WriteLine(newName);
            Console.ReadLine();
        }
    }
}
