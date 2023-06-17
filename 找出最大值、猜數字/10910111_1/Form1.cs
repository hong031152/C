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

        private void button1_Click(object sender, EventArgs e)
        {
            //int num1 = Convert.ToInt32(textBox1.Text);
            //int num2 = Convert.ToInt32(textBox2.Text);
            //int max = (num1 > num2) ? num1 : num2;
            //label1.Text = "最大值：" + max;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox3.Text);
            int num2 = Convert.ToInt32(textBox4.Text);
            int num3 = Convert.ToInt32(textBox5.Text);
            int max1 = (num1 > num2) ? num1 : num2;
            int max2 = (max1 > num3) ? max1 : num3;
            label2.Text = "最大值：" + max2;
        }

        int ans = 65;
        int times = 1;
        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox6.Text);
            string msg = "";
            if (num1== ans)
            {
                msg = "猜對了";

            }
            else
            {
                msg = (num1 > ans) ? "太大了" : "太小了";
            }
            msg += "一共猜了 " + times + " 次";
            label3.Text = msg;
            times++;
        }
    }
}
