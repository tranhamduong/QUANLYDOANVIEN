namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOATDONG")]
    public partial class HOATDONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOATDONG()
        {
            CHITIETHOATDONGs = new HashSet<CHITIETHOATDONG>();
        }

        [Key]
        [StringLength(15)]
        public string MaHoatDong { get; set; }

        [StringLength(200)]
        public string TenHoatDong { get; set; }

        [StringLength(70)]
        public string CapToChuc { get; set; }

        [StringLength(15)]
        public string MaChiDoanToChuc { get; set; }

        [StringLength(15)]
        public string MaDoanKhoaToChuc { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime  NgayBatDau { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime  NgayKetThuc { get; set; }

        [StringLength(70)]
        public string GhiChu { get; set; }

        public bool  IsDeleted { get; set; }

        public virtual CHIDOAN CHIDOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOATDONG> CHITIETHOATDONGs { get; set; }

        public virtual DOANKHOA DOANKHOA { get; set; }
    }
}
