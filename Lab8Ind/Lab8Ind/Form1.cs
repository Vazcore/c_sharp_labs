using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab8Ind
{
    public partial class Form1 : Form
    {
        class Employe 
        {
            public string Name;
            public double Total;
            public int Age;
            public Employe(string name, double total, int age)
            {
                this.Name = name;
                this.Total = total;
                this.Age = age;
            }           

        }

        List<Employe> list = new List<Employe>();

        public Form1()
        {
            InitializeComponent();
            list.Add(new Employe("Alexey", 230.5, 26));
            this.comboBox1.Items.Add(list[0].Name);
            
            list.Add(new Employe("Nick", 210.5, 21));
            this.comboBox1.Items.Add(list[1].Name);

            MessageBox.Show(list[0].Name);

            list.Sort();

            MessageBox.Show(list[0].Name);

        }

        int Ind;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ind = this.comboBox1.SelectedIndex;
            this.textBox1.Text = list[Ind].Name;
            this.textBox2.Text = list[Ind].Age.ToString();
            this.textBox3.Text = list[Ind].Total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sal = Convert.ToDouble(this.textBox4.Text);
            list[Ind].Total += sal;
            this.textBox3.Text = list[Ind].Total.ToString();
        }
    }
}
