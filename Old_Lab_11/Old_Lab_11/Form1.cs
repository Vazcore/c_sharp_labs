using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Old_Lab_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        long[,] OKL = new long[12, 50];
        byte[,] PRP = new byte[12, 50];

        private void UST(int i, int j)
        {
            textBox1.Text = OKL[i, j].ToString();
            textBox2.Text = PRP[i, j].ToString();
            float pr = OKL[i, j] * PRP[i, j] / 100;
            textBox4.Text = pr.ToString();
            pr += OKL[i, j];
            textBox3.Text = pr.ToString();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UST(comboBox1.SelectedIndex, axTabStrip1.Value);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Иванов И.И.");
            comboBox1.Items.Add("Петров П.П.");
            comboBox1.Items.Add("Сидоров С.С.");
            comboBox1.Items.Add("Яковлев Я.Я.");
            comboBox1.SelectedIndex = 0;
            for (int i = 0; i < 12; i++)
                for (int j = 0; j < 50; j++)
                {
                    OKL[i, j] = 1000000; PRP[i, j] = 30;
                }
            axTabStrip1.Tabs.Clear();
            axTabStrip1.Tabs.Add("янв"); axTabStrip1.Tabs.Add("фев"); axTabStrip1.Tabs.Add("март");
            axTabStrip1.Tabs.Add("апр"); axTabStrip1.Tabs.Add("май"); axTabStrip1.Tabs.Add("июнь");
            axTabStrip1.Tabs.Add("июль"); axTabStrip1.Tabs.Add("авг"); axTabStrip1.Tabs.Add("сен");
            axTabStrip1.Tabs.Add("окт"); axTabStrip1.Tabs.Add("ноя"); axTabStrip1.Tabs.Add("дек");
            axTabStrip1.Value = 0;
            UST(0, 0);
        }

        private void axTabStrip1_Change(object sender, EventArgs e)
        {
            UST(comboBox1.SelectedIndex, axTabStrip1.Value);            
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            int j = axTabStrip1.Value;
            OKL[i, j] = Convert.ToInt64(textBox1.Text);
            UST(i, j);

        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            int j = axTabStrip1.Value;
            PRP[i, j] = Convert.ToByte(textBox2.Text);
            UST(i, j);

        }

    }
}
