using QuanLyDiem.BLL.Category;
using QuanLyDiem.DAL.Category;
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
    public partial class frmLoaiDiem : Form
    {

        private readonly LoaiDiemBLL bll = new LoaiDiemBLL();
        private bool isAdding = false;
        public frmLoaiDiem()
        {
            InitializeComponent();
        }

        private void frmLoaiDiem_Load(object sender, EventArgs e)
        {
            LoadData();
            SetControls(false);
        }
        private void LoadData()
        {
            dgvLoaiDiem.DataSource = bll.LayDanhSachLoaiDiem();

            if (dgvLoaiDiem.Columns.Contains("IDLoaiDiem"))
                dgvLoaiDiem.Columns["IDLoaiDiem"].Visible = false;

            dgvLoaiDiem.Columns["TenLoaiDiem"].HeaderText = "Tên loại điểm";
            dgvLoaiDiem.Columns["HeSo"].HeaderText = "Hệ số";

            dgvLoaiDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetControls(bool editing)
        {
            txtTenLoaiDiem.Enabled = editing;
            txtHeSo.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;
        }

        private void ClearInputs()
        {
            txtIDLoaiDiem.Text = "";
            txtTenLoaiDiem.Text = "";
            txtHeSo.Text = "";
        }

        private void dgvLoaiDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLoaiDiem.CurrentRow != null)
            {
                txtIDLoaiDiem.Text = dgvLoaiDiem.CurrentRow.Cells["IDLoaiDiem"].Value.ToString();
                txtTenLoaiDiem.Text = dgvLoaiDiem.CurrentRow.Cells["TenLoaiDiem"].Value.ToString();
                txtHeSo.Text = dgvLoaiDiem.CurrentRow.Cells["HeSo"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearInputs();
            SetControls(true);
            txtTenLoaiDiem.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDLoaiDiem.Text))
            {
                MessageBox.Show("Vui lòng chọn loại điểm muốn sửa!");
                return;
            }

            isAdding = false;
            SetControls(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDLoaiDiem.Text))
            {
                MessageBox.Show("Vui lòng chọn loại điểm muốn xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string error;
                int id = int.Parse(txtIDLoaiDiem.Text);

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
            string ten = txtTenLoaiDiem.Text.Trim();
            string error;

            if (!int.TryParse(txtHeSo.Text.Trim(), out int heSo))
            {
                MessageBox.Show("Hệ số phải là số nguyên!");
                return;
            }

            bool success;

            if (isAdding)
            {
                success = bll.Them(ten, heSo, out error);
            }
            else
            {
                int id = int.Parse(txtIDLoaiDiem.Text);
                success = bll.Sua(id, ten, heSo, out error);
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

            if (dgvLoaiDiem.CurrentRow != null)
            {
                dgvLoaiDiem_CellClick(null,
                    new DataGridViewCellEventArgs(0, dgvLoaiDiem.CurrentRow.Index));
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
