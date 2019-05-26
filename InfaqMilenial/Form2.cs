using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InfaqMilenial
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void infaqMingguanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void tabunganAkhiratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show(); 
        }

        private void donasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void modeAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void tambahSaldoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void tambahAkunToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void isiSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lewatPaypalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.MdiParent = this;
            frm8.Show();
        }

        private void lewatATMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.MdiParent = this;
            frm8.Show();
        }

        private void lewatAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silahkan masuk ke mode admin!");
        }

        private void cekSakdoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.MdiParent = this;
            frm9.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void infaqMingguanToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void infaqMingguanToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void tabunganAkhiratToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void tabunganAkhiratToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void donasiToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void donasiToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
