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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using WinFormsApp1.Models;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class Register_Nasabah : Form
    {
        public Register_Nasabah()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Opsi_Login nextpage = new Opsi_Login();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNama.Text) ||
                string.IsNullOrWhiteSpace(tbUserName.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text) ||
                string.IsNullOrWhiteSpace(tbNoHP.Text) ||
                string.IsNullOrWhiteSpace(tbAlamat.Text))
            {
                MessageBox.Show("Semua data harus diisi!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DBConnection.openConn();

                string checkUsernameQuery = @"SELECT COUNT(*) FROM customer WHERE username_customer = @username";
                using (var cmdCheck = new NpgsqlCommand(checkUsernameQuery, DBConnection.connection))
                {
                    cmdCheck.Parameters.AddWithValue("username", tbUserName.Text);
                    long usernameCount = (long)cmdCheck.ExecuteScalar();

                    if (usernameCount > 0)
                    {
                        MessageBox.Show("Username sudah ada, silakan gunakan username lain!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

                string query = @"INSERT INTO customer (nama_customer, username_customer, password_customer, no_hp, alamat, saldo)
                                     VALUES (@nama, @username, @password, @no_hp, @alamat, @saldo)";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("username", tbUserName.Text);
                    cmd.Parameters.AddWithValue("password", tbPassword.Text);
                    cmd.Parameters.AddWithValue("no_hp", tbNoHP.Text);
                    cmd.Parameters.AddWithValue("alamat", tbAlamat.Text);
                    cmd.Parameters.AddWithValue("saldo", 0);

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
                Opsi_Login nextpage = new Opsi_Login();
                nextpage.FormClosed += (s, args) => this.Close();
                nextpage.ShowDialog();
            }

        }
    }
}
