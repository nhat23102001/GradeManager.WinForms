using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    public class LopDAL
    {
        public DataTable GetAll()
        {
            return DbHelper.ExecuteQuery("sp_Lop_GetAll");
        }

        public DataTable GetAllSimple()
        {
            return DbHelper.ExecuteQuery("sp_Lop_GetAllSimple");
        }

        public int Insert(string maLop, string tenLop, string khoi, int siSo)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@MaLop", maLop),
                new SqlParameter("@TenLop", tenLop),
                new SqlParameter("@Khoi", khoi),
                new SqlParameter("@SiSo", siSo)
            };

            return DbHelper.ExecuteNonQuery("sp_Lop_Insert", param);
        }

        public int Update(int idLop, string maLop, string tenLop, string khoi, int siSo)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@IDLop", idLop),
                new SqlParameter("@MaLop", maLop),
                new SqlParameter("@TenLop", tenLop),
                new SqlParameter("@Khoi", khoi),
                new SqlParameter("@SiSo", siSo)
            };

            return DbHelper.ExecuteNonQuery("sp_Lop_Update", param);
        }

        public int Delete(int idLop)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@IDLop", idLop)
            };

            return DbHelper.ExecuteNonQuery("sp_Lop_Delete", param);
        }
    }
}
