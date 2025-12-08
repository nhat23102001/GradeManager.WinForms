using QuanLyDiem.DAL.Point;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL.Point
{
    public class BangDiemBLL
    {
        private BangDiemDAL dal = new BangDiemDAL();

        // Lấy danh sách học sinh theo lớp
        public DataTable LayDanhSachHocSinh(int idLop)
        {
            return dal.GetDanhSachHocSinh(idLop);
        }

        // Lấy bảng điểm theo bộ lọc
        public DataTable LayBangDiem(int idNam, int idHocKy, int idMon, int idLop)
        {
            return dal.GetByFilter(idNam, idHocKy, idMon, idLop);
        }

        // Thêm điểm
        public bool ThemDiem(int idHS, int idMon, int idNamHoc, int idHocKy,
                             int idLoaiDiem, float diem, out string error)
        {
            error = "";

            if (diem < 0 || diem > 10)
            {
                error = "Điểm phải nằm trong khoảng 0 - 10.";
                return false;
            }

            int result = dal.Insert(idHS, idMon, idNamHoc, idHocKy, idLoaiDiem, diem);
            return result > 0;
        }

        // Cập nhật điểm
        public bool SuaDiem(int idBangDiem, float diem, out string error)
        {
            error = "";

            if (diem < 0 || diem > 10)
            {
                error = "Điểm phải nằm trong khoảng 0 - 10.";
                return false;
            }

            int result = dal.Update(idBangDiem, diem);
            return result > 0;
        }

        // Xóa điểm
        public bool XoaDiem(int idBangDiem, out string error)
        {
            error = "";

            if (idBangDiem <= 0)
            {
                error = "ID bảng điểm không hợp lệ.";
                return false;
            }

            return dal.Delete(idBangDiem) > 0;
        }
    }
}
