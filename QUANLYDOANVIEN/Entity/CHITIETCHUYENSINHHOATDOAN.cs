namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETCHUYENSINHHOATDOAN")]
    public partial class CHITIETCHUYENSINHHOATDOAN
    {
        [Key]
        [StringLength(15)]
        public string MaChiTiet { get; set; }

        [StringLength(15)]
        public string MaDoanVien { get; set; }

        [StringLength(200)]
        public string DonViChuyenDen { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ThoiGianChuyen { get; set; }

        public virtual DOANVIEN DOANVIEN { get; set; }
    }
}
