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
using Npgsql;
using WinFormsApp1.Controllers;
using WinFormsApp1.Models;

namespace WinFormsApp1.Views
{
    public partial class Riwayat_Admin : Form
    {
        public Riwayat_Admin()
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

        private void Riwayat_Admin_Load(object sender, EventArgs e)
        {
            int IDTempatPengepul = Form_Login_Admin.IdTempatPengepul;
            dgvRiwayatTransaksi.AutoGenerateColumns = false;

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
                                 WHERE t.id_tempatpengepul = @id_tempatpengepul AND t.id_StatusTransaksi = @Status
                                 ORDER BY t.id_transaksi";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@id_tempatpengepul", IDTempatPengepul);
                    cmd.Parameters.AddWithValue("@Status", 3);

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

            dgvRiwayatTransaksi.DataSource = dataTable;

            dgvRiwayatTransaksi.Columns[0].DataPropertyName = "ID Transaksi";
            dgvRiwayatTransaksi.Columns[1].DataPropertyName = "Tanggal Transaksi";
            dgvRiwayatTransaksi.Columns[2].DataPropertyName = "Tempat Pengepul";
            dgvRiwayatTransaksi.Columns[3].DataPropertyName = "Admin";
            dgvRiwayatTransaksi.Columns[4].DataPropertyName = "Customer";
            dgvRiwayatTransaksi.Columns[5].DataPropertyName = "Status Transaksi";


            try
            {
                DBConnection.openConn();

                string queryTahun = @"SELECT DISTINCT EXTRACT(YEAR FROM tanggal_transaksi) AS tahun
                                      FROM transaksi
                                      ORDER BY tahun";

                using (var cmdTahun = new NpgsqlCommand(queryTahun, DBConnection.connection))
                using (var readerTahun = cmdTahun.ExecuteReader())
                {
                    var tahunList = new List<int>();
                    while (readerTahun.Read())
                    {
                        int tahun = readerTahun.GetInt32(0);
                        tahunList.Add(tahun);
                    }

                    cbPerTahun.DataSource = tahunList;
                }

                string queryBulan = @"SELECT DISTINCT TO_CHAR(tanggal_transaksi, 'MM/YYYY') AS bulan_tahun
                                      FROM transaksi
                                      ORDER BY bulan_tahun";

                using (var cmdBulan = new NpgsqlCommand(queryBulan, DBConnection.connection))
                using (var readerBulan = cmdBulan.ExecuteReader())
                {
                    var bulanList = new List<string>();
                    while (readerBulan.Read())
                    {
                        string bulanTahun = readerBulan.GetString(0);
                        bulanList.Add(bulanTahun);
                    }

                    cbPerBulan.DataSource = bulanList;
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

        private void btnBulan_Click(object sender, EventArgs e)
        {
            int IDTempatPengepul = Form_Login_Admin.IdTempatPengepul;
            dgvRiwayatTransaksi.AutoGenerateColumns = false;

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

                string BulanTahun = (string)cbPerBulan.SelectedItem;
                var SplitBulanTahun = BulanTahun.Split('/');
                int Bulan = int.Parse(SplitBulanTahun[0]);
                int Tahun = int.Parse(SplitBulanTahun[1]);
                string query = @"SELECT t.id_transaksi, t.tanggal_transaksi, tp.nama_tempat, atp.nama_admin, c.nama_customer, st.Status
                                 FROM transaksi t
                                 JOIN tempatpengepul tp on t.id_tempatpengepul = tp.id_tempatpengepul
                                 JOIN admin_tempat_pengepul atp on t.id_admin = atp.id_admin
                                 JOIN customer c on t.id_customer = c.id_customer
                                 JOIN Status_Transaksi st on t.id_StatusTransaksi = st.id_StatusTransaksi
                                 WHERE EXTRACT(YEAR FROM t.tanggal_transaksi) = @tahun AND EXTRACT(MONTH FROM t.tanggal_transaksi) = @bulan AND t.id_tempatpengepul = @id_tempatpengepul
                                 ORDER BY t.id_transaksi";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@tahun", Tahun);
                    cmd.Parameters.AddWithValue("@bulan", Bulan);
                    cmd.Parameters.AddWithValue("@id_tempatpengepul", IDTempatPengepul);

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

            dgvRiwayatTransaksi.DataSource = dataTable;

            dgvRiwayatTransaksi.Columns[0].DataPropertyName = "ID Transaksi";
            dgvRiwayatTransaksi.Columns[1].DataPropertyName = "Tanggal Transaksi";
            dgvRiwayatTransaksi.Columns[2].DataPropertyName = "Tempat Pengepul";
            dgvRiwayatTransaksi.Columns[3].DataPropertyName = "Admin";
            dgvRiwayatTransaksi.Columns[4].DataPropertyName = "Customer";
            dgvRiwayatTransaksi.Columns[5].DataPropertyName = "Status Transaksi";
        }

        private void btnTahun_Click(object sender, EventArgs e)
        {
            int IDTempatPengepul = Form_Login_Admin.IdTempatPengepul;
            dgvRiwayatTransaksi.AutoGenerateColumns = false;

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

                int Tahun = (int)cbPerTahun.SelectedItem;
                string query = @"SELECT t.id_transaksi, t.tanggal_transaksi, tp.nama_tempat, atp.nama_admin, c.nama_customer, st.Status
                                 FROM transaksi t
                                 JOIN tempatpengepul tp on t.id_tempatpengepul = tp.id_tempatpengepul
                                 JOIN admin_tempat_pengepul atp on t.id_admin = atp.id_admin
                                 JOIN customer c on t.id_customer = c.id_customer
                                 JOIN Status_Transaksi st on t.id_StatusTransaksi = st.id_StatusTransaksi
                                 WHERE EXTRACT(YEAR FROM t.tanggal_transaksi) = @tahun AND t.id_tempatpengepul = @id_tempatpengepul
                                 ORDER BY t.id_transaksi";

                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@tahun", Tahun);
                    cmd.Parameters.AddWithValue("@id_tempatpengepul", IDTempatPengepul);

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

            dgvRiwayatTransaksi.DataSource = dataTable;

            dgvRiwayatTransaksi.Columns[0].DataPropertyName = "ID Transaksi";
            dgvRiwayatTransaksi.Columns[1].DataPropertyName = "Tanggal Transaksi";
            dgvRiwayatTransaksi.Columns[2].DataPropertyName = "Tempat Pengepul";
            dgvRiwayatTransaksi.Columns[3].DataPropertyName = "Admin";
            dgvRiwayatTransaksi.Columns[4].DataPropertyName = "Customer";
            dgvRiwayatTransaksi.Columns[5].DataPropertyName = "Status Transaksi";
        }
    }
}
