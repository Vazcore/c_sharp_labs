using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static Double MySinus(Double x)
        {
            return Math.Sin(x);
        }

        static Double Calculate(Double x)
        {
            if (x > 5)
            {
                return x * x + 0.3;
            }
            else if (x < 2)
            {
                return x / 2 + 32;
            }
            else
            {
                return x / 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y; string st;
            x = Convert.ToDouble(maskedTextBox1.Text);
            st = String.Format("{0,4:0.##}", Calculate(x));
            textBox2.Text = st;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ColorDialog Col = new ColorDialog();
            if (Col.ShowDialog() == DialogResult.OK)
            {
                maskedTextBox1.BackColor = Col.Color;
                textBox2.ForeColor = Col.Color;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
