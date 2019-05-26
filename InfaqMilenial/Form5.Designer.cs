namespace InfaqMilenial
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tambahSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahAkunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahSaldoToolStripMenuItem,
            this.tambahAkunToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tambahSaldoToolStripMenuItem
            // 
            this.tambahSaldoToolStripMenuItem.Name = "tambahSaldoToolStripMenuItem";
            this.tambahSaldoToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.tambahSaldoToolStripMenuItem.Text = "Tambah Saldo";
            this.tambahSaldoToolStripMenuItem.Click += new System.EventHandler(this.tambahSaldoToolStripMenuItem_Click);
            // 
            // tambahAkunToolStripMenuItem
            // 
            this.tambahAkunToolStripMenuItem.Name = "tambahAkunToolStripMenuItem";
            this.tambahAkunToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.tambahAkunToolStripMenuItem.Text = "Tambah Akun";
            this.tambahAkunToolStripMenuItem.Click += new System.EventHandler(this.tambahAkunToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mode Admin";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tambahSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahAkunToolStripMenuItem;


    }
}