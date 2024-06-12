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

namespace WinFormsApp1.Views
{
    public partial class Form2 : Form
    {
        private Dictionary<Control, Rectangle> originalControlRects = new Dictionary<Control, Rectangle>();
        private Size originalFormSize;

        public Form2()
        {
            InitializeComponent();
            this.Resize += Form2_Resize;
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Store original control sizes and form size
            originalFormSize = this.ClientSize;
            foreach (Control control in this.Controls)
            {
                originalControlRects[control] = new Rectangle(control.Location, control.Size);
            }

            dgvInformasiSampah.AutoGenerateColumns = false;
            dgvInformasiSampah.DataSource = LoadPencairanData();

            // Set DataPropertyName for each column
            dgvInformasiSampah.Columns["ID"].DataPropertyName = "ID";
            dgvInformasiSampah.Columns["MetodePencairan"].DataPropertyName = "Metode Pencairan";
            dgvInformasiSampah.Columns["RekeningTujuan"].DataPropertyName = "Rekening Tujuan";
            dgvInformasiSampah.Columns["Nominal"].DataPropertyName = "Nominal";
            dgvInformasiSampah.Columns["Status"].DataPropertyName = "Status";
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            // Calculate resizing ratios
            float xRatio = (float)this.ClientSize.Width / originalFormSize.Width;
            float yRatio = (float)this.ClientSize.Height / originalFormSize.Height;

            // Resize and reposition controls
            foreach (Control control in this.Controls)
            {
                Rectangle originalRect = originalControlRects[control];
                int newX = (int)(originalRect.X * xRatio);
                int newY = (int)(originalRect.Y * yRatio);
                int newWidth = (int)(originalRect.Width * xRatio);
                int newHeight = (int)(originalRect.Height * yRatio);

                control.Location = new Point(newX, newY);
                control.Size = new Size(newWidth, newHeight);
            }
        }

        private DataTable LoadPencairanData()
        {
            DataTable dt = new DataTable();
            try
            {
                DBConnection.openConn();

                // Query dengan JOIN dan tambahkan kolom rekening_tujuan
                string query = @"
                    SELECT p.id_pencairan AS ID, m.nama_metode AS ""Metode Pencairan"", p.rekening_tujuan AS ""Rekening Tujuan"", p.nominal_pencairan AS Nominal, s.status AS Status
                    FROM pencairan p
                    JOIN metodepencairan m ON p.id_metode = m.id_metode
                    JOIN status_pencairan s ON p.id_statuspencairan = s.id_statuspencairan
                    WHERE p.id_customer = @idCustomer;
                ";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    // Dapatkan ID Customer (dari pengguna yang sedang login)
                    int idCustomer = GetIdCustomer(Form_Login_Nasabah.UsernameLogin);
                    cmd.Parameters.AddWithValue("idCustomer", idCustomer);

                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            finally
            {
                DBConnection.closeConn();
            }
            return dt;
        }

        private int GetIdCustomer(string usernameCustomer)
        {
            try
            {
                DBConnection.openConn();

                string query = "SELECT id_customer FROM customer WHERE username_customer = @username";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("username", usernameCustomer);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0; // Return 0 jika tidak ditemukan
                }
            }
            finally
            {
                DBConnection.closeConn();
            }
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
