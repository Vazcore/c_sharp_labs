using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_ind
{
    class Program
    {        
        static void Main(string[] args)
        {
            int a_n,b_n;
            Console.Write("Enter a: ");
            a_n = Convert.ToInt32(Console.ReadLine());
            Number a = new Number(a_n);
            Console.Write("Enter b: ");
            b_n = Convert.ToInt32(Console.ReadLine());
            Number b = new Number(b_n);
            // (1 + a) * (5 + b)
            Number res1 = ((new Number(1)) + a) * ((new Number(5)) + b);
            Console.WriteLine("(1 + a) * (5 + b) = " + res1.getN());
            Console.ReadKey();
            // 3a + 4b
            Number res2 = ((new Number(3)) * a) + ((new Number(4)) * b);
            Console.WriteLine("3a + 4b = " + res2.getN());
            Console.ReadKey();
        }
    }
}
