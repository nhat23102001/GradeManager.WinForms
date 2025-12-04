CREATE DATABASE QuanLyDiem;
GO
USE QuanLyDiem;
GO

-- 1. Bảng Lop
CREATE TABLE Lop (
    MaLop INT IDENTITY(1,1) PRIMARY KEY,
    TenLop NVARCHAR(50) NOT NULL,
    Khoi NVARCHAR(20) NULL,
    SiSo INT DEFAULT 0
);
go

-- 2. Bảng HocSinh
CREATE TABLE HocSinh (
    MaHS INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NULL,
    GioiTinh BIT NULL,         -- 0: Nữ, 1: Nam
    DiaChi NVARCHAR(200) NULL,
    MaLop INT NOT NULL,
    CONSTRAINT FK_HocSinh_Lop FOREIGN KEY(MaLop) REFERENCES Lop(MaLop)
);
go

-- 3. Bảng MonHoc
CREATE TABLE MonHoc (
    MaMon INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL,
    HeSo INT DEFAULT 1
);
go

-- 4. Bảng GiaoVien
CREATE TABLE GiaoVien (
    MaGV INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    SDT VARCHAR(15) NULL
);
go

-- 5. Bảng NamHoc
CREATE TABLE NamHoc (
    MaNamHoc INT IDENTITY(1,1) PRIMARY KEY,
    TenNamHoc NVARCHAR(20) NOT NULL   -- ví dụ: 2024-2025
);
go

-- 6. Bảng HocKy
CREATE TABLE HocKy (
    MaHocKy INT IDENTITY(1,1) PRIMARY KEY,
    TenHocKy NVARCHAR(20) NOT NULL    -- ví dụ: HK1, HK2
);
go

-- 7. Bảng LoaiDiem
CREATE TABLE LoaiDiem (
    MaLoaiDiem INT IDENTITY(1,1) PRIMARY KEY,
    TenLoaiDiem NVARCHAR(50) NOT NULL,  -- 15 phút, 1 tiết, Thi
    HeSo INT DEFAULT 1
);
go

-- 8. Bảng PhanCong
CREATE TABLE PhanCong (
    MaPC INT IDENTITY(1,1) PRIMARY KEY,
    MaGV INT NOT NULL,
    MaLop INT NOT NULL,
    MaMon INT NOT NULL,
    CONSTRAINT FK_PhanCong_GV FOREIGN KEY(MaGV) REFERENCES GiaoVien(MaGV),
    CONSTRAINT FK_PhanCong_Lop FOREIGN KEY(MaLop) REFERENCES Lop(MaLop),
    CONSTRAINT FK_PhanCong_Mon FOREIGN KEY(MaMon) REFERENCES MonHoc(MaMon)
);
go

-- 9. Bảng BangDiem
CREATE TABLE BangDiem (
    MaBangDiem INT IDENTITY(1,1) PRIMARY KEY,
    MaHS INT NOT NULL,
    MaMon INT NOT NULL,
    MaNamHoc INT NOT NULL,
    MaHocKy INT NOT NULL,
    MaLoaiDiem INT NOT NULL,
    Diem FLOAT NOT NULL,
    NgayNhap DATE DEFAULT GETDATE(),
    CONSTRAINT FK_BD_HS FOREIGN KEY(MaHS) REFERENCES HocSinh(MaHS),
    CONSTRAINT FK_BD_Mon FOREIGN KEY(MaMon) REFERENCES MonHoc(MaMon),
    CONSTRAINT FK_BD_NamHoc FOREIGN KEY(MaNamHoc) REFERENCES NamHoc(MaNamHoc),
    CONSTRAINT FK_BD_HocKy FOREIGN KEY(MaHocKy) REFERENCES HocKy(MaHocKy),
    CONSTRAINT FK_BD_LoaiDiem FOREIGN KEY(MaLoaiDiem) REFERENCES LoaiDiem(MaLoaiDiem)
);
go

