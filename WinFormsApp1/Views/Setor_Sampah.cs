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

            textBoxTanggal.Text = DateTime.Now.ToLongDateString();
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
            if (comboBoxLokasiBank.SelectedIndex == 0)
            {
                MessageBox.Show("Harap pilih lokasi bank sampah.");
                return; // Keluar dari fungsi jika lokasi belum dipilih
            }

            if (dataGridViewSetorSampah.Rows.Count == 1) // Memeriksa apakah ada data sampah
            {
                MessageBox.Show("Harap tambahkan jenis sampah yang akan disetorkan.");
                return; // Keluar dari fungsi jika tidak ada data sampah
            }

            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menyetorkan sampah ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    DBConnection.openConn();

                    // 1. Dapatkan ID Tempat Pengepul
                    string namaTempatPengepul = textBoxNamaBank.Text;
                    int idTempatPengepul = GetIdTempatPengepul(namaTempatPengepul);
                    if (idTempatPengepul == 0)
                    {
                        MessageBox.Show("Bank sampah tidak ditemukan.");
                        return; // Keluar dari fungsi jika bank sampah tidak ditemukan
                    }

                    // 2. Dapatkan ID Admin
                    int idAdmin = GetIdAdmin(idTempatPengepul);
                    if (idAdmin == 0)
                    {
                        MessageBox.Show("Admin bank sampah tidak ditemukan.");
                        return; // Keluar dari fungsi jika admin tidak ditemukan
                    }

                    // 3. Dapatkan ID Customer
                    int idCustomer = GetIdCustomer(Form_Login_Nasabah.UsernameLogin);
                    if (idCustomer == 0)
                    {
                        MessageBox.Show("Data pengguna tidak valid. Silakan login kembali.");
                        return; // Keluar dari fungsi jika pengguna tidak valid
                    }

                    // 4. Tambahkan data ke tabel transaksi
                    int idTransaksi = InsertTransaksi(idTempatPengepul, idCustomer, idAdmin, DateTime.Now);

                    // 5. Hitung dan update jumlah imbalan di tabel transaksi
                    int jumlahImbalan = HitungJumlahImbalan();
                    UpdateJumlahImbalan(idTransaksi, jumlahImbalan);

                    // 6. Tambahkan data ke tabel detail_transaksi
                    InsertDetailTransaksi(idTransaksi);

                    MessageBox.Show("Terimakasih, proses penjemputan sampah selanjutnya akan dikonfirmasi oleh admin :)");

                    this.Hide();
                    Riwayat_Nasbah nextpage = new Riwayat_Nasbah();
                    nextpage.FormClosed += (s, args) => this.Close();
                    nextpage.ShowDialog();
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
            else
            {

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

        private int GetIdTempatPengepul(string namaTempatPengepul)
        {
            string query = "SELECT id_tempatpengepul FROM tempatpengepul WHERE nama_tempat = @namaTempatPengepul";
            using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
            {
                cmd.Parameters.AddWithValue("namaTempatPengepul", namaTempatPengepul);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0; // Atau berikan nilai default jika tidak ditemukan
            }
        }

        private int GetIdAdmin(int idTempatPengepul)
        {
            string query = "SELECT id_admin FROM admin_tempat_pengepul WHERE id_tempatpengepul = @idTempatPengepul";
            using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
            {
                cmd.Parameters.AddWithValue("idTempatPengepul", idTempatPengepul);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0; // Atau berikan nilai default jika tidak ditemukan
            }
        }

        private int GetIdCustomer(string usernameCustomer)
        {
            string query = "SELECT id_customer FROM customer WHERE username_customer = @usernameCustomer";
            using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
            {
                cmd.Parameters.AddWithValue("usernameCustomer", usernameCustomer);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0; // Atau berikan nilai default jika tidak ditemukan
            }
        }

        private int InsertTransaksi(int idTempatPengepul, int idCustomer, int idAdmin, DateTime tanggalTransaksi)
        {
            string query = @"INSERT INTO transaksi (tanggal_transaksi, id_tempatpengepul, id_customer, id_admin, jumlah_imbalan, id_statustransaksi) 
                             VALUES (@tanggalTransaksi, @idTempatPengepul, @idCustomer, @idAdmin, 0, 1) RETURNING id_transaksi;"; // Status transaksi awal: 'Diproses' (ID 1)

            using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
            {
                cmd.Parameters.AddWithValue("tanggalTransaksi", tanggalTransaksi);
                cmd.Parameters.AddWithValue("idTempatPengepul", idTempatPengepul);
                cmd.Parameters.AddWithValue("idCustomer", idCustomer);
                cmd.Parameters.AddWithValue("idAdmin", idAdmin);

                return Convert.ToInt32(cmd.ExecuteScalar()); // Mengembalikan ID transaksi yang baru saja dimasukkan
            }
        }

        private int HitungJumlahImbalan()
        {
            int totalImbalan = 0;
            foreach (DataGridViewRow row in dataGridViewSetorSampah.Rows)
            {
                if (row.Cells["JenisSampah"].Value != null && row.Cells["Bobot"].Value != null)
                {
                    string jenisSampah = row.Cells["JenisSampah"].Value.ToString();
                    int kuantitas = Convert.ToInt32(row.Cells["Bobot"].Value);
                    int hargaSampah = GetHargaSampah(jenisSampah);
                    totalImbalan += hargaSampah * kuantitas;
                }
            }
            return totalImbalan;
        }

        private int GetHargaSampah(string jenisSampah)
        {
            string query = "SELECT harga FROM jenis_sampah WHERE nama_jenis_sampah = @jenisSampah";
            using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
            {
                cmd.Parameters.AddWithValue("jenisSampah", jenisSampah); // Tambahkan parameter
                var result = cmd.ExecuteScalar(); // Simpan hasil query ke variabel result
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private void UpdateJumlahImbalan(int idTransaksi, int jumlahImbalan)
        {
            string query = "UPDATE transaksi SET jumlah_imbalan = @jumlahImbalan WHERE id_transaksi = @idTransaksi";
            using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
            {
                cmd.Parameters.AddWithValue("jumlahImbalan", jumlahImbalan);
                cmd.Parameters.AddWithValue("idTransaksi", idTransaksi);
                cmd.ExecuteNonQuery();
            }
        }

        private void InsertDetailTransaksi(int idTransaksi)
        {
            foreach (DataGridViewRow row in dataGridViewSetorSampah.Rows)
            {
                if (row.Cells["JenisSampah"].Value != null && row.Cells["Bobot"].Value != null)
                {
                    string jenisSampah = row.Cells["JenisSampah"].Value.ToString();
                    int kuantitas = Convert.ToInt32(row.Cells["Bobot"].Value);
                    int idJenisSampah = GetIdJenisSampah(jenisSampah);

                    string query = "INSERT INTO detail_transaksi (id_transaksi, id_jenis_sampah, kuantitas) VALUES (@idTransaksi, @idJenisSampah, @kuantitas)";
                    using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                    {
                        cmd.Parameters.AddWithValue("idTransaksi", idTransaksi);
                        cmd.Parameters.AddWithValue("idJenisSampah", idJenisSampah);
                        cmd.Parameters.AddWithValue("kuantitas", kuantitas);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private int GetIdJenisSampah(string jenisSampah)
        {
            string query = "SELECT id_jenis_sampah FROM jenis_sampah WHERE nama_jenis_sampah = @jenisSampah";
            using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
            {
                cmd.Parameters.AddWithValue("jenisSampah", jenisSampah);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }
    }
}
