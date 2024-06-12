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
    public partial class Edit_Kurir : Form
    {
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

        public Edit_Kurir()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atur_Akun_Kurir nextpage = new Atur_Akun_Kurir();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void Edit_Kurir_Load(object sender, EventArgs e)
        {
            int ID_Kurir = Atur_Akun_Kurir.ID_Kurir;
            try
            {
                DBConnection.openConn();
                string query = @"SELECT nama_kurir, username_kurir, password_kurir, no_hp
                                 FROM kurir
                                 WHERE id_kurir = @IDKurir";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("IDKurir", ID_Kurir);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tbNama.Text = reader["nama_kurir"].ToString();
                            tbNomorHP.Text = reader["no_hp"].ToString();
                            tbUsername.Text = reader["username_kurir"].ToString();
                            tbSandi.Text = reader["password_kurir"].ToString();
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int ID_Kurir = Atur_Akun_Kurir.ID_Kurir;
            if (string.IsNullOrWhiteSpace(tbNama.Text) ||
                string.IsNullOrWhiteSpace(tbNomorHP.Text) ||
                string.IsNullOrWhiteSpace(tbUsername.Text) ||
                string.IsNullOrWhiteSpace(tbSandi.Text))
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
                                    FROM kurir
                                    WHERE (nama_kurir ILIKE @NamaKurir OR no_hp = @NomorHP OR username_kurir ILIKE @UsernameKurir) 
                                    AND id_kurir != @IDKurir";

                using (var cmd = new NpgsqlCommand(queryCek, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("NamaKurir", tbNama.Text);
                    cmd.Parameters.AddWithValue("NomorHP", tbNomorHP.Text);
                    cmd.Parameters.AddWithValue("UsernameKurir", tbUsername.Text);
                    cmd.Parameters.AddWithValue("IDKurir", ID_Kurir);

                    long count = (long)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Nama, nomor telepon, atau username sudah ada di database!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string query = @"UPDATE kurir
                                 SET nama_kurir = @NamaKurir, username_kurir = @UsernameKurir, password_kurir = @PasswordKurir, no_hp = @NomorHP
                                 WHERE id_kurir = @IDKurir";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("NamaKurir", tbNama.Text);
                    cmd.Parameters.AddWithValue("UsernameKurir", tbUsername.Text);
                    cmd.Parameters.AddWithValue("PasswordKurir", tbSandi.Text);
                    cmd.Parameters.AddWithValue("NomorHP", tbNomorHP.Text);
                    cmd.Parameters.AddWithValue("IDKurir", ID_Kurir);

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
                Atur_Akun_Kurir nextpage = new Atur_Akun_Kurir();
                nextpage.FormClosed += (s, args) => this.Close();
                nextpage.ShowDialog();
            }
        }
    }
}
