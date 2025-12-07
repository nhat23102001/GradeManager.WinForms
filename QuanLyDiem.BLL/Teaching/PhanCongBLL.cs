using QuanLyDiem.DAL.Teaching;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL.Teaching
{
    public class PhanCongBLL
    {
        private readonly PhanCongDAL dal = new PhanCongDAL();

        public DataTable LayDanhSachPhanCong()
        {
            return dal.GetAll();
        }

        public DataTable LayDanhSachGiaoVien()
        {
            return dal.GetGiaoVien();
        }

        public DataTable LayDanhSachLop()
        {
            return dal.GetLop();
        }

        public DataTable LayDanhSachMonHoc()
        {
            return dal.GetMonHoc();
        }

        public bool Them(int idGV, int idLop, int idMon, out string error)
        {
            error = "";

            if (idGV <= 0 || idLop <= 0 || idMon <= 0)
            {
                error = "Vui lòng chọn đủ giáo viên, lớp và môn học!";
                return false;
            }

            return dal.Insert(idGV, idLop, idMon) > 0;
        }

        public bool Sua(int idPC, int idGV, int idLop, int idMon, out string error)
        {
            error = "";

            if (idPC <= 0)
            {
                error = "Bản ghi phân công không hợp lệ!";
                return false;
            }

            if (idGV <= 0 || idLop <= 0 || idMon <= 0)
            {
                error = "Vui lòng chọn đủ giáo viên, lớp và môn học!";
                return false;
            }

            return dal.Update(idPC, idGV, idLop, idMon) > 0;
        }

        public bool Xoa(int idPC, out string error)
        {
            error = "";

            if (idPC <= 0)
            {
                error = "Bản ghi phân công không hợp lệ!";
                return false;
            }

            return dal.Delete(idPC) > 0;
        }
    }
}
