using QuanLyDiem.BLL.Teaching;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.GUI.Teaching
{
    public partial class frmPhanCong : Form
    {
        private readonly PhanCongBLL bll = new PhanCongBLL();
        private bool isAdding = false;
        public frmPhanCong()
        {
            InitializeComponent();
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadGrid();
            SetControls(false);
        }

        private void LoadComboBox()
        {
            // Giáo viên
            cboGiaoVien.DataSource = bll.LayDanhSachGiaoVien();
            cboGiaoVien.DisplayMember = "HoTen";
            cboGiaoVien.ValueMember = "IDGV";
            cboGiaoVien.SelectedIndex = -1;

            // Lớp
            cboLop.DataSource = bll.LayDanhSachLop();
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "IDLop";
            cboLop.SelectedIndex = -1;

            // Môn học
            cboMon.DataSource = bll.LayDanhSachMonHoc();
            cboMon.DisplayMember = "TenMon";
            cboMon.ValueMember = "IDMon";
            cboMon.SelectedIndex = -1;
        }

        private void LoadGrid()
        {
            dgvPhanCong.DataSource = bll.LayDanhSachPhanCong();

            if (dgvPhanCong.Columns.Contains("IDPC"))
                dgvPhanCong.Columns["IDPC"].Visible = false;
            if (dgvPhanCong.Columns.Contains("IDGV"))
                dgvPhanCong.Columns["IDGV"].Visible = false;
            if (dgvPhanCong.Columns.Contains("IDLop"))
                dgvPhanCong.Columns["IDLop"].Visible = false;
            if (dgvPhanCong.Columns.Contains("IDMon"))
                dgvPhanCong.Columns["IDMon"].Visible = false;

            dgvPhanCong.Columns["MaGV"].HeaderText = "Mã GV";
            dgvPhanCong.Columns["TenGV"].HeaderText = "Giáo viên";
            dgvPhanCong.Columns["MaLop"].HeaderText = "Mã lớp";
            dgvPhanCong.Columns["TenLop"].HeaderText = "Lớp";
            dgvPhanCong.Columns["MaMon"].HeaderText = "Mã môn";
            dgvPhanCong.Columns["TenMon"].HeaderText = "Môn học";

            dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetControls(bool editing)
        {
            cboGiaoVien.Enabled = editing;
            cboLop.Enabled = editing;
            cboMon.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
        }

        private void ClearInputs()
        {
            txtIDPC.Text = "";
            cboGiaoVien.SelectedIndex = -1;
            cboLop.SelectedIndex = -1;
            cboMon.SelectedIndex = -1;
        }

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhanCong.CurrentRow != null)
            {
                txtIDPC.Text = dgvPhanCong.CurrentRow.Cells["IDPC"].Value.ToString();

                // Set value cho combobox theo ID
                cboGiaoVien.SelectedValue = dgvPhanCong.CurrentRow.Cells["IDGV"].Value;
                cboLop.SelectedValue = dgvPhanCong.CurrentRow.Cells["IDLop"].Value;
                cboMon.SelectedValue = dgvPhanCong.CurrentRow.Cells["IDMon"].Value;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearInputs();
            SetControls(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDPC.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi phân công muốn sửa!");
                return;
            }

            isAdding = false;
            SetControls(true);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDPC.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi phân công muốn xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string error;
                int idPC = int.Parse(txtIDPC.Text);

                if (bll.Xoa(idPC, out error))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadGrid();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboGiaoVien.SelectedValue == null ||
            cboLop.SelectedValue == null ||
            cboMon.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đủ giáo viên, lớp và môn học!");
                return;
            }

            int idGV = (int)cboGiaoVien.SelectedValue;
            int idLop = (int)cboLop.SelectedValue;
            int idMon = (int)cboMon.SelectedValue;

            string error;
            bool success;

            if (isAdding)
            {
                success = bll.Them(idGV, idLop, idMon, out error);
            }
            else
            {
                int idPC = int.Parse(txtIDPC.Text);
                success = bll.Sua(idPC, idGV, idLop, idMon, out error);
            }

            if (success)
            {
                MessageBox.Show("Lưu thành công!");
                LoadGrid();
                SetControls(false);
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControls(false);

            if (dgvPhanCong.CurrentRow != null)
            {
                dgvPhanCong_CellClick(null,
                    new DataGridViewCellEventArgs(0, dgvPhanCong.CurrentRow.Index));
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
