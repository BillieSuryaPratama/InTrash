using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class Kurir
    {
        public int ID_Kurir { get; set; }
        public string Nama_Kurir { get; set; }
        public string Username_Kurir { get; set; }
        public string Password {  get; set; }
        public string No_HP {  get; set; }
        public int ID_TempatPengepul {  get; set; }
    }
}
