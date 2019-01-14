using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DTO
{
    public class ChiTietChuyenSinhHoatDoanDTO
    {
        public ChiTietChuyenSinhHoatDoanDTO() { }

        private string MaChiTiet;
        private string MaDoanVien;
        private string DonViChuyenDen;
        private DateTime ThoiGianChuyen;
        private bool isDeleted;
        private string LyDoChuyen;

        public void setMaChiTiet(string maChiTiet) { this.MaChiTiet = maChiTiet; }
        public string getMaChiTiet() { return this.MaChiTiet; }

        public void setMaDoanVien(string MaDoanVien) { this.MaDoanVien = MaDoanVien; }
        public string getMaDoanVien() { return this.MaDoanVien; }

        public void setDonViChuyenDen(string DonViChuyenDen) { this.DonViChuyenDen = DonViChuyenDen; }
        public string getDonViChuyenDen() { return this.DonViChuyenDen; }

        public void setThoiGianChuyen(DateTime ThoiGianChuyen) { this.ThoiGianChuyen = ThoiGianChuyen; }
        public DateTime getThoiGianChuyen() { return this.ThoiGianChuyen; }

        public void setIsDeleted(bool isDeleted) { this.isDeleted = isDeleted; }
        public bool getIsDeleted() { return this.isDeleted; }

        public void setLyDoChuyen(string lyDoChuyen) { this.LyDoChuyen = lyDoChuyen; }
        public string getLyDoChuyen() { return this.LyDoChuyen; }

        public CHITIETCHUYENSINHHOATDOAN ConvertToEntity()
        {
            CHITIETCHUYENSINHHOATDOAN entity = new CHITIETCHUYENSINHHOATDOAN();
            entity.MaChiTiet = this.getMaChiTiet();
            entity.MaDoanVien = this.getMaDoanVien();
            entity.DonViChuyenDen = this.getDonViChuyenDen();
            entity.ThoiGianChuyen = this.getThoiGianChuyen();
            entity.IsDeleted = this.getIsDeleted();
            entity.LyDoChuyen = this.getLyDoChuyen();

            return entity;
        }

        public ChiTietChuyenSinhHoatDoanDTO reConvertToDTO(CHITIETCHUYENSINHHOATDOAN entity)
        {
            ChiTietChuyenSinhHoatDoanDTO dto = new ChiTietChuyenSinhHoatDoanDTO();
            dto.setMaChiTiet(entity.MaChiTiet);
            dto.setMaDoanVien(entity.MaDoanVien);
            dto.setDonViChuyenDen(entity.DonViChuyenDen);
            dto.setThoiGianChuyen(entity.ThoiGianChuyen);
            dto.setIsDeleted(entity.IsDeleted);
            dto.setLyDoChuyen(entity.LyDoChuyen);

            return dto;
        }
    }
}
