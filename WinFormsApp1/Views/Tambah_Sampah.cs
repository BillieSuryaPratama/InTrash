using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class Tambah_Sampah : Form
    {
        private Size formOriginalSize;
        private Dictionary<Control, Rectangle> controlOriginalRects = new Dictionary<Control, Rectangle>();

        public Tambah_Sampah()
        {
            InitializeComponent();
        }

        public DataTable dataSampah = new DataTable();

        private void Tambah_Sampah_Load_1(object sender, EventArgs e)
        {
            comboBoxJenisSampah.Items.Add("Pilih Jenis Sampah");
            IsiComboBoxJenisSampah();
            if (comboBoxJenisSampah.Items.Count > 0)
            {
                comboBoxJenisSampah.SelectedIndex = 0;
            }

            dataSampah.Columns.Add("Jenis Sampah", typeof(string));
            dataSampah.Columns.Add("Kuantitas", typeof(decimal));

            // Inisialisasi untuk auto-resize
            formOriginalSize = this.Size;
            this.Resize += Tambah_Sampah_Resize;

            // Simpan ukuran dan posisi awal semua kontrol
            foreach (Control control in this.Controls)
            {
                controlOriginalRects.Add(control, new Rectangle(control.Location, control.Size));
            }
        }

        private void IsiComboBoxJenisSampah()
        {
            try
            {
                DBConnection.openConn();
                string query = "SELECT nama_jenis_sampah FROM jenis_sampah";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxJenisSampah.Items.Add(reader["nama_jenis_sampah"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nDetail: {ex.StackTrace}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeConn();
            }
        }

        private void Tambah_Sampah_Resize(object sender, EventArgs e)
        {
            // Dapatkan rasio perubahan ukuran form
            float xRatio = (float)this.Width / (float)formOriginalSize.Width;
            float yRatio = (float)this.Height / (float)formOriginalSize.Height;

            // Sesuaikan ukuran dan posisi setiap kontrol yang ingin Anda resize
            foreach (var entry in controlOriginalRects)
            {
                ResizeControl(entry.Key, entry.Value);
            }
        }

        private void ResizeControl(Control control, Rectangle originalRect)
        {
            float xRatio = (float)Width / formOriginalSize.Width;
            float yRatio = (float)Height / formOriginalSize.Height;

            int newX = (int)(originalRect.X * xRatio);
            int newY = (int)(originalRect.Y * yRatio);
            int newWidth = (int)(originalRect.Width * xRatio);
            int newHeight = (int)(originalRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (comboBoxJenisSampah.SelectedIndex > 0 && !string.IsNullOrWhiteSpace(tbKuantitas.Text))
            {
                decimal kuantitas;
                string text = tbKuantitas.Text.Replace('.', ',');

                if (decimal.TryParse(text, out kuantitas) && kuantitas >= 1)
                {
                    dataSampah.Rows.Add(comboBoxJenisSampah.SelectedItem.ToString(), kuantitas);
                    comboBoxJenisSampah.SelectedIndex = 0;
                    tbKuantitas.Clear();
                }
                else
                {
                    MessageBox.Show("Jumlah minimal untuk kuantitas adalah 1KG.");
                }
            }
            else
            {
                MessageBox.Show("Harap pilih jenis sampah dan masukkan kuantitas.");
            }
        }

        private void comboBoxJenisSampah_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ... (kode untuk menangani perubahan pilihan jenis sampah) ...
        }

        private void tbKuantitas_TextChanged(object sender, EventArgs e)
        {
            // Validasi input dan aktifkan/nonaktifkan tombol Simpan
            decimal kuantitas;
            string text = tbKuantitas.Text.Replace('.', ',');
        }

        private void tbKuantitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Izinkan hanya karakter angka, koma, dan tombol kontrol
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Batasi jumlah koma menjadi satu
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == ',' && textBox.Text.Contains(','))
            {
                e.Handled = true;
            }
        }
    }
}
