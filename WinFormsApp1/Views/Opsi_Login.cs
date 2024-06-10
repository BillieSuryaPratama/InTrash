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
    public partial class Opsi_Login : Form
    {
        public Opsi_Login()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login_Admin nextpage = new Form_Login_Admin();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnNasabah_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login_Nasabah nextpage = new Form_Login_Nasabah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnKurir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login_Kurir nextpage = new Form_Login_Kurir();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }
}
