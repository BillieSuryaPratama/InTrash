using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class Transaksi
    {
        public int ID_Transaksi { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public int ID_TempatPengepul { get; set; }
        public int ID_Admin {  get; set; }
        public int ID_Customer {  get; set; }
    }
}
