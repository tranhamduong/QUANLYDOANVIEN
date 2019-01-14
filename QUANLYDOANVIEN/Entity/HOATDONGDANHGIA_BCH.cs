namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOATDONGDANHGIA_BCH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOATDONGDANHGIA_BCH()
        {
            CHITIETDANHGIA_BCH = new HashSet<CHITIETDANHGIA_BCH>();
        }

        [Key]
        [StringLength(15)]
        public string MaHDDG { get; set; }

        [StringLength(15)]
        public string MaDoanKhoa { get; set; }

        [StringLength(15)]
        public string MaChiDoan { get; set; }

        [StringLength(15)]
        public string MaDoanVienDanhGia { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime  ThoiGianDanhGia { get; set; }

        [StringLength(20)]
        public string NamHoc { get; set; }

        [StringLength(20)]
        public string HocKy { get; set; }

        public short  SoLuongDVHoanThanhXuatSac { get; set; }

        public short  SoLuongDVHoanThanh { get; set; }

        public short  SoLuongDVKhongHoanThanh { get; set; }

        public bool  IsDeleted { get; set; }

        public virtual CHIDOAN CHIDOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDANHGIA_BCH> CHITIETDANHGIA_BCH { get; set; }

        public virtual DOANKHOA DOANKHOA { get; set; }

        public virtual DOANVIEN DOANVIEN { get; set; }
    }
}
