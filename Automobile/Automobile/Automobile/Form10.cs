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
    public partial class Form10 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=XTREME-EDUSSR26;Initial Catalog=Automobil;Integrated Security=True");
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlDataAdapter scd = new SqlDataAdapter("select count(*) from Pass where loghin='"+textBox1.Text+"' and passw='"+textBox2.Text+"'",connect);
            DataTable dt = new DataTable();
            scd.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            { Form1 s1 = new Form1(); this.Hide(); s1.Show(); }
            else { MessageBox.Show("Mai Incearca", "Logare"); }
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 s11 = new Form11();
            this.Hide();
            s11.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
