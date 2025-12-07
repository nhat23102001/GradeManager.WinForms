using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    public class MonHocDAL
    {
        public DataTable GetAll()
        {
            return DbHelper.ExecuteQuery("sp_MonHoc_GetAll");
        }

        public int Insert(string maMon, string tenMon, int heSo)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@MaMon", maMon),
                new SqlParameter("@TenMon", tenMon),
                new SqlParameter("@HeSo", heSo)
            };

            return DbHelper.ExecuteNonQuery("sp_MonHoc_Insert", p);
        }

        public int Update(int idMon, string maMon, string tenMon, int heSo)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@IDMon", idMon),
                new SqlParameter("@MaMon", maMon),
                new SqlParameter("@TenMon", tenMon),
                new SqlParameter("@HeSo", heSo)
            };

            return DbHelper.ExecuteNonQuery("sp_MonHoc_Update", p);
        }

        public int Delete(int idMon)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@IDMon", idMon)
            };

            return DbHelper.ExecuteNonQuery("sp_MonHoc_Delete", p);
        }
    }
}
