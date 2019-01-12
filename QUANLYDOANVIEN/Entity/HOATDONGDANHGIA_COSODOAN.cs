namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOATDONGDANHGIA_COSODOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOATDONGDANHGIA_COSODOAN()
        {
            CHITIETDANHGIA_COSODOAN = new HashSet<CHITIETDANHGIA_COSODOAN>();
        }

        [Key]
        [StringLength(15)]
        public string MaHDDG { get; set; }

        [StringLength(15)]
        public string MaDoanVienDanhGia { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ThoiGianBatDauDanhGia { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ThoiGianKetThucDanhGia { get; set; }

        [StringLength(20)]
        public string NamHoc { get; set; }

        public short? SoLuong_CD_VungManh { get; set; }

        public short? SoLuong_CD_Kha { get; set; }

        public short? SoLuong_CD_TrungBinh { get; set; }

        public short? SoLuong_CD_YeuKem { get; set; }

        public short? SoLuong_CD_KhongXepLoai { get; set; }

        public short? SoLuong_DK_XuatSac { get; set; }

        public short? SoLuong_DK_TienTien { get; set; }

        public short? SoLuong_DK_Kha { get; set; }

        public short? SoLuong_DK_TrungBinh { get; set; }

        public short? SoLuong_DK_Yeu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDANHGIA_COSODOAN> CHITIETDANHGIA_COSODOAN { get; set; }

        public virtual DOANVIEN DOANVIEN { get; set; }
    }
}
