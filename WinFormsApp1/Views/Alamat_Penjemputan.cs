using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers;

namespace WinFormsApp1.Views
{
    public partial class Alamat_Penjemputan : Form
    {
        public Alamat_Penjemputan()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Beranda_Kurir nextpage = new Beranda_Kurir();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void Alamat_Penjemputan_Load(object sender, EventArgs e)
        {
            dgvListAlamat.AutoGenerateColumns = false;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID Transaksi", typeof(int));
            dataTable.Columns.Add("Alamat", typeof(string));

            try
            {
                DBConnection.openConn();
                string query = @"select t.id_transaksi, c.alamat
                                 From customer c
                                 Join transaksi t on (c.id_customer = t.id_customer)
                                 where id_statustransaksi = 2";
                using (var cmd = new NpgsqlCommand(query, DBConnection.connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dataTable.Rows.Add(reader["id_transaksi"], reader["alamat"]);
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

            dgvListAlamat.DataSource = dataTable;

            //if (!dgvListAlamat.AutoGenerateColumns)
            //{
            //    dgvListAlamat.Columns.Clear();
            //    dgvListAlamat.Columns.Add(new DataGridViewTextBoxColumn()
            //    {
            //        Name = "ID Transaksi",
            //        DataPropertyName = "ID Transaksi",
            //        HeaderText = "ID Transaksi"
            //    });
            //    dgvListAlamat.Columns.Add(new DataGridViewTextBoxColumn()
            //    {
            //        Name = "Alamat",
            //        DataPropertyName = "Alamat",
            //        HeaderText = "Alamat"
            //    });

            //}
        }
    }
}
