using Npgsql;
using System;
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
    public partial class Hapus_Akun_Admin : Form
    {
        public Hapus_Akun_Admin()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beranda_Admin nextpage = new Beranda_Admin();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            string enteredPassword = tbSandi.Text;
            string username = Form_Login_Admin.UsernameLogin;
            string Password = Form_Login_Admin.PasswordLogin;

            if (enteredPassword == Password)
            {
                try
                {
                    DBConnection.openConn();

                    string deleteQuery = @"DELETE FROM admin_tempat_pengepul 
                                           WHERE username_admin = @Username";

                    using (var cmd = new NpgsqlCommand(deleteQuery, DBConnection.connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Akun berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Opsi_Login nextpage = new Opsi_Login();
                            nextpage.FormClosed += (s, args) => this.Close();
                            nextpage.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus akun. Akun mungkin tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DBConnection.closeConn();
                }
            }
            else
            {
                MessageBox.Show("Sandi yang dimasukkan salah.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
