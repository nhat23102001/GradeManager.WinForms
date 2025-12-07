namespace QuanLyDiem.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHocSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNamHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHocKy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiangDay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhanCong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBangDiemHS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBangDiemLop = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhMuc,
            this.mnuGiangDay,
            this.mnuDiem,
            this.mnuBaoCao});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuDangXuat,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(132, 22);
            this.mnuDangNhap.Text = "Đăng nhập";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(132, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(132, 22);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLop,
            this.mnuHocSinh,
            this.mnuMonHoc,
            this.mnuGiaoVien,
            this.mnuNamHoc,
            this.mnuHocKy,
            this.mnuLoaiDiem});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuLop
            // 
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(126, 22);
            this.mnuLop.Text = "Lớp";
            this.mnuLop.Click += new System.EventHandler(this.mnuLop_Click);
            // 
            // mnuHocSinh
            // 
            this.mnuHocSinh.Name = "mnuHocSinh";
            this.mnuHocSinh.Size = new System.Drawing.Size(126, 22);
            this.mnuHocSinh.Text = "Học sinh";
            this.mnuHocSinh.Click += new System.EventHandler(this.mnuHocSinh_Click);
            // 
            // mnuMonHoc
            // 
            this.mnuMonHoc.Name = "mnuMonHoc";
            this.mnuMonHoc.Size = new System.Drawing.Size(126, 22);
            this.mnuMonHoc.Text = "Môn học";
            this.mnuMonHoc.Click += new System.EventHandler(this.mnuMonHoc_Click);
            // 
            // mnuGiaoVien
            // 
            this.mnuGiaoVien.Name = "mnuGiaoVien";
            this.mnuGiaoVien.Size = new System.Drawing.Size(126, 22);
            this.mnuGiaoVien.Text = "Giáo viên";
            this.mnuGiaoVien.Click += new System.EventHandler(this.mnuGiaoVien_Click);
            // 
            // mnuNamHoc
            // 
            this.mnuNamHoc.Name = "mnuNamHoc";
            this.mnuNamHoc.Size = new System.Drawing.Size(126, 22);
            this.mnuNamHoc.Text = "Năm học";
            this.mnuNamHoc.Click += new System.EventHandler(this.mnuNamHoc_Click);
            // 
            // mnuHocKy
            // 
            this.mnuHocKy.Name = "mnuHocKy";
            this.mnuHocKy.Size = new System.Drawing.Size(126, 22);
            this.mnuHocKy.Text = "Học kỳ";
            this.mnuHocKy.Click += new System.EventHandler(this.mnuHocKy_Click);
            // 
            // mnuLoaiDiem
            // 
            this.mnuLoaiDiem.Name = "mnuLoaiDiem";
            this.mnuLoaiDiem.Size = new System.Drawing.Size(126, 22);
            this.mnuLoaiDiem.Text = "Loại điểm";
            this.mnuLoaiDiem.Click += new System.EventHandler(this.mnuLoaiDiem_Click);
            // 
            // mnuGiangDay
            // 
            this.mnuGiangDay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPhanCong});
            this.mnuGiangDay.Name = "mnuGiangDay";
            this.mnuGiangDay.Size = new System.Drawing.Size(72, 20);
            this.mnuGiangDay.Text = "Giảng dạy";
            // 
            // mnuPhanCong
            // 
            this.mnuPhanCong.Name = "mnuPhanCong";
            this.mnuPhanCong.Size = new System.Drawing.Size(186, 22);
            this.mnuPhanCong.Text = "Phân công giảng dạy";
            this.mnuPhanCong.Click += new System.EventHandler(this.mnuPhanCong_Click);
            // 
            // mnuDiem
            // 
            this.mnuDiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhapDiem});
            this.mnuDiem.Name = "mnuDiem";
            this.mnuDiem.Size = new System.Drawing.Size(47, 20);
            this.mnuDiem.Text = "Điểm";
            // 
            // mnuNhapDiem
            // 
            this.mnuNhapDiem.Name = "mnuNhapDiem";
            this.mnuNhapDiem.Size = new System.Drawing.Size(133, 22);
            this.mnuNhapDiem.Text = "Nhập điểm";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBangDiemHS,
            this.mnuBangDiemLop});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuBangDiemHS
            // 
            this.mnuBangDiemHS.Name = "mnuBangDiemHS";
            this.mnuBangDiemHS.Size = new System.Drawing.Size(179, 22);
            this.mnuBangDiemHS.Text = "Bảng điểm học sinh";
            // 
            // mnuBangDiemLop
            // 
            this.mnuBangDiemLop.Name = "mnuBangDiemLop";
            this.mnuBangDiemLop.Size = new System.Drawing.Size(179, 22);
            this.mnuBangDiemLop.Text = "Bảng điểm lớp";
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai});
            this.statusMain.Location = new System.Drawing.Point(0, 428);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(800, 22);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(54, 17);
            this.lblTrangThai.Text = "Sẵn sàng";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ ĐIỂM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuHocSinh;
        private System.Windows.Forms.ToolStripMenuItem mnuMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem mnuNamHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuHocKy;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuGiangDay;
        private System.Windows.Forms.ToolStripMenuItem mnuPhanCong;
        private System.Windows.Forms.ToolStripMenuItem mnuDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapDiem;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBangDiemHS;
        private System.Windows.Forms.ToolStripMenuItem mnuBangDiemLop;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
    }
}

