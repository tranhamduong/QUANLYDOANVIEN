namespace QUANLYDOANVIEN.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THANNHAN")]
    public partial class THANNHAN
    {
        [Key]
        [StringLength(15)]
        public string MaThanNhan { get; set; }

        [StringLength(15)]
        public string MaDoanVien { get; set; }

        [StringLength(70)]
        public string HoTen { get; set; }

        [StringLength(70)]
        public string NgheNghiep { get; set; }

        [StringLength(70)]
        public string QuocTich { get; set; }

        [StringLength(70)]
        public string DanToc { get; set; }

        [StringLength(70)]
        public string TonGiao { get; set; }

        [StringLength(70)]
        public string QueQuan { get; set; }

        [StringLength(70)]
        public string MoiQuanHe { get; set; }

        [StringLength(70)]
        public string GhiChu { get; set; }

        public bool  IsDeleted { get; set; }

        public virtual DOANVIEN DOANVIEN { get; set; }
    }
}
