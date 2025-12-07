using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL.Category
{
    public class LoaiDiemDAL
    {
        public DataTable GetAll()
        {
            return DbHelper.ExecuteQuery("sp_LoaiDiem_GetAll");
        }

        public int Insert(string tenLoaiDiem, int heSo)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@TenLoaiDiem", tenLoaiDiem),
            new SqlParameter("@HeSo", heSo)
        };
            return DbHelper.ExecuteNonQuery("sp_LoaiDiem_Insert", p);
        }

        public int Update(int id, string tenLoaiDiem, int heSo)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@IDLoaiDiem", id),
            new SqlParameter("@TenLoaiDiem", tenLoaiDiem),
            new SqlParameter("@HeSo", heSo)
        };
            return DbHelper.ExecuteNonQuery("sp_LoaiDiem_Update", p);
        }

        public int Delete(int id)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@IDLoaiDiem", id)
        };
            return DbHelper.ExecuteNonQuery("sp_LoaiDiem_Delete", p);
        }
    }
}
