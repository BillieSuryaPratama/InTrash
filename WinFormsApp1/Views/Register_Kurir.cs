using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using WinFormsApp1.Controllers;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace WinFormsApp1.Views
{
    public partial class Register_Kurir : Form
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

        public Register_Kurir()
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int IDTempatPengepul = Form_Login_Admin.IdTempatPengepul;

            if (string.IsNullOrWhiteSpace(tbNama.Text) ||
                string.IsNullOrWhiteSpace(tbUsername.Text) ||
                string.IsNullOrWhiteSpace(tbSandi.Text) ||
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
                                    FROM kurir 
                                    WHERE username_kurir = @username";
                using (var cmd = new NpgsqlCommand(queryCek, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("username", tbUsername.Text);
                    long usernameCount = (long)cmd.ExecuteScalar();

                    if (usernameCount > 0)
                    {
                        MessageBox.Show("Username sudah ada, silakan gunakan username lain!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string query = @"INSERT INTO Kurir (Nama_Kurir, Username_Kurir, Password_Kurir, No_HP, Id_TempatPengepul)
                                 VALUES (@nama, @username, @password, @nohp, @id_tempatpengepul)";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("nohp", tbNomorHP.Text);
                    cmd.Parameters.AddWithValue("username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("password", tbSandi.Text);
                    cmd.Parameters.AddWithValue("Id_tempatpengepul", IDTempatPengepul);

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
                Beranda_Admin nextpage = new Beranda_Admin();
                nextpage.FormClosed += (s, args) => this.Close();
                nextpage.ShowDialog();
            }
        }
    }
}
