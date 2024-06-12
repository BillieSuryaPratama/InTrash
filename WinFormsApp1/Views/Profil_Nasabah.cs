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
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class Profil_Nasabah : Form
    {
        private int GetIdNasabah(string username, string password)
        {
            int idNasabah = -1;

            try
            {
                DBConnection.openConn();
                string query = @"SELECT id_customer
                         FROM customer
                         WHERE username_customer = @Username AND password_customer = @Password";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Username", NpgsqlTypes.NpgsqlDbType.Varchar, username);
                    cmd.Parameters.AddWithValue("@Password", NpgsqlTypes.NpgsqlDbType.Varchar, password);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        idNasabah = Convert.ToInt32(result);
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

            return idNasabah;
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
        public Profil_Nasabah()
        {
            InitializeComponent();
        }
        private void Profil_Nasabah_Load(object sender, EventArgs e)
        {
            string Username = Form_Login_Nasabah.UsernameLogin;
            string Password = Form_Login_Nasabah.PasswordLogin;
            try
            {
                DBConnection.openConn();
                string query = @"SELECT *
                                 FROM Customer
                                 WHERE Username_Customer = @Username AND Password_Customer = @Password";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tbNama.Text = reader["Nama_Customer"].ToString();
                            tbUsername.Text = reader["Username_Customer"].ToString();
                            tbNomorHP.Text = reader["No_hp"].ToString();
                            tbAlamat.Text = reader["Alamat"].ToString();
                            tbSaldo.Text = reader["Saldo"].ToString();
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
        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beranda_Nasabah nextpage = new Beranda_Nasabah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnUbahSandi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ganti_Sandi nextpage = new Ganti_Sandi();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string Username = Form_Login_Nasabah.UsernameLogin;
            string Password = Form_Login_Nasabah.PasswordLogin;
            int idNasabah = GetIdNasabah(Username, Password);

            if (string.IsNullOrWhiteSpace(tbNama.Text) ||
                string.IsNullOrWhiteSpace(tbUsername.Text) ||
                string.IsNullOrWhiteSpace(tbAlamat.Text) ||
                string.IsNullOrWhiteSpace(tbNomorHP.Text))
            {
                MessageBox.Show("Terdapat data kosong!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsNumeric(tbNomorHP.Text))
            {
                MessageBox.Show("Nomor telepon hanya boleh mengandung angka!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DBConnection.openConn();

                string queryCek = @"SELECT COUNT(*) 
                            FROM customer
                            WHERE (nama_customer ILIKE @NamaCustomer OR no_hp = @NomorHP OR username_customer ILIKE @Username) 
                            AND id_customer != @idNasabah";

                using (var cmd = new NpgsqlCommand(queryCek, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("NamaCustomer", NpgsqlTypes.NpgsqlDbType.Varchar, tbNama.Text);
                    cmd.Parameters.AddWithValue("NomorHP", NpgsqlTypes.NpgsqlDbType.Varchar, tbNomorHP.Text);
                    cmd.Parameters.AddWithValue("Username", NpgsqlTypes.NpgsqlDbType.Varchar, tbUsername.Text);
                    cmd.Parameters.AddWithValue("idNasabah", NpgsqlTypes.NpgsqlDbType.Integer, idNasabah);

                    long count = (long)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Nama, nomor telepon, atau username sudah ada di database!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string query = @"UPDATE customer
                         SET nama_customer = @NamaCustomer, username_customer = @Username, no_hp = @NomorHP, alamat = @Alamat
                         WHERE id_customer = @idNasabah";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("NamaCustomer", NpgsqlTypes.NpgsqlDbType.Varchar, tbNama.Text);
                    cmd.Parameters.AddWithValue("Username", NpgsqlTypes.NpgsqlDbType.Varchar, tbUsername.Text);
                    cmd.Parameters.AddWithValue("NomorHP", NpgsqlTypes.NpgsqlDbType.Varchar, tbNomorHP.Text);
                    cmd.Parameters.AddWithValue("Alamat", NpgsqlTypes.NpgsqlDbType.Varchar, tbAlamat.Text);
                    cmd.Parameters.AddWithValue("idNasabah", NpgsqlTypes.NpgsqlDbType.Integer, idNasabah);

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
            }
        }
    }
}