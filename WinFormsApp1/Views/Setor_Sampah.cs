using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class Setor_Sampah : Form
    {
        private Dictionary<string, string> bankData = new Dictionary<string, string>();
        private Size formOriginalSize;
        private Dictionary<Control, Rectangle> controlOriginalRects = new Dictionary<Control, Rectangle>();

        public Setor_Sampah()
        {
            InitializeComponent();
            textBoxNamaBank.ReadOnly = true;
        }

        private void SetorSampah_Load(object sender, EventArgs e)
        {
            dataGridViewSetorSampah.AutoGenerateColumns = false;

            comboBoxLokasiBank.Items.Add("Pilih Lokasi");
            IsiComboBoxLokasiBank();

            if (comboBoxLokasiBank.Items.Count > 0)
            {
                comboBoxLokasiBank.SelectedIndex = 0;
            }

            dataGridViewSetorSampah.Columns[0].DataPropertyName = "Jenis Sampah";
            dataGridViewSetorSampah.Columns[1].DataPropertyName = "Bobot";

            // Inisialisasi untuk auto-resize
            formOriginalSize = this.Size;
            this.Resize += SetorSampah_Resize;

            // Simpan ukuran dan posisi awal semua kontrol
            foreach (Control control in this.Controls)
            {
                controlOriginalRects.Add(control, new Rectangle(control.Location, control.Size));
            }
        }

        private void IsiComboBoxLokasiBank()
        {
            try
            {
                DBConnection.openConn();
                string query = "SELECT nama_tempat, alamat FROM tempatpengepul";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string namaTempat = reader["nama_tempat"].ToString();
                        string alamat = reader["alamat"].ToString();

                        comboBoxLokasiBank.Items.Add(alamat);
                        bankData[alamat] = namaTempat;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nDetail: {ex.StackTrace}",
                                "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeConn();
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beranda_Nasabah nextpage = new Beranda_Nasabah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tambah_Sampah tambahSampahForm = new Tambah_Sampah();
            if (tambahSampahForm.ShowDialog() == DialogResult.OK)
            {
                DataTable dataSampahBaru = tambahSampahForm.dataSampah;

                foreach (DataRow row in dataSampahBaru.Rows)
                {
                    string jenisSampah = row["Jenis Sampah"].ToString();
                    int kuantitas = Convert.ToInt32(row["Kuantitas"]);

                    bool ditemukan = false;
                    foreach (DataGridViewRow dgvRow in dataGridViewSetorSampah.Rows)
                    {
                        if (dgvRow.Cells["JenisSampah"].Value != null &&
                            dgvRow.Cells["JenisSampah"].Value.ToString() == jenisSampah &&
                            dgvRow.Cells["Bobot"].Value != null)
                        {
                            int kuantitasLama = Convert.ToInt32(dgvRow.Cells["Bobot"].Value);
                            dgvRow.Cells["Bobot"].Value = kuantitasLama + kuantitas;
                            ditemukan = true;
                            break;
                        }
                    }

                    if (!ditemukan)
                    {
                        dataGridViewSetorSampah.Rows.Add(jenisSampah, kuantitas);
                    }
                }
            }
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (comboBoxLokasiBank.SelectedIndex > 0 && dataGridViewSetorSampah.Rows.Count > 1)
            {
                this.Hide();
                Riwayat_Nasbah nextpage = new Riwayat_Nasbah();
                nextpage.FormClosed += (s, args) => this.Close();
                nextpage.ShowDialog();
            }
            else
            {
                if (comboBoxLokasiBank.SelectedIndex <= 0)
                {
                    MessageBox.Show("Harap pilih lokasi bank sampah.");
                }
                else
                {
                    MessageBox.Show("Harap tambahkan jenis sampah yang akan disetorkan.");
                }
            }
        }

        private void comboBoxLokasiBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLokasiBank.SelectedItem != null)
            {
                string alamat = comboBoxLokasiBank.SelectedItem.ToString();
                if (bankData.ContainsKey(alamat))
                {
                    textBoxNamaBank.Text = bankData[alamat];
                }
                else
                {
                    textBoxNamaBank.Text = ""; // Jika tidak ditemukan
                }
            }
        }

        private void textBoxNamaBank_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetorSampah_Resize(object sender, EventArgs e)
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
    }
}
