using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DAL.Point
{
    public class BangDiemDAL
    {
        // Lấy danh sách học sinh theo lớp
        public DataTable GetDanhSachHocSinh(int idLop)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@IDLop", idLop)
            };

            return DbHelper.ExecuteQuery("sp_BangDiem_GetDanhSachHS", p);
        }

        // Lấy bảng điểm theo bộ lọc
        public DataTable GetByFilter(int idNam, int idHocKy, int idMon, int idLop)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@IDNamHoc", idNam),
                new SqlParameter("@IDHocKy", idHocKy),
                new SqlParameter("@IDMon", idMon),
                new SqlParameter("@IDLop", idLop)
            };

            return DbHelper.ExecuteQuery("sp_BangDiem_GetByFilter", p);
        }

        // Thêm điểm
        public int Insert(int idHS, int idMon, int idNamHoc, int idHocKy, int idLoaiDiem, float diem)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@IDHS", idHS),
                new SqlParameter("@IDMon", idMon),
                new SqlParameter("@IDNamHoc", idNamHoc),
                new SqlParameter("@IDHocKy", idHocKy),
                new SqlParameter("@IDLoaiDiem", idLoaiDiem),
                new SqlParameter("@Diem", diem)
            };

            return DbHelper.ExecuteNonQuery("sp_BangDiem_Insert", p);
        }

        // Cập nhật điểm
        public int Update(int idBangDiem, float diem)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@IDBangDiem", idBangDiem),
                new SqlParameter("@Diem", diem)
            };

            return DbHelper.ExecuteNonQuery("sp_BangDiem_Update", p);
        }

        // Xóa điểm
        public int Delete(int idBangDiem)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@IDBangDiem", idBangDiem)
            };

            return DbHelper.ExecuteNonQuery("sp_BangDiem_Delete", p);
        }
    }
}
