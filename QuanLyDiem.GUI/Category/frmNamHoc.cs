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
    public partial class frmNamHoc : Form
    {
        private readonly NamHocBLL bll = new NamHocBLL();
        private bool isAdding = false;

        public frmNamHoc()
        {
            InitializeComponent();
        }

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            LoadData();
            SetControls(false);
        }
        private void LoadData()
        {
            dgvNamHoc.DataSource = bll.LayDanhSachNam();

            if (dgvNamHoc.Columns.Contains("IDNamHoc"))
                dgvNamHoc.Columns["IDNamHoc"].Visible = false;

            dgvNamHoc.Columns["TenNamHoc"].HeaderText = "Tên năm học";

            dgvNamHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetControls(bool editing)
        {
            txtTenNamHoc.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
        }

        private void ClearInputs()
        {
            txtIDNamHoc.Text = "";
            txtTenNamHoc.Text = "";
        }

        private void dgvNamHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNamHoc.CurrentRow != null)
            {
                txtIDNamHoc.Text = dgvNamHoc.CurrentRow.Cells["IDNamHoc"].Value.ToString();
                txtTenNamHoc.Text = dgvNamHoc.CurrentRow.Cells["TenNamHoc"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearInputs();
            SetControls(true);
            txtTenNamHoc.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDNamHoc.Text))
            {
                MessageBox.Show("Vui lòng chọn năm học muốn sửa!");
                return;
            }

            isAdding = false;
            SetControls(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDNamHoc.Text))
            {
                MessageBox.Show("Vui lòng chọn năm học muốn xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string error;
                int id = int.Parse(txtIDNamHoc.Text);

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
            string tenNamHoc = txtTenNamHoc.Text.Trim();

            string error;
            bool success;

            if (isAdding)
            {
                success = bll.Them(tenNamHoc, out error);
            }
            else
            {
                int id = int.Parse(txtIDNamHoc.Text);
                success = bll.Sua(id, tenNamHoc, out error);
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
            if (dgvNamHoc.CurrentRow != null)
                dgvNamHoc_CellClick(null,
                    new DataGridViewCellEventArgs(0, dgvNamHoc.CurrentRow.Index));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
