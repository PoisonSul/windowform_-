using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK11_11_이미지_그리기_
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

            Image img = new Bitmap("원광대로고.png");
            Point[] pts = {
            new Point(0, 0), // 원본의 왼쪽 상단 모서리의 대상 위치
            new Point(200, 0), // 원본의 오른쪽 상단 모서리의 대상 위치
            new Point(50, 100) // 원본의 왼쪽 하단 모서리의 대상 위치
};
            g.DrawImage(img, pts);
        }
    }
}
