using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DTO
{
    public class ChiTietDanhGia_DoanVienDTO
    {
        private string MaChiTiet;
        private string MaHDDG;
        private string MaDoanVien;
        private string NhanXetBiThuChiDoan;
        private string XepLoai;
        private bool IsDeleted;

        public void setMaChiTiet(string MaChiTiet) { this.MaChiTiet = MaChiTiet; }
        public string getMaChiTiet() { return this.MaChiTiet; }

        public void setMaHDDG(string MaHDDG) { this.MaHDDG = MaHDDG; }
        public string getMaHDDG() { return this.MaHDDG; }

        public void setMaDoanVien(string MaDoanVien) { this.MaDoanVien = MaDoanVien; }
        public string getMaDoanVien() { return this.MaDoanVien; }

        public void setNhanXetBiThuChiDoan(string NhanXetBiThuChiDoan) { this.NhanXetBiThuChiDoan = NhanXetBiThuChiDoan; }
        public string getNhanXetBiThuChiDoan() { return this.NhanXetBiThuChiDoan; }

        public void setXepLoai(string XepLoai) { this.XepLoai = XepLoai; }
        public string getXepLoai() { return this.XepLoai; }

        public void setIsDeleted(bool IsDeleted) { this.IsDeleted = IsDeleted; }
        public bool getIsDeleted() { return this.IsDeleted; }

        private int DRL;

        public void setDRL(int DRL) { this.DRL = DRL; }
        public int getDRL() { return this.DRL; }

        public CHITIETDANHGIA_DOANVIEN ConvertToEntity()
        {
            CHITIETDANHGIA_DOANVIEN ct = new CHITIETDANHGIA_DOANVIEN();
            ct.MaChiTiet = this.getMaChiTiet();
            ct.MaDoanVien = this.getMaDoanVien();
            ct.NhanXetBiThuChiDoan = this.NhanXetBiThuChiDoan;
            ct.XepLoai = this.getXepLoai();
            ct.MaHDDG = this.getMaHDDG();
            return ct;
        }

        public ChiTietDanhGia_DoanVienDTO reConvertToDTO(CHITIETDANHGIA_DOANVIEN ct)
        {
            ChiTietDanhGia_DoanVienDTO dto = new ChiTietDanhGia_DoanVienDTO();
            dto.setMaChiTiet(ct.MaChiTiet);
            dto.setMaDoanVien(ct.MaDoanVien);
            dto.setMaHDDG(ct.MaHDDG);
            dto.setNhanXetBiThuChiDoan(ct.NhanXetBiThuChiDoan);
            dto.setXepLoai(ct.XepLoai);
            dto.setIsDeleted(ct.IsDeleted);

            return dto;
        }


    }
}
