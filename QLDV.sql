CREATE DATABASE QUANLYDOANVIEN
GO
SET DATEFORMAT DMY
USE QUANLYDOANVIEN
--Create Table
GO
CREATE TABLE [CHITIETCHUCVU] (
  [MaChiTiet] VARCHAR(15) NOT NULL,
  [MaDoanVien] VARCHAR(15) NOT NULL,
  [MaChucVu] VARCHAR(15) NOT NULL,
  [NhiemKy] NVARCHAR(70),
  PRIMARY KEY ([MaChiTiet])
);
GO
CREATE TABLE [TAIKHOAN] (
  [MaTaiKhoan] VARCHAR(15) NOT NULL,
  [MaChucVu] VARCHAR(15) NOT NULL,
  [MaDonVi] VARCHAR(15) NOT NULL,
  [TenDangNhap] NVARCHAR(70) NOT NULL,
  [MatKhau] NVARCHAR(70) NOT NULL,
  PRIMARY KEY ([MaTaiKhoan])
);
GO
CREATE TABLE [CHITIETDANHGIA_COSODOAN] (
  [MaChiTiet] VARCHAR(15) NOT NULL,
  [MaHDDG] VARCHAR(15) NOT NULL,
  [MaCoSoDoan] VARCHAR(15) NOT NULL,
  [CapDanhGia] NVARCHAR(70),
  [XepLoai] NVARCHAR(70),
  PRIMARY KEY ([MaChiTiet])
);
GO
CREATE TABLE [HOATDONGDANHGIA_DOANVIEN] (
  [MaHDDG] VARCHAR(15),
  [MaDoanVienDanhGia] VARCHAR(15),
  [ThoiGianDanhGia] SMALLDATETIME,
  [NamHoc] NVARCHAR(70),
  [SoLuongDV_XuatSac] SMALLINT,
  [SoLuongDV_Kha] SMALLINT,
  [SoLuongDV_TrungBinhKha] SMALLINT,
  [SoLuongDV_TrungBinh] SMALLINT,
  [SoLuongDV_Yeu] SMALLINT,
  [SoLuongDV_Kem] SMALLINT,
  PRIMARY KEY ([MaHDDG])
);
GO
CREATE TABLE [CHITIETCHUYENSINHHOATDOAN] (
  [MaChiTiet] VARCHAR(15),
  [MaDoanVien] VARCHAR(15),
  [DonViChuyenDen] NVARCHAR(200),
  [ThoiGianChuyen] SMALLDATETIME,
  PRIMARY KEY ([MaChiTiet])
);
GO
CREATE TABLE [KHENTHUONGKYLUAT] (
  [Ma_KT_KL] VARCHAR(15),
  [Ten_KT_KL] NVARCHAR(200),
  [ThoiGianHieuLuc] SMALLDATETIME,
  PRIMARY KEY ([Ma_KT_KL])
);
GO
CREATE TABLE [CHITIETDANHGIA_DOANVIEN] (
  [MaChiTiet] VARCHAR(15),
  [MaHDDG] VARCHAR(15),
  [MaDoanVien] VARCHAR(15),
  [NhanXetBiThuChiDoan] NVARCHAR(70),
  [XepLoai] NVARCHAR(70),
  PRIMARY KEY ([MaChiTiet])
);
GO
CREATE TABLE [DOANKHOA] (
  [MaDoanKhoa] VARCHAR(15),
  [TenDoanKhoa] NVARCHAR(70),
  PRIMARY KEY ([MaDoanKhoa])
);

CREATE TABLE [HOATDONG] (
  [MaHoatDong] VARCHAR(15),
  [CapToChuc] NVARCHAR(70),
  [MaDonViToChuc] VARCHAR(15),
  [NgayBatDau] SMALLDATETIME,
  [NgayKetThuc] SMALLDATETIME,
  [GhiChu] NVARCHAR(70),
  PRIMARY KEY ([MaHoatDong])
);

CREATE TABLE [CHITIETDANHGIA_BCH] (
  [MaChiTiet] VARCHAR(15),
  [MaHDDG] VARCHAR(15),
  [MaDoanVienBCH] VARCHAR(15),
  [DiemRenLuyen] SMALLINT,
  [DiemTrungBinh] SMALLINT,
  [KetQuaTuDanhGia] NVARCHAR(70),
  [NhanXetCapTren] NVARCHAR(70),
  PRIMARY KEY ([MaChiTiet])
);

CREATE TABLE [CHITIETHOATDONG] (
  [MaChiTiet] VARCHAR(15),
  [MaHoatDong] VARCHAR(15),
  [MaDoanVienThamGia] VARCHAR(15),
  [GhiChu] NVARCHAR(70),
  PRIMARY KEY ([MaChiTiet])
);

CREATE TABLE [CHUCVU] (
  [MaChucVu] VARCHAR(15),
  [Cap] VARCHAR(50),
  [TenChucVu] NVARCHAR(50),
  PRIMARY KEY ([MaChucVu])
);

