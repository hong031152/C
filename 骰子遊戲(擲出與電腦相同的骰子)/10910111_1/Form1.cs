using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10910111_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int getp = 0;
        int pcp = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            timer1.Interval = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Random rd = new Random();
            pcp= rd.Next(0, 6);
            pictureBox1.Image = imageList1.Images[pcp];
            label2.Text = "電腦：" + (pcp + 1) + "點";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            getp = rd.Next(0, 6);
            pictureBox1.Image = imageList1.Images[getp];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label2.Text = "你得到" + (getp + 1) + "點";
            if (pcp == getp)
            {
                label2.Text = "恭喜中獎";
            }
            else
            {
                label2.Text = "在試一次";
            }
        }
    }
}
