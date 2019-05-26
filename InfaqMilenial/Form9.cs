using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InfaqMilenial
{
    public partial class Form9 : Form
    {
        string namauser = Form1.username;
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = @"Data Source=DESKTOP-8U9MFQK\SQLEXPRESS;Initial Catalog=login_tb;database=login_db;integrated security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            MessageBox.Show("Berhasil ditemukan");

            string sqlSelectQuery = "SELECT * FROM login_tb WHERE username = '" + namauser + "'";
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            textBox1.Text = (dr["ID"].ToString());
            textBox2.Text = namauser;
            textBox3.Text = (dr["norekening"].ToString());
            textBox4.Text = (dr["Asal"].ToString());
            textBox5.Text = (dr["Kelamin"].ToString());
            textBox6.Text = (dr["Agama"].ToString());
            textBox7.Text = (dr["Lahir"].ToString());
            textBox8.Text = (dr["Saldo"].ToString());
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
