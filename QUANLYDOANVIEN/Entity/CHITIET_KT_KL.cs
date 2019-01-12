namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHITIET_KT_KL
    {
        [Key]
        [StringLength(15)]
        public string MaChiTiet { get; set; }

        [StringLength(15)]
        public string Ma_KT_KL { get; set; }

        [StringLength(15)]
        public string MaDoanVien { get; set; }

        public virtual KHENTHUONGKYLUAT KHENTHUONGKYLUAT { get; set; }

        public virtual DOANVIEN DOANVIEN { get; set; }
    }
}
