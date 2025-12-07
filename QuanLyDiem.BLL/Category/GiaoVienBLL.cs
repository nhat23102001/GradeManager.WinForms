using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    public class GiaoVienBLL
    {
        private readonly GiaoVienDAL dal = new GiaoVienDAL();

        public DataTable LayDanhSachGV()
        {
            return dal.GetAll();
        }

        public bool Them(string maGV, string hoTen, string sdt, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(maGV))
            {
                error = "Mã giáo viên không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                error = "Họ tên không được để trống!";
                return false;
            }

            return dal.Insert(maGV, hoTen, sdt) > 0;
        }

        public bool Sua(int idGV, string maGV, string hoTen, string sdt, out string error)
        {
            error = "";

            if (idGV <= 0)
            {
                error = "ID giáo viên không hợp lệ!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(maGV))
            {
                error = "Mã giáo viên không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                error = "Họ tên không được để trống!";
                return false;
            }

            return dal.Update(idGV, maGV, hoTen, sdt) > 0;
        }

        public bool Xoa(int idGV, out string error)
        {
            error = "";

            if (idGV <= 0)
            {
                error = "ID giáo viên không hợp lệ!";
                return false;
            }

            return dal.Delete(idGV) > 0;
        }
    }
}
