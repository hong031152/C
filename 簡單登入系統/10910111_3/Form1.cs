using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10910111_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] stuId = new string[] { "8001", "8002", "8003", "8004", "8005" };
        string[] stuName = new string[] { "劉學有", "張杰輪", "周立宏", "王吉吉", "陶得華" };
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if ((e.KeyChar.CompareTo('0')<0 || e.KeyChar.CompareTo('9')>0)&& e.KeyChar!='\b')
            {
                e.Handled = true;
            }
            */
            if (!((e.KeyChar.CompareTo('0') >= 0 && e.KeyChar.CompareTo('9') <= 0) || e.KeyChar == '\b'))
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = Array.IndexOf(stuId, textBox1.Text);
            if (index==-1)
            {
                label2.Text = "sorry!";
            }
            else
            {
                label2.Text = "歡迎" + stuName[index];
            }
            
        }
    }
}
