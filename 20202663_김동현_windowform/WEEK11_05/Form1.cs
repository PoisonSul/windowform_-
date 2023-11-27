using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK11_05
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
            //각각 영역 따로 구현 가능

            /*
            Rectangle r = new Rectangle(50, 50, 150, 100);
            g.FillRectangle(Brushes.Lime, r);
            g.DrawRectangle(new Pen(Color.Black), r);
            */
          Rectangle[] rects = {
            new Rectangle(40, 40, 40, 100),
            new Rectangle(100, 40, 100, 40),
            new Rectangle(100, 100, 100, 40)
};
            g.FillRectangles(Brushes.Blue, rects);
            g.DrawRectangles(Pens.Red, rects);

        }
    }
}
