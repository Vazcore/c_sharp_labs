using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace la6_lecture
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label2.Text = "Just take away mouse from input";
            textBox1.Text = "55";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            Form1.z = Convert.ToDouble(textBox1.Text);
            label2.Text = "Z value in Form1 was changes to " + Convert.ToString(Form1.z);
        }
    }
}
