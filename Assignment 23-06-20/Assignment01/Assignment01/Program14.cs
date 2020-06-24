 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program14
    {
        static void Main()
        {
            int[] arr1 = new int[5];
            int i, mn;
            Console.WriteLine("Input 5 elements in the array :\n");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());



            }

            mn = arr1[0];
            for (i = 0; i < 5; i++)
            {
                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.WriteLine("Smallest among 5 digit " + mn);
            Console.ReadKey();
        }
    }
}