CREATE TABLE [CHITIET_KT_KL] (
  [MaChiTiet] VARCHAR(15),
  [Ma_KT_KL] VARCHAR(15),
  [MaDoanVien] VARCHAR(15),
  PRIMARY KEY ([MaChiTiet])
);

CREATE TABLE [HOATDONGDANHGIA_BCH] (
  [MaHDDG] VARCHAR(15),
  [MaDoanVienDanhGia] VARCHAR(15),
  [ThoiGianDanhGia] SMALLDATETIME,
  [NamHoc] NVARCHAR(20),
  [HocKy] NVARCHAR(20),
  [SoLuongDVHoanThanhXuatSac] SMALLINT,
  [SoLuongDVHoanThanh] SMALLINT,
  [SoLuongDVKhongHoanThanh] SMALLINT,
  PRIMARY KEY ([MaHDDG])
);

CREATE TABLE [PHIEUTHUDOANPHI] (
  [MaPhieuThu] VARCHAR(15),
  [NamHoc] NVARCHAR(20),
  [MaChiDoan] VARCHAR(15),
  PRIMARY KEY ([MaPhieuThu])
);

CREATE TABLE [HOATDONGDANHGIA_COSODOAN] (
  [MaHDDG] VARCHAR(15),
  [MaDoanVienDanhGia] VARCHAR(15),
  [ThoiGianBatDauDanhGia] SMALLDATETIME,
  [ThoiGianKetThucDanhGia] SMALLDATETIME,
  [NamHoc] NVARCHAR(20),
  [SoLuong_CD_VungManh] SMALLINT,
  [SoLuong_CD_Kha] SMALLINT,
  [SoLuong_CD_TrungBinh] SMALLINT,
  [SoLuong_CD_YeuKem] SMALLINT,
  [SoLuong_CD_KhongXepLoai] SMALLINT,
  [SoLuong_DK_XuatSac] SMALLINT,
  [SoLuong_DK_TienTien] SMALLINT,
  [SoLuong_DK_Kha] SMALLINT,
  [SoLuong_DK_TrungBinh] SMALLINT,
  [SoLuong_DK_Yeu] SMALLINT,
  PRIMARY KEY ([MaHDDG])
);

CREATE TABLE [CHITIETPHIEUTHUDOANPHI] (
  [MaChiTiet] VARCHAR(15),
  [MaPhieuThu] VARCHAR(15),
  [MaDoanVien] VARCHAR(15),
  [GhiChu] NVARCHAR(300),
  PRIMARY KEY ([MaChiTiet])
);

CREATE TABLE [DOANVIEN] (
  [MaDoanVien] VARCHAR(15),
  [HoTen] NVARCHAR(70),
  [TenKhac] NVARCHAR(70),
  [GioiTinh] BIT,
  [NgaySinh] SMALLDATETIME,
  [QueQuan] NVARCHAR(70),
  [ThuongTru] NVARCHAR(300),
  [TamTru] NVARCHAR(300),
  [DanToc] NVARCHAR(70),
  [TonGiao] NVARCHAR(70),
  [NgheNghiep] NVARCHAR(70),
  [TrinhDo] NVARCHAR(70),
  [ChuyenMon] NVARCHAR(70),
  [LyLuanChinhTri] NVARCHAR(70),
  [NgoaiNgu] NVARCHAR(70),
  [TinhHinhSucKhoe] NVARCHAR(70),
  [ThongTinDiNuocNgoai] NVARCHAR(300),
  [QuaTrinhCongTac] NVARCHAR(300),
  [KhenThuong] NVARCHAR(300),
  [KyLuat] NVARCHAR(300),
  [NangKhieu] NVARCHAR(70),
  [SoTruong] NVARCHAR(70),
  [NgayVaoDoan] SMALLDATETIME,
  [NoiVaoDoan] NVARCHAR(100),
  [MaChiDoan] VARCHAR(15),
  [TinhTrangSinhHoatDoan] NVARCHAR(70),
  [NamBDSinhHoat] VARCHAR(50),
  [NamKTSinhHoat] VARCHAR(50),
  PRIMARY KEY ([MaDoanVien])
);

CREATE TABLE [CHIDOAN] (
  [MaChiDoan] VARCHAR(15),
  [TenChiDoan] NVARCHAR(100),
  [MaDoanKhoa] VARCHAR(15),
  PRIMARY KEY ([MaChiDoan])
);

CREATE TABLE [THAMSO] (
  [SoLuongUVBCHDoanKhoa_max1] SMALLINT,
  [SoLuongUVBCHDoanKhoa_max2] SMALLINT,
  [SoLuongUVBCHChiDoan_max1] SMALLINT,
  [SoLuongUVBCHCHiDoan_max2] SMALLINT
);

