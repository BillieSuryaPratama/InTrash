using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class Verifikasi_NoHP : Form
    {
        private String mode,
            id_akun,
            no_hp;

        public Verifikasi_NoHP(String mode, String id_akun, String no_hp)
        {
            this.no_hp = no_hp;
            this.mode = mode;
            this.id_akun = id_akun;
            InitializeComponent();
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "admin":
                    this.Hide();
                    Form_Login_Admin admin = new Form_Login_Admin();
                    admin.FormClosed += (s, args) => this.Close();
                    admin.ShowDialog();
                    break;
                case "kurir":
                    this.Hide();
                    Form_Login_Kurir kurir = new Form_Login_Kurir();
                    kurir.FormClosed += (s, args) => this.Close();
                    kurir.ShowDialog();
                    break;
                case "nasabah":
                    this.Hide();
                    Form_Login_Nasabah nasabah = new Form_Login_Nasabah();
                    nasabah.FormClosed += (s, args) => this.Close();
                    nasabah.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void btnBerikutnya_Click(object sender, EventArgs e)
        {
            if (!tbNomorHP.Text.Equals(""))
            {
                switch (mode)
                {
                    case "admin":
                        if (no_hp == tbNomorHP.Text)
                        {
                            MessageBox.Show(
                                "Verifikasi Nomor Handphone berhasil!",
                                "Informasi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            this.Hide();
                            Lupa_Password_Admin admin = new Lupa_Password_Admin(id_akun);
                            admin.FormClosed += (s, args) => this.Close();
                            admin.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Nomor Handphone salah!",
                                "Perhatian",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                        break;
                    case "kurir":
                        if (no_hp == tbNomorHP.Text)
                        {
                            MessageBox.Show(
                                "Verifikasi Nomor Handphone berhasil!",
                                "Informasi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            this.Hide();
                            Lupa_Password_Kurir kurir = new Lupa_Password_Kurir(id_akun);
                            kurir.FormClosed += (s, args) => this.Close();
                            kurir.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Nomor Handphone salah!",
                                "Perhatian",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                        break;
                    case "nasabah":
                        if (no_hp == tbNomorHP.Text)
                        {
                            MessageBox.Show(
                                "Verifikasi Nomor Handphone berhasil!",
                                "Informasi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            this.Hide();
                            Lupa_Password_Nasabah nasabah = new Lupa_Password_Nasabah(id_akun);
                            nasabah.FormClosed += (s, args) => this.Close();
                            nasabah.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Nomor Handphone salah!",
                                "Perhatian",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                        break;
                    default:
                        MessageBox.Show(
                            "Masukkan password baru!",
                            "Perhatian",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        break;
                }
            }else
            {
                MessageBox.Show(
                    "Nomor Handphone belum di isi!",
                    "Perhatian",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
