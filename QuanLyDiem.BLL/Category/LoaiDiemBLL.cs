using QuanLyDiem.DAL;
using QuanLyDiem.DAL.Category;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL.Category
{
    public class LoaiDiemBLL
    {
        private LoaiDiemDAL dal = new LoaiDiemDAL();

        public DataTable LayDanhSachLoaiDiem()
        {
            return dal.GetAll();
        }

        public bool Them(string tenLoaiDiem, int heSo, out string error)
        {
            error = "";

            if (string.IsNullOrWhiteSpace(tenLoaiDiem))
            {
                error = "Tên loại điểm không được để trống!";
                return false;
            }

            if (heSo <= 0)
            {
                error = "Hệ số phải lớn hơn 0!";
                return false;
            }

            return dal.Insert(tenLoaiDiem, heSo) > 0;
        }

        public bool Sua(int id, string tenLoaiDiem, int heSo, out string error)
        {
            error = "";

            if (id <= 0)
            {
                error = "ID không hợp lệ!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tenLoaiDiem))
            {
                error = "Tên loại điểm không được để trống!";
                return false;
            }

            if (heSo <= 0)
            {
                error = "Hệ số phải lớn hơn 0!";
                return false;
            }

            return dal.Update(id, tenLoaiDiem, heSo) > 0;
        }

        public bool Xoa(int id, out string error)
        {
            error = "";

            if (id <= 0)
            {
                error = "ID không hợp lệ!";
                return false;
            }

            return dal.Delete(id) > 0;
        }
    }
}
