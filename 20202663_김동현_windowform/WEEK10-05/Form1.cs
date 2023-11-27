using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEEK10_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            index %= imageList1.Images.Count;
            label1.Image = imageList1.Images[index++];
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool baseResult = base.ProcessCmdKey(ref msg, keyData);
            if (keyData == (Keys.Left))
            {
                label1.Location = new System.Drawing.Point(label1.Location.X - 1, label1.Location.Y);
            }
            else if (keyData == (Keys.Right))
            {
                label1.Location = new System.Drawing.Point(label1.Location.X - 1, label1.Location.Y);
            }
            return baseResult;
        }
    }
}
