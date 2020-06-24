using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program9
    {
        public static void Main(String[] args)
        {
            int n3,n1 = 0, n2 = 1,number,i;
            Console.WriteLine("enter a number for fibnocci");
           number= int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");

            for (i=2;i<number;++i)
            {
               
                n3 = n1 + n2;
                
                Console.Write(n3+"");
               
                n1 = n2;
                n2 = n3;
                Console.ReadLine();

            }
        }
    }
}
