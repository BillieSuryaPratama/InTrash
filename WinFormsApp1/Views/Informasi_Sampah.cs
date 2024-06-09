using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class Informasi_Sampah : Form
    {
        public Informasi_Sampah()
        {
            InitializeComponent();
        }

        private void Informasi_Sampah_Load(object sender, EventArgs e)
        {

            dgvInformasiSampah.AutoGenerateColumns = false;


            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nama", typeof(string));
            dataTable.Columns.Add("Harga per KG", typeof(int));
            dataTable.Columns.Add("Deskripsi", typeof(string));

            try
            {
                DBConnection.openConn();
                string query = "SELECT nama_jenis_sampah, harga, deskripsi FROM jenis_sampah";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataTable.Rows.Add(reader["nama_jenis_sampah"], reader["harga"], reader["deskripsi"]);
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


            dgvInformasiSampah.DataSource = dataTable;


            dgvInformasiSampah.Columns[0].DataPropertyName = "Nama";
            dgvInformasiSampah.Columns[1].DataPropertyName = "Harga per KG";
            dgvInformasiSampah.Columns[2].DataPropertyName = "Deskripsi";
        }

        private void dgvInformasiSampah_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
