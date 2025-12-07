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
    public partial class frmHocKy : Form
    {
        private readonly HocKyBLL bll = new HocKyBLL();
        private bool isAdding = false;
        public frmHocKy()
        {
            InitializeComponent();
        }

        private void frmHocKy_Load(object sender, EventArgs e)
        {
            LoadData();
            SetControls(false);
        }

        private void LoadData()
        {
            dgvHocKy.DataSource = bll.LayDanhSachHocKy();

            if (dgvHocKy.Columns.Contains("IDHocKy"))
                dgvHocKy.Columns["IDHocKy"].Visible = false;

            dgvHocKy.Columns["TenHocKy"].HeaderText = "Tên học kỳ";

            dgvHocKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetControls(bool editing)
        {
            txtTenHocKy.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
        }

        private void ClearInputs()
        {
            txtIDHocKy.Text = "";
            txtTenHocKy.Text = "";
        }

        private void dgvHocKy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHocKy.CurrentRow != null)
            {
                txtIDHocKy.Text = dgvHocKy.CurrentRow.Cells["IDHocKy"].Value.ToString();
                txtTenHocKy.Text = dgvHocKy.CurrentRow.Cells["TenHocKy"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearInputs();
            SetControls(true);
            txtTenHocKy.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDHocKy.Text))
            {
                MessageBox.Show("Vui lòng chọn học kỳ muốn sửa!");
                return;
            }

            isAdding = false;
            SetControls(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDHocKy.Text))
            {
                MessageBox.Show("Vui lòng chọn học kỳ muốn xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string error = "";
                int id = int.Parse(txtIDHocKy.Text);

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
            string tenHK = txtTenHocKy.Text.Trim();

            string error;
            bool success;

            if (isAdding)
            {
                success = bll.Them(tenHK, out error);
            }
            else
            {
                int id = int.Parse(txtIDHocKy.Text);
                success = bll.Sua(id, tenHK, out error);
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

            if (dgvHocKy.CurrentRow != null)
                dgvHocKy_CellClick(null,
                    new DataGridViewCellEventArgs(0, dgvHocKy.CurrentRow.Index));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
