using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DTO
{
    public class HoatDongDanhGiaDoanVienDTO
    {
        private string MaHDDG;
        private string MaDoanVienDanhGia;
        private DateTime ThoiGianDanhGia;
        private string NamHoc;
        private int SoLuongDV_XuatSac;
        private int SoLuongDV_Kha;
        private int SoLuongDV_TrungBinhKha;
        private int SoLuongDV_TrungBinh;
        private int SoLuongDV_Yeu;
        private int SoLuongDV_Kem;
        private string MaDonVi;
        private bool IsDeleted;

        public void setMaHDDG(string MaHDDG) { this.MaHDDG = MaHDDG; }
        public string getMaHDDG() { return this.MaHDDG; }

        public void setMaDoanVienDanhGia(string MaDoanVienDanhGia) { this.MaDoanVienDanhGia = MaDoanVienDanhGia; }
        public string getMaDoanVienDanhGia() { return this.MaDoanVienDanhGia; }

        public void setThoiGianDanhGia(DateTime ThoiGianDanhGia) { this.ThoiGianDanhGia = ThoiGianDanhGia; }
        public DateTime getThoiGianDanhGia() { return this.ThoiGianDanhGia; }

        public void setNamHoc(string NamHoc) { this.NamHoc = NamHoc; }
        public string getNamHoc() { return this.NamHoc; }

        public void setSoLuongDV_XuatSac(int SoLuongDV_XuatSac) { this.SoLuongDV_XuatSac = SoLuongDV_XuatSac; }
        public int getSoLuongDV_XuatSac() { return this.SoLuongDV_XuatSac; }

        public void setSoLuongDV_Kha(int SoLuongDV_Kha) { this.SoLuongDV_Kha = SoLuongDV_Kha; }
        public int getSoLuongDV_Kha() { return this.SoLuongDV_Kha; }

        public void setSoLuongDV_TrungBinhKha(int SoLuongDV_TrungBinhKha) { this.SoLuongDV_TrungBinhKha = SoLuongDV_TrungBinhKha; }
        public int getSoLuongDV_TrungBinhKha() { return this.SoLuongDV_TrungBinhKha; }

        public void setSoLuongDV_TrungBinhG(int SoLuongDV_TrungBinh) { this.SoLuongDV_TrungBinh = SoLuongDV_TrungBinh; }
        public int getSoLuongDV_TrungBinh() { return this.SoLuongDV_TrungBinh; }
        public void setSoLuongDV_Kem(int SoLuongDV_Kem) { this.SoLuongDV_Kem = SoLuongDV_Kem; }
        public int getSoLuongDV_Kem() { return this.SoLuongDV_Kem; }
        public void setSoLuongDV_Yeu(int SoLuongDV_Yeu) { this.SoLuongDV_Yeu = SoLuongDV_Yeu; }
        public int getSoLuongDV_Yeu() { return this.SoLuongDV_Yeu; }

        public void setMaDonVi(string MaDonVi) { this.MaDonVi = MaDonVi; }
        public string getMaDonVi() { return this.MaDonVi; }

        public HOATDONGDANHGIA_DOANVIEN convertToEntity()
        {
            HOATDONGDANHGIA_DOANVIEN hd = new HOATDONGDANHGIA_DOANVIEN();
            hd.MaHDDG = this.getMaHDDG();
            hd.MaDoanVienDanhGia = this.getMaDoanVienDanhGia();
            hd.ThoiGianDanhGia = this.getThoiGianDanhGia();
            hd.NamHoc = this.getNamHoc();
            hd.SoLuongDV_XuatSac = (Int16)this.getSoLuongDV_XuatSac();
            hd.SoLuongDV_Kha = (Int16)this.getSoLuongDV_Kha();
            hd.SoLuongDV_TrungBinhKha = (Int16)this.getSoLuongDV_TrungBinhKha();
            hd.SoLuongDV_TrungBinh = (Int16)this.getSoLuongDV_TrungBinh();
            hd.SoLuongDV_Yeu = (Int16)this.getSoLuongDV_Yeu();
            hd.SoLuongDV_Kem = (Int16)this.getSoLuongDV_Yeu();
            hd.MaDonVi = this.getMaDonVi();
            return hd;
        }

        public static HoatDongDanhGiaDoanVienDTO reConvertToDTO(HOATDONGDANHGIA_DOANVIEN entity)
        {
            HoatDongDanhGiaDoanVienDTO dto = new HoatDongDanhGiaDoanVienDTO();
            dto.setMaHDDG(entity.MaHDDG);
            dto.setMaDoanVienDanhGia(entity.MaDoanVienDanhGia);
            dto.setThoiGianDanhGia(entity.ThoiGianDanhGia);
            dto.setNamHoc(entity.NamHoc);
            dto.setSoLuongDV_XuatSac(entity.SoLuongDV_XuatSac);
            dto.setSoLuongDV_Kha(entity.SoLuongDV_Kha);
            dto.setSoLuongDV_TrungBinhKha(entity.SoLuongDV_TrungBinhKha);
            dto.setSoLuongDV_TrungBinhG(entity.SoLuongDV_TrungBinh);
            dto.setSoLuongDV_Yeu(entity.SoLuongDV_Yeu);
            dto.setSoLuongDV_Kem(entity.SoLuongDV_Kem);
            dto.setMaDonVi(entity.MaDonVi);
            return dto;
        }

    }
}
