using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Views
{
    public partial class Profil_Nasabah : Form
    {
        public Profil_Nasabah()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beranda_Nasabah nextpage = new Beranda_Nasabah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnUbahSandi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ganti_Sandi nextpage = new Ganti_Sandi();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }
}
