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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class Konfirmasi_Jemput_Sampah : Form
    {
        private int idCustomer;
        private bool IsNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public Konfirmasi_Jemput_Sampah()
        {
            InitializeComponent();
        }

        private void Konfirmasi_Jemput_Sampah_Load(object sender, EventArgs e)
        {
            int ID_Transaksi = Jemput_Sampah.ID_Transaksi;
            dgvListSampah.AutoGenerateColumns = false;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Jenis Sampah", typeof(string));
            dataTable.Columns.Add("Bobot", typeof(int));

            try
            {
                DBConnection.openConn();
                string query = @"SELECT js.nama_jenis_sampah, dt.kuantitas
                                 FROM detail_transaksi dt
                                 JOIN jenis_sampah js on dt.id_jenis_sampah = js.id_jenis_sampah
                                 WHERE dt.id_transaksi = @ID_Transaksi";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Transaksi", ID_Transaksi);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataTable.Rows.Add(reader["nama_jenis_sampah"], reader["kuantitas"]);
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

            dgvListSampah.DataSource = dataTable;

            dgvListSampah.Columns[0].DataPropertyName = "Jenis Sampah";
            dgvListSampah.Columns[1].DataPropertyName = "Bobot";


            try
            {
                DBConnection.openConn();
                string query = @"SELECT t.id_customer, c.nama_customer, tp.nama_tempat, tp.alamat, t.jumlah_imbalan
                                 FROM Transaksi t
                                 JOIN Tempatpengepul tp ON t.id_tempatpengepul = tp.id_tempatpengepul
                                 JOIN Customer c on t.id_customer = c.id_customer
                                 WHERE id_transaksi = @ID_Transaksi";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Transaksi", ID_Transaksi);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            idCustomer = Convert.ToInt32(reader["id_customer"]);
                            lblNama.Text = reader["nama_customer"].ToString();
                            lblBankSampah.Text = reader["nama_tempat"].ToString();
                            lblAlamatBankSampah.Text = reader["alamat"].ToString();
                            tbImbalan.Text = reader["jumlah_imbalan"].ToString();
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
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jemput_Sampah nextpage = new Jemput_Sampah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            int ID_Transaksi = Jemput_Sampah.ID_Transaksi;

            if (string.IsNullOrWhiteSpace(tbImbalan.Text))
            {
                MessageBox.Show("Terdapat data kosong!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsNumeric(tbImbalan.Text))
            {
                MessageBox.Show("Imbalan hanya boleh mengandung angka!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DBConnection.openConn();

                string queryStatus = @"UPDATE transaksi
                                       SET id_StatusTransaksi = @Status
                                       WHERE id_transaksi = @ID_Transaksi";

                using (var cmd = new NpgsqlCommand(queryStatus, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Status", 3);
                    cmd.Parameters.AddWithValue("@ID_Transaksi", ID_Transaksi);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Transaksi Selesai!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Gagal!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                string querySaldo = @"UPDATE customer
                                      SET saldo = saldo + @Saldo
                                      WHERE id_customer = @ID_Customer";

                using (var cmd = new NpgsqlCommand(querySaldo, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Saldo", Convert.ToInt32(tbImbalan.Text));
                    cmd.Parameters.AddWithValue("@ID_Customer", idCustomer);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Saldo Ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Gagal!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeConn();
                this.Hide();
                Jemput_Sampah nextpage = new Jemput_Sampah();
                nextpage.FormClosed += (s, args) => this.Close();
                nextpage.ShowDialog();
            }
        }
    }
}
