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
    public partial class Form4 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=XTREME-EDUSSR26;Initial Catalog=Automobil;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string delete;
            delete = "Delete From Automobil where IDAuto='"+textBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(delete, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sa Sters Cu Succes", "Operatiune");
            this.Hide();
            Form1 s1 = new Form1();
            s1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 s1 = new Form1();
            this.Hide();
            s1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
    }

