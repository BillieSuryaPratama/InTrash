using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class Informasi_Sampah : Form
    {
        private Size formOriginalSize;
        private Dictionary<Control, Rectangle> controlOriginalRects = new Dictionary<Control, Rectangle>();

        public Informasi_Sampah()
        {
            InitializeComponent();
            this.Resize += Informasi_Sampah_Resize; // Tambahkan event handler

            // Simpan ukuran dan posisi awal
            formOriginalSize = this.Size;
            controlOriginalRects.Add(dgvInformasiSampah, new Rectangle(dgvInformasiSampah.Location, dgvInformasiSampah.Size));
            controlOriginalRects.Add(btnKembali, new Rectangle(btnKembali.Location, btnKembali.Size));
            // Tambahkan kontrol lainnya di sini
        }

        private void Informasi_Sampah_Resize(object sender, EventArgs e)
        {
            // Panggil ResizeControl untuk setiap kontrol
            ResizeControl(dgvInformasiSampah);
            ResizeControl(btnKembali);
        }

        private void ResizeControl(Control control)
        {
            float xRatio = (float)Width / formOriginalSize.Width;
            float yRatio = (float)Height / formOriginalSize.Height;

            Rectangle originalRect = controlOriginalRects[control];
            int newX = (int)(originalRect.X * xRatio);
            int newY = (int)(originalRect.Y * yRatio);
            int newWidth = (int)(originalRect.Width * xRatio);
            int newHeight = (int)(originalRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
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
            this.Close();
        }
    }
}
