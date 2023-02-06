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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobilDataSet9.Ex3". При необходимости она может быть перемещена или удалена.
            this.ex3TableAdapter.Fill(this.automobilDataSet9.Ex3);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 s1 = new Form1();
            s1.Show();
        }
    }
}
