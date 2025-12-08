namespace QuanLyDiem.GUI.Point
{
    partial class frmBangDiem
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
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboMon = new System.Windows.Forms.ComboBox();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblMon = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpHocSinh = new System.Windows.Forms.GroupBox();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.grpBangDiem = new System.Windows.Forms.GroupBox();
            this.dgvBangDiem = new System.Windows.Forms.DataGridView();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpFilter.SuspendLayout();
            this.grpHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.grpBangDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.cboLop);
            this.grpFilter.Controls.Add(this.cboMon);
            this.grpFilter.Controls.Add(this.cboHocKy);
            this.grpFilter.Controls.Add(this.cboNamHoc);
            this.grpFilter.Controls.Add(this.lblLop);
            this.grpFilter.Controls.Add(this.lblMon);
            this.grpFilter.Controls.Add(this.lblHocKy);
            this.grpFilter.Controls.Add(this.lblNamHoc);
            this.grpFilter.Location = new System.Drawing.Point(20, 15);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(1150, 100);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Bộ lọc";
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(810, 32);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(150, 25);
            this.cboLop.TabIndex = 7;
            // 
            // cboMon
            // 
            this.cboMon.FormattingEnabled = true;
            this.cboMon.Location = new System.Drawing.Point(582, 32);
            this.cboMon.Name = "cboMon";
            this.cboMon.Size = new System.Drawing.Size(150, 25);
            this.cboMon.TabIndex = 6;
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(330, 32);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(150, 25);
            this.cboHocKy.TabIndex = 5;
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.FormattingEnabled = true;
            this.cboNamHoc.Location = new System.Drawing.Point(100, 32);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(150, 25);
            this.cboNamHoc.TabIndex = 4;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(770, 35);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(37, 17);
            this.lblLop.TabIndex = 3;
            this.lblLop.Text = "Lớp :";
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Location = new System.Drawing.Point(510, 35);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(67, 17);
            this.lblMon.TabIndex = 2;
            this.lblMon.Text = "Môn học :";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(270, 35);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(54, 17);
            this.lblHocKy.TabIndex = 1;
            this.lblHocKy.Text = "Học kỳ :";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Location = new System.Drawing.Point(20, 35);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(68, 17);
            this.lblNamHoc.TabIndex = 0;
            this.lblNamHoc.Text = "Năm học :";
            // 
            // grpHocSinh
            // 
            this.grpHocSinh.Controls.Add(this.dgvHocSinh);
            this.grpHocSinh.Location = new System.Drawing.Point(20, 140);
            this.grpHocSinh.Name = "grpHocSinh";
            this.grpHocSinh.Size = new System.Drawing.Size(350, 420);
            this.grpHocSinh.TabIndex = 1;
            this.grpHocSinh.TabStop = false;
            this.grpHocSinh.Text = "Danh sách học sinh";
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.AllowUserToAddRows = false;
            this.dgvHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Location = new System.Drawing.Point(10, 25);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.ReadOnly = true;
            this.dgvHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocSinh.Size = new System.Drawing.Size(330, 370);
            this.dgvHocSinh.TabIndex = 0;
            this.dgvHocSinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocSinh_CellClick);
            // 
            // grpBangDiem
            // 
            this.grpBangDiem.Controls.Add(this.dgvBangDiem);
            this.grpBangDiem.ForeColor = System.Drawing.Color.Black;
            this.grpBangDiem.Location = new System.Drawing.Point(380, 140);
            this.grpBangDiem.Name = "grpBangDiem";
            this.grpBangDiem.Size = new System.Drawing.Size(790, 420);
            this.grpBangDiem.TabIndex = 2;
            this.grpBangDiem.TabStop = false;
            this.grpBangDiem.Text = "Bảng điểm";
            // 
            // dgvBangDiem
            // 
            this.dgvBangDiem.AllowUserToAddRows = false;
            this.dgvBangDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiem.Location = new System.Drawing.Point(10, 25);
            this.dgvBangDiem.Name = "dgvBangDiem";
            this.dgvBangDiem.ReadOnly = true;
            this.dgvBangDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangDiem.Size = new System.Drawing.Size(770, 370);
            this.dgvBangDiem.TabIndex = 0;
            this.dgvBangDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangDiem_CellClick);
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnThoat);
            this.grpChucNang.Controls.Add(this.btnHuy);
            this.grpChucNang.Controls.Add(this.btnLuu);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChucNang.Location = new System.Drawing.Point(22, 579);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(1150, 80);
            this.grpChucNang.TabIndex = 5;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(680, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 35);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(480, 25);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(370, 25);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 35);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(240, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(130, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(20, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpBangDiem);
            this.Controls.Add(this.grpHocSinh);
            this.Controls.Add(this.grpFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmBangDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điểm";
            this.Load += new System.EventHandler(this.frmBangDiem_Load);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpHocSinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.grpBangDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboMon;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.GroupBox grpHocSinh;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.GroupBox grpBangDiem;
        private System.Windows.Forms.DataGridView dgvBangDiem;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}