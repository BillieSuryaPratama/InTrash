using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class Nasabah
    {
        public int ID_Customer {  get; set; }
        public string Nama_Customer { get; set; }
        public string Username_Customer { get; set; }
        public string Password {  get; set; }
        public string No_HP {  get; set; }
        public string Alamat { get; set; }
        public int Saldo {  get; set; }
    }
}
