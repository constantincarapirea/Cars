using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Automobile
{
    public partial class Form8 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=XTREME-EDUSSR26;Initial Catalog=Automobil;Integrated Security=True");
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string insert;
            SqlDataAdapter s1=new SqlDataAdapter("exec proba1",connect);
            DataTable for8 = new DataTable();
            s1.Fill(for8);
            dataGridView1.DataSource = for8;
                connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 s1 = new Form1();
            this.Hide();
            s1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect.Open();
            string insert;
            SqlDataAdapter s1 = new SqlDataAdapter("exec proba1", connect);
            DataTable for8 = new DataTable();
            s1.Fill(for8);
            for8.Dispose();
            connect.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
