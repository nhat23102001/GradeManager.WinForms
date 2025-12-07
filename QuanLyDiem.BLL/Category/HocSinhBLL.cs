using QuanLyDiem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL
{
    public class HocSinhBLL
    {
        HocSinhDAL dal = new HocSinhDAL();

        public DataTable LayDanhSachHS()
        {
            return dal.GetAll();
        }

        public DataTable LayDanhSachLop()
        {
            return dal.GetLopSimple();
        }

        public bool Them(string maHS, string hoTen, DateTime ngaySinh, bool gioiTinh,
                        string diaChi, int idLop, out string error)
        {
            error = "";

            // Validation
            if (string.IsNullOrWhiteSpace(maHS))
            {
                error = "Mã học sinh không được để trống!";
                return false;
            }

            if (maHS.Length > 20)
            {
                error = "Mã học sinh không được vượt quá 20 ký tự!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                error = "Họ tên không được để trống!";
                return false;
            }

            if (idLop <= 0)
            {
                error = "Vui lòng chọn lớp!";
                return false;
            }

            return dal.Insert(maHS, hoTen, ngaySinh, gioiTinh, diaChi, idLop) > 0;
        }

        public bool Sua(int idHS, string maHS, string hoTen, DateTime ngaySinh, bool gioiTinh,
                        string diaChi, int idLop, out string error)
        {
            error = "";

            if (idHS <= 0)
            {
                error = "ID học sinh không hợp lệ!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(maHS))
            {
                error = "Mã học sinh không được để trống!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                error = "Họ tên không được để trống!";
                return false;
            }

            if (idLop <= 0)
            {
                error = "Vui lòng chọn lớp!";
                return false;
            }

            return dal.Update(idHS, maHS, hoTen, ngaySinh, gioiTinh, diaChi, idLop) > 0;
        }

        public bool Xoa(int idHS, out string error)
        {
            error = "";

            if (idHS <= 0)
            {
                error = "ID học sinh không hợp lệ!";
                return false;
            }

            return dal.Delete(idHS) > 0;
        }
    }
}
