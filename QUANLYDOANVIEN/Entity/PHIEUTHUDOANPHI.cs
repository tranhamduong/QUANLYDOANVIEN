namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHUDOANPHI")]
    public partial class PHIEUTHUDOANPHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUTHUDOANPHI()
        {
            CHITIETPHIEUTHUDOANPHIs = new HashSet<CHITIETPHIEUTHUDOANPHI>();
        }

        [Key]
        [StringLength(15)]
        public string MaPhieuThu { get; set; }

        [StringLength(20)]
        public string NamHoc { get; set; }

        [StringLength(15)]
        public string MaChiDoan { get; set; }

        public virtual CHIDOAN CHIDOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHIEUTHUDOANPHI> CHITIETPHIEUTHUDOANPHIs { get; set; }
    }
}
