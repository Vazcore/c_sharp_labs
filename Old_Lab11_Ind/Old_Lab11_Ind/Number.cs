using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Old_Lab11_Ind
{
    class Number
    {
        private int n;
        
        public Number(int n)
        {
            this.n = n;
        }

        public int getN()
        {
            return this.n;
        }

        public static Number operator+(Number n1, Number n2)
        {
            return new Number (n1.getN() + n2.getN());
        }

        public static Number operator -(Number n1, Number n2)
        {
            return new Number(n1.getN() - n2.getN());
        }

        public static Number operator *(Number n1, Number n2)
        {
            return new Number(n1.getN() * n2.getN());
        }

    }
}
