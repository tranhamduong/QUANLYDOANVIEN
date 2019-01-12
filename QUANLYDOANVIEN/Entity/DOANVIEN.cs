namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOANVIEN")]
    public partial class DOANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOANVIEN()
        {
            CHITIET_KT_KL = new HashSet<CHITIET_KT_KL>();
            CHITIETCHUCVUs = new HashSet<CHITIETCHUCVU>();
            CHITIETCHUYENSINHHOATDOANs = new HashSet<CHITIETCHUYENSINHHOATDOAN>();
            CHITIETDANHGIA_BCH = new HashSet<CHITIETDANHGIA_BCH>();
            CHITIETDANHGIA_DOANVIEN = new HashSet<CHITIETDANHGIA_DOANVIEN>();
            CHITIETHOATDONGs = new HashSet<CHITIETHOATDONG>();
            CHITIETPHIEUTHUDOANPHIs = new HashSet<CHITIETPHIEUTHUDOANPHI>();
            HOATDONGDANHGIA_DOANVIEN = new HashSet<HOATDONGDANHGIA_DOANVIEN>();
            HOATDONGDANHGIA_BCH = new HashSet<HOATDONGDANHGIA_BCH>();
            HOATDONGDANHGIA_COSODOAN = new HashSet<HOATDONGDANHGIA_COSODOAN>();
            THANNHANs = new HashSet<THANNHAN>();
        }

        [Key]
        [StringLength(15)]
        public string MaDoanVien { get; set; }

        [StringLength(70)]
        public string HoTen { get; set; }

        [StringLength(70)]
        public string TenKhac { get; set; }

        public bool? GioiTinh { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(70)]
        public string QueQuan { get; set; }

        [StringLength(300)]
        public string ThuongTru { get; set; }

        [StringLength(300)]
        public string TamTru { get; set; }

        [StringLength(70)]
        public string DanToc { get; set; }

        [StringLength(70)]
        public string TonGiao { get; set; }

        [StringLength(70)]
        public string NgheNghiep { get; set; }

        [StringLength(70)]
        public string TrinhDo { get; set; }

        [StringLength(70)]
        public string ChuyenMon { get; set; }

        [StringLength(70)]
        public string LyLuanChinhTri { get; set; }

        [StringLength(70)]
        public string NgoaiNgu { get; set; }

        [StringLength(70)]
        public string TinhHinhSucKhoe { get; set; }

        [StringLength(300)]
        public string ThongTinDiNuocNgoai { get; set; }

        [StringLength(300)]
        public string QuaTrinhCongTac { get; set; }

        [StringLength(300)]
        public string KhenThuong { get; set; }

        [StringLength(300)]
        public string KyLuat { get; set; }

        [StringLength(70)]
        public string NangKhieu { get; set; }

        [StringLength(70)]
        public string SoTruong { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayVaoDoan { get; set; }

        [StringLength(100)]
        public string NoiVaoDoan { get; set; }

        [StringLength(15)]
        public string MaChiDoan { get; set; }

        [StringLength(70)]
        public string TinhTrangSinhHoatDoan { get; set; }

        [StringLength(50)]
        public string NamBDSinhHoat { get; set; }

        [StringLength(50)]
        public string NamKTSinhHoat { get; set; }

        public virtual CHIDOAN CHIDOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_KT_KL> CHITIET_KT_KL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETCHUCVU> CHITIETCHUCVUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETCHUYENSINHHOATDOAN> CHITIETCHUYENSINHHOATDOANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDANHGIA_BCH> CHITIETDANHGIA_BCH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDANHGIA_DOANVIEN> CHITIETDANHGIA_DOANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOATDONG> CHITIETHOATDONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUTHUDOANPHI> CHITIETPHIEUTHUDOANPHIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOATDONGDANHGIA_DOANVIEN> HOATDONGDANHGIA_DOANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOATDONGDANHGIA_BCH> HOATDONGDANHGIA_BCH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOATDONGDANHGIA_COSODOAN> HOATDONGDANHGIA_COSODOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THANNHAN> THANNHANs { get; set; }
    }
}
