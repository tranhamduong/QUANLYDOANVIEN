using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DTO
{
    public class ThanNhanDTO
    {
        private string MaThanNhan;
        private string MaDoanVien;
        private string HoTen;
        private string NgheNghiep;
        private string QuocTich;
        private string DanToc;
        private string TonGiao;
        private string QueQuan;
        private string MoiQuanHe;
        private string GhiChu;
        private bool IsDeleted;

        public void setMaThanNhan(string maThanNhan) { this.MaThanNhan = maThanNhan; }
        public string getMaThanNhan() { return this.MaThanNhan; }

        public void setMaDoanVien(string MaDoanVien) { this.MaDoanVien = MaDoanVien; }
        public string getMaDoanVien() { return this.MaDoanVien; }

        public void setHoTen(string HoTen) { this.HoTen = HoTen; }
        public string getHoTen() { return this.HoTen; }

        public void setNgheNghiep(string NgheNghiep) { this.NgheNghiep = NgheNghiep; }
        public string getNgheNghiep() { return this.NgheNghiep; }

        public void setQuocTich(string QuocTich) { this.QuocTich = QuocTich; }
        public string getQuocTich() { return this.QuocTich; }

        public void setDanToc(string DanToc) { this.DanToc = DanToc; }
        public string getDanToc() { return this.DanToc; }

        public void setTonGiao(string TonGiao) { this.TonGiao = TonGiao; }
        public string getTonGiao() { return this.TonGiao; }

        public void setQueQuan(string QueQuan) { this.QueQuan = QueQuan; }
        public string getQueQuan() { return this.QueQuan; }

        public void setMoiQuanHe(string MoiQuanHe) { this.MoiQuanHe = MoiQuanHe; }
        public string getMoiQuanHe() { return this.MoiQuanHe; }

        public void setGhiChu(string GhiChu) { this.GhiChu = GhiChu; }
        public string getGhiChu() { return this.GhiChu; }

        public THANNHAN ConvertToEntity()
        {
            THANNHAN tn = new THANNHAN();
            tn.MaThanNhan = this.getMaThanNhan();
            tn.MaDoanVien = this.getMaDoanVien();
            tn.HoTen = this.getHoTen();
            tn.NgheNghiep = this.getNgheNghiep();
            tn.QuocTich = this.getQuocTich();
            tn.TonGiao = this.getTonGiao();
            tn.DanToc = this.getDanToc();
            tn.MoiQuanHe = this.getMoiQuanHe();
            tn.GhiChu = this.getGhiChu();
            tn.QueQuan = this.getQueQuan();
            return tn; 
        }

        public static ThanNhanDTO reConvertToDTO(THANNHAN tn)
        {
            ThanNhanDTO dto = new ThanNhanDTO();
            dto.setMaThanNhan(tn.MaThanNhan);
            dto.setMaDoanVien(tn.MaDoanVien);
            dto.setHoTen(tn.HoTen);
            dto.setNgheNghiep(tn.NgheNghiep);
            dto.setQuocTich(tn.QuocTich);
            dto.setTonGiao(tn.TonGiao);
            dto.setDanToc(tn.DanToc);
            dto.setMoiQuanHe(tn.MoiQuanHe);
            dto.setGhiChu(tn.GhiChu);
            dto.setQueQuan(tn.QueQuan);
            return dto;
        }
    }
}
