using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        long[,] OKL = new long[12, 50];
        byte[,] PRP = new byte[12, 50];
        int prev;
        bool start = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void UST(int i, int j)
        {
            MessageBox.Show(Convert.ToString(OKL[i, j]));
            textBox1.Text = OKL[i, j].ToString();
            textBox2.Text = PRP[i, j].ToString();
            float pr = OKL[i, j] * PRP[i, j] / 100;
            textBox4.Text = pr.ToString();
            pr += OKL[i, j];
            textBox3.Text = pr.ToString();            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nicole");
            comboBox1.Items.Add("Britney");
            comboBox1.Items.Add("Sindey");
            comboBox1.Items.Add("Lindsey");
            comboBox1.SelectedIndex = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    OKL[i, j] = 1000000; PRP[i, j] = 30;
                }
            }
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add("Jan");
            tabControl1.TabPages.Add("Feb");
            tabControl1.TabPages.Add("Mar");
            tabControl1.TabPages.Add("Apr");
            tabControl1.TabPages.Add("May");
            tabControl1.TabPages.Add("Jun");
            tabControl1.TabPages.Add("Jul");
            tabControl1.TabPages.Add("Aug");
            tabControl1.TabPages.Add("Sep");
            tabControl1.TabPages.Add("Oct");
            tabControl1.TabPages.Add("Nov");
            tabControl1.TabPages.Add("Dec");
            tabControl1.TabIndex = 0;
            //UST(0, 0);
            prev = 0;
            start = true;
        }

        private void comboBox1_TabIndexChanged(object sender, EventArgs e)
        {
            if (prev == comboBox1.SelectedIndex)
                return;
            prev = comboBox1.SelectedIndex;            
            //UST(comboBox1.SelectedIndex, tabControl1.TabIndex);
            //MessageBox.Show(Convert.ToString(comboBox1.SelectedIndex) + " and " + Convert.ToString(tabControl1.TabIndex));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.start && comboBox1.SelectedIndex == 0)
                return;
            UST(comboBox1.SelectedIndex, tabControl1.TabIndex);
            MessageBox.Show(Convert.ToString(comboBox1.SelectedIndex) + " and " + Convert.ToString(tabControl1.SelectedIndex));
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            //UST(comboBox1.SelectedIndex, tabControl1.TabIndex);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            int j = tabControl1.TabIndex;
            OKL[i, j] = Convert.ToInt64(textBox1.Text);
            UST(i, j);
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            int j = tabControl1.TabIndex;
            PRP[i, j] = Convert.ToByte(textBox2.Text);
            UST(i, j);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
