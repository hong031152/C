using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _10910111_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer player;
        int testnum;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            label1.Text = "";
            Random rd = new Random();
            testnum = rd.Next(1, 11);
            player = new SoundPlayer(testnum+".wav");
            player.Load();
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player.Play();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] ary = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            if (textBox1.Text.ToLower() == ary[testnum-1])
            {
                label1.Text = "答對了";

            }
            else
            {
                label1.Text = "答錯了";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
