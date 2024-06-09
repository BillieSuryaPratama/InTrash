using System;
using System.Windows.Forms;

namespace WinFormsApp1.Views
{
    public partial class Beranda_Nasabah : Form
    {
        public Beranda_Nasabah()
        {
            InitializeComponent();
        }

        private void Beranda_Nasabah_Load(object sender, EventArgs e)
        {

        }
        private void btnProfil_Click_1(object sender, EventArgs e)
        {
            Profil_Nasabah formProfil = new Profil_Nasabah();
            formProfil.ShowDialog();
        }

        private void btnSetorSampah_Click(object sender, EventArgs e)
        {
            Setor_Sampah formSetor = new Setor_Sampah();
            formSetor.ShowDialog();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            Riwayat_Nasbah formRiwayat = new Riwayat_Nasbah();
            formRiwayat.ShowDialog();
        }

        private void btnInformasiSampah_Click(object sender, EventArgs e)
        {
            Informasi_Sampah formInfo = new Informasi_Sampah();
            formInfo.ShowDialog();
        }

        private void btnHapusAkun_Click(object sender, EventArgs e)
        {
            Hapus_Akun_Nasabah formHapusAkun = new Hapus_Akun_Nasabah();
            formHapusAkun.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form_Login formLogin = new Form_Login();
            formLogin.Show();
            this.Close();
        }
    }
}