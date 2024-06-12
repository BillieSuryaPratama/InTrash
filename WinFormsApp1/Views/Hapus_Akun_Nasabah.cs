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
    public partial class Hapus_Akun_Nasabah : Form
    {
        public Hapus_Akun_Nasabah()
        {
            InitializeComponent();
        }

        private void Hapus_Akun_Nasabah_Load(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            try
            {
                DBConnection.openConn();

                using (var transaction = DBConnection.connection.BeginTransaction())
                {
                    try
                    {
   
                        string getCustomerIdQuery = "SELECT id_customer FROM customer WHERE Password_Customer = @password LIMIT 1";
                        int customerId;
                        using (var getCustomerIdCmd = new NpgsqlCommand(getCustomerIdQuery, DBConnection.connection, transaction))
                        {
                            getCustomerIdCmd.Parameters.AddWithValue("@password", password);
                            var result = getCustomerIdCmd.ExecuteScalar();
                            if (result == null)
                            {
                                MessageBox.Show("Kata sandi salah atau tidak ada akun yang sesuai. Silakan coba lagi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            customerId = Convert.ToInt32(result);
                        }

                        string deleteCustomerQuery = "DELETE FROM customer WHERE id_customer = @customerId";
                        using (var deleteCustomerCmd = new NpgsqlCommand(deleteCustomerQuery, DBConnection.connection, transaction))
                        {
                            deleteCustomerCmd.Parameters.AddWithValue("@customerId", customerId);
                            int rowsAffected = deleteCustomerCmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Akun berhasil dihapus.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Gagal menghapus akun. Silakan coba lagi.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error: {ex.Message}\n\nDetail: {ex.StackTrace}", "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Beranda_Nasabah nextpage = new Beranda_Nasabah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }

}