-- 10. Bảng TaiKhoan
CREATE TABLE TaiKhoan (
    MaTK INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(100) NOT NULL,    -- demo: lưu plain text (bài tập); thực tế phải hash
    VaiTro NVARCHAR(50) NOT NULL      -- Admin, GiaoVu, GiaoVien
);
go


-- ds lớp
CREATE PROCEDURE sp_Lop_GetAll
AS
BEGIN
    SELECT * FROM Lop
    ORDER BY MaLop;
END
go


-- thêm lớp
CREATE PROCEDURE sp_Lop_Insert
    @TenLop NVARCHAR(50),
    @Khoi NVARCHAR(20),
    @SiSo INT
AS
BEGIN
    INSERT INTO Lop(TenLop, Khoi, SiSo)
    VALUES(@TenLop, @Khoi, @SiSo)
END
go

--sửa lớp
CREATE PROCEDURE sp_Lop_Update
    @MaLop INT,
    @TenLop NVARCHAR(50),
    @Khoi NVARCHAR(20),
    @SiSo INT
AS
BEGIN
    UPDATE Lop
    SET TenLop=@TenLop, Khoi=@Khoi, SiSo=@SiSo
    WHERE MaLop=@MaLop
END
go


--xóa lớp
CREATE PROCEDURE sp_Lop_Delete
    @MaLop INT
AS
BEGIN
    DELETE FROM Lop WHERE MaLop=@MaLop
END
go



-- ds hs
CREATE PROCEDURE sp_HocSinh_GetAll
AS
BEGIN
    SELECT HS.*, L.TenLop
    FROM HocSinh HS
    JOIN Lop L ON HS.MaLop = L.MaLop
    ORDER BY MaHS;
END
go

-- thêm hs
CREATE PROCEDURE sp_HocSinh_Insert
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh BIT,
    @DiaChi NVARCHAR(200),
    @MaLop INT
AS
BEGIN
    INSERT INTO HocSinh(HoTen, NgaySinh, GioiTinh, DiaChi, MaLop)
    VALUES(@HoTen, @NgaySinh, @GioiTinh, @DiaChi, @MaLop)
END
go

-- sửa hs
CREATE PROCEDURE sp_HocSinh_Update
    @MaHS INT,
    @HoTen NVARCHAR(100),
    @NgaySinh DATE,
    @GioiTinh BIT,
    @DiaChi NVARCHAR(200),
    @MaLop INT
AS
BEGIN
    UPDATE HocSinh
    SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, DiaChi=@DiaChi, MaLop=@MaLop
    WHERE MaHS=@MaHS
END
go


-- xóa hs
CREATE PROCEDURE sp_HocSinh_Delete
    @MaHS INT
AS
BEGIN
    DELETE FROM HocSinh WHERE MaHS=@MaHS
END
go

-- ds môn
CREATE PROCEDURE sp_MonHoc_GetAll
AS
BEGIN
    SELECT * FROM MonHoc
END
go


-- thêm môn
CREATE PROCEDURE sp_MonHoc_Insert
    @TenMon NVARCHAR(100),
    @HeSo INT
AS
BEGIN
    INSERT INTO MonHoc(TenMon, HeSo)
    VALUES(@TenMon, @HeSo)
END
go

-- sửa môn
CREATE PROCEDURE sp_MonHoc_Update
    @MaMon INT,
    @TenMon NVARCHAR(100),
    @HeSo INT
AS
BEGIN
    UPDATE MonHoc
    SET TenMon=@TenMon, HeSo=@HeSo
    WHERE MaMon=@MaMon
END
go


--xóa môn
CREATE PROCEDURE sp_MonHoc_Delete
    @MaMon INT
AS
BEGIN
    DELETE FROM MonHoc WHERE MaMon=@MaMon
END
go

-- ds gv
CREATE PROCEDURE sp_GiaoVien_GetAll
AS BEGIN
    SELECT * FROM GiaoVien ORDER BY MaGV