CREATE TABLE [THANNHAN] (
  [MaThanNhan] VARCHAR(15),
  [MaDoanVien] VARCHAR(15),
  [HoTen] NVARCHAR(70),
  [NgheNghiep] NVARCHAR(70),
  [QuocTich] NVARCHAR(70),
  [DanToc] NVARCHAR(70),
  [TonGiao] NVARCHAR(70),
  [QueQuan] NVARCHAR(70),
  [MoiQuanHe] NVARCHAR(70),
  [GhiChu] NVARCHAR(70),
  PRIMARY KEY ([MaThanNhan])
);

--Data
----1. Đoàn Khoa (DOANKHOA)
INSERT dbo.DOANKHOA
        ( MaDoanKhoa ,
          TenDoanKhoa
        )
VALUES  ( 'CNPM' , -- MaDoanKhoa - VARCHAR(15)
          N'Công Nghệ Phần Mềm' -- TenDoanKhoa - NVARCHAR(70)
        )
INSERT dbo.DOANKHOA
        ( MaDoanKhoa ,
          TenDoanKhoa
        )
VALUES  ( 'KHMT' , -- MaDoanKhoa - VARCHAR(15)
          N'Khoa Học Máy Tính' -- TenDoanKhoa - NVARCHAR(70)
        )
INSERT dbo.DOANKHOA
        ( MaDoanKhoa ,
          TenDoanKhoa 
        )
VALUES  ( 'MMTT' , -- MaDoanKhoa - VARCHAR(15)
          N'Mạng Máy Tính Và Truyền Thông' -- TenDoanKhoa - NVARCHAR(70)
        )
INSERT dbo.DOANKHOA
        ( MaDoanKhoa ,
          TenDoanKhoa
        )
VALUES  ( 'HTTT' , -- MaDoanKhoa - VARCHAR(15)
          N'Hệ Thống Thông Tin'  -- TenDoanKhoa - NVARCHAR(70)
        )
INSERT dbo.DOANKHOA
        ( MaDoanKhoa ,
          TenDoanKhoa
        )
VALUES  ( 'KTMT' , -- MaDoanKhoa - VARCHAR(15)
          N'Kỹ Thuật Máy Tính'  -- TenDoanKhoa - NVARCHAR(70)
        )
INSERT dbo.DOANKHOA
        ( MaDoanKhoa ,
          TenDoanKhoa 
        )
VALUES  ( 'KTTT' , -- MaDoanKhoa - VARCHAR(15)
          N'Khoa Học Và Kỹ Thuật Thông Tin'  -- TenDoanKhoa - NVARCHAR(70)
        )
INSERT dbo.DOANKHOA
        ( MaDoanKhoa ,
          TenDoanKhoa         )
VALUES  ( 'CBT' , -- MaDoanKhoa - VARCHAR(15)
          N'Đoàn Khối Cán Bộ Trẻ'  -- TenDoanKhoa - NVARCHAR(70)
        )

----2. Chi Đoàn (CHIDOAN)
INSERT dbo.CHIDOAN
        ( MaChiDoan ,
          TenChiDoan ,
          MaDoanKhoa
        )
VALUES  ( 'PMCL2015.3' , -- MaChiDoan - VARCHAR(15)
          N'Kỹ thuật Phần mềm hệ chất lượng cao khóa 2015 - lớp 3' , -- TenChiDoan - NVARCHAR(70)
          'CNPM'  -- MaDoanKhoa - VARCHAR(15)
        )
INSERT dbo.CHIDOAN
        ( MaChiDoan ,
          TenChiDoan ,
          MaDoanKhoa
        )
VALUES  ( 'KHTN2015' , -- MaChiDoan - VARCHAR(15)
          N'Khoa học máy tính hệ cử nhân tài năng khóa 2015' , -- TenChiDoan - NVARCHAR(70)
          'KHMT'  -- MaDoanKhoa - VARCHAR(15)
        )
INSERT dbo.CHIDOAN
        ( MaChiDoan ,
          TenChiDoan ,
          MaDoanKhoa
        )
VALUES  ( 'CTTT2015' , -- MaChiDoan - VARCHAR(15)
          N'Chương trình tiên tiến khóa 2015' , -- TenChiDoan - NVARCHAR(70)
          'HTTT'  -- MaDoanKhoa - VARCHAR(15)
        )
INSERT dbo.CHIDOAN
        ( MaChiDoan ,
          TenChiDoan ,
          MaDoanKhoa
        )
VALUES  ( 'CNTT2015' , -- MaChiDoan - varchar(15)
          N'Công nghệ thông tin khóa 2015' , -- TenChiDoan - NVARCHAR(70)
          'KTTT'  -- MaDoanKhoa - varchar(15)
        )
INSERT dbo.CHIDOAN
        ( MaChiDoan ,
          TenChiDoan ,
          MaDoanKhoa
        )
VALUES  ( 'KTMT2015' , -- MaChiDoan - varchar(15)
          N'Kỹ thuật máy tính hệ đại trà khóa 2015' , -- TenChiDoan - nvarchar(70)
          'KTMT'  -- MaDoanKhoa - varchar(15)
        )

