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
    public partial class Form4 : Form
    {
        static int kesempatan = 5;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kesempatan == 0)
            {
                label3.Text = ("Kesempatan masuk sudah habis, Mohon maaf");
                return;
            }
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=DESKTOP-8U9MFQK\SQLEXPRESS;Initial Catalog=login;database=login_adm;integrated security=SSPI";
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from login where username=@usr and password=@pwd", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", textBox1.Text);
            scmd.Parameters.AddWithValue("@pwd", textBox2.Text);
            scn.Open();

            if (scmd.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("Anda telah masuk mode admin");
                Form5 frm5 = new Form5();
                frm5.Show();
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
        }
    }
}
