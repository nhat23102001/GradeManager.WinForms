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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Hàm mở form con trong MDI
        private void OpenChildForm(Form childForm)
        {
            // Nếu form này đã mở rồi thì kích hoạt thay vì mở thêm
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == childForm.GetType())
                {
                    frm.Activate();
                    return;
                }
            }

            childForm.MdiParent = this;
            childForm.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?",
                                "Xác nhận", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đăng nhập sẽ được xây dựng sau.",
                           "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đăng xuất sẽ được xây dựng sau.",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuHocSinh_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmHocSinh());
        }
    }
}
