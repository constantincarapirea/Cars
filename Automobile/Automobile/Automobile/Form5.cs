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
    public partial class Form5 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=XTREME-EDUSSR26;Initial Catalog=Automobil;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string insert;
            insert = "Select AVG(Automobil.Pret) as Medie from Automobil inner join Firma on firma.IDFirma = Automobil.IDFirma inner join Tara on Tara.IDTARA = Firma.IDTARA where Tara.Denumire ='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(insert, connect);
            object ex4 = cmd.ExecuteScalar();
            connect.Close();
            textBox1.Text = "Pretul Mediu Este "+ex4.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
 this.Hide();
            Form1 s1 = new Form1();
            s1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
