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
        enum Zvanie {masergant,mayor,leitenant,capitan };
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = Int32.Parse(this.textBox2.Text);
            bool isE = Enum.IsDefined(typeof(Zvanie), ind);
            if (isE)
                this.textBox1.Text = ((Zvanie)ind).ToString("F");
            else
                this.textBox1.Text = "Doesn't Exist";           
        }
    }
}
