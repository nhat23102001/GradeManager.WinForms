using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    public class MonHocBLL
    {
        private readonly MonHocDAL dal = new MonHocDAL();

        public DataTable LayDanhSachMonHoc()
        {
            return dal.GetAll();
        }

        public bool Them(string maMon, string tenMon, int heSo, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(maMon))
            {
                error = "Mã môn không được để trống!";
                return false;
            }

            if (maMon.Length > 20)
            {
                error = "Mã môn tối đa 20 ký tự!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tenMon))
            {
                error = "Tên môn không được để trống!";
                return false;
            }

            if (heSo <= 0)
            {
                error = "Hệ số phải là số nguyên dương!";
                return false;
            }

            return dal.Insert(maMon, tenMon, heSo) > 0;
        }

        public bool Sua(int idMon, string maMon, string tenMon, int heSo, out string error)
        {
            error = "";

            if (idMon <= 0)
            {
                error = "ID môn học không hợp lệ!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(maMon))
            {
                error = "Mã môn không được để trống!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tenMon))
            {
                error = "Tên môn không được để trống!";
                return false;
            }

            if (heSo <= 0)
            {
                error = "Hệ số phải là số nguyên dương!";
                return false;
            }

            return dal.Update(idMon, maMon, tenMon, heSo) > 0;
        }

        public bool Xoa(int idMon, out string error)
        {
            error = "";

            if (idMon <= 0)
            {
                error = "ID môn học không hợp lệ!";
                return false;
            }

            return dal.Delete(idMon) > 0;
        }
    }
}
