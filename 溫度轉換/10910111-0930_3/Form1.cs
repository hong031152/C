using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10910111_0930_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          double f = Convert.ToDouble(textBox1.Text) * 9 / 5 + 32;
           
            label2.Text = "華氏="+f;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox2.Text);
            c = (c - 32) * 5 / 9;
            label3.Text ="華氏="+c;
        }
    }
}
