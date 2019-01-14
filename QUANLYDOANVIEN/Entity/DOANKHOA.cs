namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOANKHOA")]
    public partial class DOANKHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOANKHOA()
        {
            CHIDOANs = new HashSet<CHIDOAN>();
            CHITIETDANHGIA_COSODOAN = new HashSet<CHITIETDANHGIA_COSODOAN>();
            DOANVIENs = new HashSet<DOANVIEN>();
            HOATDONGs = new HashSet<HOATDONG>();
            HOATDONGDANHGIA_BCH = new HashSet<HOATDONGDANHGIA_BCH>();
        }

        [Key]
        [StringLength(15)]
        public string MaDoanKhoa { get; set; }

        [StringLength(15)]
        public string MaHienThi { get; set; }

        [StringLength(70)]
        public string TenDoanKhoa { get; set; }

        public bool  IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHIDOAN> CHIDOANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDANHGIA_COSODOAN> CHITIETDANHGIA_COSODOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOANVIEN> DOANVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOATDONG> HOATDONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOATDONGDANHGIA_BCH> HOATDONGDANHGIA_BCH { get; set; }
    }
}
