using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    public class HocKyBLL
    {
        HocKyDAL dal = new HocKyDAL();

        public DataTable LayDanhSachHocKy()
        {
            return dal.GetAll();
        }

        public bool Them(string tenHocKy, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(tenHocKy))
            {
                error = "Tên học kỳ không được để trống!";
                return false;
            }

            return dal.Insert(tenHocKy) > 0;
        }

        public bool Sua(int id, string tenHocKy, out string error)
        {
            error = "";

            if (id <= 0)
            {
                error = "ID học kỳ không hợp lệ!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tenHocKy))
            {
                error = "Tên học kỳ không được để trống!";
                return false;
            }

            return dal.Update(id, tenHocKy) > 0;
        }

        public bool Xoa(int id, out string error)
        {
            error = "";

            if (id <= 0)
            {
                error = "ID học kỳ không hợp lệ!";
                return false;
            }

            return dal.Delete(id) > 0;
        }
    }
}
