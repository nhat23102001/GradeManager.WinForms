namespace QuanLyDiem.GUI
{
    partial class frmLoaiDiem
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
            this.grpThongTinLoaiDiem = new System.Windows.Forms.GroupBox();
            this.lblTenLoaiDiem = new System.Windows.Forms.Label();
            this.txtTenLoaiDiem = new System.Windows.Forms.TextBox();
            this.lblHeSo = new System.Windows.Forms.Label();
            this.txtHeSo = new System.Windows.Forms.TextBox();
            this.txtIDLoaiDiem = new System.Windows.Forms.TextBox();
            this.dgvLoaiDiem = new System.Windows.Forms.DataGridView();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpThongTinLoaiDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDiem)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpThongTinLoaiDiem
            // 
            this.grpThongTinLoaiDiem.Controls.Add(this.txtIDLoaiDiem);
            this.grpThongTinLoaiDiem.Controls.Add(this.txtHeSo);
            this.grpThongTinLoaiDiem.Controls.Add(this.lblHeSo);
            this.grpThongTinLoaiDiem.Controls.Add(this.txtTenLoaiDiem);
            this.grpThongTinLoaiDiem.Controls.Add(this.lblTenLoaiDiem);
            this.grpThongTinLoaiDiem.Location = new System.Drawing.Point(20, 20);
            this.grpThongTinLoaiDiem.Name = "grpThongTinLoaiDiem";
            this.grpThongTinLoaiDiem.Size = new System.Drawing.Size(840, 120);
            this.grpThongTinLoaiDiem.TabIndex = 0;
            this.grpThongTinLoaiDiem.TabStop = false;
            this.grpThongTinLoaiDiem.Text = "Thông tin loại điểm";
            // 
            // lblTenLoaiDiem
            // 
            this.lblTenLoaiDiem.Location = new System.Drawing.Point(20, 40);
            this.lblTenLoaiDiem.Name = "lblTenLoaiDiem";
            this.lblTenLoaiDiem.Size = new System.Drawing.Size(130, 25);
            this.lblTenLoaiDiem.TabIndex = 0;
            this.lblTenLoaiDiem.Text = "Tên loại điểm :";
            // 
            // txtTenLoaiDiem
            // 
            this.txtTenLoaiDiem.Location = new System.Drawing.Point(160, 38);
            this.txtTenLoaiDiem.Name = "txtTenLoaiDiem";
            this.txtTenLoaiDiem.Size = new System.Drawing.Size(300, 25);
            this.txtTenLoaiDiem.TabIndex = 1;
            // 
            // lblHeSo
            // 
            this.lblHeSo.Location = new System.Drawing.Point(20, 80);
            this.lblHeSo.Name = "lblHeSo";
            this.lblHeSo.Size = new System.Drawing.Size(60, 25);
            this.lblHeSo.TabIndex = 2;
            this.lblHeSo.Text = "Hệ sô :";
            // 
            // txtHeSo
            // 
            this.txtHeSo.Location = new System.Drawing.Point(160, 78);
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.Size = new System.Drawing.Size(80, 25);
            this.txtHeSo.TabIndex = 3;
            // 
            // txtIDLoaiDiem
            // 
            this.txtIDLoaiDiem.Location = new System.Drawing.Point(734, 37);
            this.txtIDLoaiDiem.Name = "txtIDLoaiDiem";
            this.txtIDLoaiDiem.Size = new System.Drawing.Size(10, 25);
            this.txtIDLoaiDiem.TabIndex = 4;
            this.txtIDLoaiDiem.Visible = false;
            // 
            // dgvLoaiDiem
            // 
            this.dgvLoaiDiem.AllowUserToAddRows = false;
            this.dgvLoaiDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDiem.Location = new System.Drawing.Point(20, 240);
            this.dgvLoaiDiem.Name = "dgvLoaiDiem";
            this.dgvLoaiDiem.ReadOnly = true;
            this.dgvLoaiDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiDiem.Size = new System.Drawing.Size(840, 230);
            this.dgvLoaiDiem.TabIndex = 7;
            this.dgvLoaiDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiDiem_CellClick);
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
            this.grpChucNang.Location = new System.Drawing.Point(22, 150);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(840, 70);
            this.grpChucNang.TabIndex = 6;
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
            // frmLoaiDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dgvLoaiDiem);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpThongTinLoaiDiem);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmLoaiDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại điểm";
            this.Load += new System.EventHandler(this.frmLoaiDiem_Load);
            this.grpThongTinLoaiDiem.ResumeLayout(false);
            this.grpThongTinLoaiDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDiem)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTinLoaiDiem;
        private System.Windows.Forms.TextBox txtHeSo;
        private System.Windows.Forms.Label lblHeSo;
        private System.Windows.Forms.TextBox txtTenLoaiDiem;
        private System.Windows.Forms.Label lblTenLoaiDiem;
        private System.Windows.Forms.TextBox txtIDLoaiDiem;
        private System.Windows.Forms.DataGridView dgvLoaiDiem;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}