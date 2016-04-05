using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab12
{
    public partial class Form1 : Form
    {
        public string g_x, g_y; 
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y; string st;
            x = Convert.ToDouble(textBox1.Text);
            y = Math.Sin(x);
            st = String.Format("{0,4:0.##}", y);
            textBox2.Text = st;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 50;
            toolTip1.BackColor = Color.Azure;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.button1, " ");
            toolTip1.ToolTipTitle = "4444444";

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = pictureBox1.Location;   // позиция левого верхнего угла pictureBox1
            Point p1 = this.Location;        // позиция левого верхнего угла формы
            // e.X и e.Y погиция курсора в pictureBox1
            int XX, YY;
            XX = e.X + p.X + p1.X; YY = e.Y + p.Y + p1.Y;
            Bitmap bmp = new Bitmap(1, 1);
            using (Graphics g = Graphics.FromImage(bmp))
            { g.CopyFromScreen(XX, YY, 0, 0, new Size(1, 1)); }
            Color color = bmp.GetPixel(0, 0);
            string SS;
            SS = Convert.ToString(color);
            toolTip1.ToolTipTitle = SS;
            toolTip1.SetToolTip(this.pictureBox1, " ");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.ToolTipTitle = "X = " + this.g_x + ", Y = " + this.g_y;
            toolTip1.SetToolTip(this.textBox1, " ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.g_x = this.textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.g_y = this.textBox2.Text;
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.ToolTipTitle = "X = " + this.g_x + ", Y = " + this.g_y;
            toolTip1.SetToolTip(this.textBox1, " ");
        }

        private void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string in_file = "in.txt";
            string out_file = "out.txt";

            // write to file
            using (FileStream fs = File.Create(out_file))
            {
                AddText(fs, "my name is alexey");
                AddText(fs, "\n hola todos \n");
                AddText(fs, "\n me enctanto estudiar esta idioma \n");
                AddText(fs, "\n y hasta luego \n");
            }

            // read from file
            using (FileStream fs = File.OpenRead(out_file))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                using (FileStream fs_write = File.Create(in_file))
                {
                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        // every 1024 bytes go here
                        // get the words
                        string[] words = temp.GetString(b).Split(' ');
                        char[] word;
                        for (int i = 0; i < words.Length; i++)
                        {
                            word = words[i].ToCharArray();
                            word[0] = char.ToUpper(word[0]);
                            words[i] = new string(word);
                            AddText(fs_write, words[i] + " ");
                        }
                    }
                }
            }

        }
    }
}
