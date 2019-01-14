using QUANLYDOANVIEN.DTO;
using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DAO
{
    public class DoanVienDAO
    {
        QLDOANVIEN_DATABASE db;

        public DoanVienDAO()
        {
            db = new QLDOANVIEN_DATABASE();
        }
        public IQueryable<object> listAll()
        {
            var array = from c in db.DOANVIENs
                        where  c.IsDeleted == false
                        select new
                        {
                            c.MaDoanVien,
                            c.HoTen,
                            c.TenKhac,
                            c.NgaySinh,
                            c.GioiTinh,
                            c.DanToc,
                            c.QueQuan,
                            c.TonGiao,
                            c.TamTru,
                            c.ThuongTru,
                            c.NgheNghiep,
                            c.TrinhDo,
                            c.ChuyenMon,
                            c.NgoaiNgu,
                            c.LyLuanChinhTri,
                            c.ThongTinDiNuocNgoai,
                            c.QuaTrinhCongTac,
                            c.KhenThuong,
                            c.KyLuat,
                            c.SoTruong,
                            c.NangKhieu,
                            c.NgayVaoDoan,
                            c.NoiVaoDoan,
                            c.TinhTrangSinhHoatDoan,
                            c.NamBDSinhHoat
                        };            
            return array;
        }

        public IQueryable<object> layTatCaTuMotChiDoan(string maChiDoan)
        {
            var array = from c in db.DOANVIENs
                        where  c.IsDeleted == false && c.MaChiDoan == maChiDoan
                        select new
                        {
                            c.MaDoanVien,
                            c.HoTen,
                            c.TenKhac,
                            c.NgaySinh,
                            c.GioiTinh,
                            c.DanToc,
                            c.QueQuan,
                            c.TonGiao,
                            c.TamTru,
                            c.ThuongTru,
                            c.NgheNghiep,
                            c.TrinhDo,
                            c.ChuyenMon,
                            c.NgoaiNgu,
                            c.LyLuanChinhTri,
                            c.ThongTinDiNuocNgoai,
                            c.QuaTrinhCongTac,
                            c.KhenThuong,
                            c.KyLuat,
                            c.SoTruong,
                            c.NangKhieu,
                            c.NgayVaoDoan,
                            c.NoiVaoDoan,
                            c.TinhTrangSinhHoatDoan,
                            c.NamBDSinhHoat
                        };
            return array;
        }

        //public IQueryable<object> layTatCaTuMotDoanKhoa(string maDoanKhoa)
        //{
        //    var tatCaChiDoan = from cd in db.CHIDOANs
        //                       where (cd.IsDeleted == null || cd.IsDeleted == false) && cd.MaDoanKhoa == maDoanKhoa
        //                       select new
        //                       {
        //                           cd.MaChiDoan
        //                       };

        //    var danhSach = from c in db.DOANVIENs
        //                   where (c.IsDeleted == null || c.IsDeleted == false) && tatCaChiDoan.Contains(c.MaChiDoan)
        //                    select new
        //                    {
        //                        c.MaDoanVien,
        //                        c.HoTen,
        //                        c.TenKhac,
        //                        c.NgaySinh,
        //                        c.GioiTinh,
        //                        c.DanToc,
        //                        c.QueQuan,
        //                        c.TonGiao,
        //                        c.TamTru,
        //                        c.ThuongTru,
        //                        c.NgheNghiep,
        //                        c.TrinhDo,
        //                        c.ChuyenMon,
        //                        c.NgoaiNgu,
        //                        c.LyLuanChinhTri,
        //                        c.ThongTinDiNuocNgoai,
        //                        c.QuaTrinhCongTac,
        //                        c.KhenThuong,
        //                        c.KyLuat,
        //                        c.SoTruong,
        //                        c.NangKhieu,
        //                        c.NgayVaoDoan,
        //                        c.NoiVaoDoan,
        //                        c.TinhTrangSinhHoatDoan,
        //                        c.NamBDSinhHoat
        //                    };

        //}

        public bool themDoanVien(DoanVienDTO dto)
        {
            try
            {
                DOANVIEN entity = dto.ConvertToEntity();
                entity.MaDoanVien = this.taoMaDoanVien();
                entity.IsDeleted = false;

                var res = db.DOANVIENs.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception e) { }
            return false;
        }

        public bool xoaDoanVien(string selected)
        {
            var res = db.DOANVIENs.Where(x => x.MaDoanVien == selected).FirstOrDefault();
            if (res != null)
            {
                res.IsDeleted = true;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        internal DOANVIEN getByMaDoanVien(string selected)
        {
            return db.DOANVIENs.Where(x => x.MaDoanVien == selected).FirstOrDefault();
        }

        internal bool suaDoanVien(DoanVienDTO doanvien)
        {
            string id = doanvien.getMaDoanVien();
            var res = db.DOANVIENs.Where(x => x.MaDoanVien == id).FirstOrDefault();
            if (res == null) // không tồn tại
                return false;
            else
            {
                res.GioiTinh = doanvien.getGioiTinh();
                res.HoTen = doanvien.getHoVaTen();
                res.QueQuan = doanvien.getQueQuan();
                res.NgaySinh = doanvien.getNgaySinh();
                res.GioiTinh = doanvien.getGioiTinh();
                res.TenKhac = doanvien.getTenGoiKhac();
                res.DanToc = doanvien.getDanToc();
                res.TrinhDo = doanvien.getTrinhDoHocVan();
                res.ChuyenMon = doanvien.getChuyenMonNghiepVu();
                res.NgheNghiep = doanvien.getNgheNghiepBanThan();
                res.LyLuanChinhTri = doanvien.getLiLuanChinhTri();
                res.ThongTinDiNuocNgoai = doanvien.getNuocDaDi();
                res.TinhHinhSucKhoe = doanvien.getSucKhoe();
                res.NgayVaoDoan = doanvien.getNgayVaoDoan();
                res.NoiVaoDoan = doanvien.getNoiVaoDoan();
                res.NgoaiNgu = doanvien.getNgoaiNgu();
                res.QuaTrinhCongTac = doanvien.getQuaTrinHCongTac();
                res.KhenThuong = doanvien.getKhenThuong();
                res.KyLuat = doanvien.getKyLuat();
                res.NangKhieu = doanvien.getNangKhieu();
                res.SoTruong = doanvien.getSoTruong();
                res.TamTru = doanvien.getTamTru();
                res.ThuongTru = doanvien.getThuongTru();
                res.TonGiao = doanvien.getTonGiao();
                res.NamBDSinhHoat = doanvien.getNamBDSinhHoat();
                res.TinhTrangSinhHoatDoan = doanvien.getTinhTrangSinhHoatDoan();
                
                res.MaChiDoan = doanvien.getMaChiDoan();
                res.MaDoanKhoa = doanvien.getMaDoanKhoa();

                db.SaveChanges();
                return true;
            }
        }

        internal string taoMaDoanVien()
        {
            string ma = db.DOANVIENs.Count().ToString();
            int tienTo = 5 - db.DOANVIENs.Count().ToString().Length;
            if (tienTo < 0) { }
            else
            {
                for (int i = 1; i <= tienTo; i++)
                {
                    ma = "0" + ma;
                }
            }
            ma = "DV" + ma;
            return ma;
        }

        public IQueryable<object> getDSDoanVienTuMotChiDoan(string maChiDoan)
        {
            var array = from c in db.DOANVIENs
                         where  c.IsDeleted == false && c.MaChiDoan == maChiDoan
                         select new
                         {
                             c.MaDoanVien,
                             c.HoTen,
                             c.TenKhac,
                             c.NgaySinh,
                             c.GioiTinh,
                             c.DanToc,
                             c.QueQuan,
                             c.TonGiao,
                             c.TamTru,
                             c.ThuongTru,
                             c.NgheNghiep,
                             c.TrinhDo,
                             c.ChuyenMon,
                             c.NgoaiNgu,
                             c.LyLuanChinhTri,
                             c.ThongTinDiNuocNgoai,
                             c.QuaTrinhCongTac,
                             c.KhenThuong,
                             c.KyLuat,
                             c.SoTruong,
                             c.NangKhieu,
                             c.NgayVaoDoan,
                             c.NoiVaoDoan,
                             c.TinhTrangSinhHoatDoan,
                             c.NamBDSinhHoat
                         };
            return array;
        }

        internal IQueryable<object> getDSDoanVienTuMotDoanKhoa(string maDoanKhoa)
        {
            var array = from c in db.DOANVIENs
                        where  c.IsDeleted == false && c.MaDoanKhoa == maDoanKhoa
                        select new
                        {
                            c.MaDoanVien,
                            c.HoTen,
                            c.TenKhac,
                            c.NgaySinh,
                            c.GioiTinh,
                            c.DanToc,
                            c.QueQuan,
                            c.TonGiao,
                            c.TamTru,
                            c.ThuongTru,
                            c.NgheNghiep,
                            c.TrinhDo,
                            c.ChuyenMon,
                            c.NgoaiNgu,
                            c.LyLuanChinhTri,
                            c.ThongTinDiNuocNgoai,
                            c.QuaTrinhCongTac,
                            c.KhenThuong,
                            c.KyLuat,
                            c.SoTruong,
                            c.NangKhieu,
                            c.NgayVaoDoan,
                            c.NoiVaoDoan,
                            c.TinhTrangSinhHoatDoan,
                            c.NamBDSinhHoat
                        };
            return array;
        }

        public string getSoLuongDoanTruong()
        {
            return db.DOANVIENs.Where(x =>  x.IsDeleted == false).Count().ToString();
        }

        public string getSoLuongNamDoanTruong()
        {
            return db.DOANVIENs.Where(x => x.GioiTinh == true && x.IsDeleted == false).Count().ToString();
        }

        public string getSoLuongNuDoanTruong()
        {
            return db.DOANVIENs.Where(x => x.GioiTinh == false &&  x.IsDeleted == false).Count().ToString();
        }

        public IQueryable<object> timTheoTenDoanVien(string tenDoanVien)
        {
            var array = from c in db.DOANVIENs
                        where c.IsDeleted == false && c.HoTen.Contains(tenDoanVien)
                        select new
                        {
                            c.MaDoanVien,
                            c.HoTen,
                            c.TenKhac,
                            c.NgaySinh,
                            c.GioiTinh,
                            c.DanToc,
                            c.QueQuan,
                            c.TonGiao,
                            c.TamTru,
                            c.ThuongTru,
                            c.NgheNghiep,
                            c.TrinhDo,
                            c.ChuyenMon,
                            c.NgoaiNgu,
                            c.LyLuanChinhTri,
                            c.ThongTinDiNuocNgoai,
                            c.QuaTrinhCongTac,
                            c.KhenThuong,
                            c.KyLuat,
                            c.SoTruong,
                            c.NangKhieu,
                            c.NgayVaoDoan,
                            c.NoiVaoDoan,
                            c.TinhTrangSinhHoatDoan,
                            c.NamBDSinhHoat
                        };
            return array;
        }

        public void XoaChiDoanCuaNhieuDoanVien(string maChiDoan)
        {
            List<DOANVIEN> list = db.DOANVIENs.Where(x => x.MaChiDoan == maChiDoan && (x.IsDeleted == false)).ToList();
            foreach( var item in list)
            {
                item.MaChiDoan = null;
            }
            db.SaveChanges();
        }

        public void ThayDoiChiDoanCuaNhieuDoanVien(string maChiDoanCu, string maChiDoanMoi)
        {
            ChiDoanDAO chiDoanDAO = new ChiDoanDAO();
            string maDoanKhoMoi = chiDoanDAO.getMaDoanKhoaTuMaChiDoan(maChiDoanMoi);
            List<DOANVIEN> list = db.DOANVIENs.Where(x => x.MaChiDoan == maChiDoanCu && (x.IsDeleted == false)).ToList();
            foreach (var item in list)
            {
                item.MaChiDoan = maChiDoanMoi;
                item.MaDoanKhoa = maDoanKhoMoi;

            }
            db.SaveChanges();
        }

        public void ThayDoiChiDoanCuaMotDoanVien(string maDoanVien, string maChiDoanMoi)
        {
            var entity = db.DOANVIENs.Where(x => x.IsDeleted == false && x.MaDoanVien == maDoanVien).FirstOrDefault();
            entity.MaChiDoan = maChiDoanMoi;
            string maDoanKhoaMoi = db.CHIDOANs.Where(x => x.IsDeleted == false && x.MaChiDoan == maChiDoanMoi).Select(x => x.MaDoanKhoa).FirstOrDefault().ToString();
            entity.MaDoanKhoa = maDoanKhoaMoi;
            db.SaveChanges();
        }

        public void KetThucSinhHoatDoanMotDoanVien(string maDoanVien)
        {
            var entity = db.DOANVIENs.Where(x => x.IsDeleted == false && x.MaDoanVien == maDoanVien).FirstOrDefault();
            entity.TinhTrangSinhHoatDoan = "Không sinh hoạt đoàn nữa";
            entity.NamKTSinhHoat = "2019";
            entity.IsDeleted = true;
            db.SaveChanges();
        }

        public  IQueryable<object> timNangCaoToanTruong(string ten, string gioiTinh, string danToc, string tonGiao)
        { 
            if (gioiTinh == "Nam")
            {
                var array = from c in db.DOANVIENs
                        where c.IsDeleted == false && c.HoTen.Contains(ten) && c.GioiTinh == true && c.DanToc.Contains(danToc) && c.TonGiao.Contains(tonGiao)
                        select new
                        {
                            c.MaDoanVien,
                            c.HoTen,
                            c.TenKhac,
                            c.NgaySinh,
                            c.GioiTinh,
                            c.DanToc,
                            c.QueQuan,
                            c.TonGiao,
                            c.TamTru,
                            c.ThuongTru,
                            c.NgheNghiep,
                            c.TrinhDo,
                            c.ChuyenMon,
                            c.NgoaiNgu,
                            c.LyLuanChinhTri,
                            c.ThongTinDiNuocNgoai,
                            c.QuaTrinhCongTac,
                            c.KhenThuong,
                            c.KyLuat,
                            c.SoTruong,
                            c.NangKhieu,
                            c.NgayVaoDoan,
                            c.NoiVaoDoan,
                            c.TinhTrangSinhHoatDoan,
                            c.NamBDSinhHoat
                        };
                return array;
            }
            else if (gioiTinh == "Nữ")
            {
                var array = from c in db.DOANVIENs
                        where c.IsDeleted == false && c.HoTen.Contains(ten) && c.GioiTinh == false && c.DanToc.Contains(danToc) && c.TonGiao.Contains(tonGiao)
                        select new
                        {
                            c.MaDoanVien,
                            c.HoTen,
                            c.TenKhac,
                            c.NgaySinh,
                            c.GioiTinh,
                            c.DanToc,
                            c.QueQuan,
                            c.TonGiao,
                            c.TamTru,
                            c.ThuongTru,
                            c.NgheNghiep,
                            c.TrinhDo,
                            c.ChuyenMon,
                            c.NgoaiNgu,
                            c.LyLuanChinhTri,
                            c.ThongTinDiNuocNgoai,
                            c.QuaTrinhCongTac,
                            c.KhenThuong,
                            c.KyLuat,
                            c.SoTruong,
                            c.NangKhieu,
                            c.NgayVaoDoan,
                            c.NoiVaoDoan,
                            c.TinhTrangSinhHoatDoan,
                            c.NamBDSinhHoat
                        };
                return array;
            }
            else
            {
                var array = from c in db.DOANVIENs
                        where c.IsDeleted == false && c.HoTen.Contains(ten) && c.DanToc.Contains(danToc) && c.TonGiao.Contains(tonGiao)
                        select new
                        {
                            c.MaDoanVien,
                            c.HoTen,
                            c.TenKhac,
                            c.NgaySinh,
                            c.GioiTinh,
                            c.DanToc,
                            c.QueQuan,
                            c.TonGiao,
                            c.TamTru,
                            c.ThuongTru,
                            c.NgheNghiep,
                            c.TrinhDo,
                            c.ChuyenMon,
                            c.NgoaiNgu,
                            c.LyLuanChinhTri,
                            c.ThongTinDiNuocNgoai,
                            c.QuaTrinhCongTac,
                            c.KhenThuong,
                            c.KyLuat,
                            c.SoTruong,
                            c.NangKhieu,
                            c.NgayVaoDoan,
                            c.NoiVaoDoan,
                            c.TinhTrangSinhHoatDoan,
                            c.NamBDSinhHoat
                        };
                return array;
            }

        }

        public IQueryable<object> timNangCaoToanKhoa(string tenDoanKhoa, string ten, string gioiTinh, string danToc, string tonGiao)
        {
            DoanKhoaDAO doanKhoaDAO = new DoanKhoaDAO();
            string maDoanKhoa = doanKhoaDAO.getMaDoanKhoaTuTenDoanKhoa(tenDoanKhoa);
            if (gioiTinh == "Nam")
            {
                var array = from c in db.DOANVIENs
                            where c.IsDeleted == false && c.HoTen.Contains(ten) && c.GioiTinh == true && c.DanToc.Contains(danToc) && c.TonGiao.Contains(tonGiao) && c.MaDoanKhoa == maDoanKhoa
                            select new
                            {
                                c.MaDoanVien,
                                c.HoTen,
                                c.TenKhac,
                                c.NgaySinh,
                                c.GioiTinh,
                                c.DanToc,
                                c.QueQuan,
                                c.TonGiao,
                                c.TamTru,
                                c.ThuongTru,
                                c.NgheNghiep,
                                c.TrinhDo,
                                c.ChuyenMon,
                                c.NgoaiNgu,
                                c.LyLuanChinhTri,
                                c.ThongTinDiNuocNgoai,
                                c.QuaTrinhCongTac,
                                c.KhenThuong,
                                c.KyLuat,
                                c.SoTruong,
                                c.NangKhieu,
                                c.NgayVaoDoan,
                                c.NoiVaoDoan,
                                c.TinhTrangSinhHoatDoan,
                                c.NamBDSinhHoat
                            };
                return array;
            }
            else if (gioiTinh == "Nữ")
            {
                var array = from c in db.DOANVIENs
                            where c.IsDeleted == false && c.HoTen.Contains(ten) && c.GioiTinh == false && c.DanToc.Contains(danToc) && c.TonGiao.Contains(tonGiao) && c.MaDoanKhoa == maDoanKhoa
                            select new
                            {
                                c.MaDoanVien,
                                c.HoTen,
                                c.TenKhac,
                                c.NgaySinh,
                                c.GioiTinh,
                                c.DanToc,
                                c.QueQuan,
                                c.TonGiao,
                                c.TamTru,
                                c.ThuongTru,
                                c.NgheNghiep,
                                c.TrinhDo,
                                c.ChuyenMon,
                                c.NgoaiNgu,
                                c.LyLuanChinhTri,
                                c.ThongTinDiNuocNgoai,
                                c.QuaTrinhCongTac,
                                c.KhenThuong,
                                c.KyLuat,
                                c.SoTruong,
                                c.NangKhieu,
                                c.NgayVaoDoan,
                                c.NoiVaoDoan,
                                c.TinhTrangSinhHoatDoan,
                                c.NamBDSinhHoat
                            };
                return array;
            }
            else
            {
                var array = from c in db.DOANVIENs
                            where c.IsDeleted == false && c.HoTen.Contains(ten) && c.DanToc.Contains(danToc) && c.TonGiao.Contains(tonGiao) && c.MaDoanKhoa == maDoanKhoa
                            select new
                            {
                                c.MaDoanVien,
                                c.HoTen,
                                c.TenKhac,
                                c.NgaySinh,
                                c.GioiTinh,
                                c.DanToc,
                                c.QueQuan,
                                c.TonGiao,
                                c.TamTru,
                                c.ThuongTru,
                                c.NgheNghiep,
                                c.TrinhDo,
                                c.ChuyenMon,
                                c.NgoaiNgu,
                                c.LyLuanChinhTri,
                                c.ThongTinDiNuocNgoai,
                                c.QuaTrinhCongTac,
                                c.KhenThuong,
                                c.KyLuat,
                                c.SoTruong,
                                c.NangKhieu,
                                c.NgayVaoDoan,
                                c.NoiVaoDoan,
                                c.TinhTrangSinhHoatDoan,
                                c.NamBDSinhHoat
                            };
                return array;
            }
        }

        public IQueryable<object> timNangCaoTheoKhoaVaChiDoan(string tenChiDoan, string tenDoanKhoa, string ten, string gioiTinh, string danToc, string tonGiao)
        {
            DoanKhoaDAO doanKhoaDAO = new DoanKhoaDAO();
            ChiDoanDAO chiDoanDAO = new ChiDoanDAO();

            string maDoanKhoa = doanKhoaDAO.getMaDoanKhoaTuTenDoanKhoa(tenDoanKhoa);
            string maChiDoan = chiDoanDAO.getMaChiDoanBangTen(tenChiDoan);
            if (gioiTinh == "Nam")
            {
                var array = from c in db.DOANVIENs
                            where c.IsDeleted == false && c.HoTen.Contains(ten) && c.GioiTinh == true && c.DanToc.Contains(danToc) && c.TonGiao.Contains(tonGiao) && c.MaDoanKhoa == maDoanKhoa && c.MaChiDoan == maChiDoan
                            select new
                            {
                                c.MaDoanVien,
                                c.HoTen,
                                c.TenKhac,
                                c.NgaySinh,
                                c.GioiTinh,
                                c.DanToc,
                                c.QueQuan,
                                c.TonGiao,
                                c.TamTru,
                                c.ThuongTru,
                                c.NgheNghiep,
                                c.TrinhDo,
                                c.ChuyenMon,
                                c.NgoaiNgu,
                                c.LyLuanChinhTri,
                                c.ThongTinDiNuocNgoai,
                                c.QuaTrinhCongTac,
                                c.KhenThuong,
                                c.KyLuat,
                                c.SoTruong,
                                c.NangKhieu,
                                c.NgayVaoDoan,
                                c.NoiVaoDoan,
                                c.TinhTrangSinhHoatDoan,
                                c.NamBDSinhHoat
                            };
                return array;
            }
            else if (gioiTinh == "Nữ")
            {
                var array = from c in db.DOANVIENs
                            where c.IsDeleted == false && c.HoTen.Contains(ten) && c.GioiTinh == false && c.DanToc.Contains(danToc) && c.TonGiao.Contains(tonGiao) && c.MaDoanKhoa == maDoanKhoa && c.MaChiDoan == maChiDoan
                            select new
                            {
                                c.MaDoanVien,
                                c.HoTen,
                                c.TenKhac,
                                c.NgaySinh,
                                c.GioiTinh,
                                c.DanToc,
                                c.QueQuan,
                                c.TonGiao,
                                c.TamTru,
                                c.ThuongTru,
                                c.NgheNghiep,
                                c.TrinhDo,
                                c.ChuyenMon,
                                c.NgoaiNgu,
                                c.LyLuanChinhTri,
                                c.ThongTinDiNuocNgoai,
                                c.QuaTrinhCongTac,
                                c.KhenThuong,
                                c.KyLuat,
                                c.SoTruong,
                                c.NangKhieu,
                                c.NgayVaoDoan,
                                c.NoiVaoDoan,
                                c.TinhTrangSinhHoatDoan,
                                c.NamBDSinhHoat
                            };
                return array;
            }
            else
            {
                var array = from c in db.DOANVIENs
                            where c.IsDeleted == false && c.HoTen.Contains(ten) && c.DanToc.Contains(danToc) && c.TonGiao.Contains(tonGiao) && c.MaDoanKhoa == maDoanKhoa && c.MaChiDoan == maChiDoan
                            select new
                            {
                                c.MaDoanVien,
                                c.HoTen,
                                c.TenKhac,
                                c.NgaySinh,
                                c.GioiTinh,
                                c.DanToc,
                                c.QueQuan,
                                c.TonGiao,
                                c.TamTru,
                                c.ThuongTru,
                                c.NgheNghiep,
                                c.TrinhDo,
                                c.ChuyenMon,
                                c.NgoaiNgu,
                                c.LyLuanChinhTri,
                                c.ThongTinDiNuocNgoai,
                                c.QuaTrinhCongTac,
                                c.KhenThuong,
                                c.KyLuat,
                                c.SoTruong,
                                c.NangKhieu,
                                c.NgayVaoDoan,
                                c.NoiVaoDoan,
                                c.TinhTrangSinhHoatDoan,
                                c.NamBDSinhHoat
                            };
                return array;
            }
        }

        public string getTenDoanVienTuMa(string maDoanVien)
        {
            return db.DOANVIENs.Where(x => x.IsDeleted == false && x.MaDoanVien == maDoanVien).Select(x => x.HoTen).FirstOrDefault().ToString();
        }

        public string getMaChiDoanTuMaDoanVien(string maDoanVien)
        {
            string a =  db.DOANVIENs.Where(x => x.IsDeleted == false && x.MaDoanVien == maDoanVien).Select(x => x.MaChiDoan).FirstOrDefault().ToString();
            return a;
        }

        public string getMaDoanVienTuTenDoanVien(string tenDoanVien)
        {
            return db.DOANVIENs.Where(x => x.HoTen == tenDoanVien && x.IsDeleted == false).Select(x => x.MaDoanVien).FirstOrDefault();
        }
    }
}
