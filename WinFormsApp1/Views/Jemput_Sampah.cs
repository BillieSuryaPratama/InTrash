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
    public partial class Jemput_Sampah : Form
    {
        public static int ID_Transaksi;
        public Jemput_Sampah()
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

        private void Jemput_Sampah_Load(object sender, EventArgs e)
        {
            dgvListPenjemputan.AutoGenerateColumns = false;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Transaksi", typeof(int));
            dataTable.Columns.Add("Tanggal Transaksi", typeof(DateTime));
            dataTable.Columns.Add("Tempat Pengepul", typeof(string));
            dataTable.Columns.Add("Admin", typeof(string));
            dataTable.Columns.Add("Customer", typeof(string));
            dataTable.Columns.Add("Status Transaksi", typeof(string));

            try
            {
                DBConnection.openConn();
                string query = @"SELECT t.id_transaksi, t.tanggal_transaksi, tp.nama_tempat, atp.nama_admin, c.nama_customer, st.Status
                                 FROM transaksi t
                                 JOIN tempatpengepul tp on t.id_tempatpengepul = tp.id_tempatpengepul
                                 JOIN admin_tempat_pengepul atp on t.id_admin = atp.id_admin
                                 JOIN customer c on t.id_customer = c.id_customer
                                 JOIN Status_Transaksi st on t.id_StatusTransaksi = st.id_StatusTransaksi
                                 WHERE t.id_StatusTransaksi = @Status1 OR t.id_StatusTransaksi = @Status2
                                 ORDER BY t.id_transaksi";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Status1", 1);
                    cmd.Parameters.AddWithValue("@Status2", 2);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataTable.Rows.Add(reader["id_transaksi"], reader["tanggal_transaksi"], reader["nama_tempat"], reader["nama_admin"], reader["nama_customer"], reader["Status"]);
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

            dgvListPenjemputan.DataSource = dataTable;

            dgvListPenjemputan.Columns[0].DataPropertyName = "ID Transaksi";
            dgvListPenjemputan.Columns[1].DataPropertyName = "Tanggal Transaksi";
            dgvListPenjemputan.Columns[2].DataPropertyName = "Tempat Pengepul";
            dgvListPenjemputan.Columns[3].DataPropertyName = "Admin";
            dgvListPenjemputan.Columns[4].DataPropertyName = "Customer";
            dgvListPenjemputan.Columns[5].DataPropertyName = "Status Transaksi";

            try
            {
                DBConnection.openConn();

                string queryStatus1 = @"SELECT DISTINCT id_transaksi AS tahun
                                      FROM transaksi
                                      WHERE id_StatusTransaksi = @Status1
                                      ORDER BY id_transaksi";

                using (var cmd = new NpgsqlCommand(queryStatus1, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Status1", 1);

                    using (var reader = cmd.ExecuteReader())
                    {
                        var Status1List = new List<int>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            Status1List.Add(id);
                        }

                        cbKonfirmasi.DataSource = Status1List;
                    }
                }

                string queryStatus2 = @"SELECT DISTINCT id_transaksi AS tahun
                                      FROM transaksi
                                      WHERE id_StatusTransaksi = @Status2
                                      ORDER BY id_transaksi";

                using (var cmd = new NpgsqlCommand(queryStatus2, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Status2", 2);

                    using (var reader = cmd.ExecuteReader())
                    {
                        var Status2List = new List<int>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            Status2List.Add(id);
                        }

                        cbSelesai.DataSource = Status2List;
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

        private void btnTampil1_Click(object sender, EventArgs e)
        {
            dgvListPenjemputan.AutoGenerateColumns = false;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Transaksi", typeof(int));
            dataTable.Columns.Add("Tanggal Transaksi", typeof(DateTime));
            dataTable.Columns.Add("Tempat Pengepul", typeof(string));
            dataTable.Columns.Add("Admin", typeof(string));
            dataTable.Columns.Add("Customer", typeof(string));
            dataTable.Columns.Add("Status Transaksi", typeof(string));

            try
            {
                DBConnection.openConn();
                string query = @"SELECT t.id_transaksi, t.tanggal_transaksi, tp.nama_tempat, atp.nama_admin, c.nama_customer, st.Status
                                 FROM transaksi t
                                 JOIN tempatpengepul tp on t.id_tempatpengepul = tp.id_tempatpengepul
                                 JOIN admin_tempat_pengepul atp on t.id_admin = atp.id_admin
                                 JOIN customer c on t.id_customer = c.id_customer
                                 JOIN Status_Transaksi st on t.id_StatusTransaksi = st.id_StatusTransaksi
                                 WHERE t.id_StatusTransaksi = @Status1
                                 ORDER BY t.id_transaksi";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Status1", 1);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataTable.Rows.Add(reader["id_transaksi"], reader["tanggal_transaksi"], reader["nama_tempat"], reader["nama_admin"], reader["nama_customer"], reader["Status"]);
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

            dgvListPenjemputan.DataSource = dataTable;

            dgvListPenjemputan.Columns[0].DataPropertyName = "ID Transaksi";
            dgvListPenjemputan.Columns[1].DataPropertyName = "Tanggal Transaksi";
            dgvListPenjemputan.Columns[2].DataPropertyName = "Tempat Pengepul";
            dgvListPenjemputan.Columns[3].DataPropertyName = "Admin";
            dgvListPenjemputan.Columns[4].DataPropertyName = "Customer";
            dgvListPenjemputan.Columns[5].DataPropertyName = "Status Transaksi";
        }

        private void btnTampil2_Click(object sender, EventArgs e)
        {
            dgvListPenjemputan.AutoGenerateColumns = false;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Transaksi", typeof(int));
            dataTable.Columns.Add("Tanggal Transaksi", typeof(DateTime));
            dataTable.Columns.Add("Tempat Pengepul", typeof(string));
            dataTable.Columns.Add("Admin", typeof(string));
            dataTable.Columns.Add("Customer", typeof(string));
            dataTable.Columns.Add("Status Transaksi", typeof(string));

            try
            {
                DBConnection.openConn();
                string query = @"SELECT t.id_transaksi, t.tanggal_transaksi, tp.nama_tempat, atp.nama_admin, c.nama_customer, st.Status
                                 FROM transaksi t
                                 JOIN tempatpengepul tp on t.id_tempatpengepul = tp.id_tempatpengepul
                                 JOIN admin_tempat_pengepul atp on t.id_admin = atp.id_admin
                                 JOIN customer c on t.id_customer = c.id_customer
                                 JOIN Status_Transaksi st on t.id_StatusTransaksi = st.id_StatusTransaksi
                                 WHERE t.id_StatusTransaksi = @Status2
                                 ORDER BY t.id_transaksi";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Status2", 2);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataTable.Rows.Add(reader["id_transaksi"], reader["tanggal_transaksi"], reader["nama_tempat"], reader["nama_admin"], reader["nama_customer"], reader["Status"]);
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

            dgvListPenjemputan.DataSource = dataTable;

            dgvListPenjemputan.Columns[0].DataPropertyName = "ID Transaksi";
            dgvListPenjemputan.Columns[1].DataPropertyName = "Tanggal Transaksi";
            dgvListPenjemputan.Columns[2].DataPropertyName = "Tempat Pengepul";
            dgvListPenjemputan.Columns[3].DataPropertyName = "Admin";
            dgvListPenjemputan.Columns[4].DataPropertyName = "Customer";
            dgvListPenjemputan.Columns[5].DataPropertyName = "Status Transaksi";
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            ID_Transaksi = Convert.ToInt32(cbKonfirmasi.SelectedItem);

            try
            {
                DBConnection.openConn();

                string query = @"UPDATE Transaksi
                                 SET id_StatusTransaksi = @Status2
                                 WHERE id_transaksi = @ID_Transaksi";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Status2", 2);
                    cmd.Parameters.AddWithValue("@ID_Transaksi", ID_Transaksi);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Setoran sampah berhasil dikonfirmasi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengkonfirmasi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            ID_Transaksi = Convert.ToInt32(cbSelesai.SelectedItem);
            this.Hide();
            Konfirmasi_Jemput_Sampah nextpage = new Konfirmasi_Jemput_Sampah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }
}
