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
    public partial class Edit_Jenis_Sampah : Form
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

        public Edit_Jenis_Sampah()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atur_Jenis_Sampah nextpage = new Atur_Jenis_Sampah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void Edit_Jenis_Sampah_Load(object sender, EventArgs e)
        {
            int IDSampah = Atur_Jenis_Sampah.ID_Sampah;
            if (IDSampah > 0)
            {
                try
                {
                    DBConnection.openConn();
                    string query = @"SELECT nama_jenis_sampah, nama_jenis_sampah, harga, deskripsi
                                     FROM jenis_sampah
                                     WHERE id_jenis_sampah = @IDSampah";
                    using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                    {
                        cmd.Parameters.AddWithValue("IDSampah", IDSampah);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tbJenisSampah.Text = reader["nama_jenis_sampah"].ToString();
                                tbHarga.Text = reader["harga"].ToString();
                                tbDeskripsi.Text = reader["deskripsi"].ToString();
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
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int IDSampah = Atur_Jenis_Sampah.ID_Sampah;
            if (IDSampah > 0)
            {
                if (string.IsNullOrWhiteSpace(tbJenisSampah.Text) ||
                    string.IsNullOrWhiteSpace(tbHarga.Text))
                {
                    MessageBox.Show("Terdapat data kosong!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsNumeric(tbHarga.Text))
                {
                    MessageBox.Show("Nomor telepon hanya boleh mengandung angka!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    DBConnection.openConn();

                    string queryCek = @"SELECT COUNT(*) 
                                        FROM jenis_sampah 
                                        WHERE nama_jenis_sampah ILIKE @JenisSampah AND id_jenis_sampah != @IDSampah";
                    using (var cmd = new NpgsqlCommand(queryCek, DBConnection.connection))
                    {
                        cmd.Parameters.AddWithValue("JenisSampah", tbJenisSampah.Text);
                        cmd.Parameters.AddWithValue("IDSampah", IDSampah);
                        long usernameCount = (long)cmd.ExecuteScalar();

                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Data Sampah sudah ada!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string query = @"UPDATE jenis_sampah
                                     SET Harga = @Harga, Deskripsi = @Deskripsi, Nama_Jenis_Sampah = @JenisSampah
                                     WHERE id_jenis_sampah = @IDSampah";

                    using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                    {
                        cmd.Parameters.AddWithValue("JenisSampah", tbJenisSampah.Text);
                        cmd.Parameters.AddWithValue("Harga", Convert.ToInt32(tbHarga.Text));
                        cmd.Parameters.AddWithValue("Deskripsi", tbDeskripsi.Text);
                        cmd.Parameters.AddWithValue("IDSampah", IDSampah);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan data!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Atur_Jenis_Sampah nextpage = new Atur_Jenis_Sampah();
                    nextpage.FormClosed += (s, args) => this.Close();
                    nextpage.ShowDialog();
                }
            }

            else
            {
                if (string.IsNullOrWhiteSpace(tbJenisSampah.Text) ||
                    string.IsNullOrWhiteSpace(tbHarga.Text))
                {
                    MessageBox.Show("Terdapat data kosong!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsNumeric(tbHarga.Text))
                {
                    MessageBox.Show("Nomor telepon hanya boleh mengandung angka!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    DBConnection.openConn();

                    string queryCek = @"SELECT COUNT(*) 
                                        FROM jenis_sampah 
                                        WHERE nama_jenis_sampah ILIKE @JenisSampah";
                    using (var cmd = new NpgsqlCommand(queryCek, DBConnection.connection))
                    {
                        cmd.Parameters.AddWithValue("JenisSampah", tbJenisSampah.Text);
                        long usernameCount = (long)cmd.ExecuteScalar();

                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Data Sampah sudah ada!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string query = @"INSERT INTO jenis_sampah (Nama_Jenis_Sampah, Harga, Deskripsi)
                                     VALUES (@JenisSampah, @Harga, @Deskripsi)";

                    using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                    {
                        cmd.Parameters.AddWithValue("JenisSampah", tbJenisSampah.Text);
                        cmd.Parameters.AddWithValue("Harga", Convert.ToInt32(tbHarga.Text));
                        cmd.Parameters.AddWithValue("Deskripsi", tbDeskripsi.Text);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan data!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Atur_Jenis_Sampah nextpage = new Atur_Jenis_Sampah();
                    nextpage.FormClosed += (s, args) => this.Close();
                    nextpage.ShowDialog();
                }
            }
        }
    }
}
