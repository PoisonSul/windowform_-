using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK11_07_타원형_그리기_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color[] _Color =
        {
            Color.Red,
           Color.Orange,            
            Color.Yellow,
            Color.Green, 
            Color.Blue, 
            Color.Indigo,
            Color.Purple
        };

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle r = new Rectangle(50, 50, 200, 200);
            for (int i = 1; i <= 7; i++)
            {
                SolidBrush _SolidBrush = new SolidBrush(_Color[i - 1]);
                g.FillPie(_SolidBrush, r, 45 * i, 45);
                g.DrawPie(Pens.DarkGreen, r,  45 * i, 45);
            }
            /* Rectangle r = new Rectangle(50, 50, 150, 100);     //타원 전체
               g.FillEllipse(Brushes.Cyan, r);
               g.DrawEllipse(Pens.Black, r); 
            */
            /*
            Rectangle r = new Rectangle(50, 50, 200, 200);         //타원 일부 

            g.FillPie(Brushes.Red, r, 45 * 1, 45);
            g.FillPie(Brushes.Orange, r, 45 * 2 , 45);
            g.FillPie(Brushes.Yellow, r, 45 * 3, 45);
            g.FillPie(Brushes.Green, r, 45 * 4, 45);
            g.FillPie(Brushes.Blue, r, 45 * 5, 45);
            g.FillPie(Brushes.Indigo, r, 45 * 6, 45);
            g.FillPie(Brushes.Purple, r, 45 * 7, 45);

            for (int i = 1; i <= 7; i++)
            {
                                            //FiIIPie타원 일부 색상 (45도쪽 부분만)
                g.DrawPie(Pens.Black, r, 45 * i, 45);
            }
         */

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
