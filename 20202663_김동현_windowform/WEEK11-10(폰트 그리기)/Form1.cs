﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK11_10_폰트_그리기_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            /*
            string s = "This string is long enough to wrap.";
            s += " With a 300px-width rectangle, ";
            s += "it requires six lines to display the string in its entirety.";
            Font f = new Font("Tahoma", 20);
            Rectangle r = new Rectangle(10, 10, 300, 200);
            g.DrawRectangle(Pens.Black, r);
            g.DrawString(s, f, Brushes.Black, r);
            f.Dispose();
            */


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
    
            int x = e.X;
            int y = e.Y;
            toolStripStatusLabel1.Text = "(" + x + ", " + y + ")";
        }
    }
}
