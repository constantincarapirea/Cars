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
    public partial class Form7 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=XTREME-EDUSSR26;Initial Catalog=Automobil;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string insert;
            insert = "exec ex6";
            SqlCommand cmd = new SqlCommand(insert, connect);
            object ex5 = cmd.ExecuteScalar();
            String s1;
            s1 = "exec ex6_1";
            SqlCommand qwe = new SqlCommand(s1, connect);
            object ex6 = qwe.ExecuteScalar();
            connect.Close();
            textBox1.Text = "Numarul Maximal De Automobile Inregistrate Are Compania " + ex5.ToString()+" Fiind "+ex6.ToString()+" Exemplare" ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 s1 = new Form1();
            this.Hide();
            s1.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
