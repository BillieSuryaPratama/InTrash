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

            // Simpan ukuran dan posisi awal semua kontrol
            foreach (Control control in this.Controls)
            {
                if (control is Button || control is Label) // Hanya tombol dan label yang akan di-resize
                {
                    controlOriginalRects.Add(control, new Rectangle(control.Location, control.Size));
                }
            }
        }

        private void Beranda_Nasabah_Resize(object sender, EventArgs e)
        {
            // Iterasi melalui semua kontrol dan resize yang diperlukan
            foreach (var entry in controlOriginalRects)
            {
                ResizeControl(entry.Key, entry.Value);
            }
        }

        private void ResizeControl(Control control, Rectangle originalRect)
        {
            float xRatio = (float)this.Width / (float)formOriginalSize.Width;
            float yRatio = (float)this.Height / (float)formOriginalSize.Height;

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

        private void buttonPencairanSaldo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 nextpage = new Form1();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }
}
