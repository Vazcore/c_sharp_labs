using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        static byte Kol = 55;
        float[] PL = new float[Kol];
        float[] CH = new float[Kol];
        float[] LT = new float[Kol];
        string[] ST = new string[Kol];
        int Numb;
        bool KOD;


        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.Add("USA");
            this.listBox1.Items.Add("Canada");
            this.listBox1.Items.Add("Russia");

            PL[0] = 207600; CH[0] = 9675000; ST[0] = "Минск";
            PL[1] = 17075000; CH[1] = 139000000; ST[1] = "Москва";
            PL[2] = 313000; CH[2] = 35400000; ST[2] = "Варшава";
            this.listBox1.SelectedIndex = 1;
            Numb = 1;
            int K = 1;
            textBox1.Text = Convert.ToString(PL[K]);
            textBox2.Text = Convert.ToString(CH[K]);
            textBox3.Text = String.Format("{0,5:f2}", CH[K] / PL[K]);
            textBox5.Text = ST[K];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int K = this.listBox1.SelectedIndex;
            Numb = K;
            textBox1.Text = Convert.ToString(PL[K]);
            textBox2.Text = Convert.ToString(CH[K]);
            textBox3.Text = String.Format("{0,5:f2}", CH[K] / PL[K]);
            textBox5.Text = ST[K];

        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox3.Text = String.Format("{0,5:f2}", CH[Numb] / PL[Numb]);
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            CH[Numb] = Convert.ToSingle(textBox2.Text);
            textBox3.Text = String.Format("{0,5:f2}", CH[Numb] / PL[Numb]);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            PL[Numb] = Convert.ToSingle(textBox1.Text);
            textBox3.Text = String.Format("{0,5:f2}", CH[Numb] / PL[Numb]);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PL[Numb] = Convert.ToSingle(textBox1.Text);
                textBox3.Text = String.Format("{0,5:f2}", CH[Numb] / PL[Numb]);
            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CH[Numb] = Convert.ToSingle(textBox2.Text);
                textBox3.Text = String.Format("{0,5:f2}", CH[Numb] / PL[Numb]);
            }

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar <= 'я' & e.KeyChar >= 'а' | e.KeyChar <= 'Я' & e.KeyChar >= 'А' |
    e.KeyChar == Convert.ToChar(Keys.Back) | e.KeyChar == Convert.ToChar(Keys.Delete) |
    e.KeyChar == Convert.ToChar(Keys.Right) | e.KeyChar == Convert.ToChar(Keys.Left)))
                e.Handled = true; 

        }

        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.Z) { MessageBox.Show("Нажата Alt+Z"); e.Handled = true; } 
        }


    }
}
