using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 s2 = new Form2(); s2.Show();
            this.Hide();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 s4 = new Form4();
            this.Hide();
            s4.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 s3 = new Form3();
            this.Hide();
            s3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 s5 = new Form5();
            this.Hide();
            s5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 s6 = new Form6();
            this.Hide();
            s6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 s7 = new Form7();
            this.Hide();
            s7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 s8 = new Form8();
            this.Hide();
            s8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 s9 = new Form9();
            this.Hide();
            s9.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
