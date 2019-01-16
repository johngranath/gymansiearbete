using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymnasiearbete
{
    public partial class Form1 : Form
    {
        int speed = 6;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='d')
            {
                pictureBox1.Left += speed;
            }
            else if (e.KeyChar == 'a')
            {
                pictureBox1.Left -= speed;
            }
            else if (e.KeyChar == 'w')
            {
                pictureBox1.Top -= speed;
            }
            else if (e.KeyChar == 's')
            {
                pictureBox1.Top += speed;
            }
        }
    }
}
