using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    public class HocKyDAL
    {
        public DataTable GetAll()
        {
            return DbHelper.ExecuteQuery("sp_HocKy_GetAll");
        }

        public int Insert(string tenHocKy)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@TenHocKy", tenHocKy)
        };

            return DbHelper.ExecuteNonQuery("sp_HocKy_Insert", p);
        }

        public int Update(int id, string tenHocKy)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@IDHocKy", id),
            new SqlParameter("@TenHocKy", tenHocKy)
        };

            return DbHelper.ExecuteNonQuery("sp_HocKy_Update", p);
        }

        public int Delete(int id)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@IDHocKy", id)
        };

            return DbHelper.ExecuteNonQuery("sp_HocKy_Delete", p);
        }
    }
}
