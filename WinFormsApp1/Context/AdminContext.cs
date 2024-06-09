using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Controllers;
using Npgsql;
using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1.Context
{
    internal class AdminContext
    {
        public List<Admin> ListAdmin = new List<Admin>();
        NpgsqlCommand command = new NpgsqlCommand();
        NpgsqlDataReader reader;
        public bool Read()
        {
            bool isSuccess = false;
            DBConnection.openConn();

            string sql = @"SELECT a.id_admin, a.nama_admin, a.username_admin, a.password_admin, a.alamat, a.no_HP, a.id_tempatpengepul, tp.nama_tempat
                           FROM Admin_Tempat_Pengepul a
                           JOIN tempatpengepul tp on a.id_tempatpengepul = tp.id_tempatpengepul
                           ORDER BY a.id_admin;";
            return isSuccess;
        }
    }
}