END
go

-- thêm gv
CREATE PROCEDURE sp_GiaoVien_Insert
    @HoTen NVARCHAR(100),
    @SDT VARCHAR(15)
AS
BEGIN
    INSERT INTO GiaoVien(HoTen, SDT)
    VALUES(@HoTen, @SDT)
END
go


-- sửa gv
CREATE PROCEDURE sp_GiaoVien_Update
    @MaGV INT,
    @HoTen NVARCHAR(100),
    @SDT VARCHAR(15)
AS
BEGIN
    UPDATE GiaoVien SET HoTen=@HoTen, SDT=@SDT WHERE MaGV=@MaGV
END
go

-- xóa gv
CREATE PROCEDURE sp_GiaoVien_Delete
    @MaGV INT
AS
BEGIN
    DELETE FROM GiaoVien WHERE MaGV=@MaGV
END
go

--ds năm học
CREATE PROCEDURE sp_NamHoc_GetAll
AS BEGIN
    SELECT * FROM NamHoc
END
go

-- thêm năm học
CREATE PROCEDURE sp_NamHoc_Insert
    @TenNamHoc NVARCHAR(20)
AS BEGIN
    INSERT INTO NamHoc(TenNamHoc) VALUES(@TenNamHoc)
END
go

-- sửa năm học
CREATE PROCEDURE sp_NamHoc_Update
    @MaNamHoc INT,
    @TenNamHoc NVARCHAR(20)
AS BEGIN
    UPDATE NamHoc SET TenNamHoc=@TenNamHoc WHERE MaNamHoc=@MaNamHoc
END
go


--xóa năm học
CREATE PROCEDURE sp_NamHoc_Delete
    @MaNamHoc INT
AS BEGIN
    DELETE FROM NamHoc WHERE MaNamHoc=@MaNamHoc
END
go

-- ds học kỳ
CREATE PROCEDURE sp_HocKy_GetAll
AS BEGIN
    SELECT * FROM HocKy
END

go
CREATE PROCEDURE sp_HocKy_Insert
    @TenHocKy NVARCHAR(20)
AS BEGIN
    INSERT INTO HocKy(TenHocKy) VALUES(@TenHocKy)
END

go
CREATE PROCEDURE sp_HocKy_Update
    @MaHocKy INT,
    @TenHocKy NVARCHAR(20)
AS BEGIN
    UPDATE HocKy SET TenHocKy=@TenHocKy WHERE MaHocKy=@MaHocKy
END

go
CREATE PROCEDURE sp_HocKy_Delete
    @MaHocKy INT
AS BEGIN
    DELETE FROM HocKy WHERE MaHocKy=@MaHocKy
END
go

-- ds loại điểm
CREATE PROCEDURE sp_LoaiDiem_GetAll
AS BEGIN
    SELECT * FROM LoaiDiem
END

go
CREATE PROCEDURE sp_LoaiDiem_Insert
    @TenLoaiDiem NVARCHAR(50),
    @HeSo INT
AS BEGIN
    INSERT INTO LoaiDiem(TenLoaiDiem, HeSo)
    VALUES(@TenLoaiDiem, @HeSo)
END

go
CREATE PROCEDURE sp_LoaiDiem_Update
    @MaLoaiDiem INT,
    @TenLoaiDiem NVARCHAR(50),
    @HeSo INT
AS BEGIN
    UPDATE LoaiDiem SET TenLoaiDiem=@TenLoaiDiem, HeSo=@HeSo WHERE MaLoaiDiem=@MaLoaiDiem
END

go
CREATE PROCEDURE sp_LoaiDiem_Delete
    @MaLoaiDiem INT
AS BEGIN
    DELETE FROM LoaiDiem WHERE MaLoaiDiem=@MaLoaiDiem
END
go

