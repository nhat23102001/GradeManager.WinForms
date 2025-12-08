using QuanLyDiem.BLL;
using QuanLyDiem.BLL.Category;
using QuanLyDiem.BLL.Point;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.GUI.Point
{
    public partial class frmBangDiem : Form
    {
        BangDiemBLL bllBD = new BangDiemBLL();
        NamHocBLL bllNH = new NamHocBLL();
        HocKyBLL bllHK = new HocKyBLL();
        MonHocBLL bllMH = new MonHocBLL();
        LopBLL bllL = new LopBLL();
        HocSinhBLL bllHS = new HocSinhBLL();
        LoaiDiemBLL bllLD = new LoaiDiemBLL();

        bool isAdding = false;
        int selectedHS = 0;
        int selectedBangDiem = 0;

        public frmBangDiem()
        {
            InitializeComponent();
        }

        private void frmBangDiem_Load(object sender, EventArgs e)
        {
            LoadCombos();
            LoadHocSinh();
            LoadBangDiem();
            LoadLoaiDiem();
            SetControls(false);

            cboNamHoc.SelectedIndexChanged += FilterChanged;
            cboHocKy.SelectedIndexChanged += FilterChanged;
            cboMon.SelectedIndexChanged += FilterChanged;
            cboLop.SelectedIndexChanged += FilterChanged;
        }

        private void LoadCombos()
        {
            cboNamHoc.DataSource = bllNH.LayDanhSachNam();
            cboNamHoc.DisplayMember = "TenNamHoc";
            cboNamHoc.ValueMember = "IDNamHoc";

            cboHocKy.DataSource = bllHK.LayDanhSachHocKy();
            cboHocKy.DisplayMember = "TenHocKy";
            cboHocKy.ValueMember = "IDHocKy";

            cboMon.DataSource = bllMH.LayDanhSachMonHoc();
            cboMon.DisplayMember = "TenMon";
            cboMon.ValueMember = "IDMon";

            cboLop.DataSource = bllL.LayDanhSachLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "IDLop";
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            selectedHS = 0;
            selectedBangDiem = 0;

            LoadHocSinh();
            LoadBangDiem();
           
        }

        private void LoadHocSinh()
        {
            if (cboLop.SelectedValue == null) return;

            dgvHocSinh.DataSource = bllHS.LayHocSinhTheoLop((int)cboLop.SelectedValue);

            // Ẩn ID
            dgvHocSinh.Columns["IDHS"].Visible = false;

            // Set tiêu đề
            dgvHocSinh.Columns["MaHS"].HeaderText = "Mã HS";
            dgvHocSinh.Columns["HoTen"].HeaderText = "Họ tên";
            dgvHocSinh.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvHocSinh.Columns.Remove("GioiTinh");

            DataGridViewTextBoxColumn colGT = new DataGridViewTextBoxColumn();
            colGT.Name = "GioiTinh";
            colGT.HeaderText = "Giới tính";
            colGT.DataPropertyName = "GioiTinh";
            dgvHocSinh.Columns.Add(colGT);

            dgvHocSinh.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvHocSinh.Columns["TenLop"].HeaderText = "Lớp";

            dgvHocSinh.Columns["MaHS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHocSinh.Columns["HoTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHocSinh.Columns["NgaySinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHocSinh.Columns["GioiTinh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHocSinh.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHocSinh.Columns["TenLop"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvHocSinh.RowHeadersVisible = false; 
        }

        private void LoadBangDiem()
        {
            if (cboNamHoc.SelectedValue == null ||
               cboHocKy.SelectedValue == null ||
               cboMon.SelectedValue == null ||
               cboLop.SelectedValue == null) return;

            dgvBangDiem.DataSource = bllBD.LayBangDiem(
                (int)cboNamHoc.SelectedValue,
                (int)cboHocKy.SelectedValue,
                (int)cboMon.SelectedValue,
                (int)cboLop.SelectedValue
            );

            if (dgvBangDiem.DataSource == null) return;

            // Ẩn các ID
            dgvBangDiem.Columns["IDBangDiem"].Visible = false;
            dgvBangDiem.Columns["IDHS"].Visible = false;
            dgvBangDiem.Columns["IDMon"].Visible = false;
            dgvBangDiem.Columns["IDNamHoc"].Visible = false;
            dgvBangDiem.Columns["IDHocKy"].Visible = false;
            dgvBangDiem.Columns["IDLoaiDiem"].Visible = false;

            // ----- Đổi tên cột -----
            dgvBangDiem.Columns["MaHS"].HeaderText = "Mã HS";
            dgvBangDiem.Columns["HoTen"].HeaderText = "Họ tên";
            dgvBangDiem.Columns["TenLop"].HeaderText = "Lớp";
            dgvBangDiem.Columns["TenMon"].HeaderText = "Môn học";
            dgvBangDiem.Columns["TenLoaiDiem"].HeaderText = "Loại điểm";
            dgvBangDiem.Columns["HeSoDiem"].HeaderText = "Hệ số";
            dgvBangDiem.Columns["Diem"].HeaderText = "Điểm";
            dgvBangDiem.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            dgvBangDiem.Columns["TenHocKy"].HeaderText = "Học kỳ";
            dgvBangDiem.Columns["TenNamHoc"].HeaderText = "Năm học";

            // ----- Thiết lập kích thước cột -----
            dgvBangDiem.Columns["MaHS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBangDiem.Columns["HoTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBangDiem.Columns["TenLop"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBangDiem.Columns["TenMon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBangDiem.Columns["TenLoaiDiem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBangDiem.Columns["HeSoDiem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBangDiem.Columns["Diem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBangDiem.Columns["NgayNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBangDiem.Columns["TenHocKy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBangDiem.Columns["TenNamHoc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Bỏ row header
            dgvBangDiem.RowHeadersVisible = false;

            // ----- Sắp xếp lại thứ tự cột -----
            dgvBangDiem.Columns["MaHS"].DisplayIndex = 0;
            dgvBangDiem.Columns["HoTen"].DisplayIndex = 1;
            dgvBangDiem.Columns["TenLop"].DisplayIndex = 2;
            dgvBangDiem.Columns["TenMon"].DisplayIndex = 3;
            dgvBangDiem.Columns["TenLoaiDiem"].DisplayIndex = 4;
            dgvBangDiem.Columns["HeSoDiem"].DisplayIndex = 5;
            dgvBangDiem.Columns["Diem"].DisplayIndex = 6;
            dgvBangDiem.Columns["NgayNhap"].DisplayIndex = 7;
            dgvBangDiem.Columns["TenHocKy"].DisplayIndex = 8;
            dgvBangDiem.Columns["TenNamHoc"].DisplayIndex = 9;
        }

        private void LoadLoaiDiem()
        {
            cboLoaiDiem.DataSource = bllLD.LayDanhSachLoaiDiem();
            cboLoaiDiem.DisplayMember = "TenLoaiDiem";
            cboLoaiDiem.ValueMember = "IDLoaiDiem";
            cboLoaiDiem.SelectedIndex = 0;
        }


        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                selectedHS = Convert.ToInt32(dgvHocSinh.CurrentRow.Cells["IDHS"].Value);
        }

        private void dgvBangDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                selectedBangDiem = Convert.ToInt32(dgvBangDiem.CurrentRow.Cells["IDBangDiem"].Value);
        }

        private void SetControls(bool editing)
        {
            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (selectedHS == 0)
            {
                MessageBox.Show("Hãy chọn học sinh!");
                return;
            }

            isAdding = true;
            SetControls(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedBangDiem == 0)
            {
                MessageBox.Show("Chọn điểm để sửa!");
                return;
            }

            isAdding = false;
            SetControls(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedBangDiem == 0)
            {
                MessageBox.Show("Chọn điểm để xoá!");
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xoá điểm này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err;
                if (bllBD.XoaDiem(selectedBangDiem, out err))
                {
                    LoadBangDiem();
                    selectedBangDiem = 0;
                }
                else MessageBox.Show(err);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float diem;

            string inp = Microsoft.VisualBasic.Interaction.InputBox("Nhập điểm:", "Điểm", "");
            if (!float.TryParse(inp, out diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm không hợp lệ (0 - 10)!");
                return;
            }

            string err;

            if (isAdding)
            {
                if (bllBD.ThemDiem(
                    selectedHS,
                    (int)cboMon.SelectedValue,
                    (int)cboNamHoc.SelectedValue,
                    (int)cboHocKy.SelectedValue,
                    (int)cboLoaiDiem.SelectedValue,
                    diem,
                    out err))
                {
                    LoadBangDiem();
                }
                else MessageBox.Show(err);
            }
            else
            {
                if (bllBD.SuaDiem(selectedBangDiem, diem, out err))
                {
                    LoadBangDiem();
                }
                else MessageBox.Show(err);
            }

            SetControls(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControls(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHocSinh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHocSinh.Columns[e.ColumnIndex].Name == "GioiTinh")
            {
                if (e.Value != null && e.Value is bool)
                {
                    bool gt = (bool)e.Value;
                    e.Value = gt ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }
            }

        }
    }
}
