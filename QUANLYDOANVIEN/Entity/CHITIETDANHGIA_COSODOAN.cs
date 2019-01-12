namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHITIETDANHGIA_COSODOAN
    {
        [Key]
        [StringLength(15)]
        public string MaChiTiet { get; set; }

        [Required]
        [StringLength(15)]
        public string MaHDDG { get; set; }

        [Required]
        [StringLength(15)]
        public string MaCoSoDoan { get; set; }

        [StringLength(70)]
        public string CapDanhGia { get; set; }

        [StringLength(70)]
        public string XepLoai { get; set; }

        public virtual CHIDOAN CHIDOAN { get; set; }

        public virtual DOANKHOA DOANKHOA { get; set; }

        public virtual HOATDONGDANHGIA_COSODOAN HOATDONGDANHGIA_COSODOAN { get; set; }
    }
}
