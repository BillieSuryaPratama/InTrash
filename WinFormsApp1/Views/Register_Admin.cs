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
    public partial class Register_Admin : Form
    {
        public Register_Admin()
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
                string.IsNullOrWhiteSpace(tbAlamat.Text) ||
                string.IsNullOrWhiteSpace(tbNoHP.Text) ||
                cbTempatPengepul.SelectedValue == null)
            {
                MessageBox.Show("Semua data harus diisi!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                DBConnection.openConn();

                string checkUsernameQuery = @"SELECT COUNT(*) FROM admin_tempat_pengepul WHERE username_admin = @username";
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

                string query = @"INSERT INTO admin_tempat_pengepul (nama_admin, username_admin, password_admin, alamat, no_hp, id_tempatpengepul)
                                 VALUES (@nama, @username, @password, @alamat, @no_hp, @id_tempatpengepul)";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("username", tbUserName.Text);
                    cmd.Parameters.AddWithValue("password", tbPassword.Text);
                    cmd.Parameters.AddWithValue("alamat", tbAlamat.Text);
                    cmd.Parameters.AddWithValue("no_hp", tbNoHP.Text);
                    cmd.Parameters.AddWithValue("id_tempatpengepul", (int)cbTempatPengepul.SelectedValue);

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

        private void Register_Admin_Load(object sender, EventArgs e)
        {
            dgvTempatPengepul.AutoGenerateColumns = false;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Tempat Pengepul", typeof(int));
            dataTable.Columns.Add("Nama Tempat", typeof(string));
            dataTable.Columns.Add("Alamat", typeof(string));
            dataTable.Columns.Add("Deskripsi", typeof(string));

            try
            {
                DBConnection.openConn();
                string query = @"SELECT id_tempatpengepul, nama_tempat, alamat, deskripsi 
                                 FROM TempatPengepul";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataTable.Rows.Add(reader["id_tempatpengepul"], reader["nama_tempat"], reader["alamat"], reader["deskripsi"]);
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

            dgvTempatPengepul.DataSource = dataTable;

            dgvTempatPengepul.Columns[0].DataPropertyName = "ID Tempat Pengepul";
            dgvTempatPengepul.Columns[1].DataPropertyName = "Nama Tempat";
            dgvTempatPengepul.Columns[2].DataPropertyName = "Alamat";
            dgvTempatPengepul.Columns[3].DataPropertyName = "Deskripsi";

            try
            {
                DBConnection.openConn();
                string query = @"SELECT id_tempatpengepul, nama_tempat
                                 FROM TempatPengepul";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                using (var reader = cmd.ExecuteReader())
                {
                    var dataSource = new List<KeyValuePair<int, string>>();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        dataSource.Add(new KeyValuePair<int, string>(id, name));
                    }

                    cbTempatPengepul.DataSource = dataSource;
                    cbTempatPengepul.ValueMember = "Key";
                    cbTempatPengepul.DisplayMember = "Value";
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
}
