using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program18
    {
        public static void Main()
        {
           
            Console.WriteLine("Enter the first string: ");


            String string1= Console.ReadLine();
           
            Console.WriteLine("Enter the second string :");



            String string2 = Console.ReadLine();
           
            Console.WriteLine("\nAre both strings same: ");

            if (string1.Equals(string2) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadLine();
        }
    }
}
