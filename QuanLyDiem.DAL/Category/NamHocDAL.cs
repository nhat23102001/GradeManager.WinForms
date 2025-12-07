using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    public class NamHocDAL
    {
        public DataTable GetAll()
        {
            return DbHelper.ExecuteQuery("sp_NamHoc_GetAll");
        }

        public int Insert(string tenNamHoc)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@TenNamHoc", tenNamHoc)
        };

            return DbHelper.ExecuteNonQuery("sp_NamHoc_Insert", p);
        }

        public int Update(int id, string tenNamHoc)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@IDNamHoc", id),
            new SqlParameter("@TenNamHoc", tenNamHoc)
        };

            return DbHelper.ExecuteNonQuery("sp_NamHoc_Update", p);
        }

        public int Delete(int id)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@IDNamHoc", id)
        };

            return DbHelper.ExecuteNonQuery("sp_NamHoc_Delete", p);
        }
    }
}
