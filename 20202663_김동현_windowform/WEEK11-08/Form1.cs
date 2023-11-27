using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK11_08
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
            Point[] pts = {                                                     //별모양 전체
            new Point(110, 40), new Point(125, 91),
            new Point(180, 91), new Point(135, 123),
            new Point(152, 172), new Point(110, 141),
            new Point(66, 172), new Point(82, 122),
            new Point(40, 91), new Point(95, 91)
            };
            */

            Point[] pts =
            {
            new Point(110, 40), new Point(125, 91),
            new Point(180, 91), new Point(110, 112),
            };

            Point[] pts1 =
            {
            new Point(180, 91), new Point(135, 123),
            new Point(152, 172), new Point(110, 112),
            };

            Point[] pts2 =
            {
          new Point(152, 172), new Point(110, 141),
            new Point(66, 172), new Point(110, 112),
            };
          
            Point[] pts3 =
           {
                new Point(66, 172), new Point(82, 122),
            new Point(40, 91), new Point(110, 112)
            };
           
            Point[] pts4 =
           {
                new Point(40, 91), new Point(95, 91),
                 new Point(110, 40), new Point(110, 112)
            };


            g.FillPolygon(Brushes.Red, pts);
            g.DrawPolygon(Pens.Black, pts);
            g.FillPolygon(Brushes.Orange, pts1);
            g.DrawPolygon(Pens.Black, pts1);
            g.FillPolygon(Brushes.Yellow, pts2);
            g.DrawPolygon(Pens.Black, pts2);
            g.FillPolygon(Brushes.Green, pts3);
            g.DrawPolygon(Pens.Black, pts3);
            g.FillPolygon(Brushes.Blue, pts4);
            g.DrawPolygon(Pens.Black, pts4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        { //마우스 커서 올려서 좌표 확인

            MessageBox.Show(e.X + " : " + e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {//마우스 커서 올려서 좌표 확인
            int x = e.X;
            int y = e.Y;
            toolStripStatusLabel1.Text = "(" + x + ", " + y + ")";
        }
    }
}
