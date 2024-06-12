using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class Ganti_Sandi : Form
    {
        public Ganti_Sandi()
        {
            InitializeComponent();

            btnSimpan.Click += btnSimpan_Click;

        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Mendapatkan nilai dari TextBox
            string sandiSaatIni = sandiSaatIniTextBox.Text;
            string sandiBaru = sandiBaruTextBox.Text;
            string konfirmasiSandi = konfirmasiSandiTextBox.Text;

            // Memverifikasi bahwa sandi baru dan konfirmasi sandi cocok
            if (sandiBaru != konfirmasiSandi)
            {
                MessageBox.Show("Sandi baru dan konfirmasi sandi tidak cocok.");
                return;
            }

            // Memperbarui kata sandi di database
            UpdatePassword(sandiSaatIni, sandiBaru);
        }

        private void UpdatePassword(string sandiSaatIni, string sandiBaru)
        {
            DBConnection.openConn();
            string username = Form_Login_Nasabah.UsernameLogin;
            string queryCheck = "SELECT COUNT(*) FROM Customer WHERE username_customer = @username AND password_customer = @sandiSaatIni";
            string queryUpdate = "UPDATE Customer SET password_customer = @sandiBaru WHERE username_customer = @username";

            try
            {
                {
                    // Memverifikasi sandi saat ini
                    using (var cmd = new NpgsqlCommand(queryCheck, DBConnection.connection))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("sandiSaatIni", sandiSaatIni);

                        // Menggunakan Convert.ToInt64
                        long userCount = Convert.ToInt64(cmd.ExecuteScalar());
                        if (userCount == 0)
                        {
                            MessageBox.Show("Sandi saat ini tidak benar.");
                            return;
                        }
                    }

                    // Memperbarui sandi baru
                    using (var commandUpdate = new NpgsqlCommand(queryUpdate, DBConnection.connection))
                    {
                        commandUpdate.Parameters.AddWithValue("username", username);
                        commandUpdate.Parameters.AddWithValue("sandiBaru", sandiBaru);

                        commandUpdate.ExecuteNonQuery();
                        MessageBox.Show("Sandi berhasil diperbarui.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profil_Nasabah nextpage = new Profil_Nasabah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }
}
