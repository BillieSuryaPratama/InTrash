using Npgsql;
using System.Data;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class Form_Login_Kurir : Form
    {
        public static string UsernameLogin { get; private set; }
        public static string PasswordLogin { get; private set; }
        public static int IdTempatPengepul { get; private set; }

        public static void UpdateUsername(string UsernameBaru)
        {
            UsernameLogin = UsernameBaru;
        }

        public static void UpdatePassword(string PasswordBaru)
        {
            PasswordLogin = PasswordBaru;
        }

        public Form_Login_Kurir()
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
            string query = @"SELECT id_kurir
                             FROM kurir
                             WHERE Username_Kurir = @Username AND Password_Kurir = @Password";
            using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
            {
                cmd.Parameters.AddWithValue("Username", tbUsername.Text);
                cmd.Parameters.AddWithValue("Password", tbPassword.Text);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    IdTempatPengepul = Convert.ToInt32(result);
                    UsernameLogin = tbUsername.Text;
                    PasswordLogin = tbPassword.Text;

                    this.Hide();
                    Beranda_Kurir nextpage = new Beranda_Kurir();
                    nextpage.FormClosed += (s, args) => this.Close();
                    nextpage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mohon isi Username dan Password anda dengan Benar!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DBConnection.closeConn();
        }

        private void btnLupaPassword_Click(object sender, EventArgs e)
        {
            DBConnection.openConn();
            string query = @"SELECT COUNT (*)
            FROM kurir
            WHERE Username_kurir = @Username";
            using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
            {
                cmd.Parameters.AddWithValue("username", tbUsername.Text);
                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (userCount == 1)
                {
                    // Mengubah query untuk mengambil kolom lain selain COUNT(*)
                    string dataQuery = @"SELECT * FROM kurir WHERE Username_Kurir = @Username";
                    using (var dataCmd = new NpgsqlCommand(dataQuery, DBConnection.connection))
                    {
                        dataCmd.Parameters.AddWithValue("username", tbUsername.Text);
                        using (var reader = dataCmd.ExecuteReader())
                        {
                            if (reader.Read()) // Jika ada baris yang terbaca
                            {
                                // Ambil nilai dari kolom yang diinginkan
                                string id_kurir = reader["id_kurir"].ToString();
                                // Lakukan sesuatu dengan nilai yang diambil
                                Console.WriteLine($"Nama kurir: {id_kurir}");

                                // Hide current form and open Verifikasi_NoHP form
                                this.Hide();
                                Verifikasi_NoHP nextpage = new Verifikasi_NoHP("kurir", id_kurir, reader["no_hp"].ToString());
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
    }
}