----Chức Vụ (CHUCVU)
INSERT dbo.CHUCVU
(
    MaChucVu,
    Cap,
    TenChucVu
)
VALUES
(   'BTDT',  -- MaChucVu - varchar(15)
    N'DT', -- Cap - nvarchar(50)
    N'Bí thư Đoàn trường'  -- TenChucVu - nvarchar(50)
    )
INSERT dbo.CHUCVU
(
    MaChucVu,
    Cap,
    TenChucVu
)
VALUES
(   'PBTDK',  -- MaChucVu - varchar(15)
    N'DK', -- Cap - nvarchar(50)
    N'Phó Bí Thư Đoàn Khoa'  -- TenChucVu - nvarchar(50)
    )
INSERT dbo.CHUCVU
	(
	    MaChucVu,
	    Cap,
	    TenChucVu
	)
	VALUES
	(   'UVBCHCD',  -- MaChucVu - varchar(15)
	    N'CD', -- Cap - nvarchar(50)
	    N'Ủy viên Ban chấp hành Chi Đoàn'  -- TenChucVu - nvarchar(50)
	    )
INSERT dbo.CHUCVU
(
    MaChucVu,
    Cap,
    TenChucVu
)
VALUES
(   'UVBTVDT',  -- MaChucVu - varchar(15)
    N'DT', -- Cap - nvarchar(50)
    N'Ủy viên Ban thường vụ Đoàn Trường'  -- TenChucVu - nvarchar(50)
    )
INSERT dbo.CHUCVU
(
    MaChucVu,
    Cap,
    TenChucVu
)
VALUES
(   'UVBKT',  -- MaChucVu - varchar(15)
    N'DT', -- Cap - nvarchar(50)
    N'Ủy viên Ban Kiểm tra'  -- TenChucVu - nvarchar(50)
    )

---4, Đoàn viên (DOANVIEN)
INSERT dbo.DOANVIEN
        ( MaDoanVien ,
          HoTen ,
          TenKhac ,
          GioiTinh ,
          NgaySinh ,
          QueQuan ,
          ThuongTru ,
          TamTru ,
          DanToc ,
          TonGiao ,
          NgheNghiep ,
          TrinhDo ,
          ChuyenMon ,
          LyLuanChinhTri ,
          NgoaiNgu ,
          TinhHinhSucKhoe ,
          ThongTinDiNuocNgoai ,
          QuaTrinhCongTac ,
          KhenThuong ,
          KyLuat ,
          NangKhieu ,
          SoTruong ,
          NgayVaoDoan ,
          NoiVaoDoan ,
          MaChiDoan ,
          TinhTrangSinhHoatDoan ,
          NamBDSinhHoat ,
          NamKTSinhHoat
        )
VALUES  ( '15521016' , -- MaDoanVien - varchar(15)
          N'Lê Nhựt Vinh' , -- HoTen - nvarchar(70)
          N'Không có' , -- TenKhac - nvarchar(70)
          1 , -- GioiTinh - bit
		  CAST('03/12/2011 18:03:40' AS SMALLDATETIME), -- NgaySinh - smalldatetime
          N'Đồng Tháp' , -- QueQuan - nvarchar(70)
          N'07A Tân Bình, Tân Khánh Trung, Lấp Vò' , -- ThuongTru - nvarchar(70)
          N'Quận 12 Hcm' , -- TamTru - nvarchar(70)
          N'Kinh' , -- DanToc - nvarchar(70)
          N'Không có' , -- TonGiao - nvarchar(70)
          N'Sinh Viên' , -- NgheNghiep - nvarchar(70)
          N'Đại Học' , -- TrinhDo - nvarchar(70)
          N'Không có' , -- ChuyenMon - nvarchar(70)
          N'Không có' , -- LyLuanChinhTri - nvarchar(70)
          N'Không có' , -- NgoaiNgu - nvarchar(70)
          N'Không có' , -- TinhHinhSucKhoe - nvarchar(70)
          N'Không có' , -- ThongTinDiNuocNgoai - nvarchar(70)
          N'Không có' , -- QuaTrinhCongTac - nvarchar(70)
          N'Không có' , -- KhenThuong - nvarchar(70)
          N'Không có' , -- KyLuat - nvarchar(70)
          N'Không có' , -- NangKhieu - nvarchar(70)
          N'Không có' , -- SoTruong - nvarchar(70)
            CAST('2014/10/03' AS SMALLDATETIME) , -- NgayVaoDoan - smalldatetime
          N'Hồ Chí Minh' , -- NoiVaoDoan - nvarchar(70)
          'PMCL2015.3' , -- MaChiDoan - varchar(15)
          N'Không có' , -- TinhTrangSinhHoatDoan - nvarchar(70)
          '2015' , -- NamBDSinhHoat - varchar(50)
          'Không có'  -- NamKTSinhHoat - varchar(50)
        )
