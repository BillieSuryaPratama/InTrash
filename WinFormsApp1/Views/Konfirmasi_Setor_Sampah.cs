using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Views
{
    public partial class Konfirmasi_Setor_Sampah : Form
    {
        public Konfirmasi_Setor_Sampah()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setor_Sampah nextpage = new Setor_Sampah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Riwayat_Nasbah nextpage = new Riwayat_Nasbah();
            nextpage.FormClosed += (s, args) => this.Close();
            nextpage.ShowDialog();
        }
    }
}
