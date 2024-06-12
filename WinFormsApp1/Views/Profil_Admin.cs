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
    public partial class Profil_Admin : Form
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

        private bool IsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public Profil_Admin()
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

        private void Profil_Admin_Load(object sender, EventArgs e)
        {
            string Username = Form_Login_Admin.UsernameLogin;
            string Password = Form_Login_Admin.PasswordLogin;
            try
            {
                DBConnection.openConn();
                string query = @"SELECT atp.nama_admin, atp.username_admin, atp.Alamat, atp.No_hp, tp.nama_tempat
                                 FROM admin_tempat_pengepul atp
                                 JOIN TempatPengepul tp on atp.id_tempatpengepul = tp.id_tempatpengepul
                                 WHERE username_admin = @Username AND password_admin = @Password";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tbNama.Text = reader["nama_admin"].ToString();
                            tbUsername.Text = reader["username_admin"].ToString();
                            tbalamat.Text = reader["Alamat"].ToString();
                            tbnoHP.Text = reader["No_hp"].ToString();
                            tbtempatpengepul.Text = reader["nama_tempat"].ToString();
                        }
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
        }

        private void btnUbahSandi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ganti_Sandi_Admin nextpage = new Ganti_Sandi_Admin();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string Username = Form_Login_Admin.UsernameLogin;
            string Password = Form_Login_Admin.PasswordLogin;
            int idAdmin = GetIdAdmin(Username, Password);

            Form_Login_Admin.UpdateUsername(tbUsername.Text);

            if (string.IsNullOrWhiteSpace(tbNama.Text) ||
                string.IsNullOrWhiteSpace(tbUsername.Text) ||
                string.IsNullOrWhiteSpace(tbalamat.Text) ||
                string.IsNullOrWhiteSpace(tbnoHP.Text))
            {
                MessageBox.Show("Terdapat data kosong!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsNumeric(tbnoHP.Text))
            {
                MessageBox.Show("Nomor telepon hanya boleh mengandung angka!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DBConnection.openConn();

                string queryCek = @"SELECT COUNT(*) 
                                    FROM admin_tempat_pengepul
                                    WHERE (nama_admin ILIKE @NamaAdmin OR no_hp = @NomorHP OR username_admin ILIKE @UsernameAdmin) 
                                    AND id_admin != @IDAdmin";

                using (var cmd = new NpgsqlCommand(queryCek, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("NamaAdmin", tbNama.Text);
                    cmd.Parameters.AddWithValue("NomorHP", tbnoHP.Text);
                    cmd.Parameters.AddWithValue("UsernameAdmin", tbUsername.Text);
                    cmd.Parameters.AddWithValue("IDAdmin", idAdmin);

                    long count = (long)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Nama, nomor telepon, atau username sudah ada di database!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string query = @"UPDATE admin_tempat_pengepul
                                 SET nama_admin = @Nama, username_admin = @Username, no_hp = @nohp, alamat = @alamat
                                 WHERE id_admin = @IDKurir";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("Nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("Username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("nohp", tbnoHP.Text);
                    cmd.Parameters.AddWithValue("alamat", tbalamat.Text);
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
                DBConnection.closeConn();
                this.Hide();
                Beranda_Admin nextpage = new Beranda_Admin();
                nextpage.FormClosed += (s, args) => this.Close();
                nextpage.ShowDialog();
            }
        }
    }
}