INSERT dbo.DOANVIEN
(
    MaDoanVien,
    HoTen,
    TenKhac,
    GioiTinh,
    NgaySinh,
    QueQuan,
    ThuongTru,
    TamTru,
    DanToc,
    TonGiao,
    NgheNghiep,
    TrinhDo,
    ChuyenMon,
    LyLuanChinhTri,
    NgoaiNgu,
    TinhHinhSucKhoe,
    ThongTinDiNuocNgoai,
    QuaTrinhCongTac,
    KhenThuong,
    KyLuat,
    NangKhieu,
    SoTruong,
    NgayVaoDoan,
    NoiVaoDoan,
    MaChiDoan,
    TinhTrangSinhHoatDoan,
    NamBDSinhHoat,
    NamKTSinhHoat
)
VALUES
(   '15521020',                    -- MaDoanVien - varchar(15)
    N'Trần Phú Vinh',                   -- HoTen - nvarchar(70)
    N'Không có',                   -- TenKhac - nvarchar(70)
    1,                  -- GioiTinh - bit
    '18-11-1997 03:35:56', -- NgaySinh - smalldatetime
    N'Vĩnh Long',                   -- QueQuan - nvarchar(70)
    N'Cầu Mỹ Thuận, Vĩnh Long',                   -- ThuongTru - nvarchar(70)
    N'Ktx Khu B',                   -- TamTru - nvarchar(70)
    N'Kinh',                   -- DanToc - nvarchar(70)
    N'Không có',                   -- TonGiao - nvarchar(70)
    N'Sinh Viên',                   -- NgheNghiep - nvarchar(70)
    N'Đại Học',                   -- TrinhDo - nvarchar(70)
    N'Không có',                   -- ChuyenMon - nvarchar(70)
    N'Không có',                   -- LyLuanChinhTri - nvarchar(70)
    N'Không có',                   -- NgoaiNgu - nvarchar(70)
    N'Không có',                   -- TinhHinhSucKhoe - nvarchar(70)
    N'Không có',                   -- ThongTinDiNuocNgoai - nvarchar(70)
    N'Không có',                   -- QuaTrinhCongTac - nvarchar(70)
    N'Không có',                   -- KhenThuong - nvarchar(70)
    N'Không có',                   -- KyLuat - nvarchar(70)
    N'Không có',                   -- NangKhieu - nvarchar(70)
    N'Không có',                   -- SoTruong - nvarchar(70)
    '01-11-1997 03:35:56', -- NgayVaoDoan - smalldatetime
    N'Vĩnh Long',                   -- NoiVaoDoan - nvarchar(70)
    'PMCL2015.3',                    -- MaChiDoan - varchar(15)
    N'Không có',                   -- TinhTrangSinhHoatDoan - nvarchar(70)
    '2015',                    -- NamBDSinhHoat - varchar(50)
    'Không có'                     -- NamKTSinhHoat - varchar(50)
    )
INSERT dbo.DOANVIEN
(
    MaDoanVien,
    HoTen,
    TenKhac,
    GioiTinh,
    NgaySinh,
    QueQuan,
    ThuongTru,
    TamTru,
    DanToc,
    TonGiao,
    NgheNghiep,
    TrinhDo,
    ChuyenMon,
    LyLuanChinhTri,
    NgoaiNgu,
    TinhHinhSucKhoe,
    ThongTinDiNuocNgoai,
    QuaTrinhCongTac,
    KhenThuong,
    KyLuat,
    NangKhieu,
    SoTruong,
    NgayVaoDoan,
    NoiVaoDoan,
    MaChiDoan,
    TinhTrangSinhHoatDoan,
    NamBDSinhHoat,
    NamKTSinhHoat
)
VALUES
(   '15521037',                    -- MaDoanVien - varchar(15)
    N'Phạm Hùng Vĩ',                   -- HoTen - nvarchar(70)
    N'Không có',                   -- TenKhac - nvarchar(70)
    1,                  -- GioiTinh - bit
    '08-08-1997 03:41:08', -- NgaySinh - smalldatetime
    N'Gia Lai',                   -- QueQuan - nvarchar(70)
    N'Pleiku, Gia Lai',                   -- ThuongTru - nvarchar(70)
    N'KTX Khu B',                   -- TamTru - nvarchar(70)
    N'Kinh',                   -- DanToc - nvarchar(70)
    N'Không có',                   -- TonGiao - nvarchar(70)
    N'Sinh Viên',                   -- NgheNghiep - nvarchar(70)
    N'Không có',                   -- TrinhDo - nvarchar(70)
    N'Không có',                   -- ChuyenMon - nvarchar(70)
    N'Không có',                   -- LyLuanChinhTri - nvarchar(70)
    N'Không có',                   -- NgoaiNgu - nvarchar(70)
    N'Không có',                   -- TinhHinhSucKhoe - nvarchar(70)
    N'Không có',                   -- ThongTinDiNuocNgoai - nvarchar(70)
    N'Không có',                   -- QuaTrinhCongTac - nvarchar(70)
    N'Không có',                   -- KhenThuong - nvarchar(70)
    N'Không có',                   -- KyLuat - nvarchar(70)
    N'Không có',                   -- NangKhieu - nvarchar(70)
    N'Không có',                   -- SoTruong - nvarchar(70)
    '26-03-2014 03:41:08', -- NgayVaoDoan - smalldatetime
    N'Hồ Chí Minh',                   -- NoiVaoDoan - nvarchar(70)
    'PMCL2015.3',                    -- MaChiDoan - varchar(15)
    N'Không có',                   -- TinhTrangSinhHoatDoan - nvarchar(70)
    '2015',                    -- NamBDSinhHoat - varchar(50)
    'Không có'                     -- NamKTSinhHoat - varchar(50)
    )
