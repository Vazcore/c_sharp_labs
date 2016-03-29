using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab13_Ind
{
    
    public partial class Form1 : Form
    {
        public class CPNumber
        {
            private int n1;
            private int n2;

            public CPNumber(int n1, int n2)
            {
                this.n1 = n1;
                this.n2 = n2;
            }
            public override string ToString()
            {
                return (System.String.Format("{0} + {1}i", this.n1, this.n2));
            }

            public static CPNumber operator +(CPNumber a, CPNumber b)
            {
                return new CPNumber(a.n1 + b.n1, a.n2 + b.n2);
            }

            public static CPNumber operator -(CPNumber a, CPNumber b)
            {
                return new CPNumber(a.n1 - b.n1, a.n2 - b.n2);
            }

            public static CPNumber operator *(CPNumber a, CPNumber b)
            {
                return new CPNumber(a.n1 * b.n1, a.n2 * b.n2);
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CPNumber a = new CPNumber(Int32.Parse(this.textBox1.Text), Int32.Parse(this.textBox4.Text));
            CPNumber b = new CPNumber(Int32.Parse(this.textBox2.Text), Int32.Parse(this.textBox5.Text));

            CPNumber sum = a + b;            
            CPNumber bb = b * b;
            CPNumber p3 = a-bb;
            CPNumber res = sum * p3;

            this.textBox3.Text = res.ToString();
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
