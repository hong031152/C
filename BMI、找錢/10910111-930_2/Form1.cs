using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10910111_930_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(textBox1.Text);
            int coin10 = 0, coin5 = 0, coin1 = 0;
            coin10 = money / 10;
            money = money % 10;
            coin5 = money / 5;
            coin1 = money % 5;
            label2.Text = "10元"+coin10+"枚,5元"+coin5+"枚,1元"+coin1+"枚";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double h1 = Convert.ToDouble(textBox2.Text);
            double w1 = Convert.ToDouble(textBox3.Text);
            h1 = h1 / 100;          
            label5.Text = "BMI="+w1 / (h1*h1); 

        }
    }
}
