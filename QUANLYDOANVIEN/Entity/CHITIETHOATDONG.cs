namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOATDONG")]
    public partial class CHITIETHOATDONG
    {
        [Key]
        [StringLength(15)]
        public string MaChiTiet { get; set; }

        [StringLength(15)]
        public string MaHoatDong { get; set; }

        [StringLength(15)]
        public string MaDoanVienThamGia { get; set; }

        [StringLength(70)]
        public string GhiChu { get; set; }

        public virtual DOANVIEN DOANVIEN { get; set; }

        public virtual HOATDONG HOATDONG { get; set; }
    }
}
