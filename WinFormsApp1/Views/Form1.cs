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
    public partial class Form1 : Form
    {
        private Dictionary<Control, Rectangle> originalControlRects = new Dictionary<Control, Rectangle>();
        private Size originalFormSize;

        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Store original control sizes and form size
            originalFormSize = this.ClientSize;
            foreach (Control control in this.Controls)
            {
                originalControlRects[control] = new Rectangle(control.Location, control.Size);
            }

            // Ambil data saldo pengguna aktif
            string usernameAktif = Form_Login_Nasabah.UsernameLogin;
            int saldo = GetSaldoCustomer(usernameAktif);

            textBoxJumlahSaldo.Text = saldo.ToString(); // Tampilkan saldo di textbox

            // Isi combo box dengan data dari tabel metodepencairan
            IsiComboBoxMetodePencairan();
        }

        private void Form1_Resize(object sender, EventArgs e)
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

        private int GetSaldoCustomer(string usernameCustomer)
        {
            try
            {
                DBConnection.openConn(); // Buka koneksi ke database

                string query = "SELECT saldo FROM customer WHERE username_customer = @username";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("username", usernameCustomer);
                    object result = cmd.ExecuteScalar(); // Eksekusi query dan ambil hasil
                    return result != null ? Convert.ToInt32(result) : 0; // Kembalikan saldo atau 0 jika tidak ada
                }
            }
            finally
            {
                DBConnection.closeConn(); // Tutup koneksi database
            }
        }

        private int GetIdMetodePencairan(string namaMetode)
        {
            try
            {
                DBConnection.openConn();
                string query = "SELECT id_metode FROM metodepencairan WHERE nama_metode = @namaMetode";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("namaMetode", namaMetode);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
            finally
            {
                DBConnection.closeConn();
            }
        }

        private void InsertPencairan(int idCustomer, string rekeningTujuan, int nominal, int idMetode)
        {
            try
            {
                DBConnection.openConn(); // Buka koneksi sebelum eksekusi query

                string query = @"INSERT INTO pencairan (rekening_tujuan, nominal_pencairan, id_statuspencairan, id_metode, id_customer)
                         VALUES (@rekeningTujuan, @nominalPencairan, 1, @idMetode, @idCustomer)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("rekeningTujuan", rekeningTujuan);
                    cmd.Parameters.AddWithValue("nominalPencairan", nominal);
                    cmd.Parameters.AddWithValue("idMetode", idMetode);
                    cmd.Parameters.AddWithValue("idCustomer", idCustomer);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                DBConnection.closeConn(); // Tutup koneksi di finally block
            }
        }


        private void IsiComboBoxMetodePencairan()
        {
            try
            {
                DBConnection.openConn(); // Buka koneksi ke database

                string query = "SELECT DISTINCT nama_metode FROM metodepencairan"; // Use DISTINCT to avoid duplicates directly from the query
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, DBConnection.connection))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    comboBoxMetodePencairan.Items.Clear();  // Clear existing items
                    while (reader.Read())
                    {
                        string namaMetode = reader["nama_metode"].ToString();
                        comboBoxMetodePencairan.Items.Add(namaMetode);
                    }
                }
            }
            finally
            {
                DBConnection.closeConn(); // Tutup koneksi database
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beranda_Nasabah nextpage = new Beranda_Nasabah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void buttonLihatRiwayat_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog(this);
        }

        private void textBoxJumlahSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMetodePencairan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRekeningTujuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRekeningTujuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Izinkan hanya karakter angka, koma, dan tombol kontrol
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNominal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Izinkan hanya karakter angka, koma, dan tombol kontrol
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UpdateSaldoCustomer(int idCustomer, int saldoBaru)
        {
            try
            {
                DBConnection.openConn();

                string query = "UPDATE customer SET saldo = @saldoBaru WHERE id_customer = @idCustomer";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("saldoBaru", saldoBaru);
                    cmd.Parameters.AddWithValue("idCustomer", idCustomer);
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                DBConnection.closeConn();
            }
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (comboBoxMetodePencairan.SelectedIndex <= -1)
            {
                MessageBox.Show("Harap pilih metode pencairan.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxRekeningTujuan.Text))
            {
                MessageBox.Show("Harap isi nomor rekening tujuan.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNominal.Text))
            {
                MessageBox.Show("Harap isi nominal pencairan.");
                return;
            }

            if (!int.TryParse(textBoxNominal.Text, out int nominal) || nominal <= 0)
            {
                MessageBox.Show("Nominal tidak benar.");
                return;
            }

            int saldo = GetSaldoCustomer(Form_Login_Nasabah.UsernameLogin);
            int biayaAdmin = 2500;
            if (nominal + biayaAdmin > saldo)
            {
                MessageBox.Show("Saldo tidak mencukupi (biaya admin 2500).");
                return;
            }
            
            DialogResult dialogResult = MessageBox.Show($"Apakah Anda yakin ingin mengajukan pencairan sebesar {nominal} dengan biaya admin {biayaAdmin}?", "Konfirmasi Pencairan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                DBConnection.openConn();

                // 1. Dapatkan ID Customer (dari pengguna yang sedang login)
                int idCustomer = GetIdCustomer(Form_Login_Nasabah.UsernameLogin);

                // 2. Dapatkan ID Metode Pencairan
                string namaMetode = comboBoxMetodePencairan.SelectedItem.ToString();
                int idMetode = GetIdMetodePencairan(namaMetode);

                // 3. Simpan data ke tabel pencairan
                InsertPencairan(idCustomer, textBoxRekeningTujuan.Text, nominal, idMetode);

                // 4. Kurangi saldo customer
                int saldoAwal = GetSaldoCustomer(Form_Login_Nasabah.UsernameLogin);
                int saldoBaru = saldoAwal - nominal - biayaAdmin;
                UpdateSaldoCustomer(idCustomer, saldoBaru);

                MessageBox.Show("Pengajuan pencairan berhasil! Tunggu admin untuk menyetujui");
                textBoxJumlahSaldo.Text = saldoBaru.ToString();
                
                Form2 form2 = new Form2();
                form2.ShowDialog(this);
                }
                finally
                {
                    DBConnection.closeConn();
                }
        }   }
    }
}
