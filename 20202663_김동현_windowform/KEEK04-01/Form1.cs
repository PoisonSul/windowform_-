using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEEK04_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.ClientSize.Height.ToString());

            Random _R = new Random();
            button1.BackColor = Color.FromArgb( _R.Next(1,256), _R.Next(1,256), _R.Next(1,256));

            button1.Location = new Point(_R.Next(0, this.ClientSize.Width - button1.Width), _R.Next(0, this.ClientSize.Height - button1.Height));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random _R = new Random();
            button1.BackColor = Color.FromArgb(_R.Next(1, 256), _R.Next(1, 256), _R.Next(1, 256));

            button1.Location = new Point(_R.Next(0, this.ClientSize.Width - button1.Width), _R.Next(0, this.ClientSize.Height - button1.Height));
        }
    }
}
