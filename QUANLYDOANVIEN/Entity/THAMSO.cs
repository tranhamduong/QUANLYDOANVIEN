namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THAMSO")]
    public partial class THAMSO
    {
        [Key]
        [StringLength(5)]
        public string MaThamSo { get; set; }

        public short  SoLuongUVBCHDoanTruong_max { get; set; }

        public short  SoLuongUVBCHDoanKhoa_max1 { get; set; }

        public short  SoLuongUVBCHDoanKhoa_max2 { get; set; }

        public short  SoLuongUVBCHChiDoan_max1 { get; set; }

        public short  SoLuongUVBCHCHiDoan_max2 { get; set; }
    }
}
