using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Old_Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y; string st;
            x = Convert.ToDouble(textBox1.Text);
            y = Math.Sin(x);
            st = String.Format("{0,4:0.##}", y);
            textBox2.Text = st;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y; string st;
            x = Convert.ToDouble(textBox4.Text);
            y = Math.Cos(x);
            st = String.Format("{0,4:0.##}", y);
            textBox3.Text = st;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

            if (e.TabPageIndex == 0) label5.Text = "Tab 1";
            if (e.TabPageIndex == 1) label5.Text = "Tab 2";
            if (e.TabPageIndex == 2) label5.Text = "Tab 3";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x, y;
            double res;
            x = Convert.ToInt32(textBox6.Text);
            y = Convert.ToInt32(textBox5.Text);
            try
            {
                res = x / y;
                label9.Text = Convert.ToString(res);
            }
            catch (DivideByZeroException)
            {
                label9.Text = "Error while dividing by zero!!!";
            }
        }
    }
}
