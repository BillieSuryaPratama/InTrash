using Npgsql;
using System.Data;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class Form_Login_Admin : Form
    {
        public static string UsernameLogin { get; private set; }
        public static string PasswordLogin { get; private set; }

        public Form_Login_Admin()
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
            DataTable dt = new DataTable();
            DBConnection.openConn();
            string query = @"SELECT COUNT (*)
                            FROM Admin_Tempat_Pengepul
                            WHERE Username_Admin = @Username and Password_Admin = @Password";
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
                    Beranda_Admin nextpage = new Beranda_Admin();
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
            this.Hide();
            Lupa_Password_Admin nextpage = new Lupa_Password_Admin();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }
}
