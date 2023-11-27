using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK_11_01
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

            LinearGradientBrush b = new LinearGradientBrush(
            new Point(0, 0), new Point(100, 0), Color.Blue, Color.Red);
            Rectangle R = new Rectangle(0, 0, 100, 400);
            g.FillRectangle(b, R);

            LinearGradientBrush b1 = new LinearGradientBrush(
            new Point(0, 0), new Point(100, 30), Color.Blue, Color.Red);
            Rectangle R1 = new Rectangle(0, 0, 100, 400);
            g.FillRectangle(b1, R1);

            LinearGradientBrush b2 = new LinearGradientBrush(
         new Point(0, 0), new Point(100, 30), Color.Blue, Color.Red);
            Rectangle R2 = new Rectangle(0, 0, 100, 400);
            g.FillRectangle(b2, R2);

            b.Dispose();           
        }



        private void Form1_Load(object sender, EventArgs e)
        {
      
        }


    }
}
