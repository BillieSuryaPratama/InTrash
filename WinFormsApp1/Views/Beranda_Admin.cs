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
    public partial class Beranda_Admin : Form
    {
        public Beranda_Admin()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Opsi_Login nextpage = new Opsi_Login();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profil_Admin nextpage = new Profil_Admin();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnReward_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reward_Admin nextpage = new Reward_Admin();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnJemputSampah_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jemput_Sampah nextpage = new Jemput_Sampah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Riwayat_Admin nextpage = new Riwayat_Admin();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnDaftarkanKurir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Kurir nextpage = new Register_Kurir();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnEditKurir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atur_Akun_Kurir nextpage = new Atur_Akun_Kurir();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnEditSampah_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atur_Jenis_Sampah nextpage = new Atur_Jenis_Sampah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnHapusAkun_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hapus_Akun_Admin nextpage = new Hapus_Akun_Admin();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }
}
