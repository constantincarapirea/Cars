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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobilDataSet13.Ex52". При необходимости она может быть перемещена или удалена.
            this.ex52TableAdapter.Fill(this.automobilDataSet13.Ex52);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobilDataSet12.Ex51". При необходимости она может быть перемещена или удалена.
            this.ex51TableAdapter.Fill(this.automobilDataSet12.Ex51);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 s1 = new Form1();
            this.Hide();
            s1.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
