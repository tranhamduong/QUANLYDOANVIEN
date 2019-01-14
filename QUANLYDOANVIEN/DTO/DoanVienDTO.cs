using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QUANLYDOANVIEN.DTO
{
    public class DoanVienDTO
    {
        private string maDoanVien;
        private string hoVaTen;
        private string tenGoiKhac;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string danToc;
        private string queQuan;
        private string ngheNghiepBanThan;
        private string trinhDoHocVan;
        private string chuyenMonNghiepVu;
        private DateTime ngayVaoDoan;
        private string noiVaoDoan;
        private string sucKhoe;
        private string ngoaiNgu;
        private string nuocDaDi;
        private string liDoDi;
        private string quaTrinhCongTac;
        private string kyLuat;
        private string soTruong;
        private string khenThuong;
        private string namBDSinhHoat;
        private string namKTSinhHoat;
        private string tinhTrangSinhHoatDoan;
        private string nangKhieu;
        private string tamTru;
        private string thuongTru;
        private string tonGiao;
        private string maChiDoan;
        private string lyLuanChinhTri;
        private string maDoanKhoa;

        public DoanVienDTO()
        {

        }

        public void setHoVaTen(string hoVaTen) { this.hoVaTen = hoVaTen; }
        public string getHoVaTen() { return this.hoVaTen; }

        public void setTenGoiKhac(string tenGoiKhac) { this.tenGoiKhac = tenGoiKhac; }
        public string getTenGoiKhac() { return this.tenGoiKhac; }

        public void setNgaySinh(DateTime ngaySinh) { this.ngaySinh = ngaySinh; }
        public DateTime getNgaySinh() { return this.ngaySinh; }

        public void setGioiTinh(bool gioiTinh) { this.gioiTinh = gioiTinh; }
        public bool getGioiTinh() { return this.gioiTinh; }

        public void setDanToc(string danToc) { this.danToc = danToc; }
        public string getDanToc() { return this.danToc; }

        public void setQueQuan(string queQuan) { this.queQuan = queQuan; }
        public string getQueQuan() { return this.queQuan; }

        public void setNgheNghiepBanThan(string ngheNghiepBanThan) { this.ngheNghiepBanThan = ngheNghiepBanThan; }
        public string getNgheNghiepBanThan() { return this.ngheNghiepBanThan; }

        public void setTrinhDoHocVan(string trinhDoHocVan) { this.trinhDoHocVan = trinhDoHocVan; }
        public string getTrinhDoHocVan() { return this.trinhDoHocVan; }

        public void setNgayVaoDoan(DateTime ngayVaoDoan) { this.ngayVaoDoan = ngayVaoDoan; }
        public DateTime getNgayVaoDoan() { return this.ngayVaoDoan; }

        public void setNoiVaoDoan(string noiVaoDoan) { this.noiVaoDoan = noiVaoDoan; }
        public string getNoiVaoDoan() { return this.noiVaoDoan; }

        public void setSucKhoe(string sucKhoe) { this.sucKhoe = sucKhoe; }
        public string getSucKhoe() { return this.sucKhoe; }

        public void setNuocDaDi(string nuocDaDi) { this.nuocDaDi = nuocDaDi; }
        public string getNuocDaDi() { return this.nuocDaDi; }

        public void setLiDoDi(string liDoDi) { this.liDoDi = liDoDi; }
        public string getliDoDi() { return this.liDoDi; }

        public void setMaChiDoan(string maChiDoan) { this.maChiDoan = maChiDoan; }
        public string getMaChiDoan() { return this.maChiDoan; }

        public void setChuyenMonNghiepVu(string chuyenMonNghiepVu) { this.chuyenMonNghiepVu = chuyenMonNghiepVu; }
        public string getChuyenMonNghiepVu() { return this.chuyenMonNghiepVu; }

        public void setNgoaiNgu(string ngoaiNgu) { this.ngoaiNgu = ngoaiNgu; }
        public string getNgoaiNgu() { return this.ngoaiNgu; }

        public void setQuaTrinhCongTac(string quaTrinhCongTac) { this.quaTrinhCongTac = quaTrinhCongTac; }
        public string getQuaTrinHCongTac() { return this.quaTrinhCongTac; }

        public void setKhenThuong(string khenThuong) { this.khenThuong = khenThuong; }
        public string getKhenThuong() { return this.khenThuong; }

        public void setKyLuat(string kyLuat) { this.kyLuat = kyLuat; }
        public string getKyLuat() { return this.kyLuat; }

        public void setNangKhieu(string nangKhieu) { this.nangKhieu = nangKhieu; }
        public string getNangKhieu() { return this.nangKhieu; }

        public void setSoTruong(string soTruong) { this.soTruong = soTruong; }
        public string getSoTruong() { return this.soTruong; }
        public void setTinhTrangSinhHoatDoan(string tinhTrangSinhHoatDoan) { this.tinhTrangSinhHoatDoan = tinhTrangSinhHoatDoan; }
        public string getTinhTrangSinhHoatDoan() { return this.tinhTrangSinhHoatDoan; }

        public void setNamBDSinhHoat(string namBDSinhHoat) { this.namBDSinhHoat = namBDSinhHoat; }
        public string getNamBDSinhHoat() { return this.namBDSinhHoat; }

        public void setNamKTSinhHoat(string namKTSinhHoat) { this.namKTSinhHoat = namKTSinhHoat; }
        public string getNamKTSinhHoat() { return this.namKTSinhHoat; }

        public void setTonGiao(string tonGiao) { this.tonGiao = tonGiao; }
        public string getTonGiao() { return this.tonGiao; }

        public void setTamTru(string tamTru) { this.tamTru = tamTru; }
        public string getTamTru() { return this.tamTru; }

        public void setThuongTru(string thuongTru) { this.thuongTru = thuongTru; }
        public string getThuongTru() { return this.thuongTru; }

        public void setLiLuanChinhTri(string liLuanChinhTri) { this.lyLuanChinhTri = liLuanChinhTri; }
        public string getLiLuanChinhTri() { return this.lyLuanChinhTri; }

        public void setMaDoanVien(string maDoanVien) { this.maDoanVien = maDoanVien; }
        public string getMaDoanVien() { return this.maDoanVien; }

        public void setMaDoanKhoa(string maDoanKhoa) { this.maDoanKhoa = maDoanKhoa; }
        public string getMaDoanKhoa() { return this.maDoanKhoa; }


        //entity
        public DOANVIEN ConvertToEntity()
        {
            DOANVIEN dv = new DOANVIEN();
            dv.MaDoanVien = this.maDoanVien;
            dv.HoTen = this.hoVaTen;
            dv.TenKhac = this.tenGoiKhac;
            dv.NgaySinh = this.ngaySinh;
            dv.DanToc = this.danToc;
            dv.GioiTinh = this.gioiTinh;
            dv.QueQuan = this.queQuan;
            dv.NgheNghiep = this.ngheNghiepBanThan;
            dv.TrinhDo = this.trinhDoHocVan;
            dv.ChuyenMon = this.chuyenMonNghiepVu;
            dv.NgayVaoDoan = this.ngayVaoDoan;
            dv.NoiVaoDoan = this.noiVaoDoan;
            dv.TinhHinhSucKhoe = this.sucKhoe;
            dv.ThongTinDiNuocNgoai = this.nuocDaDi;
            dv.MaChiDoan = this.maChiDoan;
            dv.NgoaiNgu = this.ngoaiNgu;
            dv.TamTru = this.tamTru;
            dv.ThuongTru = this.thuongTru;
            dv.TonGiao = this.tonGiao;
            dv.KhenThuong = this.khenThuong;
            dv.KyLuat = this.kyLuat;
            dv.NangKhieu = this.nangKhieu;
            dv.SoTruong = this.soTruong;
            dv.NamBDSinhHoat = this.namBDSinhHoat;
            dv.NamKTSinhHoat = this.namKTSinhHoat;
            dv.TinhTrangSinhHoatDoan = this.tinhTrangSinhHoatDoan;
            dv.LyLuanChinhTri = this.lyLuanChinhTri;
            dv.QuaTrinhCongTac = this.quaTrinhCongTac;
            dv.MaChiDoan = this.maChiDoan;
            dv.MaDoanKhoa = this.maDoanKhoa;
            return dv;
        }

        public static DoanVienDTO reConvertToDTO(DOANVIEN doanvien)
        {
            DoanVienDTO dv = new DoanVienDTO();

            dv.maDoanVien = doanvien.MaDoanVien;
            dv.setHoVaTen(doanvien.HoTen);
            dv.setTenGoiKhac(doanvien.TenKhac);
            dv.setNgaySinh(doanvien.NgaySinh);
            dv.setGioiTinh(doanvien.GioiTinh);
            dv.setDanToc(doanvien.DanToc);
            dv.setQueQuan(doanvien.QueQuan);
            dv.setNgheNghiepBanThan(doanvien.NgheNghiep);
            dv.setTrinhDoHocVan(doanvien.TrinhDo);
            dv.setChuyenMonNghiepVu(doanvien.ChuyenMon);
            dv.setNgayVaoDoan(doanvien.NgayVaoDoan);
            dv.setNoiVaoDoan(doanvien.NoiVaoDoan);
            dv.setSucKhoe(doanvien.TinhHinhSucKhoe);
            dv.setNuocDaDi(doanvien.ThongTinDiNuocNgoai);
            dv.setMaChiDoan(doanvien.MaChiDoan);
            dv.setNgoaiNgu(doanvien.NgoaiNgu);
            dv.setTamTru(doanvien.TamTru);
            dv.setThuongTru(doanvien.ThuongTru);
            dv.setTonGiao(doanvien.TonGiao);
            dv.setTinhTrangSinhHoatDoan(doanvien.TinhTrangSinhHoatDoan);
            dv.setNamBDSinhHoat(doanvien.NamBDSinhHoat);
            dv.setNamKTSinhHoat(doanvien.NamKTSinhHoat);
            dv.setQuaTrinhCongTac(doanvien.QuaTrinhCongTac);
            dv.setKhenThuong(doanvien.KhenThuong);
            dv.setKyLuat(doanvien.KyLuat);
            dv.setNangKhieu(doanvien.NangKhieu);
            dv.setSoTruong(doanvien.SoTruong);
            dv.setLiLuanChinhTri(doanvien.LyLuanChinhTri);
            dv.setTonGiao(doanvien.TonGiao);
            dv.setMaChiDoan(doanvien.MaChiDoan);
            dv.setMaDoanKhoa(doanvien.MaDoanKhoa);
            return dv;
        }
        //entity

        //end entity

        #region excel handle

        public DoanVienDTO(int i, Microsoft.Office.Interop.Excel.Range xlRange)
        {
            //maDoanVien = xlRange.Cells[i, 1].Value2.ToString();
            hoVaTen = xlRange.Cells[i, 2].Value2.ToString();
            tenGoiKhac = xlRange.Cells[i, 3].Value2.ToString();
            ngaySinh = DateTime.FromOADate(Convert.ToDouble((xlRange.Cells[i, 4] as Microsoft.Office.Interop.Excel.Range).Value2));

            if (xlRange.Cells[i, 5].Value2.ToString().Trim() == "Nam")
                gioiTinh = true;
            else
                gioiTinh = false;

            danToc = xlRange.Cells[i, 6].Value2.ToString();
            queQuan = xlRange.Cells[i, 7].Value2.ToString();
            ngheNghiepBanThan = xlRange.Cells[i, 8].Value2.ToString();
            trinhDoHocVan = xlRange.Cells[i, 9].Value2.ToString();
            chuyenMonNghiepVu = xlRange.Cells[i, 10].Value2.ToString();
            ngayVaoDoan = DateTime.FromOADate(Convert.ToDouble((xlRange.Cells[i, 11] as Microsoft.Office.Interop.Excel.Range).Value2));
            noiVaoDoan = xlRange.Cells[i, 12].Value2.ToString();
            sucKhoe = xlRange.Cells[i, 13].Value2.ToString();
            ngoaiNgu = xlRange.Cells[i, 14].Value2.ToString();
            nuocDaDi = xlRange.Cells[i, 15].Value2.ToString();
            liDoDi = xlRange.Cells[i, 16].Value2.ToString();
            quaTrinhCongTac = xlRange.Cells[i, 17].Value2.ToString();
            kyLuat = xlRange.Cells[i, 18].Value2.ToString();
            soTruong = xlRange.Cells[i, 19].Value2.ToString();
            khenThuong = xlRange.Cells[i, 20].Value2.ToString();
            namBDSinhHoat = xlRange.Cells[i, 21].Value2.ToString();
            namKTSinhHoat = xlRange.Cells[i, 22].Value2.ToString();
            tinhTrangSinhHoatDoan = xlRange.Cells[i, 23].Value2.ToString();
            nangKhieu = xlRange.Cells[i, 24].Value2.ToString();
            tamTru = xlRange.Cells[i, 25].Value2.ToString();
            thuongTru = xlRange.Cells[i, 26].Value2.ToString();
            tonGiao = xlRange.Cells[i, 27].Value2.ToString();
            lyLuanChinhTri = xlRange.Cells[i, 28].Value2.ToString();
            maChiDoan = xlRange.Cells[i, 29].Value2.ToString();
            maDoanKhoa = xlRange.Cells[i, 30].Value2.ToString();
            
        }
        #endregion end excel handle
    }
}
