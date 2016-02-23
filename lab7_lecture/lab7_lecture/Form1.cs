using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab7_lecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form2 f2 = new Form2();

        private void button1_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
            double x, y, z; string st;
            z = Convert.ToDouble(f2.textBox1.Text);
            x = Convert.ToDouble(textBox1.Text);
            y = Math.Sin(x) + 66 + z;
            st = String.Format("{0,4:0.##}", y);
            textBox2.Text = st;

        }
    }
}
