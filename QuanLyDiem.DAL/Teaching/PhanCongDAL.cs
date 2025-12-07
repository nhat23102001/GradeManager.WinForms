using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL.Teaching
{
    public class PhanCongDAL
    {
        public DataTable GetAll()
        {
            return DbHelper.ExecuteQuery("sp_PhanCong_GetAll");
        }

        public int Insert(int idGV, int idLop, int idMon)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@IDGV", idGV),
            new SqlParameter("@IDLop", idLop),
            new SqlParameter("@IDMon", idMon)
        };

            return DbHelper.ExecuteNonQuery("sp_PhanCong_Insert", p);
        }

        public int Update(int idPC, int idGV, int idLop, int idMon)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@IDPC", idPC),
            new SqlParameter("@IDGV", idGV),
            new SqlParameter("@IDLop", idLop),
            new SqlParameter("@IDMon", idMon)
        };

            return DbHelper.ExecuteNonQuery("sp_PhanCong_Update", p);
        }

        public int Delete(int idPC)
        {
            SqlParameter[] p =
            {
            new SqlParameter("@IDPC", idPC)
        };

            return DbHelper.ExecuteNonQuery("sp_PhanCong_Delete", p);
        }

        // Load dữ liệu cho combobox
        public DataTable GetGiaoVien()
        {
            return DbHelper.ExecuteQuery("sp_GiaoVien_GetAllSimple");
        }

        public DataTable GetLop()
        {
            return DbHelper.ExecuteQuery("sp_Lop_GetAllSimple");
        }

        public DataTable GetMonHoc()
        {
            return DbHelper.ExecuteQuery("sp_MonHoc_GetAllSimple");
        }
    }
}
