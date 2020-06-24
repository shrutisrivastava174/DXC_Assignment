using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program15
    {
        static void Main()
        {
            int sum = 0;
            double avg = 0.0;
            int[] arr = new int[10] { 10, 20, 26, 56, 37, 37, 82, 38, 22, 29 };
            int mx = arr[0];
            int mn = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                if (arr[i] > mx)
                {
                    mx = arr[i];
                }
                if (arr[i] < mn)
                {
                    mn = arr[i];
                }

            }
            avg = sum / arr.Length;
            Array.Sort(arr);
            Console.WriteLine("sotring in ascending order");
            foreach (int n in arr)
            {
                Console.WriteLine(n + " ");
            }
            Console.WriteLine("sotring in descending order");
            Array.Reverse(arr);
            foreach (int n in arr)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Total mark " + sum);
            Console.WriteLine("Averge mark is " + avg);
            Console.WriteLine("Maximu mark " + mx);
            Console.WriteLine("Minimu mark " + mn);
            Console.ReadKey();

        }
    }
}

