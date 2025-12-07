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
    public partial class frmMonHoc : Form
    {

        private readonly MonHocBLL bll = new MonHocBLL();
        private bool isAdding = false;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
            SetControls(false);
        }

        private void LoadData()
        {
            dgvMonHoc.DataSource = bll.LayDanhSachMonHoc();

            if (dgvMonHoc.Columns.Contains("IDMon"))
                dgvMonHoc.Columns["IDMon"].Visible = false;

            dgvMonHoc.Columns["MaMon"].HeaderText = "Mã môn";
            dgvMonHoc.Columns["TenMon"].HeaderText = "Tên môn";
            dgvMonHoc.Columns["HeSo"].HeaderText = "Hệ số";

            dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetControls(bool editing)
        {
            txtMaMon.Enabled = editing;
            txtTenMon.Enabled = editing;
            txtHeSo.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
        }

        private void ClearInputs()
        {
            txtIDMon.Text = "";
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtHeSo.Text = "";
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMonHoc.CurrentRow != null)
            {
                txtIDMon.Text = dgvMonHoc.CurrentRow.Cells["IDMon"].Value.ToString();
                txtMaMon.Text = dgvMonHoc.CurrentRow.Cells["MaMon"].Value.ToString();
                txtTenMon.Text = dgvMonHoc.CurrentRow.Cells["TenMon"].Value.ToString();
                txtHeSo.Text = dgvMonHoc.CurrentRow.Cells["HeSo"].Value.ToString();
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
            if (string.IsNullOrWhiteSpace(txtIDMon.Text))
            {
                MessageBox.Show("Hãy chọn môn học muốn sửa!");
                return;
            }

            isAdding = false;
            SetControls(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDMon.Text))
            {
                MessageBox.Show("Hãy chọn môn học muốn xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string error;
                int id = int.Parse(txtIDMon.Text);

                if (bll.Xoa(id, out error))
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
            string maMon = txtMaMon.Text.Trim();
            string tenMon = txtTenMon.Text.Trim();
            int heSo;

            if (!int.TryParse(txtHeSo.Text.Trim(), out heSo))
            {
                MessageBox.Show("Hệ số phải là số nguyên!");
                return;
            }

            string error;
            bool success;

            if (isAdding)
            {
                success = bll.Them(maMon, tenMon, heSo, out error);
            }
            else
            {
                int idMon = int.Parse(txtIDMon.Text);
                success = bll.Sua(idMon, maMon, tenMon, heSo, out error);
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
            if (dgvMonHoc.CurrentRow != null)
                dgvMonHoc_CellClick(null,
                    new DataGridViewCellEventArgs(0, dgvMonHoc.CurrentRow.Index));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
