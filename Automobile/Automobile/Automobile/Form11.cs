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
    public partial class Form11 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=XTREME-EDUSSR26;Initial Catalog=Automobil;Integrated Security=True");
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string insert;
           
            if (textBox2.Text == textBox3.Text)
            { insert = "Insert into Pass(loghin,passw) values('"; insert += textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inregistrat cu succes", "Inregistrare");
            }
            else MessageBox.Show("Parolele nu corespund", "Inregistrare");
            connect.Close();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 s10 = new Form10();
            this.Hide();
            s10.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
