namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HOATDONGDANHGIA_DOANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOATDONGDANHGIA_DOANVIEN()
        {
            CHITIETDANHGIA_DOANVIEN = new HashSet<CHITIETDANHGIA_DOANVIEN>();
        }

        [Key]
        [StringLength(15)]
        public string MaHDDG { get; set; }

        [StringLength(15)]
        public string MaDoanVienDanhGia { get; set; }

        [StringLength(15)]
        public string MaDonVi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime  ThoiGianDanhGia { get; set; }

        [StringLength(70)]
        public string NamHoc { get; set; }

        public short  SoLuongDV_XuatSac { get; set; }

        public short  SoLuongDV_Kha { get; set; }

        public short  SoLuongDV_TrungBinhKha { get; set; }

        public short  SoLuongDV_TrungBinh { get; set; }

        public short  SoLuongDV_Yeu { get; set; }

        public short  SoLuongDV_Kem { get; set; }

        public bool  IsDeleted { get; set; }

        public virtual CHIDOAN CHIDOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDANHGIA_DOANVIEN> CHITIETDANHGIA_DOANVIEN { get; set; }

        public virtual DOANVIEN DOANVIEN { get; set; }
    }
}