INSERT dbo.DOANVIEN
(
    MaDoanVien,
    HoTen,
    TenKhac,
    GioiTinh,
    NgaySinh,
    QueQuan,
    ThuongTru,
    TamTru,
    DanToc,
    TonGiao,
    NgheNghiep,
    TrinhDo,
    ChuyenMon,
    LyLuanChinhTri,
    NgoaiNgu,
    TinhHinhSucKhoe,
    ThongTinDiNuocNgoai,
    QuaTrinhCongTac,
    KhenThuong,
    KyLuat,
    NangKhieu,
    SoTruong,
    NgayVaoDoan,
    NoiVaoDoan,
    MaChiDoan,
    TinhTrangSinhHoatDoan,
    NamBDSinhHoat,
    NamKTSinhHoat
)
VALUES
(   '15521444',                    -- MaDoanVien - varchar(15)
    N'Nguyễn Thị A',                   -- HoTen - nvarchar(70)
    N'Không có',                   -- TenKhac - nvarchar(70)
    0,                  -- GioiTinh - bit
    '02-10-1996 03:41:08', -- NgaySinh - smalldatetime
    N'Hồ Chí Minh',                   -- QueQuan - nvarchar(70)
    N'Quận 12, Hồ Chí Minh',                   -- ThuongTru - nvarchar(70)
    N'KTX Khu B',                   -- TamTru - nvarchar(70)
    N'Kinh',                   -- DanToc - nvarchar(70)
    N'Không có',                   -- TonGiao - nvarchar(70)
    N'Sinh Viên',                   -- NgheNghiep - nvarchar(70)
    N'Không có',                   -- TrinhDo - nvarchar(70)
    N'Không có',                   -- ChuyenMon - nvarchar(70)
    N'Không có',                   -- LyLuanChinhTri - nvarchar(70)
    N'Không có',                   -- NgoaiNgu - nvarchar(70)
    N'Không có',                   -- TinhHinhSucKhoe - nvarchar(70)
    N'Không có',                   -- ThongTinDiNuocNgoai - nvarchar(70)
    N'Không có',                   -- QuaTrinhCongTac - nvarchar(70)
    N'Không có',                   -- KhenThuong - nvarchar(70)
    N'Không có',                   -- KyLuat - nvarchar(70)
    N'Không có',                   -- NangKhieu - nvarchar(70)
    N'Không có',                   -- SoTruong - nvarchar(70)
    '26-03-2015 03:41:08', -- NgayVaoDoan - smalldatetime
    N'Hồ Chí Minh',                   -- NoiVaoDoan - nvarchar(70)
    'PMCL2015.3',                    -- MaChiDoan - varchar(15)
    N'Không có',                   -- TinhTrangSinhHoatDoan - nvarchar(70)
    '2015',                    -- NamBDSinhHoat - varchar(50)
    'Không có'                     -- NamKTSinhHoat - varchar(50)
    )
