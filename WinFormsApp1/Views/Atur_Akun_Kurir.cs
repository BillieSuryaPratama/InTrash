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
            dataTable.Columns.Add("password",  typeof(string));
            dataTable.Columns.Add("no_hp", typeof(string));
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

            dgvListKurir.DataSource = dataTable;

            dgvListKurir.Columns[0].DataPropertyName = "ID Sampah";
            dgvListKurir.Columns[1].DataPropertyName = "Jenis Sampah";
            dgvListKurir.Columns[2].DataPropertyName = "Harga";
            dgvListKurir.Columns[3].DataPropertyName = "Deskripsi";
        }
    }
}
