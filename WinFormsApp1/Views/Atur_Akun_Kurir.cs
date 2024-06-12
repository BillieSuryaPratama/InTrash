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

namespace WinFormsApp1.Views
{
    public partial class Atur_Akun_Kurir : Form
    {
        public static int ID_Kurir;
        public Atur_Akun_Kurir()
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

        private void Atur_Akun_Kurir_Load(object sender, EventArgs e)
        {
            int IDTempatPengepul = Form_Login_Admin.IdTempatPengepul;
            dgvListKurir.AutoGenerateColumns = false;

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
                                 WHERE k.id_tempatpengepul = @idTempatPengepul
                                 ORDER BY id_kurir";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@idTempatPengepul", IDTempatPengepul);

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

            dgvListKurir.DataSource = dataTable;

            dgvListKurir.Columns[0].DataPropertyName = "ID Kurir";
            dgvListKurir.Columns[1].DataPropertyName = "Nama";
            dgvListKurir.Columns[2].DataPropertyName = "Username";
            dgvListKurir.Columns[3].DataPropertyName = "Password";
            dgvListKurir.Columns[4].DataPropertyName = "no_hp";
            dgvListKurir.Columns[5].DataPropertyName = "Deskripsi";

            try
            {
                DBConnection.openConn();

                string queryID = @"SELECT DISTINCT id_kurir as ID
                                   FROM kurir
                                   WHERE id_tempatpengepul = @idTempatPengepul
                                   ORDER BY id_kurir";

                using (var cmd = new NpgsqlCommand(queryID, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@idTempatPengepul", IDTempatPengepul);
                    using (var reader = cmd.ExecuteReader())
                    {
                        var ListID = new List<int>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            ListID.Add(id);
                        }

                        cbEdit.DataSource = ListID;
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

            try
            {
                DBConnection.openConn();

                string queryID = @"SELECT DISTINCT id_kurir as ID
                                   FROM kurir
                                   WHERE id_tempatpengepul = @idTempatPengepul
                                   ORDER BY id_kurir";

                using (var cmd = new NpgsqlCommand(queryID, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@idTempatPengepul", IDTempatPengepul);
                    using (var reader = cmd.ExecuteReader())
                    {
                        var ListID = new List<int>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            ListID.Add(id);
                        }

                        cbHapus.DataSource = ListID;
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

        private void btnEditAkun_Click(object sender, EventArgs e)
        {
            ID_Kurir = Convert.ToInt32(cbEdit.SelectedItem);
            this.Hide();
            Edit_Kurir nextpage = new Edit_Kurir();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnHapusAkun_Click(object sender, EventArgs e)
        {
            ID_Kurir = Convert.ToInt32(cbEdit.SelectedItem);
            this.Hide();
            Hapus_Akun_Kurir nextpage = new Hapus_Akun_Kurir();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }
}
