using QuanLyDiem.DAL.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.BLL.Report
{
    public class BangDiemHocSinhBLL
    {
        BangDiemHocSinhDAL dal = new BangDiemHocSinhDAL();

        public DataTable LayDanhSachLop()
        {
            return dal.GetDanhSachLop();
        }

        public DataTable LayHocSinhTheoLop(int idLop)
        {
            return dal.GetHocSinhTheoLop(idLop);
        }

        public DataTable LayBangDiemHocSinh(int idHS, int idNamHoc, int idHocKy)
        {
            return dal.GetBangDiemHocSinh(idHS, idNamHoc, idHocKy);
        }

        public DataTable LayChiTietMon(
    int idHS,
    int idMon,
    int idNamHoc,
    int idHocKy)
        {
            return dal.GetChiTietMon(idHS, idMon, idNamHoc, idHocKy);
        }

    }
}
