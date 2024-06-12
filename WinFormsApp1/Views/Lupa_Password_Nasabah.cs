using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using WinFormsApp1.Controllers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1.Views
{
    public partial class Lupa_Password_Nasabah : Form
    {
        private int id_customer;
        private string newPass;
        private string confirmPass;
        private bool modeConfirmPwd = false;

        public Lupa_Password_Nasabah(String id_akun)
        {
            id_customer = int.Parse(id_akun);
            InitializeComponent();
        }

        private void btnSetuju_Click(object sender, EventArgs e)
        {
            if (modeConfirmPwd)
            {
                DBConnection.openConn();


                // Memperbarui password di database
                string updateQuery =
                    @"UPDATE customer
                            SET password_customer= @NewPassword 
                            WHERE id_customer= @id_customer";
                using (var conn = new NpgsqlCommand(updateQuery, DBConnection.connection))
                {
                    DBConnection.openConn();
                    using (var cmd = new NpgsqlCommand(updateQuery, DBConnection.connection))
                    {
                        cmd.Parameters.AddWithValue("NewPassword", newPass);
                        cmd.Parameters.AddWithValue("id_customer", id_customer);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Password berhasil diperbarui!",
                                "Informasi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                            this.Hide();
                            Form_Login_Nasabah nextpage = new Form_Login_Nasabah();
                            nextpage.FormClosed += (s, args) => this.Close();
                            nextpage.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Gagal memperbarui password. id_customertidak ditemukan.",
                                "Perhatian",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
            else
                MessageBox.Show(
                    "Tekan tombol Simpan terlebih dahulu!",
                    "Perhatian",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            newPass = tb_sandibaru.Text;
            confirmPass = tb_confirmsandi.Text;

            // Memastikan password baru dan konfirmasi password cocok
            if (newPass != confirmPass)
            {
                MessageBox.Show(
                    "Password baru dan konfirmasi password tidak cocok!",
                    "Perhatian",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            // Memastikan password baru dan konfirmasi password harus terisi
            if (newPass.Equals("") && confirmPass.Equals(""))
            {
                MessageBox.Show(
                    "Masukkan password baru!",
                    "Perhatian",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            else
            {
                tb_sandibaru.Enabled = false;
                tb_confirmsandi.Enabled = false;
                modeConfirmPwd = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            newPass = tb_sandibaru.Text;
            confirmPass = tb_confirmsandi.Text;
            tb_sandibaru.Enabled = true;
            tb_confirmsandi.Enabled = true;
            modeConfirmPwd = false;
        }

        private void tb_sandibaru_TextChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