INSERT dbo.DOANVIEN
(
    MaDoanVien,
    HoTen,
    TenKhac,
    GioiTinh,
    NgaySinh,
    QueQuan,
    ThuongTru,
    TamTru,
    DanToc,
    TonGiao,
    NgheNghiep,
    TrinhDo,
    ChuyenMon,
    LyLuanChinhTri,
    NgoaiNgu,
    TinhHinhSucKhoe,
    ThongTinDiNuocNgoai,
    QuaTrinhCongTac,
    KhenThuong,
    KyLuat,
    NangKhieu,
    SoTruong,
    NgayVaoDoan,
    NoiVaoDoan,
    MaChiDoan,
    TinhTrangSinhHoatDoan,
    NamBDSinhHoat,
    NamKTSinhHoat
)
VALUES
(   '15521024',                    -- MaDoanVien - varchar(15)
    N'Trần Hoàng N',                   -- HoTen - nvarchar(70)
    N'Không có',                   -- TenKhac - nvarchar(70)
    0,                  -- GioiTinh - bit
    '28-03-1997 03:48:54', -- NgaySinh - smalldatetime
    N'Cần Thơ',                   -- QueQuan - nvarchar(70)
    N'Long hoà, Cần thơ',                   -- ThuongTru - nvarchar(70)
    N'Ktx Khu B, Hồ chí minh',                   -- TamTru - nvarchar(70)
    N'Kinh',                   -- DanToc - nvarchar(70)
    N'Không có',                   -- TonGiao - nvarchar(70)
    N'Sinh Viên',                   -- NgheNghiep - nvarchar(70)
    N'Đại Học',                   -- TrinhDo - nvarchar(70)
    N'Không có',                   -- ChuyenMon - nvarchar(70)
    N'Không có',                   -- LyLuanChinhTri - nvarchar(70)
    N'Không có',                   -- NgoaiNgu - nvarchar(70)
    N'Không có',                   -- TinhHinhSucKhoe - nvarchar(70)
    N'Không có',                   -- ThongTinDiNuocNgoai - nvarchar(70)
    N'Không có',                   -- QuaTrinhCongTac - nvarchar(70)
    N'Không có',                   -- KhenThuong - nvarchar(70)
    N'Không có',                   -- KyLuat - nvarchar(70)
    N'Không có',                   -- NangKhieu - nvarchar(70)
    N'Không có',                   -- SoTruong - nvarchar(70)
    '04-04-2014 03:48:54', -- NgayVaoDoan - smalldatetime
    N'Cần Thơ',                   -- NoiVaoDoan - nvarchar(70)
    'PMCL2015.3',                    -- MaChiDoan - varchar(15)
    N'Không có',                   -- TinhTrangSinhHoatDoan - nvarchar(70)
    '2015',                    -- NamBDSinhHoat - varchar(50)
    'Không có'                     -- NamKTSinhHoat - varchar(50)
    )

---5. Thân Nhân (THANNHAN)
INSERT dbo.THANNHAN
(
    MaThanNhan,
    MaDoanVien,
    HoTen,
    NgheNghiep,
    QuocTich,
    DanToc,
    TonGiao,
    QueQuan,
    MoiQuanHe,
    GhiChu
)
VALUES
(   'TN001',  -- MaThanNhan - varchar(15)
    '15521016',  -- MaDoanVien - varchar(15)
    N'Lê Thanh Tuấn', -- HoTen - nvarchar(70)
    N'Làm Ruộng', -- NgheNghiep - nvarchar(70)
    N'Việt Nam', -- QuocTich - nvarchar(70)
    N'Kinh', -- DanToc - nvarchar(70)
    N'Không có', -- TonGiao - nvarchar(70)
    N'Đồng Tháp', -- QueQuan - nvarchar(70)
    N'Cha', -- MoiQuanHe - nvarchar(70)
    N''  -- GhiChu - nvarchar(70)
    )
INSERT dbo.THANNHAN
(
    MaThanNhan,
    MaDoanVien,
    HoTen,
    NgheNghiep,
    QuocTich,
    DanToc,
    TonGiao,
    QueQuan,
    MoiQuanHe,
    GhiChu
)
VALUES
(   'TN002',  -- MaThanNhan - varchar(15)
    '15521016',  -- MaDoanVien - varchar(15)
    N'Ngô Thị Tuyết Loan', -- HoTen - nvarchar(70)
    N'Y sĩ', -- NgheNghiep - nvarchar(70)
    N'Việt Nam', -- QuocTich - nvarchar(70)
    N'Kinh', -- DanToc - nvarchar(70)
    N'Không có', -- TonGiao - nvarchar(70)
    N'Đồng Tháp', -- QueQuan - nvarchar(70)
    N'Mẹ', -- MoiQuanHe - nvarchar(70)
    N''  -- GhiChu - nvarchar(70)
    )

---6. Chi Tiết Chức Vụ (CHITIETCHUCVU)
INSERT dbo.CHITIETCHUCVU
(
    MaChiTiet,
    MaDoanVien,
    MaChucVu,
    NhiemKy
)
VALUES
(   'CTCV001', -- MaChiTiet - varchar(15)
    '15521016', -- MaDoanVien - varchar(15)
    'PBTDK', -- MaChucVu - varchar(15)
    N'2018-2019' -- NhiemKy - nvarchar(70)
    )
INSERT dbo.CHITIETCHUCVU
(
    MaChiTiet,
    MaDoanVien,
    MaChucVu,
    NhiemKy
)
VALUES
(   'CTCV002', -- MaChiTiet - varchar(15)
    '15521020', -- MaDoanVien - varchar(15)
    'UVBTVDT', -- MaChucVu - varchar(15)
    N'2018-2020' -- NhiemKy - nvarchar(70)
    )
--Foreign key
ALTER TABLE dbo.THANNHAN ADD FOREIGN KEY (MaDoanVien) REFERENCES dbo.DOANVIEN(MaDoanVien)

ALTER TABLE dbo.CHIDOAN ADD FOREIGN KEY (MaDoanKhoa) REFERENCES dbo.DOANKHOA(MaDoanKhoa)
ALTER TABLE dbo.DOANVIEN ADD FOREIGN KEY (MaChiDoan) REFERENCES dbo.CHIDOAN(MaChiDoan)

