using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    public class LopBLL
    {
        LopDAL dal = new LopDAL();

        public DataTable LayDanhSachLop()
        {
            return dal.GetAll();
        }

        public DataTable LayDanhSachLopSimple()
        {
            return dal.GetAllSimple();
        }

        public bool Them(string maLop, string tenLop, string khoi, int siSo, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(maLop))
            {
                error = "Mã lớp không được để trống!";
                return false;
            }

            if (maLop.Length > 20)
            {
                error = "Mã lớp không được vượt quá 20 ký tự!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tenLop))
            {
                error = "Tên lớp không được để trống!";
                return false;
            }

            if (siSo < 0)
            {
                error = "Sĩ số không hợp lệ!";
                return false;
            }

            return dal.Insert(maLop, tenLop, khoi, siSo) > 0;
        }


        public bool Sua(int idLop, string maLop, string tenLop, string khoi, int siSo, out string error)
        {
            error = "";

            if (idLop <= 0)
            {
                error = "ID lớp không hợp lệ!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(maLop))
            {
                error = "Mã lớp không được để trống!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tenLop))
            {
                error = "Tên lớp không được để trống!";
                return false;
            }

            if (siSo < 0)
            {
                error = "Sĩ số không hợp lệ!";
                return false;
            }

            return dal.Update(idLop, maLop, tenLop, khoi, siSo) > 0;
        }

        public bool Xoa(int idLop, out string error)
        {
            error = "";

            if (idLop <= 0)
            {
                error = "ID lớp không hợp lệ!";
                return false;
            }

            return dal.Delete(idLop) > 0;
        }
    }
}
