using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{

    public class GiaoVienDAL
    {
        public DataTable GetAll()
        {
            return DbHelper.ExecuteQuery("sp_GiaoVien_GetAll");
        }

        public int Insert(string maGV, string hoTen, string sdt)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@MaGV", maGV),
            new SqlParameter("@HoTen", hoTen),
            new SqlParameter("@SDT", sdt)
        };

            return DbHelper.ExecuteNonQuery("sp_GiaoVien_Insert", p);
        }

        public int Update(int idGV, string maGV, string hoTen, string sdt)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@IDGV", idGV),
            new SqlParameter("@MaGV", maGV),
            new SqlParameter("@HoTen", hoTen),
            new SqlParameter("@SDT", sdt)
        };

            return DbHelper.ExecuteNonQuery("sp_GiaoVien_Update", p);
        }

        public int Delete(int idGV)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@IDGV", idGV)
        };

            return DbHelper.ExecuteNonQuery("sp_GiaoVien_Delete", p);
        }
    }
}
