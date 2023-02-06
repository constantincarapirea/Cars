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
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=XTREME-EDUSSR26;Initial Catalog=Automobil;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobilDataSet7.Tara". При необходимости она может быть перемещена или удалена.
            this.taraTableAdapter1.Fill(this.automobilDataSet7.Tara);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobilDataSet6.Combustibil". При необходимости она может быть перемещена или удалена.
            this.combustibilTableAdapter1.Fill(this.automobilDataSet6.Combustibil);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobilDataSet5.Culoare". При необходимости она может быть перемещена или удалена.
            this.culoareTableAdapter1.Fill(this.automobilDataSet5.Culoare);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobilDataSet4.Firma". При необходимости она может быть перемещена или удалена.
            this.firmaTableAdapter1.Fill(this.automobilDataSet4.Firma);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "automobilDataSet3.Tara". При необходимости она может быть перемещена или удалена.
  



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            string insert;
            insert = "Insert into Automobil(IDAuto,IDFirma,Model,AnProducere,IDCuloare,CapCil,IDTipComb,Pret) values('"; insert += textBox4.Text + "',(SELECT IDFirma FROM Firma WHERE Denumire = '" + comboBox1.Text + "'),'" + textBox5.Text + "','" +textBox6.Text + "',(SELECT IDCuloare FROM Culoare WHERE Denumire = '" + comboBox2.Text + "'),'" + textBox7.Text + "',(SELECT IDTipComb FROM Combustibil WHERE Denumire = '" + comboBox3.Text + "'),'" + textBox8.Text + "')";
            SqlCommand cmd = new SqlCommand(insert, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Sa Introdus Cu Succes","Operatiune");
            this.Hide();
            Form1 s1 = new Form1();
            s1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 s1 = new Form1();
            this.Hide();
            s1.Show();
        }
    }
}
