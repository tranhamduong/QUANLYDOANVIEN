using QUANLYDOANVIEN.DTO;
using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DAO
{
    public class HoatDongDanhGia_DoanVienDAO
    {
        QLDOANVIEN_DATABASE db;

        public HoatDongDanhGia_DoanVienDAO()
        {
            db = new QLDOANVIEN_DATABASE();
        }

        public bool kiemTraTrungDotDanhGia(string NamHoc)
        {
            var res = db.HOATDONGDANHGIA_DOANVIEN.Where(x => x.NamHoc == NamHoc).FirstOrDefault();
            if (res == null) return false;
            else return true;
        }

        internal void themDotDanhGia(HoatDongDanhGiaDoanVienDTO dto)
        {
            HOATDONGDANHGIA_DOANVIEN entity = dto.convertToEntity();
            entity.MaHDDG = taoMaHoatDongDanhGia_DoanVien();
            db.HOATDONGDANHGIA_DOANVIEN.Add(entity);

            db.SaveChanges();
        }

        internal void xoaDotDanhGia(string MaHDDG_DV)
        {
            var res = db.HOATDONGDANHGIA_DOANVIEN.Where(x => x.MaHDDG == MaHDDG_DV).FirstOrDefault();
            db.HOATDONGDANHGIA_DOANVIEN.Remove(res);
            db.SaveChanges();
        }

        internal HOATDONGDANHGIA_DOANVIEN layMotDotDanhGia(string MaHDDG_DV)
        {
            var res = db.HOATDONGDANHGIA_DOANVIEN.Where(x => x.MaHDDG == MaHDDG_DV).FirstOrDefault();
            return res;
        }

        internal string LayMaHDTuNamHoc(string TenNamHoc)
        {
            return db.HOATDONGDANHGIA_DOANVIEN.Where(x => x.NamHoc == TenNamHoc).Select(x => x.MaHDDG).FirstOrDefault().ToString();
        }

        internal List<string> LayDSDotDanhGia(string maDonVi)
        {
            return db.HOATDONGDANHGIA_DOANVIEN.Where(x => x.IsDeleted == false && x.MaDonVi == maDonVi).Select(x=>x.NamHoc).ToList();
        }

        public string taoMaHoatDongDanhGia_DoanVien()
        {
            string ma = "";
            string count = db.HOATDONGDANHGIA_DOANVIEN.Count().ToString();
            int tienTo = 5 - db.HOATDONGDANHGIA_DOANVIEN.Count().ToString().Length;
            if (tienTo < 0) { }
            else
            {
                for (int i = 1; i <= tienTo; i++)
                {
                    ma = "0" + ma;
                }
            }
            return "HDDG_DV" + count;
        }

        internal HoatDongDanhGiaDoanVienDTO layMotDotDanhGia(string namHoc, string maDonVi)
        {
            HOATDONGDANHGIA_DOANVIEN res = db.HOATDONGDANHGIA_DOANVIEN.Where(x => x.MaDonVi == maDonVi && x.NamHoc == namHoc).FirstOrDefault();
            return HoatDongDanhGiaDoanVienDTO.reConvertToDTO(res);
        }
        
        internal string layMaHoatDongTuMaDonViVaNamHoc(string maDonVi, string NamHoc)
        {
            return db.HOATDONGDANHGIA_DOANVIEN.Where(x => x.MaDonVi == maDonVi && x.NamHoc == NamHoc).Select(x => x.MaHDDG).FirstOrDefault().ToString();
        }

    }
}
