namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLDOANVIEN_DATABASE : DbContext
    {
        public QLDOANVIEN_DATABASE()
            : base("name=QLDOANVIEN_DATABASE")
        {
        }

        public virtual DbSet<CHIDOAN> CHIDOANs { get; set; }
        public virtual DbSet<CHITIET_KT_KL> CHITIET_KT_KL { get; set; }
        public virtual DbSet<CHITIETCHUCVU> CHITIETCHUCVUs { get; set; }
        public virtual DbSet<CHITIETCHUYENSINHHOATDOAN> CHITIETCHUYENSINHHOATDOANs { get; set; }
        public virtual DbSet<CHITIETDANHGIA_BCH> CHITIETDANHGIA_BCH { get; set; }
        public virtual DbSet<CHITIETDANHGIA_COSODOAN> CHITIETDANHGIA_COSODOAN { get; set; }
        public virtual DbSet<CHITIETDANHGIA_DOANVIEN> CHITIETDANHGIA_DOANVIEN { get; set; }
        public virtual DbSet<CHITIETHOATDONG> CHITIETHOATDONGs { get; set; }
        public virtual DbSet<CHITIETPHIEUTHUDOANPHI> CHITIETPHIEUTHUDOANPHIs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<DOANKHOA> DOANKHOAs { get; set; }
        public virtual DbSet<DOANVIEN> DOANVIENs { get; set; }
        public virtual DbSet<HOATDONG> HOATDONGs { get; set; }
        public virtual DbSet<HOATDONGDANHGIA_BCH> HOATDONGDANHGIA_BCH { get; set; }
        public virtual DbSet<HOATDONGDANHGIA_COSODOAN> HOATDONGDANHGIA_COSODOAN { get; set; }
        public virtual DbSet<HOATDONGDANHGIA_DOANVIEN> HOATDONGDANHGIA_DOANVIEN { get; set; }
        public virtual DbSet<KHENTHUONGKYLUAT> KHENTHUONGKYLUATs { get; set; }
        public virtual DbSet<PHIEUTHUDOANPHI> PHIEUTHUDOANPHIs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THANNHAN> THANNHANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHIDOAN>()
                .Property(e => e.MaChiDoan)
                .IsUnicode(false);

            modelBuilder.Entity<CHIDOAN>()
                .Property(e => e.MaDoanKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<CHIDOAN>()
                .HasMany(e => e.CHITIETDANHGIA_COSODOAN)
                .WithRequired(e => e.CHIDOAN)
                .HasForeignKey(e => e.MaCoSoDoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHIDOAN>()
                .HasMany(e => e.HOATDONGs)
                .WithOptional(e => e.CHIDOAN)
                .HasForeignKey(e => e.MaDonViToChuc);

            modelBuilder.Entity<CHIDOAN>()
                .HasMany(e => e.TAIKHOANs)
                .WithRequired(e => e.CHIDOAN)
                .HasForeignKey(e => e.MaDonVi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHITIET_KT_KL>()
                .Property(e => e.MaChiTiet)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIET_KT_KL>()
                .Property(e => e.Ma_KT_KL)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIET_KT_KL>()
                .Property(e => e.MaDoanVien)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETCHUCVU>()
                .Property(e => e.MaChiTiet)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETCHUCVU>()
                .Property(e => e.MaDoanVien)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETCHUCVU>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETCHUYENSINHHOATDOAN>()
                .Property(e => e.MaChiTiet)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETCHUYENSINHHOATDOAN>()
                .Property(e => e.MaDoanVien)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDANHGIA_BCH>()
                .Property(e => e.MaChiTiet)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDANHGIA_BCH>()
                .Property(e => e.MaHDDG)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDANHGIA_BCH>()
                .Property(e => e.MaDoanVienBCH)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDANHGIA_COSODOAN>()
                .Property(e => e.MaChiTiet)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDANHGIA_COSODOAN>()
                .Property(e => e.MaHDDG)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDANHGIA_COSODOAN>()
                .Property(e => e.MaCoSoDoan)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDANHGIA_DOANVIEN>()
                .Property(e => e.MaChiTiet)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDANHGIA_DOANVIEN>()
                .Property(e => e.MaHDDG)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETDANHGIA_DOANVIEN>()
                .Property(e => e.MaDoanVien)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOATDONG>()
                .Property(e => e.MaChiTiet)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOATDONG>()
                .Property(e => e.MaHoatDong)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOATDONG>()
                .Property(e => e.MaDoanVienThamGia)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETPHIEUTHUDOANPHI>()
                .Property(e => e.MaChiTiet)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETPHIEUTHUDOANPHI>()
                .Property(e => e.MaPhieuThu)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETPHIEUTHUDOANPHI>()
                .Property(e => e.MaDoanVien)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.Cap)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.CHITIETCHUCVUs)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.TAIKHOANs)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOANKHOA>()
                .Property(e => e.MaDoanKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<DOANKHOA>()
                .HasMany(e => e.CHITIETDANHGIA_COSODOAN)
                .WithRequired(e => e.DOANKHOA)
                .HasForeignKey(e => e.MaCoSoDoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOANKHOA>()
                .HasMany(e => e.HOATDONGs)
                .WithOptional(e => e.DOANKHOA)
                .HasForeignKey(e => e.MaDonViToChuc);

            modelBuilder.Entity<DOANKHOA>()
                .HasMany(e => e.TAIKHOANs)
                .WithRequired(e => e.DOANKHOA)
                .HasForeignKey(e => e.MaDonVi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOANVIEN>()
                .Property(e => e.MaDoanVien)
                .IsUnicode(false);

            modelBuilder.Entity<DOANVIEN>()
                .Property(e => e.MaChiDoan)
                .IsUnicode(false);

            modelBuilder.Entity<DOANVIEN>()
                .Property(e => e.NamBDSinhHoat)
                .IsUnicode(false);

            modelBuilder.Entity<DOANVIEN>()
                .Property(e => e.NamKTSinhHoat)
                .IsUnicode(false);

            modelBuilder.Entity<DOANVIEN>()
                .HasMany(e => e.CHITIETCHUCVUs)
                .WithRequired(e => e.DOANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOANVIEN>()
                .HasMany(e => e.CHITIETDANHGIA_BCH)
                .WithOptional(e => e.DOANVIEN)
                .HasForeignKey(e => e.MaDoanVienBCH);

            modelBuilder.Entity<DOANVIEN>()
                .HasMany(e => e.CHITIETHOATDONGs)
                .WithOptional(e => e.DOANVIEN)
                .HasForeignKey(e => e.MaDoanVienThamGia);

            modelBuilder.Entity<DOANVIEN>()
                .HasMany(e => e.HOATDONGDANHGIA_DOANVIEN)
                .WithOptional(e => e.DOANVIEN)
                .HasForeignKey(e => e.MaDoanVienDanhGia);

            modelBuilder.Entity<DOANVIEN>()
                .HasMany(e => e.HOATDONGDANHGIA_BCH)
                .WithOptional(e => e.DOANVIEN)
                .HasForeignKey(e => e.MaDoanVienDanhGia);

            modelBuilder.Entity<DOANVIEN>()
                .HasMany(e => e.HOATDONGDANHGIA_COSODOAN)
                .WithOptional(e => e.DOANVIEN)
                .HasForeignKey(e => e.MaDoanVienDanhGia);

            modelBuilder.Entity<HOATDONG>()
                .Property(e => e.MaHoatDong)
                .IsUnicode(false);

            modelBuilder.Entity<HOATDONG>()
                .Property(e => e.MaDonViToChuc)
                .IsUnicode(false);

            modelBuilder.Entity<HOATDONGDANHGIA_BCH>()
                .Property(e => e.MaHDDG)
                .IsUnicode(false);

            modelBuilder.Entity<HOATDONGDANHGIA_BCH>()
                .Property(e => e.MaDoanVienDanhGia)
                .IsUnicode(false);

            modelBuilder.Entity<HOATDONGDANHGIA_COSODOAN>()
                .Property(e => e.MaHDDG)
                .IsUnicode(false);

            modelBuilder.Entity<HOATDONGDANHGIA_COSODOAN>()
                .Property(e => e.MaDoanVienDanhGia)
                .IsUnicode(false);

            modelBuilder.Entity<HOATDONGDANHGIA_COSODOAN>()
                .HasMany(e => e.CHITIETDANHGIA_COSODOAN)
                .WithRequired(e => e.HOATDONGDANHGIA_COSODOAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOATDONGDANHGIA_DOANVIEN>()
                .Property(e => e.MaHDDG)
                .IsUnicode(false);

            modelBuilder.Entity<HOATDONGDANHGIA_DOANVIEN>()
                .Property(e => e.MaDoanVienDanhGia)
                .IsUnicode(false);

            modelBuilder.Entity<KHENTHUONGKYLUAT>()
                .Property(e => e.Ma_KT_KL)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHUDOANPHI>()
                .Property(e => e.MaPhieuThu)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHUDOANPHI>()
                .Property(e => e.MaChiDoan)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MaTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MaChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MaDonVi)
                .IsUnicode(false);

            modelBuilder.Entity<THANNHAN>()
                .Property(e => e.MaThanNhan)
                .IsUnicode(false);

            modelBuilder.Entity<THANNHAN>()
                .Property(e => e.MaDoanVien)
                .IsUnicode(false);
        }
    }
}
