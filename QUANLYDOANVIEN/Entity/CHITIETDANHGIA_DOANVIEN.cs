namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHITIETDANHGIA_DOANVIEN
    {
        [Key]
        [StringLength(15)]
        public string MaChiTiet { get; set; }

        [StringLength(15)]
        public string MaHDDG { get; set; }

        [StringLength(15)]
        public string MaDoanVien { get; set; }

        [StringLength(70)]
        public string NhanXetBiThuChiDoan { get; set; }

        public int  DiemRenLuyen { get; set; }

        [StringLength(70)]
        public string XepLoai { get; set; }

        public bool  IsDeleted { get; set; }

        public virtual DOANVIEN DOANVIEN { get; set; }

        public virtual HOATDONGDANHGIA_DOANVIEN HOATDONGDANHGIA_DOANVIEN { get; set; }
    }
}
