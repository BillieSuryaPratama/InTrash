using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class Admin
    {
        public int ID_Admin {  get; set; }
        public string Nama_Admin { get; set; }
        public string Username_Admin {  get; set; }
        public string Password_Admin {  get; set; }
        public string Alamat {  get; set; }
        public string No_HP {  get; set; }
        public int ID_TempatPengepul { get; set; }
    }
}
