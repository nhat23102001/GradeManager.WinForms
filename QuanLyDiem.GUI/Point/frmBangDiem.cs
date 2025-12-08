using QuanLyDiem.BLL;
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
        BangDiemBLL bllDB = new BangDiemBLL();
        NamHocBLL bllNH = new NamHocBLL();
        HocKyBLL bllHK = new HocKyBLL();
        MonHocBLL bllMH = new MonHocBLL();
        LopBLL bllL = new LopBLL();

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

            dgvHocSinh.DataSource = bllDB.LayDanhSachHocSinh((int)cboLop.SelectedValue);

            dgvHocSinh.Columns["IDHS"].Visible = false;
            dgvHocSinh.Columns["HoTen"].HeaderText = "Họ tên";
           // dgvHocSinh.Columns["NgaySinh"].HeaderText = "Ngày sinh";
           // dgvHocSinh.Columns["DiaChi"].HeaderText = "Địa chỉ";

            dgvHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadBangDiem()
        {
            if (cboNamHoc.SelectedValue == null ||
                cboHocKy.SelectedValue == null ||
                cboMon.SelectedValue == null ||
                cboLop.SelectedValue == null) return;

            dgvBangDiem.DataSource = bllDB.LayBangDiem(
                (int)cboNamHoc.SelectedValue,
                (int)cboHocKy.SelectedValue,
                (int)cboMon.SelectedValue,
                (int)cboLop.SelectedValue
            );

            dgvBangDiem.Columns["IDBangDiem"].Visible = false;
            dgvBangDiem.Columns["Diem"].HeaderText = "Điểm";
            dgvBangDiem.Columns["NgayNhap"].HeaderText = "Ngày nhập";

            dgvBangDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                if (bllDB.XoaDiem(selectedBangDiem, out err))
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
                if (bllDB.ThemDiem(
                    selectedHS,
                    (int)cboMon.SelectedValue,
                    (int)cboNamHoc.SelectedValue,
                    (int)cboHocKy.SelectedValue,
                    1, // mặc định loại điểm 1 tiết
                    diem,
                    out err))
                {
                    LoadBangDiem();
                }
                else MessageBox.Show(err);
            }
            else
            {
                if (bllDB.SuaDiem(selectedBangDiem, diem, out err))
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
    }
}
