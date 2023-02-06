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
    public partial class Form9 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=XTREME-EDUSSR26;Initial Catalog=Automobil;Integrated Security=True");
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            string insert;
            insert = "SELECT Firma.Denumire AS Firma, Tara.Denumire AS Tara, Automobil.Model, Automobil.AnProducere,Culoare.Denumire, Automobil.CapCil, Combustibil.Denumire AS Combustibil,Automobil.Pret FROM Automobil INNER JOIN  Combustibil ON Automobil.IDTipComb = Combustibil.IDTipComb INNER JOIN Culoare ON Automobil.IDCuloare = Culoare.IDCuloare INNER JOIN Firma ON Automobil.IDFirma = Firma.IDFirma INNER JOIN Tara ON Firma.IDTARA = Tara.IDTARA where pret<"+textBox1.Text+" order by firma.Denumire";
            SqlDataAdapter s1 = new SqlDataAdapter(insert, connect);
            DataTable nume = new DataTable();
            s1.Fill(nume);
            dataGridView1.DataSource = nume;
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 s1 = new Form1();
            this.Hide();
            s1.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}
