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
    public partial class Atur_Jenis_Sampah : Form
    {
        public static int ID_Sampah;
        public Atur_Jenis_Sampah()
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

        private void Atur_Jenis_Sampah_Load(object sender, EventArgs e)
        {
            dgvListJenisSampah.AutoGenerateColumns = false;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Sampah", typeof(int));
            dataTable.Columns.Add("Jenis Sampah", typeof(string));
            dataTable.Columns.Add("Harga", typeof(int));
            dataTable.Columns.Add("Deskripsi", typeof(string));

            try
            {
                DBConnection.openConn();
                string query = @"SELECT id_jenis_sampah, nama_jenis_sampah, harga, deskripsi
                                 FROM jenis_sampah
                                 ORDER BY id_jenis_sampah";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataTable.Rows.Add(reader["id_jenis_sampah"], reader["nama_jenis_sampah"], reader["harga"], reader["deskripsi"]);
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

            dgvListJenisSampah.DataSource = dataTable;

            dgvListJenisSampah.Columns[0].DataPropertyName = "ID Sampah";
            dgvListJenisSampah.Columns[1].DataPropertyName = "Jenis Sampah";
            dgvListJenisSampah.Columns[2].DataPropertyName = "Harga";
            dgvListJenisSampah.Columns[3].DataPropertyName = "Deskripsi";


            try
            {
                DBConnection.openConn();

                string queryID = @"SELECT DISTINCT id_jenis_sampah as ID
                                   FROM jenis_sampah
                                   ORDER BY id_jenis_sampah";

                using (var cmd = new NpgsqlCommand(queryID, DBConnection.connection))
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nDetail: {ex.StackTrace}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeConn();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ID_Sampah = Convert.ToInt32(cbEdit.SelectedItem);
            this.Hide();
            Edit_Jenis_Sampah nextpage = new Edit_Jenis_Sampah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            ID_Sampah = 0;
            this.Hide();
            Edit_Jenis_Sampah nextpage = new Edit_Jenis_Sampah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }
}
