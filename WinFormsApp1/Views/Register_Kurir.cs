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
            if (string.IsNullOrWhiteSpace(tbNama.Text) ||
                string.IsNullOrWhiteSpace(tbUsername.Text) ||
                string.IsNullOrWhiteSpace(tbSandi.Text) ||
                string.IsNullOrWhiteSpace(tbNomorHP.Text) ||
                cbTempatPengepul.SelectedValue == null)
            {
                MessageBox.Show("Terdapat data kosong!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Beranda_Admin nextpage = new Beranda_Admin();
                nextpage.FormClosed += (s, args) => this.Close();
                nextpage.ShowDialog();
            }
        }

        private void Register_Kurir_Load(object sender, EventArgs e)
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
