using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_ind
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

        public static Number operator +(Number n1, Number n2)
        {
            Number res = new Number(n1.getN() + n2.getN());
            return res;
        }

        public static Number operator -(Number n1, Number n2)
        {
            Number res = new Number(n1.getN() - n2.getN());
            return res;
        }

        public static Number operator *(Number n1, Number n2)
        {
            Number res = new Number(n1.getN() * n2.getN());
            return res;
        }
    }
}
