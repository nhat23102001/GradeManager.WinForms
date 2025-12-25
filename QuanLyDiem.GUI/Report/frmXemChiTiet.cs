using QuanLyDiem.BLL.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.GUI.Report
{
    public partial class frmXemChiTiet : Form
    {
        private int _idHS;
        private int _idMon;
        private int _idNamHoc;
        private int _idHocKy;

        BangDiemHocSinhBLL bll = new BangDiemHocSinhBLL();

        public frmXemChiTiet(int idHS, int idMon, int idNamHoc, int idHocKy)
        {
            InitializeComponent();
            _idHS = idHS;
            _idMon = idMon;
            _idNamHoc = idNamHoc;
            _idHocKy = idHocKy;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXemChiTiet_Load(object sender, EventArgs e)
        {
            LoadChiTietMon();

        }

        private void LoadChiTietMon()
        {
            DataTable dt = bll.LayChiTietMon(_idHS, _idMon, _idNamHoc, _idHocKy);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu chi tiết môn!");
                return;
            }

            // Thông tin chung (lấy từ dòng đầu)
            lblHocSinh.Text = dt.Rows[0]["MaHS"] + " - " + dt.Rows[0]["HoTen"];
            lblLop.Text = dt.Rows[0]["TenLop"].ToString();
            lblMon.Text = dt.Rows[0]["TenMon"].ToString();
            lblHocKy.Text = dt.Rows[0]["TenHocKy"].ToString();
            lblNamHoc.Text = dt.Rows[0]["TenNamHoc"].ToString();

            dgvChiTiet.DataSource = dt;

            double dtb = TinhDiemTrungBinh(dt);
            lblDTB.Text = $"Điểm TB môn: {dtb}";

            // Ẩn cột không cần hiển thị
            dgvChiTiet.Columns["MaHS"].Visible = false;
            dgvChiTiet.Columns["HoTen"].Visible = false;
            dgvChiTiet.Columns["TenLop"].Visible = false;
            dgvChiTiet.Columns["TenMon"].Visible = false;
            dgvChiTiet.Columns["TenHocKy"].Visible = false;
            dgvChiTiet.Columns["TenNamHoc"].Visible = false;

            // Đặt lại tiêu đề
            dgvChiTiet.Columns["TenLoaiDiem"].HeaderText = "Loại điểm";
            dgvChiTiet.Columns["HeSo"].HeaderText = "Hệ số";
            dgvChiTiet.Columns["Diem"].HeaderText = "Điểm";
            dgvChiTiet.Columns["NgayNhap"].HeaderText = "Ngày nhập";

            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.RowHeadersVisible = false;
        }

        private double TinhDiemTrungBinh(DataTable dt)
        {
            double tong = 0;
            double tongHeSo = 0;

            foreach (DataRow r in dt.Rows)
            {
                double diem = Convert.ToDouble(r["Diem"]);
                int heSo = Convert.ToInt32(r["HeSo"]);

                tong += diem * heSo;
                tongHeSo += heSo;
            }

            if (tongHeSo == 0) return 0;
            return Math.Round(tong / tongHeSo, 2);
        }

    }
}
