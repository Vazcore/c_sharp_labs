using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Old_Lab11_Ind
{
    class Program
    {
        static void Main(string[] args)
        {
            int buf;
            Console.Write("Type a: ");
            buf  = Convert.ToInt32(Console.ReadLine());
            Number a = new Number(buf);

            Console.Write("Type b: ");
            buf = Convert.ToInt32(Console.ReadLine());
            Number b = new Number(buf);

            // 3a + 4b
            Number res = (new Number(3) * a) + (new Number(4) * b);
            Console.WriteLine("3a + 4b = " + res.getN());
            Console.ReadKey();

            // (1 + a) * (5 + b)
            Number res_2 = (new Number(1) + a) * (new Number(5) + b);
            Console.WriteLine("(1 + a) * (5 + b) = " + res_2.getN());
            Console.ReadKey();
            
        }
    }
}
