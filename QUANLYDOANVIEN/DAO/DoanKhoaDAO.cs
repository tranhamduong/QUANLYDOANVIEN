using QUANLYDOANVIEN.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYDOANVIEN.DAO
{
    public class DoanKhoaDAO
    {
        QLDOANVIEN_DATABASE db;

        public List<string> getTatCaTenDoanKhoa()
        {
            db = new QLDOANVIEN_DATABASE();
            List<string> list = new List<string>();
            list =  db.DOANKHOAs.Where(x => x.IsDeleted == false).OrderBy(x => x.TenDoanKhoa).Select(x => x.TenDoanKhoa).ToList<string>();
            list.Add("Tất cả Đoàn Khoa");
            return list;
            
        }

        public string getMaDoanKhoaTuTenDoanKhoa(string tenDoanKhoa)
        {
            db = new QLDOANVIEN_DATABASE();
            return db.DOANKHOAs.Where(x => x.TenDoanKhoa == tenDoanKhoa && x.IsDeleted == false ).Select(x => x.MaDoanKhoa).FirstOrDefault().ToString();
        }

        public string getTenDoanKhoaTuTenMotChiDoan(string tenChiDoan)
        {
            db = new QLDOANVIEN_DATABASE();
            string maDoanKhoa = db.CHIDOANs.Where(x => x.TenChiDoan == tenChiDoan && x.IsDeleted == false ).Select(x => x.MaDoanKhoa).FirstOrDefault().ToString();
            return db.DOANKHOAs.Where(x => x.MaDoanKhoa == maDoanKhoa && x.IsDeleted == false ).Select(x => x.TenDoanKhoa).FirstOrDefault();
        }

        public string getSoLuongDoanVienTuTenDoanKhoa(string tenDoanKhoa)
        {
            db = new QLDOANVIEN_DATABASE();
            string maDoanKhoa = db.DOANKHOAs.Where(x => x.TenDoanKhoa == tenDoanKhoa && x.IsDeleted == false).Select(x => x.MaDoanKhoa).FirstOrDefault().ToString();
            return db.DOANVIENs.Where(x => x.MaDoanKhoa == maDoanKhoa && x.IsDeleted == false).Count().ToString();
        }

        public string getSoLuongDoanVienNamTuTenDoanKhoa(string tenDoanKhoa)
        {
            db = new QLDOANVIEN_DATABASE();
            string maDoanKhoa = db.DOANKHOAs.Where(x => x.TenDoanKhoa == tenDoanKhoa && x.IsDeleted == false).Select(x => x.MaDoanKhoa).FirstOrDefault().ToString();
            return db.DOANVIENs.Where(x => x.MaDoanKhoa == maDoanKhoa && x.GioiTinh == true &&x.IsDeleted == false).Count().ToString();
        }

        public string getSoLuongDoanVienNuTuTenDoanKhoa(string tenDoanKhoa)
        {
            db = new QLDOANVIEN_DATABASE();
            string maDoanKhoa = db.DOANKHOAs.Where(x => x.TenDoanKhoa == tenDoanKhoa && x.IsDeleted == false).Select(x => x.MaDoanKhoa).FirstOrDefault().ToString();
            return db.DOANVIENs.Where(x => x.MaDoanKhoa == maDoanKhoa && x.GioiTinh == false && x.IsDeleted == false).Count().ToString();
        }
    }
}
