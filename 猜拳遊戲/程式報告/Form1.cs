using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 程式報告
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] getp = new int[3];
        PictureBox[] arrpic = new PictureBox[2];


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[0];            
            timer1.Interval = 50;
            arrpic[0] = pictureBox1;
            arrpic[1] = pictureBox2;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Random rd = new Random();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random rd = new Random();
            for (int i = 0; i < arrpic.Length; i++)
            {
                getp[i] = rd.Next(0, 3);
                arrpic[i].Image = imageList1.Images[getp[i]];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (getp[0] == getp[1] )
            {
                label2.Text = "平手";
            }
            else if (getp[0] > getp[1])
            {
                label2.Text = "電腦贏了";
            }
            else
            {
                label2.Text = "玩家贏了";
            }









        }
    }
}
