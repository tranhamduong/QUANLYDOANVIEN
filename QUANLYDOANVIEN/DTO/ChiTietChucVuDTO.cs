using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DTO
{
    public class ChiTietChucVuDTO
    {
        public string MaChiTiet { get; set; }
        public string MaDoanVien { get; set; }
        public string MaChucVu { get; set; }
        public string NhiemKy { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public bool? IsDeleted { get; set; }
        //Constructor
        public ChiTietChucVuDTO()
        {
            MaChiTiet = "";
            MaDoanVien = "";
            MaChucVu = "";
            NhiemKy = "";
            NgayBatDau = null;
            NgayKetThuc = null;
            IsDeleted = false;
        }

        public ChiTietChucVuDTO(string MaChiTiet, string MaDoanVien, string MaChucVu, string NhiemKy,DateTime? NgayBatDau, DateTime? NgayKetThuc, bool? IsDeleted)
        {
            this.MaChiTiet = MaChiTiet;
            this.MaDoanVien = MaDoanVien;
            this.MaChucVu = MaChucVu;
            this.NhiemKy = NhiemKy;
            this.NgayBatDau = NgayBatDau;
            this.NgayKetThuc = NgayKetThuc;
            this.IsDeleted = IsDeleted;
        }
    }
}
