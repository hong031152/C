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

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("tank1.gif");
            pictureBox1.Left = 100;
            pictureBox1.Top = 100;
            pictureBox2.Image = Image.FromFile("fire.gif");
            pictureBox2.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    pictureBox1.Top -= 2;
                    break;
                case Keys.S:
                    pictureBox1.Top += 2;
                    break;
                case Keys.A:                    
                    pictureBox1.Left -= 2;
                    break;
                case Keys.D:                    
                    pictureBox1.Left += 2;
                    break;
                case Keys.Up:
                    pictureBox1.Image = Image.FromFile("tank1.gif");
                    pictureBox2.Left = pictureBox1.Left + 5;
                    pictureBox2.Top = pictureBox1.Top - 50;
                    pictureBox2.Visible = true;
                    break;
                case Keys.Right:
                    pictureBox1.Image = Image.FromFile("tank2.gif");
                    pictureBox2.Left = pictureBox1.Left + 60;
                    pictureBox2.Top = pictureBox1.Top +5;
                    pictureBox2.Visible = true;
                    break;
                case Keys.Down:
                    pictureBox1.Image = Image.FromFile("tank3.gif");
                    pictureBox2.Left = pictureBox1.Left + 5;
                    pictureBox2.Top = pictureBox1.Top + 60;
                    pictureBox2.Visible = true;
                    break;
                case Keys.Left:
                    pictureBox1.Image = Image.FromFile("tank4.gif");
                    pictureBox2.Left = pictureBox1.Left -50;
                    pictureBox2.Top = pictureBox1.Top + 5;
                    pictureBox2.Visible = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pictureBox2.Visible = false;
        }
    }
}
