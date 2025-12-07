using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL
{
    public class HocSinhDAL
    {
        public DataTable GetAll()
        {
            return DbHelper.ExecuteQuery("sp_HocSinh_GetAll");
        }

        public DataTable GetLopSimple()
        {
            return DbHelper.ExecuteQuery("sp_Lop_GetAllSimple");
        }

        public int Insert(string maHS, string hoTen, DateTime ngaySinh, bool gioiTinh,
                          string diaChi, int idLop)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@MaHS", maHS),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@IDLop", idLop)
            };

            return DbHelper.ExecuteNonQuery("sp_HocSinh_Insert", p);
        }

        public int Update(int idHS, string maHS, string hoTen, DateTime ngaySinh, bool gioiTinh,
                          string diaChi, int idLop)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@IDHS", idHS),
                new SqlParameter("@MaHS", maHS),
                new SqlParameter("@HoTen", hoTen),
                new SqlParameter("@NgaySinh", ngaySinh),
                new SqlParameter("@GioiTinh", gioiTinh),
                new SqlParameter("@DiaChi", diaChi),
                new SqlParameter("@IDLop", idLop)
            };

            return DbHelper.ExecuteNonQuery("sp_HocSinh_Update", p);
        }

        public int Delete(int idHS)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@IDHS", idHS)
            };

            return DbHelper.ExecuteNonQuery("sp_HocSinh_Delete", p);
        }
    }
}
