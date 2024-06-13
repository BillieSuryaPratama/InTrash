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
    
    public partial class Reward_Admin : Form
    {
        private int GetCustomerIdFromPencairan(int idPencairan)
        {
            int idCustomer = 0;
            try
            {
                DBConnection.openConn();
                string query = @"SELECT id_customer FROM pencairan WHERE id_pencairan = @ID_Pencairan";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Pencairan", idPencairan);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idCustomer = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeConn();
            }
            return idCustomer;
        }

        private int ID_Pencairan;
        public Reward_Admin()
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

        private void Reward_Admin_Load(object sender, EventArgs e)
        {
            dgvListReward.AutoGenerateColumns = false;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Pencairan", typeof(int));
            dataTable.Columns.Add("Rekening Tujuan", typeof(string));
            dataTable.Columns.Add("Nominal", typeof(int));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Metode", typeof(string));
            dataTable.Columns.Add("Nama Customer", typeof(string));

            try
            {
                DBConnection.openConn();
                string query = @"SELECT p.id_pencairan, p.rekening_tujuan, p.nominal_pencairan, sp.status, mp.nama_metode, c.nama_customer
                                 FROM pencairan p
                                 JOIN Status_Pencairan sp ON p.id_statuspencairan = sp.id_statuspencairan
                                 JOIN MetodePencairan mp on p.id_metode = mp.id_metode
                                 JOIN Customer c ON p.id_customer = c.id_customer
                                 WHERE p.id_statuspencairan = @status
                                 ORDER BY p.id_pencairan";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Status", 1);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataTable.Rows.Add(reader["id_pencairan"], reader["rekening_tujuan"], reader["nominal_pencairan"], reader["status"], reader["nama_metode"], reader["nama_customer"]);
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

            dgvListReward.DataSource = dataTable;

            dgvListReward.Columns[0].DataPropertyName = "ID Pencairan";
            dgvListReward.Columns[1].DataPropertyName = "Rekening Tujuan";
            dgvListReward.Columns[2].DataPropertyName = "Nominal";
            dgvListReward.Columns[3].DataPropertyName = "Status";
            dgvListReward.Columns[4].DataPropertyName = "Metode";
            dgvListReward.Columns[5].DataPropertyName = "Nama Customer";


            try
            {
                DBConnection.openConn();

                string queryStatus1 = @"SELECT DISTINCT id_pencairan AS id
                                      FROM pencairan
                                      WHERE id_StatusPencairan = @Status
                                      ORDER BY id_pencairan";

                using (var cmd = new NpgsqlCommand(queryStatus1, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Status", 1);

                    using (var reader = cmd.ExecuteReader())
                    {
                        var StatusList = new List<int>();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            StatusList.Add(id);
                        }

                        cbKonfirmasi.DataSource = StatusList;
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

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedPencairanId = Convert.ToInt32(cbKonfirmasi.SelectedItem);

                DBConnection.openConn();

                string updateStatusQuery = @"UPDATE pencairan
                                             SET id_statuspencairan = @Status
                                             WHERE id_pencairan = @ID_Pencairan";
                using (var cmd = new NpgsqlCommand(updateStatusQuery, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Status", 2);
                    cmd.Parameters.AddWithValue("@ID_Pencairan", selectedPencairanId);
                    cmd.ExecuteNonQuery();
                }

                int nominalPencairan = 0;
                int idCustomer = 0;

                string selectQuery = @"SELECT nominal_pencairan, id_customer
                                       FROM pencairan
                                       WHERE id_pencairan = @ID_Pencairan";
                using (var cmd = new NpgsqlCommand(selectQuery, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Pencairan", selectedPencairanId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nominalPencairan = reader.GetInt32(0);
                            idCustomer = reader.GetInt32(1);
                        }
                    }
                }


                string updateSaldoQuery = @"UPDATE customer
                                            SET saldo = saldo - @Saldo
                                            WHERE id_customer = @ID_Customer";
                using (var cmd = new NpgsqlCommand(updateSaldoQuery, DBConnection.connection))
                {
                    cmd.Parameters.AddWithValue("@Saldo", nominalPencairan);
                    cmd.Parameters.AddWithValue("@ID_Customer", idCustomer);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Konfirmasi berhasil dan saldo nasabah telah diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBConnection.closeConn();
                this.Hide();
                Reward_Admin nextpage = new Reward_Admin();
                nextpage.FormClosed += (s, args) => this.Close();
                nextpage.ShowDialog();
            }
        }
    }
}
