using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program3
    {
        public static void Main(string[] args)
        {

            int a = int.Parse(args[0]);

            int b = int.Parse(args[1]);

            for(int i =a+1;i<b;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }

    }
    }