ALTER TABLE dbo.CHITIET_KT_KL ADD FOREIGN KEY (Ma_KT_KL) REFERENCES dbo.KHENTHUONGKYLUAT(Ma_KT_KL)
ALTER TABLE dbo.CHITIET_KT_KL ADD FOREIGN KEY (MaDoanVien) REFERENCES dbo.DOANVIEN(MaDoanVien)

ALTER TABLE dbo.HOATDONGDANHGIA_DOANVIEN ADD FOREIGN KEY (MaDoanVienDanhGia) REFERENCES dbo.DOANVIEN(MaDoanVien)

ALTER TABLE dbo.CHITIETDANHGIA_DOANVIEN ADD FOREIGN KEY (MaHDDG) REFERENCES dbo.HOATDONGDANHGIA_DOANVIEN(MaHDDG)
ALTER TABLE dbo.CHITIETDANHGIA_DOANVIEN ADD FOREIGN KEY (MaDoanVien) REFERENCES dbo.DOANVIEN(MaDoanVien)

ALTER TABLE dbo.HOATDONGDANHGIA_BCH ADD FOREIGN KEY (MaDoanVienDanhGia) REFERENCES dbo.DOANVIEN(MaDoanVien)

ALTER TABLE dbo.CHITIETDANHGIA_BCH ADD FOREIGN KEY (MaHDDG) REFERENCES dbo.HOATDONGDANHGIA_BCH(MaHDDG)
ALTER TABLE dbo.CHITIETDANHGIA_BCH ADD FOREIGN KEY (MaDoanVienBCH) REFERENCES dbo.DOANVIEN(MaDoanVien)

ALTER TABLE dbo.CHITIETCHUYENSINHHOATDOAN ADD FOREIGN KEY (MaDoanVien) REFERENCES dbo.DOANVIEN(MaDoanVien)

ALTER TABLE dbo.CHITIETHOATDONG ADD FOREIGN KEY (MaHoatDong) REFERENCES dbo.HOATDONG(MaHoatDong)
ALTER TABLE dbo.CHITIETHOATDONG ADD FOREIGN KEY (MaDoanVienThamGia) REFERENCES dbo.DOANVIEN(MaDoanVien)

ALTER TABLE dbo.PHIEUTHUDOANPHI ADD FOREIGN KEY (MaChiDoan) REFERENCES dbo.CHIDOAN(MaChiDoan)

ALTER TABLE dbo.CHITIETPHIEUTHUDOANPHI ADD FOREIGN KEY (MaPhieuThu) REFERENCES dbo.PHIEUTHUDOANPHI(MaPhieuThu)
ALTER TABLE dbo.CHITIETPHIEUTHUDOANPHI ADD FOREIGN KEY (MaDoanVien) REFERENCES dbo.DOANVIEN(MaDoanVien)

ALTER TABLE dbo.HOATDONG ADD FOREIGN KEY (MaDonViToChuc) REFERENCES dbo.CHIDOAN(MaChiDoan)
ALTER TABLE dbo.HOATDONG ADD FOREIGN KEY (MaDonViToChuc) REFERENCES dbo.DOANKHOA(MaDoanKhoa)



ALTER TABLE dbo.CHITIETDANHGIA_COSODOAN ADD FOREIGN KEY (MaHDDG) REFERENCES dbo.HOATDONGDANHGIA_COSODOAN(MaHDDG)
ALTER TABLE dbo.CHITIETDANHGIA_COSODOAN ADD FOREIGN KEY (MaCoSoDoan) REFERENCES dbo.CHIDOAN(MaChiDoan)
ALTER TABLE dbo.CHITIETDANHGIA_COSODOAN ADD FOREIGN KEY (MaCoSoDoan) REFERENCES dbo.DOANKHOA(MaDoanKhoa)

ALTER TABLE dbo.HOATDONGDANHGIA_COSODOAN ADD FOREIGN KEY (MaDoanVienDanhGia) REFERENCES dbo.DOANVIEN(MaDoanVien)

ALTER TABLE dbo.TAIKHOAN ADD FOREIGN KEY (MaChucVu) REFERENCES dbo.CHUCVU(MaChucVu)
ALTER TABLE dbo.TAIKHOAN ADD FOREIGN KEY (MaDonVi) REFERENCES dbo.CHIDOAN(MaChiDoan)
ALTER TABLE dbo.TAIKHOAN ADD FOREIGN KEY (MaDonVi) REFERENCES dbo.DOANKHOA(MaDoanKhoa)
ALTER TABLE dbo.CHITIETCHUCVU ADD FOREIGN KEY (MaChucVu) REFERENCES dbo.CHUCVU(MaChucVu)
ALTER TABLE dbo.CHITIETCHUCVU ADD FOREIGN KEY (MaDoanVien) REFERENCES dbo.DOANVIEN(MaDoanVien)
