namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHENTHUONGKYLUAT")]
    public partial class KHENTHUONGKYLUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHENTHUONGKYLUAT()
        {
            CHITIET_KT_KL = new HashSet<CHITIET_KT_KL>();
        }

        [Key]
        [StringLength(15)]
        public string Ma_KT_KL { get; set; }

        [StringLength(200)]
        public string Ten_KT_KL { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ThoiGianHieuLuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_KT_KL> CHITIET_KT_KL { get; set; }
    }
}
