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
    public partial class Form3 : Form
    {
        public static Int32 SaldoAwal;
        string namauser = Form1.username;

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8U9MFQK\SQLEXPRESS;Initial Catalog=login_tb;database=login_db;integrated security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE login_tb SET Saldo = '" + (SaldoAwal - Int32.Parse(textBox1.Text)) +  "'WHERE username ='" + namauser + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Terimakasih, semoga bisa menjadi tabunganmu di akhirat");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT Saldo FROM login_tb WHERE username = '"+namauser+"'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            con.Close();

            DataTable dt = new DataTable();
            SDA.Fill(dt);
            SaldoAwal = Int32.Parse(dt.Rows[0][0].ToString());
            
        }
    }
}
