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
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8U9MFQK\SQLEXPRESS;Initial Catalog=login_tb;database=login_db;integrated security=True");
        //koneksi konn = new koneksi();
        public Form6()
        {
            InitializeComponent();
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = "OTOMATIS";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO login_tb (username,password,norekening,Asal,Kelamin,Agama,Lahir) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("berhasil di tambahkan");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM login_tb";
            SqlDataAdapter SDA = new SqlDataAdapter (query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE login_tb SET username = '" + textBox2.Text + "',password='" + textBox3.Text + "',norekening='" + textBox4.Text + "',Asal='" + textBox5.Text + "',Kelamin='" + comboBox1.Text + "',Agama='" + comboBox2.Text + "',Lahir='" + dateTimePicker1.Text + "'WHERE ID ='" + textBox1.Text+ "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Berhasil");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM login_tb where ID = '" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Berhasil di hapus!");
        }

    }
}
