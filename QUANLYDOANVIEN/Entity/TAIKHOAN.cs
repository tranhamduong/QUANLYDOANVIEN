namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [StringLength(15)]
        public string MaTaiKhoan { get; set; }

        [Required]
        [StringLength(15)]
        public string MaChucVu { get; set; }

        [StringLength(15)]
        public string MaDonVi { get; set; }

        [Required]
        [StringLength(70)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(70)]
        public string MatKhau { get; set; }

        public bool  IsDeleted { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }
    }
}
