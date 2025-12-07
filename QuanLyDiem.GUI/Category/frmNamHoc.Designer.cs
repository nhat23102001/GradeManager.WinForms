namespace QuanLyDiem.GUI
{
    partial class frmNamHoc
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
            this.grpThongTinNam = new System.Windows.Forms.GroupBox();
            this.lblTenNam = new System.Windows.Forms.Label();
            this.txtTenNamHoc = new System.Windows.Forms.TextBox();
            this.txtIDNamHoc = new System.Windows.Forms.TextBox();
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNamHoc = new System.Windows.Forms.DataGridView();
            this.grpThongTinNam.SuspendLayout();
            this.grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTinNam
            // 
            this.grpThongTinNam.Controls.Add(this.txtIDNamHoc);
            this.grpThongTinNam.Controls.Add(this.txtTenNamHoc);
            this.grpThongTinNam.Controls.Add(this.lblTenNam);
            this.grpThongTinNam.Location = new System.Drawing.Point(20, 20);
            this.grpThongTinNam.Name = "grpThongTinNam";
            this.grpThongTinNam.Size = new System.Drawing.Size(840, 100);
            this.grpThongTinNam.TabIndex = 0;
            this.grpThongTinNam.TabStop = false;
            this.grpThongTinNam.Text = "Thông tin năm học";
            // 
            // lblTenNam
            // 
            this.lblTenNam.Location = new System.Drawing.Point(20, 40);
            this.lblTenNam.Name = "lblTenNam";
            this.lblTenNam.Size = new System.Drawing.Size(120, 25);
            this.lblTenNam.TabIndex = 0;
            this.lblTenNam.Text = "Tên năm học :";
            // 
            // txtTenNamHoc
            // 
            this.txtTenNamHoc.Location = new System.Drawing.Point(150, 38);
            this.txtTenNamHoc.Name = "txtTenNamHoc";
            this.txtTenNamHoc.Size = new System.Drawing.Size(300, 25);
            this.txtTenNamHoc.TabIndex = 1;
            // 
            // txtIDNamHoc
            // 
            this.txtIDNamHoc.Location = new System.Drawing.Point(734, 38);
            this.txtIDNamHoc.Name = "txtIDNamHoc";
            this.txtIDNamHoc.Size = new System.Drawing.Size(100, 25);
            this.txtIDNamHoc.TabIndex = 4;
            this.txtIDNamHoc.Visible = false;
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
            this.grpChucNang.Location = new System.Drawing.Point(20, 140);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(840, 70);
            this.grpChucNang.TabIndex = 3;
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
            // dgvNamHoc
            // 
            this.dgvNamHoc.AllowUserToAddRows = false;
            this.dgvNamHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNamHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNamHoc.Location = new System.Drawing.Point(20, 230);
            this.dgvNamHoc.Name = "dgvNamHoc";
            this.dgvNamHoc.ReadOnly = true;
            this.dgvNamHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNamHoc.Size = new System.Drawing.Size(840, 230);
            this.dgvNamHoc.TabIndex = 4;
            this.dgvNamHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNamHoc_CellClick);
            // 
            // frmNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.dgvNamHoc);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpThongTinNam);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmNamHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Năm học";
            this.Load += new System.EventHandler(this.frmNamHoc_Load);
            this.grpThongTinNam.ResumeLayout(false);
            this.grpThongTinNam.PerformLayout();
            this.grpChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNamHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTinNam;
        private System.Windows.Forms.TextBox txtIDNamHoc;
        private System.Windows.Forms.TextBox txtTenNamHoc;
        private System.Windows.Forms.Label lblTenNam;
        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNamHoc;
    }
}