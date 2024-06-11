using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1.Views
{
    public partial class Beranda_Nasabah : Form
    {
        private Size formOriginalSize;
        private Dictionary<Control, Rectangle> controlOriginalRects = new Dictionary<Control, Rectangle>();

        public Beranda_Nasabah()
        {
            InitializeComponent();
            this.Resize += Beranda_Nasabah_Resize;

            formOriginalSize = this.Size;
            controlOriginalRects.Add(btnProfil, new Rectangle(btnProfil.Location, btnProfil.Size));
            controlOriginalRects.Add(btnSetorSampah, new Rectangle(btnSetorSampah.Location, btnSetorSampah.Size));
            controlOriginalRects.Add(btnRiwayatTransaksi, new Rectangle(btnRiwayatTransaksi.Location, btnRiwayatTransaksi.Size));
            controlOriginalRects.Add(btnInformasiSampah, new Rectangle(btnInformasiSampah.Location, btnInformasiSampah.Size));
            controlOriginalRects.Add(btnHapusAkun, new Rectangle(btnHapusAkun.Location, btnHapusAkun.Size));
            controlOriginalRects.Add(btnLogOut, new Rectangle(btnLogOut.Location, btnLogOut.Size));
        }

        private void Beranda_Nasabah_Resize(object sender, EventArgs e)
        {
            ResizeControl(btnProfil);
            ResizeControl(btnSetorSampah);
            ResizeControl(btnRiwayatTransaksi);
            ResizeControl(btnInformasiSampah);
            ResizeControl(btnHapusAkun);
            ResizeControl(btnLogOut);
        }

        private void ResizeControl(Control control)
        {
            float xRatio = (float)Width / formOriginalSize.Width;
            float yRatio = (float)Height / formOriginalSize.Height;

            Rectangle originalRect = controlOriginalRects[control];
            int newX = (int)(originalRect.X * xRatio);
            int newY = (int)(originalRect.Y * yRatio);
            int newWidth = (int)(originalRect.Width * xRatio);
            int newHeight = (int)(originalRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void btnProfil_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Profil_Nasabah nextpage = new Profil_Nasabah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnSetorSampah_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setor_Sampah nextpage = new Setor_Sampah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Riwayat_Nasbah nextpage = new Riwayat_Nasbah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnInformasiSampah_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informasi_Sampah nextpage = new Informasi_Sampah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnHapusAkun_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hapus_Akun_Nasabah nextpage = new Hapus_Akun_Nasabah();
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

        private void Beranda_Nasabah_Load(object sender, EventArgs e)
        {

        }
    }
}