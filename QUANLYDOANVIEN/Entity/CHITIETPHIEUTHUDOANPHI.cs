namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPHIEUTHUDOANPHI")]
    public partial class CHITIETPHIEUTHUDOANPHI
    {
        [Key]
        [StringLength(15)]
        public string MaChiTiet { get; set; }

        [StringLength(15)]
        public string MaPhieuThu { get; set; }

        [StringLength(15)]
        public string MaDoanVien { get; set; }

        [StringLength(300)]
        public string GhiChu { get; set; }

        public virtual DOANVIEN DOANVIEN { get; set; }

        public virtual PHIEUTHUDOANPHI PHIEUTHUDOANPHI { get; set; }
    }
}
