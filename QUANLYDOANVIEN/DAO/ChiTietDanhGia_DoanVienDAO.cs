using QUANLYDOANVIEN.DTO;
using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DAO
{
    public class ChiTietDanhGia_DoanVienDAO
    {
        QLDOANVIEN_DATABASE db;
        public ChiTietDanhGia_DoanVienDAO()
        {
            db = new QLDOANVIEN_DATABASE();
        }
        internal void ThemChiTiet(ChiTietDanhGia_DoanVienDTO dto)
        {
            CHITIETDANHGIA_DOANVIEN chiTiet = dto.ConvertToEntity();
            chiTiet.IsDeleted = false;
            chiTiet.MaChiTiet = taoMaChiTiet();

            db.CHITIETDANHGIA_DOANVIEN.Add(chiTiet);

            db.SaveChanges();
        }

        internal IQueryable<object> layTatCaChiTietTuMotDoanVien(string selectedMaDoanVien)
        {
            return db.CHITIETDANHGIA_DOANVIEN.Where(x => x.MaDoanVien == selectedMaDoanVien);
        }

        private string taoMaChiTiet()
        {
            string ma = "";
            string count = db.CHITIETDANHGIA_DOANVIEN.Count().ToString();
            int tienTo = 5 - db.CHITIETDANHGIA_DOANVIEN.Count().ToString().Length;
            if (tienTo < 0) { }
            else
            {
                for (int i = 1; i <= tienTo; i++)
                {
                    ma = "0" + ma;
                }
            }
            return "DGDV" + count;
        }

        internal IQueryable<object> layDSChiTietCuaMotDoanVien(string selectedMaDoanVien)
        {
            var res = from a in db.CHITIETDANHGIA_DOANVIEN
                      join b in db.HOATDONGDANHGIA_DOANVIEN on a.MaHDDG equals b.MaHDDG
                      where a.MaDoanVien == selectedMaDoanVien && a.IsDeleted == false
                      select new
                      {
                          a.MaDoanVien,
                          b.NamHoc,
                          a.XepLoai,
                          a.NhanXetBiThuChiDoan,
                      };

            //var array = db.CHITIETDANHGIA_DOANVIEN.Where(x => x.MaDoanVien == selectedMaDoanVien && x.IsDeleted == false)
            //            .Join(
            //                db.HOATDONGDANHGIA_DOANVIEN.Where(x=>x.NamHoc == namHoc)
            //                , d => d.MaHDDG,
            //                f => f.MaHDDG,
            //                (d, f) => new {
            //                    d.MaDoanVien,
            //                    f.NamHoc,
            //                    d.NhanXetBiThuChiDoan,
            //                    d.XepLoai
            //                });
            var temp = res.ToList();
            return res;
        }

        internal void xoaChiTiet(string selected)
        {
            var res = db.CHITIETDANHGIA_DOANVIEN.Where(x => x.MaDoanVien == selected).FirstOrDefault();
            db.CHITIETDANHGIA_DOANVIEN.Remove(res);
        }

        internal bool kiemTraTrung(string selectedMaDoanVien, string namHoc)
        {
            var res = from a in db.CHITIETDANHGIA_DOANVIEN
                      join b in db.HOATDONGDANHGIA_DOANVIEN on a.MaHDDG equals b.MaHDDG
                      where a.MaDoanVien == selectedMaDoanVien && a.IsDeleted == false && b.NamHoc == namHoc
                      select new
                      {
                        a.MaDoanVien
                      };
            int temp = res.Count();
            if (temp < 0) return false;
            return true;

        }
    }
}
