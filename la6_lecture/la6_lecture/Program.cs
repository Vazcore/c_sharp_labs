﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace la6_lecture
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form2 f2 = new Form2();            
            f2.Show();
            Application.Run(new Form1());
        }
    }
}
