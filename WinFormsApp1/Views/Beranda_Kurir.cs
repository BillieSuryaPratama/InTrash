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
    public partial class Beranda_Kurir : Form
    {
        public Beranda_Kurir()
        {
            InitializeComponent();
        }

        private void btnDaftarPenjemputan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alamat_Penjemputan nextpage = new Alamat_Penjemputan();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Opsi_Login nextpage = new Opsi_Login();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }
}
