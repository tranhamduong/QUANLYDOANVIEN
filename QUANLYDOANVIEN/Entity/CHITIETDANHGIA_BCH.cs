namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHITIETDANHGIA_BCH
    {
        [Key]
        [StringLength(15)]
        public string MaChiTiet { get; set; }

        [StringLength(15)]
        public string MaHDDG { get; set; }

        [StringLength(15)]
        public string MaDoanVienBCH { get; set; }

        public short  DiemRenLuyen { get; set; }

        public short  DiemTrungBinh { get; set; }

        [StringLength(70)]
        public string KetQuaTuDanhGia { get; set; }

        [StringLength(70)]
        public string NhanXetCapTren { get; set; }

        [StringLength(70)]
        public string XepLoai { get; set; }

        public bool  IsDeleted { get; set; }

        public virtual DOANVIEN DOANVIEN { get; set; }

        public virtual HOATDONGDANHGIA_BCH HOATDONGDANHGIA_BCH { get; set; }
    }
}
