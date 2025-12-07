using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    public class NamHocBLL
    {
        NamHocDAL dal = new NamHocDAL();

        public DataTable LayDanhSachNam()
        {
            return dal.GetAll();
        }

        public bool Them(string tenNamHoc, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(tenNamHoc))
            {
                error = "Tên năm học không được để trống!";
                return false;
            }

            return dal.Insert(tenNamHoc) > 0;
        }

        public bool Sua(int id, string tenNamHoc, out string error)
        {
            error = "";

            if (id <= 0)
            {
                error = "ID năm học không hợp lệ!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tenNamHoc))
            {
                error = "Tên năm học không được để trống!";
                return false;
            }

            return dal.Update(id, tenNamHoc) > 0;
        }

        public bool Xoa(int id, out string error)
        {
            error = "";

            if (id <= 0)
            {
                error = "ID năm học không hợp lệ!";
                return false;
            }

            return dal.Delete(id) > 0;
        }
    }
}
