namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETCHUCVU")]
    public partial class CHITIETCHUCVU
    {
        [Key]
        [StringLength(15)]
        public string MaChiTiet { get; set; }

        [Required]
        [StringLength(15)]
        public string MaDoanVien { get; set; }

        [Required]
        [StringLength(15)]
        public string MaChucVu { get; set; }

        [StringLength(70)]
        public string NhiemKy { get; set; }

        public bool?  IsDeleted { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime?  NgayBatDau { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime?  NgayKetThuc { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        public virtual DOANVIEN DOANVIEN { get; set; }
    }
}
