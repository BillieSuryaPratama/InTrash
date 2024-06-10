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
    public partial class Konfirmasi_Jemput_Sampah : Form
    {
        public Konfirmasi_Jemput_Sampah()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            this.Close();
            Riwayat_Nasbah formInfo = new Riwayat_Nasbah();
            formInfo.ShowDialog();
        }
    }
}
