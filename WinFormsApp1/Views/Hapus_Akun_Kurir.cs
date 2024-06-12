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
    public partial class InTrash : Form
    {
        public InTrash()
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

        private void InTrash_Load(object sender, EventArgs e)
        {
            int IDKurir = Atur_Akun_Kurir.ID_Kurir;
            dgvHapusKurir.AutoGenerateColumns = false;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Kurir", typeof(int));
            dataTable.Columns.Add("Nama", typeof(string));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("password", typeof(string));
            dataTable.Columns.Add("no_hp", typeof(string));
            dataTable.Columns.Add("Deskripsi", typeof(string));

            try
            {
                DBConnection.openConn();
                string query = @"SELECT k.id_kurir, k.nama_kurir, k.username_kurir, k.password_kurir, k.no_hp, tp.nama_tempat
                                 FROM kurir k
                                 JOIN TempatPengepul tp on k.id_tempatpengepul = tp.id_tempatpengepul
                                 WHERE k.id_kurir = @ID_Kurir
                                 ORDER BY id_kurir";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Kurir", IDKurir);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataTable.Rows.Add(reader["id_kurir"], reader["nama_kurir"], reader["username_kurir"], reader["password_kurir"], reader["no_hp"], reader["nama_tempat"]);
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

            dgvHapusKurir.DataSource = dataTable;

            dgvHapusKurir.Columns[0].DataPropertyName = "ID Kurir";
            dgvHapusKurir.Columns[1].DataPropertyName = "Nama";
            dgvHapusKurir.Columns[2].DataPropertyName = "Username";
            dgvHapusKurir.Columns[3].DataPropertyName = "Password";
            dgvHapusKurir.Columns[4].DataPropertyName = "no_hp";
            dgvHapusKurir.Columns[5].DataPropertyName = "Deskripsi";
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            int ID_Kurir = Atur_Akun_Kurir.ID_Kurir;

            if (string.IsNullOrWhiteSpace(tbID.Text) ||
                string.IsNullOrWhiteSpace(tbSandi.Text))
            {
                MessageBox.Show("Terdapat data kosong!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DBConnection.openConn();

                string queryCek = @"SELECT COUNT(*) 
                                    FROM kurir 
                                    WHERE Id_Kurir = @Id_Kurir AND Password_Kurir = @Password_Kurir";
                using (var cmd = new NpgsqlCommand(queryCek, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Id_Kurir", Convert.ToInt32(tbID.Text));
                    cmd.Parameters.AddWithValue("@Password_Kurir", tbSandi.Text);

                    long usernameCount = (long)cmd.ExecuteScalar();

                    if (usernameCount == 0)
                    {
                        MessageBox.Show("ID Atau Sandi tidak cocok", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string query = @"DELETE FROM Kurir 
                                 WHERE Id_kurir = @id AND password_kurir = @Password";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbID.Text));
                    cmd.Parameters.AddWithValue("@Password", tbSandi.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
