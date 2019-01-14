namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHIDOAN")]
    public partial class CHIDOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHIDOAN()
        {
            CHITIETDANHGIA_COSODOAN = new HashSet<CHITIETDANHGIA_COSODOAN>();
            DOANVIENs = new HashSet<DOANVIEN>();
            HOATDONGs = new HashSet<HOATDONG>();
            HOATDONGDANHGIA_BCH = new HashSet<HOATDONGDANHGIA_BCH>();
            HOATDONGDANHGIA_DOANVIEN = new HashSet<HOATDONGDANHGIA_DOANVIEN>();
            PHIEUTHUDOANPHIs = new HashSet<PHIEUTHUDOANPHI>();
        }

        [Key]
        [StringLength(15)]
        public string MaChiDoan { get; set; }

        [StringLength(15)]
        public string MaHienThi { get; set; }

        [StringLength(100)]
        public string TenChiDoan { get; set; }

        [StringLength(15)]
        public string MaDoanKhoa { get; set; }

        public bool IsDeleted { get; set; }

        public virtual DOANKHOA DOANKHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDANHGIA_COSODOAN> CHITIETDANHGIA_COSODOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOANVIEN> DOANVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOATDONG> HOATDONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOATDONGDANHGIA_BCH> HOATDONGDANHGIA_BCH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOATDONGDANHGIA_DOANVIEN> HOATDONGDANHGIA_DOANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUDOANPHI> PHIEUTHUDOANPHIs { get; set; }
    }
}
