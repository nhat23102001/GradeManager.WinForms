using QuanLyDiem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.GUI
{
    public partial class frmGiaoVien : Form
    {
        private readonly GiaoVienBLL bll = new GiaoVienBLL();
        private bool isAdding = false;
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            LoadGV();
            SetControls(false);
        }
        private void LoadGV()
        {
            dgvGiaoVien.DataSource = bll.LayDanhSachGV();

            // Ẩn ID
            if (dgvGiaoVien.Columns.Contains("IDGV"))
                dgvGiaoVien.Columns["IDGV"].Visible = false;

            dgvGiaoVien.Columns["MaGV"].HeaderText = "Mã GV";
            dgvGiaoVien.Columns["HoTen"].HeaderText = "Họ tên";
            dgvGiaoVien.Columns["SDT"].HeaderText = "Số điện thoại";

            dgvGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetControls(bool editing)
        {
            txtMaGV.Enabled = editing;
            txtHoTen.Enabled = editing;
            txtSDT.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
        }

        private void ClearInputs()
        {
            txtIDGV.Text = "";
            txtMaGV.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvGiaoVien.CurrentRow != null)
            {
                txtIDGV.Text = dgvGiaoVien.CurrentRow.Cells["IDGV"].Value.ToString();
                txtMaGV.Text = dgvGiaoVien.CurrentRow.Cells["MaGV"].Value.ToString();
                txtHoTen.Text = dgvGiaoVien.CurrentRow.Cells["HoTen"].Value.ToString();
                txtSDT.Text = dgvGiaoVien.CurrentRow.Cells["SDT"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearInputs();
            SetControls(true);
            txtMaGV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDGV.Text))
            {
                MessageBox.Show("Vui lòng chọn giáo viên muốn sửa!");
                return;
            }

            isAdding = false;
            SetControls(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDGV.Text))
            {
                MessageBox.Show("Vui lòng chọn giáo viên muốn xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string error;
                int id = int.Parse(txtIDGV.Text);

                if (bll.Xoa(id, out error))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadGV();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            string error;
            bool success;

            if (isAdding)
            {
                success = bll.Them(maGV, hoTen, sdt, out error);
            }
            else
            {
                int idGV = int.Parse(txtIDGV.Text);
                success = bll.Sua(idGV, maGV, hoTen, sdt, out error);
            }

            if (success)
            {
                MessageBox.Show("Lưu thành công!");
                LoadGV();
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
            if (dgvGiaoVien.CurrentRow != null)
                dgvGiaoVien_CellClick(null,
                    new DataGridViewCellEventArgs(0, dgvGiaoVien.CurrentRow.Index));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