--ds phân công
CREATE PROCEDURE sp_PhanCong_GetAll
AS BEGIN
    SELECT PC.*, GV.HoTen AS TenGV, L.TenLop, MH.TenMon
    FROM PhanCong PC
    JOIN GiaoVien GV ON PC.MaGV = GV.MaGV
    JOIN Lop L ON PC.MaLop = L.MaLop
    JOIN MonHoc MH ON PC.MaMon = MH.MaMon
END

go
CREATE PROCEDURE sp_PhanCong_Insert
    @MaGV INT,
    @MaLop INT,
    @MaMon INT
AS BEGIN
    INSERT INTO PhanCong(MaGV, MaLop, MaMon)
    VALUES(@MaGV, @MaLop, @MaMon)
END

go
CREATE PROCEDURE sp_PhanCong_Update
    @MaPC INT,
    @MaGV INT,
    @MaLop INT,
    @MaMon INT
AS BEGIN
    UPDATE PhanCong
    SET MaGV=@MaGV, MaLop=@MaLop, MaMon=@MaMon
    WHERE MaPC=@MaPC
END

go
CREATE PROCEDURE sp_PhanCong_Delete
    @MaPC INT
AS BEGIN
    DELETE FROM PhanCong WHERE MaPC=@MaPC
END
go

--ds bảng điểm
CREATE PROCEDURE sp_BangDiem_GetAll
AS BEGIN
    SELECT BD.*, HS.HoTen, MH.TenMon, NH.TenNamHoc, HK.TenHocKy, LD.TenLoaiDiem
    FROM BangDiem BD
    JOIN HocSinh HS ON BD.MaHS = HS.MaHS
    JOIN MonHoc MH ON BD.MaMon = MH.MaMon
    JOIN NamHoc NH ON BD.MaNamHoc = NH.MaNamHoc
    JOIN HocKy HK ON BD.MaHocKy = HK.MaHocKy
    JOIN LoaiDiem LD ON BD.MaLoaiDiem = LD.MaLoaiDiem
END

go
CREATE PROCEDURE sp_BangDiem_Insert
    @MaHS INT,
    @MaMon INT,
    @MaNamHoc INT,
    @MaHocKy INT,
    @MaLoaiDiem INT,
    @Diem FLOAT
AS BEGIN
    INSERT INTO BangDiem(MaHS, MaMon, MaNamHoc, MaHocKy, MaLoaiDiem, Diem)
    VALUES(@MaHS, @MaMon, @MaNamHoc, @MaHocKy, @MaLoaiDiem, @Diem)
END

go
CREATE PROCEDURE sp_BangDiem_Update
    @MaBangDiem INT,
    @MaHS INT,
    @MaMon INT,
    @MaNamHoc INT,
    @MaHocKy INT,
    @MaLoaiDiem INT,
    @Diem FLOAT
AS BEGIN
    UPDATE BangDiem
    SET MaHS=@MaHS, MaMon=@MaMon, MaNamHoc=@MaNamHoc, MaHocKy=@MaHocKy, 
        MaLoaiDiem=@MaLoaiDiem, Diem=@Diem
    WHERE MaBangDiem=@MaBangDiem
END

go
CREATE PROCEDURE sp_BangDiem_Delete
    @MaBangDiem INT
AS BEGIN
    DELETE FROM BangDiem WHERE MaBangDiem=@MaBangDiem
END
go

-- tài khoản 
CREATE PROCEDURE sp_TaiKhoan_GetByUsername
    @TenDangNhap VARCHAR(50)
AS
BEGIN
    SELECT * FROM TaiKhoan WHERE TenDangNhap=@TenDangNhap
END

go
CREATE PROCEDURE sp_TaiKhoan_Insert
    @TenDangNhap VARCHAR(50),
    @MatKhau VARCHAR(100),
    @VaiTro NVARCHAR(50)
AS
BEGIN
    INSERT INTO TaiKhoan(TenDangNhap, MatKhau, VaiTro)
    VALUES(@TenDangNhap, @MatKhau, @VaiTro)
END