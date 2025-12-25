using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyDiem.DAL.Report
{
    public class BangDiemHocSinhDAL
    {
        // Lấy danh sách lớp (dùng lại proc đơn giản đã có)
        public DataTable GetDanhSachLop()
        {
            return DbHelper.ExecuteQuery("sp_Lop_GetAllSimple");
        }

        // Lấy danh sách học sinh theo lớp
        public DataTable GetHocSinhTheoLop(int idLop)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@IDLop", idLop)
            };

            return DbHelper.ExecuteQuery("sp_HocSinh_GetByLop", p);
        }

        // Lấy bảng điểm của 1 học sinh theo năm + học kỳ
        public DataTable GetBangDiemHocSinh(int idHS, int idNam, int idHK)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@IDHS", idHS),
                new SqlParameter("@IDNamHoc", idNam),
                new SqlParameter("@IDHocKy", idHK)
            };

            return DbHelper.ExecuteQuery("sp_BangDiem_GetByHocSinh", p);
        }

        public DataTable GetChiTietMon(int idHS, int idMon, int idNamHoc, int idHocKy)
        {
            SqlParameter[] p =
            {
        new SqlParameter("@IDHS", idHS),
        new SqlParameter("@IDMon", idMon),
        new SqlParameter("@IDNamHoc", idNamHoc),
        new SqlParameter("@IDHocKy", idHocKy)
    };

            return DbHelper.ExecuteQuery("sp_BangDiem_ChiTietMon", p);
        }

    }
}
