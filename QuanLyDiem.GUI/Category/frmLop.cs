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
    public partial class frmLop : Form
    {
        LopBLL bll = new LopBLL();
        private bool isAdding = false;
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            LoadData();
            SetControls(false);
        }

        private void LoadData()
        {
            dgvLop.DataSource = bll.LayDanhSachLop();

            dgvLop.Columns["IDLop"].Visible = false;   // Ẩn ID thật
            dgvLop.Columns["MaLop"].HeaderText = "Mã lớp";
            dgvLop.Columns["TenLop"].HeaderText = "Tên lớp";
            dgvLop.Columns["Khoi"].HeaderText = "Khối";
            dgvLop.Columns["SiSo"].HeaderText = "Sĩ số";
        }

        private void ClearInputs()
        {
            txtIDLop.Text = "";
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtKhoi.Text = "";
            txtSiSo.Text = "";
        }

        private void SetControls(bool editing)
        {
            txtMaLop.Enabled = editing;
            txtTenLop.Enabled = editing;
            txtKhoi.Enabled = editing;
            txtSiSo.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIDLop.Text = dgvLop.CurrentRow.Cells["IDLop"].Value.ToString();
                txtMaLop.Text = dgvLop.CurrentRow.Cells["MaLop"].Value.ToString();
                txtTenLop.Text = dgvLop.CurrentRow.Cells["TenLop"].Value.ToString();
                txtKhoi.Text = dgvLop.CurrentRow.Cells["Khoi"].Value.ToString();
                txtSiSo.Text = dgvLop.CurrentRow.Cells["SiSo"].Value.ToString();
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
            if (string.IsNullOrWhiteSpace(txtIDLop.Text))
            {
                MessageBox.Show("Hãy chọn lớp muốn sửa!");
                return;
            }
            isAdding = false;
            SetControls(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDLop.Text))
            {
                MessageBox.Show("Hãy chọn lớp muốn xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string error;
                if (bll.Xoa(int.Parse(txtMaLop.Text), out error))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            string khoi = txtKhoi.Text.Trim();
            int siSo = int.Parse(txtSiSo.Text);

            string error;
            bool success;

            if (isAdding)
            {
                success = bll.Them(maLop, tenLop, khoi, siSo, out error);
            }
            else
            {
                int idLop = int.Parse(txtIDLop.Text);
                success = bll.Sua(idLop, maLop, tenLop, khoi, siSo, out error);
            }

            if (success)
            {
                MessageBox.Show("Lưu thành công!");
                LoadData();
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
            if (dgvLop.CurrentRow != null)
                dgvLop_CellClick(null, new DataGridViewCellEventArgs(0, dgvLop.CurrentRow.Index));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
