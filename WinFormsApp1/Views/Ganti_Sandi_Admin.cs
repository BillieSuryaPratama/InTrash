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
using WinFormsApp1.Models;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class Ganti_Sandi_Admin : Form
    {
        private int GetIdAdmin(string username, string password)
        {
            int idAdmin = -1;

            try
            {
                DBConnection.openConn();
                string query = @"SELECT id_admin
                                 FROM admin_tempat_pengepul
                                 WHERE username_admin = @Username AND password_admin = @Password";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        idAdmin = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nDetail: {ex.StackTrace}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeConn();
            }

            return idAdmin;
        }

        public Ganti_Sandi_Admin()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profil_Admin nextpage = new Profil_Admin();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string Username = Form_Login_Admin.UsernameLogin;
            string Password = Form_Login_Admin.PasswordLogin;
            int idAdmin = GetIdAdmin(Username, Password);

            if (string.IsNullOrWhiteSpace(tbPassLama.Text) ||
               string.IsNullOrWhiteSpace(tbPassBaru.Text) ||
               string.IsNullOrWhiteSpace(tbPassBaru2.Text))
            {
                MessageBox.Show("Terdapat data kosong!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if ((tbPassBaru.Text) != (tbPassBaru2.Text))
            {
                MessageBox.Show("Sandi tidak cocok. Silakan coba lagi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((tbPassLama.Text) != Password)
            {
                MessageBox.Show("Sandi saat ini tidak sesuai. Silakan coba lagi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DBConnection.openConn();

                string query = @"UPDATE admin_tempat_pengepul
                                 SET password_admin = @Password
                                 WHERE id_admin = @IDKurir";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("Password", tbPassBaru.Text);
                    cmd.Parameters.AddWithValue("IDKurir", idAdmin);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil diupdate!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengupdate data!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Form_Login_Admin.UpdatePassword(tbPassBaru.Text);
                DBConnection.closeConn();
                this.Hide();
                Beranda_Admin nextpage = new Beranda_Admin();
                nextpage.FormClosed += (s, args) => this.Close();
                nextpage.ShowDialog();
            }
        }
    }
}
