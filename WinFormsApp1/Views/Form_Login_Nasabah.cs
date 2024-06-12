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

namespace WinFormsApp1.Views
{
    public partial class Form_Login_Nasabah : Form
    {
        public static string UsernameLogin { get; private set; }
        public static string PasswordLogin { get; private set; }

        public Form_Login_Nasabah()
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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            DBConnection.openConn();
            string query = @"SELECT COUNT (*)
                             FROM Customer
                             WHERE Username_Customer = @Username and Password_Customer = @Password";
            using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
            {
                cmd.Parameters.AddWithValue("username", tbUsername.Text);
                cmd.Parameters.AddWithValue("password", tbPassword.Text);
                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (userCount == 1)
                {

                    UsernameLogin = tbUsername.Text;
                    PasswordLogin = tbPassword.Text;

                    this.Hide();
                    Beranda_Nasabah nextpage = new Beranda_Nasabah();
                    nextpage.FormClosed += (s, args) => this.Close();
                    nextpage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mohon isi Username dan Password anda dengan Benar!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DBConnection.closeConn();
            }
        }

        private void btnLupaPassword_Click(object sender, EventArgs e)
        {
            DBConnection.openConn();
            string query = @"SELECT COUNT (*)
            FROM customer
            WHERE Username_customer = @Username";
            using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
            {
                cmd.Parameters.AddWithValue("username", tbUsername.Text);
                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (userCount == 1)
                {
                    // Mengubah query untuk mengambil kolom lain selain COUNT(*)
                    string dataQuery = @"SELECT * FROM customer WHERE Username_customer = @Username";
                    using (var dataCmd = new NpgsqlCommand(dataQuery, DBConnection.connection))
                    {
                        dataCmd.Parameters.AddWithValue("username", tbUsername.Text);
                        using (var reader = dataCmd.ExecuteReader())
                        {
                            if (reader.Read()) // Jika ada baris yang terbaca
                            {
                                // Ambil nilai dari kolom yang diinginkan
                                string id_customer = reader["id_customer"].ToString();
                                // Lakukan sesuatu dengan nilai yang diambil
                                Console.WriteLine($"Nama Customer: {id_customer}");

                                // Hide current form and open Verifikasi_NoHP form
                                this.Hide();
                                Verifikasi_NoHP nextpage = new Verifikasi_NoHP("nasabah", id_customer, reader["no_hp"].ToString());
                                nextpage.FormClosed += (s, args) => this.Close();
                                nextpage.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Username tidak ditemukan!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mohon isi Username untuk melanjutkan Lupa password!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DBConnection.closeConn();
            }
        }

        private void Form_Login_Nasabah_Load(object sender, EventArgs e)
        {

        }
    }
}
