using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace InfaqMilenial
{
    public partial class Form1 : Form
    {
        public static string username = "";
        static int kesempatan = 5;
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(7600);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new splashscreen());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kesempatan == 0)
            {
                label3.Text = ("Kesempatan masuk sudah habis, Silakan hubungi admin!");
                return;
            }
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=DESKTOP-8U9MFQK\SQLEXPRESS;Initial Catalog=login_tb;database=login_db;integrated security=SSPI";
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from login_tb where username=@usr and password=@pwd", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", textBox1.Text);
            scmd.Parameters.AddWithValue("@pwd", textBox2.Text);
            scn.Open();

            if (scmd.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("Kamu berhasil masuk");
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Visible = false;
            }

            else
            {
                MessageBox.Show("Kamu gagal masuk");
                label3.Text = ("Kamu hanya punya " + Convert.ToString(kesempatan) + " kesempatan mencoba");
                --kesempatan;
                textBox1.Clear();
                textBox2.Clear();
            }
            scn.Close();

            username = textBox1.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
